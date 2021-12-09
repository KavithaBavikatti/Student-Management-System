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
    public partial class CourseSemesterForm : Form
    {
        public CourseSemesterForm()
        {
            InitializeComponent();
        }
        private void CourseSemesterForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCourseSemester);
        }
        public void PopulateComboBox()
        {
            using (var Context = new StudentDBEntities())
            {

                var Courseresult = (from c in Context.Courses
                                    select new
                                    {
                                        c.CourseId,
                                        c.CourseName
                                    }).ToList();
                if (Courseresult != null)
                {
                    Courseresult.Insert(0, new { CourseId = 0, CourseName = "-----Select-----" });
                    cmbCourseId.DataSource = Courseresult;
                    cmbCourseId.DisplayMember = "CourseName";
                    cmbCourseId.ValueMember = "CourseId";
                }
                var result = (from c in Context.Semesters
                              select new
                              {
                                  c.SemesterId,
                                  c.SemesterName
                              }).ToList();

                if (result != null)
                {
                    result.Insert(0, new { SemesterId = 0, SemesterName = "-----Select-----" });
                    cmbSemester.DataSource = result;
                    cmbSemester.DisplayMember = "SemesterName";
                    cmbSemester.ValueMember = "SemesterId";
                }       

            }

        }

        void LoadGridView()
        {
            try
            {
                StudentDBEntities studentDBEntities = new StudentDBEntities();
                var result = from Course in studentDBEntities.Courses
                             from semester in Course.Semesters
                             select new
                             {
                                 Course.CourseId,
                                 Course.CourseName,
                                 semester.SemesterId,
                                 semester.SemesterName
                             };
                if(result!=null)
                {
                    dgvCourseSemester.DataSource = result.ToList();
                    dgvCourseSemester.Refresh();
                }

               
            }
            catch (Exception)
            {
                throw;
            }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCourseId.SelectedIndex != 0 && cmbSemester.SelectedIndex != 0)
                {
                    int CourseId1 = Convert.ToInt32(cmbCourseId.SelectedValue);
                    int SemesterId1 = Convert.ToInt32(cmbSemester.SelectedValue);
                    StudentDBEntities studentDBEntities = new StudentDBEntities();
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Semesters.FirstOrDefault(x => x.SemesterId == SemesterId1).Courses.Add(course);
                    studentDBEntities.SaveChanges();
                    LoadGridView();
                }
                else { MessageBox.Show("Please select course and semester"); }

            }
            catch (Exception)
            {
                throw;
            }
        }

        private void dgvCourseSemester_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int CourseId1 = Convert.ToInt32(dgvCourseSemester.Rows[e.RowIndex].Cells["CourseId"].Value);
                int SemesterId1 = Convert.ToInt32(dgvCourseSemester.Rows[e.RowIndex].Cells["SemesterId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentDBEntities studentDBEntities = new StudentDBEntities();                    
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Semesters.FirstOrDefault(x => x.SemesterId == SemesterId1).Courses.Remove(course);
                    studentDBEntities.SaveChanges();
                    MessageBox.Show("Deleted Sucessfully");
                    LoadGridView();
                }
            }
        }
    }
}
