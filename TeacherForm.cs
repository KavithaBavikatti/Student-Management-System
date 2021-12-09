using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;
using System.Transactions;
namespace TAFESystem1
{   
    public partial class TeacherForm : Form
    {
        Teacher objTeacher = new Teacher();
        public TeacherForm()
        {
            InitializeComponent();
        }

        void PopulateGridView()
        {
            dgvTeacher.AutoGenerateColumns = false;
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                //dgvTeacher.DataSource= Context.Teachers.
                var result = (from c in Context.Teachers
                              select new
                              {
                                  c.TeacherId,
                                  c.TeacherName,
                                  c.EmploymentType,
                                  c.Gender,
                                  c.Address,
                                  c.Mobile,
                                  c.Email }).ToList();
                dgvTeacher.DataSource = result;
                dgvTeacher.Refresh();

            }
        }
        void ClearFields()
        {
            txtId.Text = txtTeacherName.Text = txtAddress.Text = txtMobile.Text = txtEmail.Text = "";
            rdbFemale.Checked = rdbMale.Checked = false;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objTeacher.TeacherId = Convert.ToInt32(txtId.Text);
            objTeacher.EmploymentType = cmbEmpType.Text;
            objTeacher.TeacherName = txtTeacherName.Text.Trim();
            objTeacher.DOB =Convert.ToDateTime(dtpDOB.Text);
            objTeacher.Gender = rdbFemale.Checked ? "Female" : "Male";
            objTeacher.Address = txtAddress.Text.Trim();
            objTeacher.Mobile = txtMobile.Text.Trim();
            objTeacher.Email = txtEmail.Text.Trim();

            LoginUser objuser = new LoginUser();
            objuser.UserId = txtId.Text;
            objuser.UserName = txtTeacherName.Text.Trim();
            objuser.Password = "Password";
            objuser.UserType = "Teacher";
            using (TransactionScope tran = new TransactionScope())
            {

                using (var Context = new StudentDBEntities())
                {
                    if (btnAdd.Text == "Update")
                    {
                        var UpdateTeacher = (from t in Context.Teachers
                                             where t.TeacherId == objTeacher.TeacherId
                                             select t).FirstOrDefault();
                        if (UpdateTeacher != null)
                        {
                            UpdateTeacher.EmploymentType = cmbEmpType.Text;
                            UpdateTeacher.TeacherName = txtTeacherName.Text;
                            UpdateTeacher.DOB = Convert.ToDateTime(dtpDOB.Text);
                            UpdateTeacher.Gender = rdbFemale.Checked ? "Female" : "Male";
                            UpdateTeacher.Address = txtAddress.Text;
                            UpdateTeacher.Mobile = txtMobile.Text;
                            UpdateTeacher.Email = txtEmail.Text;
                            Context.SaveChanges();

                        }

                    }
                    else
                    {
                        try
                        {
                            Context.LoginUsers.Add(objuser);
                            Context.Teachers.Add(objTeacher);
                            Context.SaveChanges();
                            tran.Complete();
                        }
                        catch (Exception)
                        {
                            Transaction.Current.Rollback();
                        }
                    }
                }
            }
            ClearFields();
            MessageBox.Show("Submitted successfully");
            PopulateGridView();
            btnAdd.Text = "Add";
        }

        private void TeacherForm_Load(object sender, EventArgs e)
        {
            PopulateGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    var entry = db.Entry(objTeacher);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Teachers.Attach(objTeacher);
                    db.Teachers.Remove(objTeacher);
                    db.SaveChanges();
                    PopulateGridView();
                    MessageBox.Show("Deleted Sucessfully");

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void dgvTeacher_DoubleClick(object sender, EventArgs e)
        {
            if (dgvTeacher.CurrentRow.Index != -1)
            {
                objTeacher.TeacherId = Convert.ToInt32(dgvTeacher.CurrentRow.Cells["TeacherId"].Value);
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    objTeacher = db.Teachers.Where(x => x.TeacherId == objTeacher.TeacherId).FirstOrDefault();
                    txtId.Text = Convert.ToInt32(objTeacher.TeacherId).ToString();
                    txtTeacherName.Text = objTeacher.TeacherName;
                    dtpDOB.Text = objTeacher.DOB.ToString();
                    if (objTeacher.Gender == "Female")
                        rdbFemale.Checked = true;
                    else
                        rdbMale.Checked = true;
                    txtAddress.Text = objTeacher.Address;
                    txtMobile.Text = objTeacher.Mobile;
                    txtEmail.Text = objTeacher.Email;
                }
                //btnAdd.Text = "Update";
                //btnDelete.Enabled = true;

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtId.Text == "")
            {
                MessageBox.Show("Please enter Teacher Id");
            }
            else
            {
                objTeacher.TeacherId = Convert.ToInt32(txtId.Text);
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    objTeacher = db.Teachers.Where(x => x.TeacherId == objTeacher.TeacherId).FirstOrDefault();
                    txtId.Text = Convert.ToInt32(objTeacher.TeacherId).ToString();
                    txtTeacherName.Text = objTeacher.TeacherName;
                    dtpDOB.Text = objTeacher.DOB.ToString();
                    if (objTeacher.Gender == "Female")
                        rdbFemale.Checked = true;
                    else
                        rdbMale.Checked = true;
                    txtAddress.Text = objTeacher.Address;
                    txtMobile.Text = objTeacher.Mobile;
                    txtEmail.Text = objTeacher.Email;
                    btnAdd.Text = "Update";
                }
            }

        }
    }
}
