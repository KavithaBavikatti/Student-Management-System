using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Linq;

namespace TAFESystem1
{
    public partial class StudentForm : Form
    {
        Student objmodel = new Student();
        public StudentForm()
        {
            InitializeComponent();
        }
       

        private void StudentForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            PopulateGridView();
        }
        public void ClearFields()
        {

            txtId.Text = txtStudentName.Text = txtAddress.Text = txtMobile.Text = txtEmail.Text = "";
            rdbFemale.Checked = rdbMale.Checked = false;

        }

        void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {

                //dgvStudent.DataSource= Context.Students.
                var studentlst = (from x in Context.Students
                                  select new { x.StudentId, x.StudentName, x.Gender, x.Address, x.Mobile, x.Email }).ToList();

                dgvStudent.DataSource = studentlst;
                dgvStudent.Refresh();
                label9.Text = "Total number of rows = " + dgvStudent.RowCount.ToString();

            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objmodel.StudentName = txtStudentName.Text.Trim();
           // objmodel.LastName = txtLastName.Text.Trim();
            objmodel.Gender = rdbFemale.Checked ? "Female" : "Male";
            objmodel.Address = txtAddress.Text.Trim();
            objmodel.Mobile = txtMobile.Text.Trim();
            objmodel.Email = txtEmail.Text.Trim();
            using (var Context = new StudentDBEntities())
            {
                Context.Students.Add(objmodel);
                Context.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Student added successfully");

        }
        

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    var entry = db.Entry(objmodel);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Students.Attach(objmodel);
                    db.Students.Remove(objmodel);
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

        private void dgvStudent_DoubleClick(object sender, EventArgs e)
        {
            if (dgvStudent.CurrentRow.Index != -1)
            {
                objmodel.StudentId = Convert.ToInt32(dgvStudent.CurrentRow.Cells["StudentId"].Value);
                using (var Context = new StudentDBEntities())
                {

                }

            }
        }

       
    }
}
