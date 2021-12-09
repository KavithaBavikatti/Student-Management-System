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
    public partial class SearchCourseForm : Form
    {
        public static int StaticCourseId;
        public static int StaticLocationId;
        public static string StaticCourseName;
        public static string StaticLocationName;
        public static int StaticSemesterId;
        public static string StaticSemesterName;
        public static int StaticFees;
        public SearchCourseForm()
        {
            InitializeComponent();
            PopulateComboBox();
        }

        public void PopulateComboBox()
        {
            using (var Context = new StudentDBEntities())
            {
                var Courseresult = (from course in Context.Courses

                                    select new
                                    {
                                        course.CourseId,
                                        course.CourseName
                                    }).ToList();

                if (Courseresult != null)
                {
                    Courseresult.Insert(0, new { CourseId = 0, CourseName = "-----Select-----" });
                    cmbCourseId.DataSource = Courseresult;
                    cmbCourseId.DisplayMember = "CourseName";
                    cmbCourseId.ValueMember = "CourseId";
                }
                
            }
        }

        private void SearchCourseForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
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
                    panelCourseInfo.Visible = true;
                    int courId = Convert.ToInt32(cmbCourseId.SelectedValue);
                    using (var Context = new StudentDBEntities())
                    {

                        var Courseresult = (from course in Context.Courses
                                            where course.CourseId == courId
                                            select new
                                            {
                                                course.Description,
                                                course.CourseType,
                                                course.StartDate,
                                                course.Fees
                                            }).FirstOrDefault();


                        richTextDescription.Text = Courseresult.Description;
                        lblCourseType.Text = Courseresult.CourseType;
                        DateTime ClassDate = DateTime.Parse(Courseresult.StartDate.ToString());
                        var date = ClassDate.Date;
                        lblStartDate.Text = date.ToString("dd-MM-yyyy");
                        lblFees.Text = Courseresult.Fees.ToString();
                        StaticFees = Convert.ToInt16(Courseresult.Fees);

                        var LoadLocations = (from loc in Context.Locations
                                             where loc.Courses.Any(c => c.CourseId == courId)
                                             select new
                                             {
                                                 loc.LocationId,
                                                 loc.LocationName
                                             }).ToList();

                        if (LoadLocations != null)
                        {
                            LoadLocations.Insert(0, new { LocationId = 0, LocationName = "-----Select-----" });
                            cmbLocationId.DataSource = LoadLocations;
                            cmbLocationId.DisplayMember = "LocationName";
                            cmbLocationId.ValueMember = "LocationId";
                           
                        }


                        var GetSemester = (from sem in Context.Semesters
                                           where sem.Courses.Any(c => c.CourseId == courId)
                                           select new
                                           {
                                               sem.SemesterId,
                                               sem.SemesterName
                                           }).FirstOrDefault();
                        if (GetSemester != null)
                        {
                            lblSemester.Text = GetSemester.SemesterName;
                            StaticSemesterName = GetSemester.SemesterName;
                            StaticSemesterId = GetSemester.SemesterId;
                        }
                        else
                        {

                        }
                    }
                }
            }
            catch (Exception)
            {
                throw;
            }
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {
            StaticCourseId = Convert.ToInt32(cmbCourseId.SelectedValue);
            StaticLocationId = Convert.ToInt32(cmbLocationId.SelectedValue);
            StaticCourseName = cmbCourseId.Text;
            StaticLocationName = cmbLocationId.Text;
            if (cmbCourseId.SelectedIndex == -1 && cmbLocationId.SelectedIndex == -1)
            {
                MessageBox.Show("Please select Course and Location");
            }
            else
            {                
                StudentEnrolmentForm fm = new StudentEnrolmentForm();
                fm.Show();
                this.Hide();
            }
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Form fm = new Login();
            fm.Show();
            this.Hide();
        }
    }
}
