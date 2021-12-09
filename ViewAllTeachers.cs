using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAFESystem1
{
    public partial class ViewAllTeachers : Form
    {
        public ViewAllTeachers()
        {
            InitializeComponent();
            PopulateComboBox();
            LoadGridView();
        }
        public void PopulateComboBox()
        {
            using (var Context = new StudentDBEntities())
            {
                this.cmbCourseId.DataSource = null;
                this.cmbCourseId.Items.Clear();
                var Courseresult = (from c in Context.Courses
                                    select new
                                    {
                                        c.CourseId,
                                        c.CourseName
                                    }).ToList();

                Courseresult.Insert(0, new  { CourseId = 0, CourseName = "-----Select-----" });
                cmbCourseId.DataSource = Courseresult;
                cmbCourseId.DisplayMember = "CourseName";
                cmbCourseId.ValueMember = "CourseId";
              
                

                var result = (from c in Context.Locations
                              select new
                              {
                                  c.LocationId,
                                  c.LocationName
                              }).ToList();

                result.Insert(0, new { LocationId = 0, LocationName = "-----Select-----" });
                cmbLocationId.DataSource = result;
                cmbLocationId.DisplayMember = "LocationName";
                cmbLocationId.ValueMember = "LocationId";
                
            }

        }
        public void LoadGridView()
        {
            using (var Context = new StudentDBEntities())
            {
                var teacherDetails = Context.vw_TeacherDetails.ToList();
                dgvTeacherInfo.DataSource = teacherDetails;
                dgvTeacherInfo.Refresh();
            }
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var loc = cmbLocationId.Text;
            var sem = cmbSemester.Text;
            var cor = cmbCourseId.Text;
            var coursetype = cmbCourseType.Text;

            using (var Context = new StudentDBEntities())
            {
                var teacherDetails = (from C in Context.vw_TeacherDetails
                                      where C.LocationName == loc || C.SemesterName == sem || C.CourseName == cor || C.CourseType == coursetype || C.TeacherName.Contains(txtStudentName.Text + "%")
                                      select C).ToList();
                dgvTeacherInfo.DataSource = teacherDetails;
                dgvTeacherInfo.Refresh();
            }
        }

        private void ViewAllTeachers_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
        }

        private void cmbCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCourseId.SelectedIndex == -1 || cmbCourseId.SelectedIndex == 0)
                {

                }
                else
                {
                    int courId = Convert.ToInt32(cmbCourseId.SelectedValue);
                    using (var Context = new StudentDBEntities())
                    {
                        var LoadLocations = (from loc in Context.Locations
                                             where loc.Courses.Any(c => c.CourseId == courId)
                                             select new
                                             {
                                                 loc.LocationId,
                                                 loc.LocationName
                                             }).ToList();


                        cmbLocationId.DataSource = LoadLocations;
                        cmbLocationId.DisplayMember = "LocationName";
                        cmbLocationId.ValueMember = "LocationId";
                        cmbLocationId.SelectedIndex = -1;
                        cmbLocationId.Text = "Select a location";

                        var GetSemester = (from sem in Context.Semesters
                                           where sem.Courses.Any(c => c.CourseId == courId)
                                           select new
                                           {
                                               sem.SemesterId,
                                               sem.SemesterName
                                           }).ToList();
                        if (GetSemester != null)
                        {
                            cmbSemester.DataSource = GetSemester;
                            cmbSemester.DisplayMember = "SemesterName";
                            cmbSemester.ValueMember = "SemesterId";
                            cmbSemester.SelectedIndex = -1;
                            cmbSemester.Text = "Select a Semester";
                        }

                       
                    }
                }
            }
            catch (Exception) { throw; }
        }
    }
}
