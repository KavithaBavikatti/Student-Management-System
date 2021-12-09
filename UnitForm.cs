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
    public partial class UnitForm : Form
    {
        Unit objmodel = new Unit();
        int id = 0;
        public UnitForm()
        {
            InitializeComponent();
        }

        private void UnitForm_Load(object sender, EventArgs e)
        {
            ClearField();
            PopulateGridView();
            clsValidation.AddDeleteButtonToGridView(dgvUnit);
            GetLastInsertedId();
        }

        void GetLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Units select record.UnitId).Count();
                if (total != 0)
                {
                    int getid = (from record in Context.Units orderby record.UnitId descending select record.UnitId).First();
                    txtUnitId.Text = (getid + 1).ToString();
                }
                else
                    txtUnitId.Text = "1";
            }
        }
        public void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var result = (from c in Context.Units
                              select new
                              {
                                  c.UnitId,
                                  c.UnitType,
                                  c.UnitName
                              }).ToList();
                dgvUnit.DataSource = result;
                dgvUnit.Refresh();
            }
        }
        private void ClearField()
        {
            txtUnitId.Text = "";
            txtUnitType.Text = "";
            txtUnitName.Text = "";
        }
       

        private void btnAdd_Click_1(object sender, EventArgs e)
        {
            objmodel.UnitId = Convert.ToInt32(txtUnitId.Text);
            objmodel.UnitType = txtUnitType.Text;
            objmodel.UnitName = txtUnitName.Text;
            if (!clsValidation.ValidateForEmptiness(txtUnitId.Text) && !clsValidation.ValidateForEmptiness(txtUnitName.Text) && !clsValidation.ValidateForEmptiness(txtUnitType.Text))
            {
                if (!clsValidation.ValidateForNumeric(txtUnitId.Text))
                {
                    using (var Context = new StudentDBEntities())
                    {
                        if (btnAdd.Text == "Update")
                        {
                            var UpdateUnit = (from s in Context.Units
                                                 where s.UnitId == id
                                                 select s).FirstOrDefault();
                            if (UpdateUnit != null)
                            {
                                UpdateUnit.UnitName = txtUnitName.Text;
                                UpdateUnit.UnitType = txtUnitType.Text;
                                Context.SaveChanges();
                            }
                        }
                        else
                        {
                            Context.Units.Add(objmodel);
                            Context.SaveChanges();
                        }
                        
                    }

                    MessageBox.Show("Submitted successfully");
                    ClearField();
                    PopulateGridView();
                }
                else { MessageBox.Show("Unit Id should be a number"); }
            }
            else { MessageBox.Show("Please enter empty fields"); }
        }

        

        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        

        private void dgvUnit_DoubleClick(object sender, EventArgs e)
        {
            if (dgvUnit.CurrentRow.Index != -1)
            {
                objmodel.UnitId = Convert.ToInt32(dgvUnit.CurrentRow.Cells["UnitId"].Value);
                using (StudentDBEntities db = new StudentDBEntities())
                {
                    objmodel = db.Units.Where(x => x.UnitId == objmodel.UnitId).FirstOrDefault();
                    if (objmodel != null)
                    {
                        txtUnitId.Text = Convert.ToInt32(objmodel.UnitId).ToString();
                        txtUnitType.Text = objmodel.UnitType;
                        txtUnitName.Text = objmodel.UnitName;
                        btnAdd.Text = "Update";
                    }

                }             

            }
        }

        private void dgvUnit_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                id = Convert.ToInt32(dgvUnit.Rows[e.RowIndex].Cells["UnitId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var x = (from s in Context.Units
                                 where s.UnitId == id
                                 select s).FirstOrDefault();
                        if (x != null)
                        {
                            Context.Units.Remove(x);
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
            if (txtUnitId.Text == "")
            {
                MessageBox.Show("Please enter Unit Id");
            }
            else
            {
                id = Convert.ToInt32(txtUnitId.Text);
                using (var Context = new StudentDBEntities())
                {
                    var x = (from s in Context.Units
                             where s.UnitId == id
                             select s).FirstOrDefault();
                    if (x != null)
                    {
                        txtUnitName.Text = x.UnitName;
                        txtUnitType.Text = x.UnitType;
                        btnAdd.Text = "Update";
                    }
                    else { MessageBox.Show("No record found"); }
                }

            }
        }
    }
}
