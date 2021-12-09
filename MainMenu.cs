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
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

      

        private void locationToolStripMenuItem_Click(object sender, EventArgs e)
        {
           Form frm = new LocationForm();
           frm.ShowDialog(this);

        }

       

       

        private void addTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TeacherForm();
            frm.ShowDialog(this);
        }

        private void courseAssignToTeacherToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new TeacherEnrolmentForm();
            frm.ShowDialog(this);
        }

        private void addStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new StudentForm();
            frm.Show();
            //this.Hide();
        }

        private void studentEnrolmentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Form frm = new StudentEnrolmentFormOld();
            frm.ShowDialog(this);
        }

        private void courseClusterUnitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseClusterUnitForm();
            frm.ShowDialog(this);
        }

        private void courseClusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseClusterForm();
            frm.Show();
        }

        private void formsToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void addCourseToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseForm();
            frm.ShowDialog(this);
        }

        private void addClusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ClusterForm();
            frm.ShowDialog(this);
        }

        private void addUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new UnitForm();
            frm.ShowDialog(this); 
            //this.Hide();
        }

        private void addSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new SemesterForm();
            frm.ShowDialog(this);
        }

        private void addCourseLocationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseLocationForm();
            frm.ShowDialog(this);
        }

        private void addCourseSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseSemesterForm();
            frm.ShowDialog(this);
        }

        private void addCourseClusterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseClusterForm();
            frm.ShowDialog(this);
        }

        private void addCourseClusterUnitsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new CourseClusterUnitForm();
            frm.ShowDialog(this);
        }

        private void viewStudentsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form frm = new ViewAllStudentsForm();
            frm.ShowDialog(this);
        }

        private void LogoutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Login frm = new Login();
            frm.Show();
            this.Close();
        }

        private void viewAllTeachersToolStripMenuItem_Click(object sender, EventArgs e)
        {
            ViewAllTeachers frm = new ViewAllTeachers();
            frm.ShowDialog(this);
        }
    }
}
