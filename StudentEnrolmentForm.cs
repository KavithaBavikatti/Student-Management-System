using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Transactions;

namespace TAFESystem1
{
    public partial class StudentEnrolmentForm : Form
    {
        StudentEnrolment objstudEnrol = new StudentEnrolment();
        Student objstudent = new Student();
        LoginUser objuser = new LoginUser();
        public StudentEnrolmentForm()
        {
            InitializeComponent();
        }

        private void AddStudEnrolmentPrototype_Load(object sender, EventArgs e)
        {
            dtpEnrolmentDate.Value = System.DateTime.Now;
            txtCourse.Text = SearchCourseForm.StaticCourseName;
            txtLocation.Text = SearchCourseForm.StaticLocationName;
            txtFeesAmt.Text = SearchCourseForm.StaticFees.ToString();
            txtSemester.Text = SearchCourseForm.StaticSemesterName;

            getLastInsertedId();
            ClearFields();
        }

        public void ClearFields()
        {

            txtUserName.Text = txtAddress.Text = txtMobile.Text = txtEmail.Text = "";
            rdbFemale.Checked = rdbMale.Checked = false;
            rbPay.Checked = rbPayLater.Checked = false;

        }
        public void getLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Students select record.StudentId).Count();
                var EnrolmentId= (from record in Context.StudentEnrolments select record.StudentId).Count();

                if (total != 0)
                {
                    int id = (from record in Context.Students orderby record.StudentId descending select record.StudentId).First();
                    txtStudentId.Text = (id + 1).ToString();
                }
                else
                    txtStudentId.Text = "1";
                if (EnrolmentId != 0)
                {
                    int id = (from record in Context.StudentEnrolments orderby record.StudentId descending select record.StudentId).First();
                    txtEnrolmentId.Text = (id + 1).ToString();
                }
                else
                    txtEnrolmentId.Text = "1";
            }
                
        }

        public bool CheckStudentExist()
        {
            using(var Context=new StudentDBEntities())
            {
                var Result=(from stud in Context.Students
                            where stud.Email == txtEmail.Text && stud.Mobile==txtMobile.Text
                            select
                            stud ).SingleOrDefault();
                if (Result != null)
                {
                    txtStudentId.Text = Result.StudentId.ToString();
                    return true;
                }
                return false;

            }

        }

        public bool CountStudentEnrolment()
        {
            int id = Convert.ToInt32(txtStudentId.Text);

            using (var Context = new StudentDBEntities())
            {
                var Result = (from stud in Context.StudentEnrolments
                              where stud.Status=="Active" && stud.StudentId== id

                              select
                              stud).Count();
                if (Result>=2)
                {
                    return true;
                }
                return false;

            }

        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            objstudent.StudentId = Convert.ToInt32(txtStudentId.Text);
            objstudent.StudentName = txtUserName.Text.Trim();           
            objstudent.Gender = rdbFemale.Checked ? "Female" : "Male";
            objstudent.DOB = Convert.ToDateTime(dtpDOB.Text);
            objstudent.Address = txtAddress.Text.Trim();
            objstudent.Mobile = txtMobile.Text.Trim();
            objstudent.Email = txtEmail.Text.Trim();

            objstudEnrol.StudentId = Convert.ToInt32(txtStudentId.Text);
            objstudEnrol.EnrolmentId = Convert.ToInt32(txtEnrolmentId.Text);
            objstudEnrol.EnrolmentDate = System.DateTime.Now;
            objstudEnrol.LocationId = SearchCourseForm.StaticLocationId;
            objstudEnrol.SemesterId = SearchCourseForm.StaticSemesterId;
            objstudEnrol.CourseId= SearchCourseForm.StaticCourseId;
            objstudEnrol.Status = "Active";
            objstudEnrol.Fees = rbPay.Checked ? Convert.ToInt32(txtFeesAmt.Text) : 0;

            objuser.UserId= txtStudentId.Text;
            objuser.UserName = txtUserName.Text;
            objuser.Password = txtPassword.Text;
            objuser.UserType = "Student";
            using (StudentDBEntities Context = new StudentDBEntities())
                if (CheckStudentExist() != true)
                {
                    using (TransactionScope tran = new TransactionScope())
                    {
                        try
                        {
                            Context.Students.Add(objstudent);
                            Context.StudentEnrolments.Add(objstudEnrol);
                            Context.LoginUsers.Add(objuser);
                            Context.SaveChanges();

                            tran.Complete();
                            MessageBox.Show("Successfully Registered the Course");
                            ClearFields();

                        }
                        catch (Exception)
                        {
                            Transaction.Current.Rollback();
                        }
                    }

                }
                else if(CountStudentEnrolment()!=true)
                {
                    Context.StudentEnrolments.Add(objstudEnrol);
                    
                }
            else
                {
                    MessageBox.Show("User is already Enrolled two Courses ,Please wait untill next Semester");
                }

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Hide();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
    }
}
