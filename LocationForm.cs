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
    public partial class LocationForm : Form
    {
        Location objmodel = new Location();
        int id = 0;
        public LocationForm()
        {
            InitializeComponent();
            GetLastInsertedId();
        }
        private void LocationForm_Load(object sender, EventArgs e)
        {
            ClearField();
            PopulateGridView();
            GetLastInsertedId();

            clsValidation.AddDeleteButtonToGridView(dgvLocation);
        }
        void GetLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Locations select record.LocationId).Count();
                if (total != 0)
                {
                    int getid = (from record in Context.Locations orderby record.LocationId descending select record.LocationId).First();
                    txtLocationId.Text = (getid + 1).ToString();
                }
                else
                    txtLocationId.Text = "1";
            }
        }
        public void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var result = (from c in Context.Locations
                              select new
                              {
                                  c.LocationId,
                                  c.LocationName
                                  

                              }).ToList();
                dgvLocation.DataSource = result;
                dgvLocation.Refresh();
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (txtLocationId.Text == "" && txtLocationName.Text == "")
            {
                objmodel.LocationId = Convert.ToInt32(txtLocationId.Text);
                objmodel.LocationName = txtLocationName.Text;
                using (var Context = new StudentDBEntities())
                {
                    if (btnAdd.Text == "Update")
                    {
                        var UpdateLocation = (from l in Context.Locations
                                              where l.LocationId == id
                                              select l).FirstOrDefault();
                        if (UpdateLocation != null)
                        {
                            UpdateLocation.LocationName = txtLocationName.Text;
                            Context.SaveChanges();
                        }
                    }
                    else
                    {
                        Context.Locations.Add(objmodel);
                        Context.SaveChanges();
                    }
                }

                MessageBox.Show("Submitted successfully");
                ClearField();
                PopulateGridView();
            }
            else { MessageBox.Show("Please enter empty fields"); }

        }

       

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void ClearField()
        {
            txtLocationId.Text = "";
            txtLocationName.Text = "";
            btnAdd.Text = "Add";
        }

        private void dgvLocation_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                  id = Convert.ToInt32(dgvLocation.Rows[e.RowIndex].Cells["LocationId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var x = (from l in Context.Locations
                                 where l.LocationId == id
                                 select l).FirstOrDefault();
                        if (x != null)
                        {
                            Context.Locations.Remove(x);
                            Context.SaveChanges();
                            MessageBox.Show("Deleted Sucessfully");
                            PopulateGridView();
                        }
                    }
                }

            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtLocationId.Text == "")
            {
                MessageBox.Show("Please enter Location Id");
            }
            else
            {
                id = Convert.ToInt32(txtLocationId.Text);
                using (var Context = new StudentDBEntities())
                {
                    var x = (from l in Context.Locations
                             where l.LocationId == id
                             select l).FirstOrDefault();
                    if (x != null)
                    {
                        txtLocationName.Text = x.LocationName;
                        btnAdd.Text = "Update";
                    }
                }

            }
        }
    }
}
