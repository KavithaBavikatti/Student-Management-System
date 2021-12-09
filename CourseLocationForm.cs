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
    public partial class CourseLocationForm : Form
    {
        
        public CourseLocationForm()
        {
            InitializeComponent();
        }
        private void CourseLocationForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCourseLocation);
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

                var result = (from c in Context.Locations
                              select new
                              {
                                  c.LocationId,
                                  c.LocationName
                              }).ToList();
                if (result != null)
                {
                    result.Insert(0, new { LocationId = 0, LocationName = "-----Select-----" });
                    cmbLocationId.DataSource = result;
                    cmbLocationId.DisplayMember = "LocationName";
                    cmbLocationId.ValueMember = "LocationId";
                }               
            }
            
        }

       

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCourseId.SelectedIndex != 0 && cmbLocationId.SelectedIndex != 0)
                {
                    int CourseId1 = Convert.ToInt32(cmbCourseId.SelectedValue);
                    int LocationId1 = Convert.ToInt32(cmbLocationId.SelectedValue);
                    StudentDBEntities studentDBEntities = new StudentDBEntities();
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Locations.FirstOrDefault(x => x.LocationId == LocationId1).Courses.Add(course);
                    studentDBEntities.SaveChanges();
                    LoadGridView();
                }
                else { MessageBox.Show("Please select course and location"); }

            }
            catch(Exception)
            {
                throw;
            }

        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateComboBox();
            //cmbLocationId.SelectedIndex = -1;
            //cmbLocationId.Text = "Select a location";
            //cmbCourseId.SelectedIndex = -1;
            //cmbCourseId.Text = "Select a course";
        }

        void LoadGridView()
        {
            try
            {
                StudentDBEntities studentDBEntities = new StudentDBEntities();
                var result = from Course in studentDBEntities.Courses
                              from location in Course.Locations
                              select new
                              {
                                  Course.CourseId,
                                  Course.CourseName,
                                  location.LocationId,
                                  location.LocationName
                              };
                if (result != null)
                {
                    dgvCourseLocation.DataSource = result.ToList();
                    dgvCourseLocation.Refresh();
                }
                else { MessageBox.Show("No Record Found"); }
            }
            catch(Exception)
            {
                throw;
            }
        }

        private void dgvCourseLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int CourseId1 = Convert.ToInt32(dgvCourseLocation.Rows[e.RowIndex].Cells["CourseId"].Value);
                int LocationId1 = Convert.ToInt32(dgvCourseLocation.Rows[e.RowIndex].Cells["LocationId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {                    
                    StudentDBEntities studentDBEntities = new StudentDBEntities();
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Locations.FirstOrDefault(x => x.LocationId == LocationId1).Courses.Remove(course);
                    studentDBEntities.SaveChanges();
                    MessageBox.Show("Deleted Sucessfully");
                    LoadGridView();
                }
            }
             
           
        }
    }
}
