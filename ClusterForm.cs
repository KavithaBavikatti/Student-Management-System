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
    public partial class ClusterForm : Form
    {
        Cluster objmodel = new Cluster();
        int id = 0;
        public ClusterForm()
        {
            InitializeComponent();
        }
        private void ClusterForm_Load(object sender, EventArgs e)
        {
            ClearField();
            PopulateGridView();
            clsValidation.AddDeleteButtonToGridView(dgvCluster);
            GetLastInsertedId();
        }
        void GetLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Clusters select record.ClusterId).Count();
                if (total != 0)
                {
                    int getid = (from record in Context.Clusters orderby record.ClusterId descending select record.ClusterId).First();
                    txtClusterId.Text = (getid + 1).ToString();
                }
                else
                    txtClusterId.Text = "1";
            }
        }
        public void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var result = (from c in Context.Clusters
                              select new
                              {
                                  c.ClusterId,
                                  c.ClusterName

                              }).ToList();
                dgvCluster.DataSource = result;
                dgvCluster.Refresh();
            }
        }
        private void ClearField()
        {
            txtClusterId.Text = "";
            txtClusterName.Text = "";
        }
        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateForEmptiness(txtClusterId.Text) && !clsValidation.ValidateForEmptiness(txtClusterName.Text))
            {
                if (!clsValidation.ValidateForNumeric(txtClusterId.Text))
                {
                    objmodel.ClusterName = txtClusterName.Text;
                    using (var Context = new StudentDBEntities())
                    {
                        if (btnAdd.Text == "Update")
                        {
                            var UpdateCluster = (from s in Context.Clusters
                                                 where s.ClusterId == id
                                                 select s).FirstOrDefault();
                            if (UpdateCluster != null)
                            {
                                UpdateCluster.ClusterName = txtClusterName.Text;
                                Context.SaveChanges();
                            }
                        }
                        else
                        {
                            Context.Clusters.Add(objmodel);
                            Context.SaveChanges();
                        }

                    }
                    MessageBox.Show("Submitted successfully");
                    ClearField();
                    PopulateGridView();
                }
                else { MessageBox.Show("Cluster Id should be a number"); }
            }
            else { MessageBox.Show("Please enter empty fields"); }
        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        

        private void dgvCluster_DoubleClick(object sender, EventArgs e)
        {
            if (dgvCluster.CurrentRow.Index != -1)
            {
                objmodel.ClusterId = Convert.ToInt32(dgvCluster.CurrentRow.Cells["ClusterId"].Value);
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    objmodel = db.Clusters.Where(x => x.ClusterId == objmodel.ClusterId).FirstOrDefault();
                    if (objmodel != null)
                    {
                        txtClusterId.Text = Convert.ToInt32(objmodel.ClusterId).ToString();
                        txtClusterName.Text = objmodel.ClusterName;
                        btnAdd.Text = "Update";
                    }
                }         
               

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtClusterId.Text == "")
            {
                MessageBox.Show("Please enter Cluster Id");
            }
            else
            {
                id = Convert.ToInt32(txtClusterId.Text);
                using (var Context = new StudentDBEntities())
                {
                    var x = (from s in Context.Clusters
                             where s.ClusterId == id
                             select s).FirstOrDefault();
                    if (x != null)
                    {
                        txtClusterName.Text = x.ClusterName;
                        btnAdd.Text = "Update";
                    }
                    else { MessageBox.Show("No record found"); }
                }

            }
        }

        private void dgvCluster_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                id = Convert.ToInt32(dgvCluster.Rows[e.RowIndex].Cells["ClusterId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var x = (from s in Context.Clusters
                                 where s.ClusterId == id
                                 select s).FirstOrDefault();
                        if (x != null)
                        {
                            Context.Clusters.Remove(x);
                            Context.SaveChanges();
                            MessageBox.Show("Deleted Sucessfully");
                            PopulateGridView();
                        }
                    }
                }

            }
        }
    }
}
