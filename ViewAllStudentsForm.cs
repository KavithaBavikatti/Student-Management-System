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
    public partial class ViewAllStudentsForm : Form
    {
        public ViewAllStudentsForm()
        {
            InitializeComponent();
        }

        private void ViewAllStudentsForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
        }
        private void btnSearch_Click(object sender, EventArgs e)
        {
            var loc = cmbLocationId.Text;
            var sem = cmbSemester.Text;
            var cor = cmbCourseId.Text;
            var coursetype = cmbCourseType.Text;

            using (var Context = new StudentDBEntities())
            {
                var studentDetails = (from C in Context.vw_StudentDetails
                                      where C.LocationName == loc || C.SemesterName== sem ||C.CourseName==cor||C.CourseType== coursetype||C.StudentName.Contains(txtStudentName.Text + "%")
                                      select C).ToList();
                dgvStudentInfo.DataSource = studentDetails;
                dgvStudentInfo.Refresh();
            }

        }
        public void PopulateComboBox()
        {
            using (var Context = new StudentDBEntities())
            {
                var result = (from c in Context.Locations
                              select new
                              {
                                  c.LocationId,
                                  c.LocationName
                              }).ToList();


                cmbLocationId.DataSource = result;
                cmbLocationId.DisplayMember = "LocationName";
                cmbLocationId.ValueMember = "LocationId";
                cmbLocationId.SelectedIndex = -1;
                cmbLocationId.Text = "Select a location";


                var Courseresult = (from c in Context.Courses
                                    select new
                                    {
                                        c.CourseId,
                                        c.CourseName
                                    }).ToList();


                cmbCourseId.DataSource = Courseresult;
                cmbCourseId.DisplayMember = "CourseName";
                cmbCourseId.ValueMember = "CourseId";
                cmbCourseId.SelectedIndex = -1;
                cmbCourseId.Text = "Select a course";
            }

        }

        void LoadGridView()
        {
            using(var Context =new StudentDBEntities())
            {
                var studentDetails = Context.vw_StudentDetails.ToList();
                dgvStudentInfo.DataSource = studentDetails;
                dgvStudentInfo.Refresh();
            }
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
