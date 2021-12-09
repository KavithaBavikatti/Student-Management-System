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
    public partial class StudentMainMenu : Form
    {
        Student objstudent = new Student();
        int courseid = Convert.ToInt32(Login.staticUserId);
        public StudentMainMenu()
        {
            InitializeComponent();
            lblUserName.Text = Login.staticUserName;
            if(tcStudentInfo.SelectedTab== tpCurrent)
            {
                CourseDetails();
                StudentPersonalDetails();
            }
            else if(tcStudentInfo.SelectedTab == tpPersonalDetails)
            {
                StudentPersonalDetails();
            }
        }

        public void PopulateCourseComboBox()
        {
            using (var Context = new StudentDBEntities())
            {
                var Courseresult = (from course in Context.Courses

                                    select new
                                    {
                                        course.CourseId,
                                        course.CourseName
                                    }).ToList();


                cmbCourseId.DataSource = Courseresult;
                cmbCourseId.DisplayMember = "CourseName";
                cmbCourseId.ValueMember = "CourseId";
                cmbCourseId.SelectedIndex = -1;
                cmbCourseId.Text = "Select a Course";
            }
        }


        public void StudentPersonalDetails()
        {
            using (var Contex = new StudentDBEntities())
            {
                var result = (from s in Contex.Students
                              where s.StudentId == courseid
                              select s).FirstOrDefault();
                if (result != null)
                {
                    txtStudentName.Text = result.StudentName;
                    txtAddress.Text = result.Address;
                    txtEmail.Text = result.Email;
                    txtMobile.Text = result.Mobile;
                    txtId.Text = result.StudentId.ToString();
                }
            }

        }


        public void CourseDetails()
        {
            using (var Contex = new StudentDBEntities())
            {
                var result = (from E in Contex.StudentEnrolments
                              join C in Contex.Courses
                              on E.CourseId equals C.CourseId
                              where E.StudentId == courseid
                              select new { C.CourseId,
                                     C.CourseName}).Take(2);
                if (result != null)
                {
                    dgvCourse.DataSource = result.ToList();
                    dgvCourse.Refresh();
                }
            }
        }

        private void dgvCourse_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCourse.CurrentRow.Index != -1)
            {
                int SelectedCourseId = Convert.ToInt32(dgvCourse.CurrentRow.Cells["CourseId"].Value);
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    var result = (from c in db.CourseClusterUnits
                                  join clust in db.Clusters on c.ClusterId equals clust.ClusterId
                                  join unit in db.Units on c.UnitId equals unit.UnitId
                                  where c.CourseId == SelectedCourseId
                                  select new 
                                  { 
                                      c.ClusterId,
                                      clust.ClusterName,
                                      unit.UnitName,
                                      unit.UnitType
                                  }).ToList();//db.CourseClusterUnits.Where(x => x.CourseId == SelectedCourseId).ToList();
                    if (result!=null)
                    {
                        dgvClusterUnit.Visible = true;
                        dgvClusterUnit.DataSource = result;
                        dgvClusterUnit.Refresh();
                    }
                }
            }
        }

        private void StudentMainMenu_Load(object sender, EventArgs e)
        {
            PopulateCourseComboBox();
        }

        private void cmbCourseId_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                int courId = Convert.ToInt32(cmbCourseId.SelectedValue);
                if (cmbCourseId.SelectedIndex == -1 || cmbCourseId.SelectedIndex == 0)
                {

                }
                else
                {
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
                                           }).FirstOrDefault();
                        if (GetSemester != null)
                        {
                            //lblSemester.Text = GetSemester.SemesterName;
                            //StaticSemesterName = GetSemester.SemesterName;
                            //StaticSemesterId = GetSemester.SemesterId;
                        }
                    }
                }
            }
            catch (Exception)
            {

            }
            
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {

        }

        private void btnLogout_Click(object sender, EventArgs e)
        {
            Form fm = new Login();
            fm.Show();
            this.Hide();
        }
    }
}
