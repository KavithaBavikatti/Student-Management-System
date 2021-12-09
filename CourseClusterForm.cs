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
    public partial class CourseClusterForm : Form
    {
        public CourseClusterForm()
        {
            InitializeComponent();
        }
        private void CourseClusterForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCourseCluster);
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
                var result = (from c in Context.Clusters
                              select new
                              {
                                  c.ClusterId,
                                  c.ClusterName
                              }).ToList();

                if (result != null)
                {
                    result.Insert(0, new { ClusterId = 0, ClusterName = "-----Select-----" });
                    cmbClusterId.DataSource = result;
                    cmbClusterId.DisplayMember = "ClusterName";
                    cmbClusterId.ValueMember = "ClusterId";
                    
                }


                
            }

        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                if (cmbCourseId.SelectedIndex != 0 && cmbClusterId.SelectedIndex != 0)
                {
                    int CourseId1 = Convert.ToInt32(cmbCourseId.SelectedValue);
                    int ClustId = Convert.ToInt32(cmbClusterId.SelectedValue);
                    StudentDBEntities studentDBEntities = new StudentDBEntities();
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Clusters.FirstOrDefault(x => x.ClusterId == ClustId).Courses.Add(course);
                    studentDBEntities.SaveChanges();
                    LoadGridView();
                }
                else { MessageBox.Show("Please select course and cluster"); }

            }
            catch (Exception)
            {
                throw;
            }
        }
        void LoadGridView()
        {
            try
            {
                StudentDBEntities studentDBEntities = new StudentDBEntities();
                var result = from Course in studentDBEntities.Courses
                             from clus in Course.Clusters
                             select new
                             {
                                 Course.CourseId,
                                 Course.CourseName,
                                 clus.ClusterId,
                                 clus.ClusterName
                             };
                if (result != null)
                {
                    dgvCourseCluster.DataSource = result.ToList();
                    dgvCourseCluster.Refresh();
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

        private void dgvCourseCluster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 4)
            {
                int CourseId1 = Convert.ToInt32(dgvCourseCluster.Rows[e.RowIndex].Cells["CourseId"].Value);
                int ClustId = Convert.ToInt32(dgvCourseCluster.Rows[e.RowIndex].Cells["ClusterId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    StudentDBEntities studentDBEntities = new StudentDBEntities();
                    Course course = studentDBEntities.Courses.FirstOrDefault(x => x.CourseId == CourseId1);
                    studentDBEntities.Clusters.FirstOrDefault(x => x.ClusterId == ClustId).Courses.Remove(course);
                    studentDBEntities.SaveChanges();
                    MessageBox.Show("Deleted Sucessfully");
                    LoadGridView();
                }
            }
        }
    }
}
