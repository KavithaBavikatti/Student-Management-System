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
    public partial class CourseClusterUnitForm : Form
    {
        CourseClusterUnit objDB = new CourseClusterUnit();
        public CourseClusterUnitForm()
        {
            InitializeComponent();
        }

        private void CourseClusterUnitForm_Load(object sender, EventArgs e)
        {
            PopulateComboBox();
            LoadGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCourseClusterUnit);

        }
        void PopulateComboBox()
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
                    cmbCourse.DataSource = Courseresult;
                    cmbCourse.DisplayMember = "CourseName";
                    cmbCourse.ValueMember = "CourseId";
                }



                var UnitResult = (from c in Context.Units
                                     select new
                                     {
                                         c.UnitId,
                                         c.UnitName
                                     }).ToList();

                if (UnitResult != null)
                {
                    UnitResult.Insert(0, new { UnitId = 0, UnitName = "-----Select-----" });
                    cmbUnit.DataSource = UnitResult;
                    cmbUnit.DisplayMember = "UnitName";
                    cmbUnit.ValueMember = "UnitId";
                    
                }
            }

        }
        void LoadGridView()
        {
            using (var Context = new StudentDBEntities())
            {
                var lst = (from x in Context.CourseClusterUnits                          
                           join c in Context.Courses on x.CourseId equals c.CourseId
                           join cl in Context.Clusters on x.ClusterId equals cl.ClusterId
                           join u in Context.Units on x.UnitId equals u.UnitId
                           select new
                           {                               
                               CourseName = c.CourseName,
                               CourseId=c.CourseId,
                               ClusterName = cl.ClusterName,
                               ClusterId=cl.ClusterId,
                               UnitId=u.UnitId,
                               UnitName=u.UnitName
                           }).ToList();
                if (lst != null)
                {
                    dgvCourseClusterUnit.DataSource = lst;
                    dgvCourseClusterUnit.Refresh();
                }
            }

        }

        

        private void btnAdd_Click(object sender, EventArgs e)
        {
            try
            {
                objDB.CourseId = Convert.ToInt32(cmbCourse.SelectedValue);
                objDB.ClusterId = Convert.ToInt32(cmbCluster.SelectedValue);
                objDB.UnitId = Convert.ToInt32(cmbUnit.SelectedValue);
                if (cmbCourse.SelectedIndex != 0 && cmbCluster.SelectedIndex != 0 &&  cmbUnit.SelectedIndex != 0)
                {
                    using (var contex = new StudentDBEntities())
                    {
                        contex.CourseClusterUnits.Add(objDB);
                        contex.SaveChanges();
                    }                    
                    MessageBox.Show("Submitted successfully");
                    LoadGridView();
                    PopulateComboBox();
                }
                else { MessageBox.Show("Please select Course, Cluster and Unit"); }
            }
            catch(Exception)
            { throw; }
        }

        
        private void btnCancel_Click(object sender, EventArgs e)
        {
            PopulateComboBox();
        }

      

        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbCourse.SelectedIndex == -1 || cmbCourse.SelectedIndex == 0)
            {

            }
            else
            {
                int courId = Convert.ToInt32(cmbCourse.SelectedValue);
                using (var Context = new StudentDBEntities())
                {
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
                        
                    }
                }
            }
        }

        private void dgvCourseClusterUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 6)
            {
                int CId = Convert.ToInt32(dgvCourseClusterUnit.Rows[e.RowIndex].Cells["CourseId"].Value);
                int Clustid = Convert.ToInt32(dgvCourseClusterUnit.Rows[e.RowIndex].Cells["ClusterId"].Value);
                int Uid = Convert.ToInt32(dgvCourseClusterUnit.Rows[e.RowIndex].Cells["UnitId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var x = (from c in Context.CourseClusterUnits
                                 where c.CourseId== CId && c.ClusterId == Clustid && c.UnitId==Uid
                                 select c).FirstOrDefault();
                        if (x != null)
                        {
                            Context.CourseClusterUnits.Remove(x);
                            Context.SaveChanges();
                            MessageBox.Show("Deleted Sucessfully");
                            LoadGridView();
                        }
                    }
                }

            }
        }
    }
}
