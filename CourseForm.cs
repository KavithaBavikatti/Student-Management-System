using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace TAFESystem1
{
    public partial class CourseForm : Form
    {
        Course objmodel = new Course();
        int id = 0;
        public CourseForm()
        {
            InitializeComponent();
            PopulateGridView();
        }
        private void CourseForm_Load(object sender, EventArgs e)
        {
            ClearFields();
            PopulateGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCourse);
            GetLastInsertedId();
            dtpStartDate.Value = DateTime.Now;
            dtpEndDate.Value = DateTime.Now.AddDays(1);
        }
        void GetLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Courses select record.CourseId).Count();
                if (total != 0)
                {
                    int getid = (from record in Context.Courses orderby record.CourseId descending select record.CourseId).First();
                    txtCourseId.Text = (getid + 1).ToString();
                }
                else
                    txtCourseId.Text = "1";
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objmodel.CourseId = Convert.ToInt32(txtCourseId.Text);
            objmodel.CourseName = txtCourseName.Text.Trim();
            objmodel.CourseType = cmbCourseType.SelectedItem.ToString();
            objmodel.Duration = Convert.ToInt16(txtCourseDuration.Text);
            objmodel.Description = txtDescription.Text;
            objmodel.Fees = Convert.ToInt32(txtFees.Text);
            objmodel.StartDate = Convert.ToDateTime(dtpStartDate.Text);
            objmodel.EndDate = Convert.ToDateTime(dtpEndDate.Text);
            if (!clsValidation.ValidateForNumeric(txtCourseDuration.Text) && !clsValidation.ValidateForNumeric(txtFees.Text))
            {
                using (var Context = new StudentDBEntities())
                {

                    Context.Courses.Add(objmodel);
                    Context.SaveChanges();

                }
                ClearFields();
                MessageBox.Show("Submitted successfully");
                PopulateGridView();
            }
            else { MessageBox.Show("Duration and Fees should be a number"); }

        }
        private void btnDelete_Click(object sender, EventArgs e)
        {
            if(MessageBox.Show("Are you sure to delete this record","Message box",MessageBoxButtons.YesNo)==DialogResult.Yes)
            {
                using(StudentDBEntities db =new StudentDBEntities())
                {
                    var entry = db.Entry(objmodel);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.Courses.Attach(objmodel);
                    db.Courses.Remove(objmodel);
                    db.SaveChanges();
                    PopulateGridView();
                    ClearFields();
                    MessageBox.Show("Deleted Sucessfully");

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }
        public void ClearFields()
        {
            txtCourseId.Text = txtCourseName.Text = txtCourseDuration.Text = txtDescription.Text= txtFees.Text= "";
            btnAdd.Text = "Add";            
            objmodel.CourseId = 0;

        }
        public void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
               var result = (from c in Context.Courses
                             select new
                          {
                              c.CourseId,
                              c.CourseName,
                              c.CourseType,                              
                              c.Duration,                              
                              c.Fees,
                              c.StartDate,
                              c.EndDate
                              
                          }).ToList();
                dgvCourse.DataSource = result;
                dgvCourse.Refresh();
            }
        }

        private void dgvCourse_DoubleClick(object sender, EventArgs e)
        {
            if(dgvCourse.CurrentRow.Index!=-1)
            {
                objmodel.CourseId = Convert.ToInt32(dgvCourse.CurrentRow.Cells["CourseId"].Value);
                using(StudentDBEntities db =new StudentDBEntities())
                {
                    objmodel = db.Courses.Where(x => x.CourseId == objmodel.CourseId).FirstOrDefault();
                    txtCourseId.Text = Convert.ToInt32(objmodel.CourseId).ToString();
                    txtCourseName.Text = objmodel.CourseName;
                    txtCourseDuration.Text = Convert.ToInt32(objmodel.Duration).ToString();
                    dtpStartDate.Value =Convert.ToDateTime(objmodel.StartDate);
                    dtpEndDate.Value= Convert.ToDateTime(objmodel.EndDate);

                }
                             

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateForEmptiness(txtCourseId.Text))
            {
                id = Convert.ToInt32(txtCourseId.Text);
                using (var Context = new StudentDBEntities())
                {
                   var result= Context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                    if (result != null)
                    {

                        txtCourseName.Text = result.CourseName;
                        cmbCourseType.Text = result.CourseType;
                        txtCourseDuration.Text = Convert.ToInt32(result.Duration).ToString();
                        txtDescription.Text = result.Description;
                        txtFees.Text = result.Fees.ToString();
                        dtpStartDate.Value = Convert.ToDateTime(result.StartDate);
                        dtpEndDate.Value = Convert.ToDateTime(result.EndDate);
                        btnAdd.Text = "Update";
                    }
                    else { MessageBox.Show("No record found"); }
                    
                }

            }
            else { MessageBox.Show("Please enter course Id"); }

        }

        private void dgvCourse_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 7)
            {
                id = Convert.ToInt32(dgvCourse.Rows[e.RowIndex].Cells["CourseId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var result = Context.Courses.Where(x => x.CourseId == id).FirstOrDefault();
                        if (result != null)
                        {
                            Context.Courses.Remove(result);
                            Context.SaveChanges();
                            MessageBox.Show("Deleted Sucessfully");
                            PopulateGridView();
                        }
                    }
                }

            }
        }
    }
}
