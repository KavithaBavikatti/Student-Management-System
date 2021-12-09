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
    public partial class StudentEnrolFormProtoType : Form
    {
        public static int StaticCourseId;
        public static int StaticLocationId;
        public static string StaticCourseName;
        public static string StaticLocationName;
        public static int StaticSemesterId;

        public StudentEnrolFormProtoType()
        {
            InitializeComponent();
            cmbLocationId.SelectedIndexChanged += cmbLocationId_SelectedIndexChanged;
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

               
                
                
            }
        }

        private void cmbLocationId_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbLocationId.SelectedIndex == -1 || cmbLocationId.SelectedIndex == 0)
            {
               
            }
            else
            {
                int Location = Convert.ToInt32(cmbLocationId.SelectedValue ) ;
                using (var Context = new StudentDBEntities())
                {

                    var Courseresult = (from course in Context.Courses
                                        where course.Locations.Any(c => c.LocationId == Location)
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
        }

        private void StudentEnrolFormProtoType_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            cmbCourseId.SelectedIndex = -1;
            cmbCourseId.Text = "Select a Course";
        }

        private void btnEnrol_Click(object sender, EventArgs e)
        {            
            StaticCourseId = Convert.ToInt32(cmbCourseId.SelectedValue);
            StaticLocationId = Convert.ToInt32(cmbLocationId.SelectedValue);
            StaticCourseName = cmbCourseId.Text;
            StaticLocationName = cmbLocationId.Text;
            StudentEnrolmentForm fm = new StudentEnrolmentForm();
            fm.Show();
            //this.Dispose();
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

                        var Courseresult = from course in Context.Courses
                                           where course.CourseId == courId
                                           select new
                                           {

                                               course.Description
                                           }.Description;


                        lblCourseDescription.Text = Courseresult.SingleOrDefault();

                    }
                }
            }
            catch(Exception)
            {
                throw;
            }
        }
    }
}
