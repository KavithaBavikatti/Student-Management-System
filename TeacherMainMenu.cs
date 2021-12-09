using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAFESystem1
{
    public partial class TeacherMainMenu : Form
    {
        int userid = Convert.ToInt32(Login.staticUserId);
        public TeacherMainMenu()
        {
            InitializeComponent();
            lblUserName.Text = Login.staticUserName;
            if (tcPersonalDetails.SelectedTab == tpCurrent)
            {
                TeacherPersonalDetails();
                PopulateGridView();
            }
        }
        public void TeacherPersonalDetails()
        {
            using (var Contex = new StudentDBEntities())
            {
                var result = (from t in Contex.Teachers
                              where t.TeacherId == userid
                              select t).FirstOrDefault();
                if (result != null)
                {
                    txtTeacherName.Text = result.TeacherName;
                    txtAddress.Text = result.Address;
                    txtEmail.Text = result.Email;
                    txtMobile.Text = result.Mobile;
                    txtId.Text = result.TeacherId.ToString();
                }
            }

        }
        public void PopulateGridView()
        {
            using (var Context = new StudentDBEntities())
            {
                var loadgrid = (from e in Context.TeacherEnrolments
                                join c in Context.Courses on e.CourseId equals c.CourseId
                                join clust in Context.Clusters on e.ClusterId equals clust.ClusterId
                                join loc in Context.Locations on e.LocationId equals loc.LocationId
                                where e.TeacherId == userid
                                select new
                                {
                                    c.CourseId,
                                    c.CourseName,
                                    clust.ClusterName,
                                    loc.LocationName
                                }).ToList();
                if (loadgrid != null)
                {
                    dgvCurrentCourses.DataSource = loadgrid;
                    dgvCurrentCourses.Refresh();
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            //Teacher objteacher = new Teacher();
            //objteacher.Address = txtAddress.Text;
            //objteacher.Mobile = txtMobile.Text;
            //objteacher.Email = txtEmail.Text;
            using (var Context = new StudentDBEntities())
            {
                var getTeacherRecord = (from t in Context.Teachers
                                        where t.TeacherId == userid
                                        select t).FirstOrDefault();
                if (getTeacherRecord != null)
                {
                    getTeacherRecord.Address = txtAddress.Text;
                    getTeacherRecord.Mobile = txtMobile.Text;
                    getTeacherRecord.Email = txtEmail.Text;
                    Context.SaveChanges();
                }
                else
                {
                    throw new UnexpectedOperationException();
                }
            }
        }

        private void dgvCurrentCourses_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCurrentCourses.CurrentRow.Index != -1)
            {
                int SelectedCourseId = Convert.ToInt32(dgvCurrentCourses.CurrentRow.Cells["CourseId"].Value);
                using (var Context = new StudentDBEntities())
                {
                    var result = (from s in Context.StudentEnrolments
                                  join stud in Context.Students on s.StudentId equals stud.StudentId
                                  join c in Context.Courses on s.CourseId equals c.CourseId
                                  where s.CourseId==SelectedCourseId
                                  select new { stud.StudentName,stud.Mobile,stud.Email}
                                  ).ToList();
                    if (result != null)
                    {
                        dgvStudentInfo.DataSource = result;
                        dgvStudentInfo.Refresh();
                    }
                }
            }
        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }
    }

    [Serializable]
    internal class UnexpectedOperationException : Exception
    {
        public UnexpectedOperationException()
        {
        }

        public UnexpectedOperationException(string message) : base(message)
        {
        }

        public UnexpectedOperationException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected UnexpectedOperationException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
