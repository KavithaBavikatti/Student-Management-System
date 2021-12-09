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
    public partial class TeacherEnrolmentForm : Form
    {

        TeacherEnrolment objDB = new TeacherEnrolment();
        public TeacherEnrolmentForm()
        {
            InitializeComponent();
        }
        public void PopulateComboBox()
        {
            using (var Context = new StudentDBEntities())
            {
                var Teacherresult = (from c in Context.Teachers
                              select new
                              {
                                  c.TeacherId,
                                  c.TeacherName
                              }).ToList();


                cmbTeacher.DataSource = Teacherresult;
                cmbTeacher.DisplayMember = "TeacherName";
                cmbTeacher.ValueMember = "TeacherId";
                cmbTeacher.SelectedIndex = -1;
                cmbTeacher.Text = "Select a Teacher";

                var Courseresult = (from c in Context.Courses
                                    select new
                                    {
                                        c.CourseId,
                                        c.CourseName
                                    }).ToList();


                cmbCourse.DataSource = Courseresult;
                cmbCourse.DisplayMember = "CourseName";
                cmbCourse.ValueMember = "CourseId";
                cmbCourse.SelectedIndex = -1;
                cmbCourse.Text = "Select a Course";

                var Locationresult = (from c in Context.Locations
                              select new
                              {
                                  c.LocationId,
                                  c.LocationName
                              }).ToList();


                cmbLocation.DataSource = Locationresult;
                cmbLocation.DisplayMember = "LocationName";
                cmbLocation.ValueMember = "LocationId";
                cmbLocation.SelectedIndex = -1;
                cmbLocation.Text = "Select a location";

                var Semesterresult = (from c in Context.Semesters
                              select new
                              {
                                  c.SemesterId,
                                  c.SemesterName
                              }).ToList();


                cmbSemester.DataSource = Semesterresult;
                cmbSemester.DisplayMember = "SemesterName";
                cmbSemester.ValueMember = "SemesterId";
                cmbSemester.SelectedIndex = -1;
                cmbSemester.Text = "Select a Semester";


               

                var ClusterResult = (from c in Context.Clusters
                                    select new
                                    {
                                        c.ClusterId,
                                        c.ClusterName
                                    }).ToList();


                cmbCluster.DataSource = ClusterResult;
                cmbCluster.DisplayMember = "ClusterName";
                cmbCluster.ValueMember = "ClusterId";
                cmbCluster.SelectedIndex = -1;
                cmbCluster.Text = "Select a Cluster";
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            objDB.TeacherId = Convert.ToInt32(cmbTeacher.SelectedValue) ;
            objDB.LocationId = Convert.ToInt32(cmbLocation.SelectedValue);
            objDB.SemesterId = Convert.ToInt32(cmbSemester.SelectedValue);
            objDB.CourseId = Convert.ToInt32(cmbCourse.SelectedValue);
            objDB.ClusterId = Convert.ToInt32(cmbCluster.SelectedValue);
            objDB.Status = "Active";
            using(var contex=new StudentDBEntities())
            {
                contex.TeacherEnrolments.Add(objDB);
                contex.SaveChanges();
            }
            ClearFields();
            MessageBox.Show("Submitted successfully");
            LoadGridView();

        }

        void LoadGridView()
        {
            using (var Context = new StudentDBEntities())
            {
                var lst = (from x in Context.TeacherEnrolments
                           join t in Context.Teachers on x.TeacherId equals t.TeacherId
                           join loc in Context.Locations on x.LocationId equals loc.LocationId
                           join s in Context.Semesters on x.SemesterId equals s.SemesterId
                           join c in Context.Courses on x.CourseId equals c.CourseId                    
                           join cl in Context.Clusters on x.ClusterId equals cl.ClusterId
                           select new { FullName = t.TeacherName,
                                        LocationName=loc.LocationName,
                                        SemesterName = s.SemesterName, 
                                        CourseName = c.CourseName,   
                                        ClusterName = cl.ClusterName }).ToList();
                dgvCourseTeacher.DataSource = lst;
                dgvCourseTeacher.Refresh();
            }
            
        }
        void ClearFields()
        {
            cmbTeacher.SelectedIndex = -1;
            cmbTeacher.Text = "Select a Teacher";
            cmbLocation.SelectedIndex = -1;
            cmbLocation.Text = "Select a location";
            cmbSemester.SelectedIndex = -1;
            cmbSemester.Text = "Select a Semester";
            cmbCourse.SelectedIndex = -1;
            cmbCourse.Text = "Select a Course";
            cmbCluster.SelectedIndex = -1;
            cmbCluster.Text = "Select a Cluster";
        }

        private void CourseTeacherForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    var entry = db.Entry(objDB);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        db.TeacherEnrolments.Attach(objDB);
                    db.TeacherEnrolments.Remove(objDB);
                    db.SaveChanges();
                    LoadGridView();
                    MessageBox.Show("Deleted Sucessfully");

                }
            }
        }

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearFields();
        }

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (cmbCourse.SelectedIndex == -1 || cmbCourse.SelectedIndex == 0)
                {

                }
                else
                {
                    int courId = Convert.ToInt32(cmbCourse.SelectedValue);
                    using (var Context = new StudentDBEntities())
                    {
                        var LoadLocations = (from loc in Context.Locations
                                             where loc.Courses.Any(c => c.CourseId == courId)
                                             select new
                                             {
                                                 loc.LocationId,
                                                 loc.LocationName
                                             }).ToList();


                        cmbLocation.DataSource = LoadLocations;
                        cmbLocation.DisplayMember = "LocationName";
                        cmbLocation.ValueMember = "LocationId";
                        cmbLocation.SelectedIndex = -1;
                        cmbLocation.Text = "Select a location";

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

                        var GetCluster = (from clust in Context.Clusters
                                          where clust.Courses.Any(c => c.CourseId == courId)
                                          select new
                                          {
                                              clust.ClusterId,
                                              clust.ClusterName
                                          }).ToList();
                        if (GetCluster != null)
                        {
                            cmbCluster.DataSource = GetCluster;
                            cmbCluster.DisplayMember = "ClusterName";
                            cmbCluster.ValueMember = "ClusterId";
                            cmbCluster.SelectedIndex = -1;
                            cmbCluster.Text = "Select a ClusterName";
                        }
                    }
                }
            }
            catch (Exception) { throw; }
        }
    }
}
