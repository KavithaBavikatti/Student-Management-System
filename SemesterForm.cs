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
    public partial class SemesterForm : Form
    {
        Semester db = new Semester();
        int id = 0;
        public SemesterForm()
        {
            InitializeComponent();
        }
        private void SemesterForm_Load(object sender, EventArgs e)
        {
            GetLastInsertedId();
            PopulateGridView();
            clsValidation.AddDeleteButtonToGridView(dgvSemester);
        }
        void GetLastInsertedId()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var total = (from record in Context.Semesters select record.SemesterId).Count();
                if (total != 0)
                {
                    int getid = (from record in Context.Semesters orderby record.SemesterId descending select record.SemesterId).First();
                    txtSemesterId.Text = (getid + 1).ToString();
                }
                else
                    txtSemesterId.Text = "1";
            }
        }
        public void PopulateGridView()
        {
            using (StudentDBEntities Context = new StudentDBEntities())
            {
                var result = (from c in Context.Semesters
                              select new
                              {
                                  c.SemesterId,
                                  c.SemesterName


                              }).ToList();
                dgvSemester.DataSource = result;
                dgvSemester.Refresh();
            }
        }
        private void ClearField()
        {
            txtSemesterId.Text = "";
            txtSemesterName.Text = "";
            btnAdd.Text = "Add";
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateForEmptiness(txtSemesterId.Text) && !clsValidation.ValidateForEmptiness(txtSemesterName.Text))
            {
                if (!clsValidation.ValidateForNumeric(txtSemesterId.Text))
                {
                    db.SemesterId = Convert.ToInt32(txtSemesterId.Text);
                    db.SemesterName = txtSemesterName.Text;
                    using (var Context = new StudentDBEntities())
                    {
                        if (btnAdd.Text == "Update")
                        {
                            var UpdateSemester = (from s in Context.Semesters
                                                  where s.SemesterId == id
                                                  select s).FirstOrDefault();
                            if (UpdateSemester != null)
                            {
                                UpdateSemester.SemesterName = txtSemesterName.Text;
                                Context.SaveChanges();
                            }
                        }
                        else
                        {
                            Context.Semesters.Add(db);
                            Context.SaveChanges();
                        }
                    }

                    MessageBox.Show("Submitted successfully");
                    ClearField();
                    PopulateGridView();
                }
                else { MessageBox.Show("Location Id should be a number"); }
            }
            else { MessageBox.Show("Please enter empty fields"); }
        }

       
        private void btnCancel_Click(object sender, EventArgs e)
        {
            ClearField();
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
            {
                using (StudentDBEntities objdb = new StudentDBEntities())
                {
                    var entry = objdb.Entry(db);
                    if (entry.State == System.Data.Entity.EntityState.Detached)
                        objdb.Semesters.Attach(db);
                    objdb.Semesters.Remove(db);
                    objdb.SaveChanges();
                    PopulateGridView();
                    MessageBox.Show("Deleted Sucessfully");

                }
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (txtSemesterId.Text == "")
            {
                MessageBox.Show("Please enter semester Id");
            }
            else
            {
                id = Convert.ToInt32(txtSemesterId.Text);
                using (var Context = new StudentDBEntities())
                {
                    var x = (from s in Context.Semesters
                             where s.SemesterId == id
                             select s).FirstOrDefault();
                    if (x != null)
                    {
                        txtSemesterName.Text = x.SemesterName;
                        btnAdd.Text = "Update";
                    }
                    else { MessageBox.Show("No record found"); }
                }

            }
        }

        private void dgvSemester_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 2)
            {
                id = Convert.ToInt32(dgvSemester.Rows[e.RowIndex].Cells["SemesterId"].Value);
                if (MessageBox.Show("Are you sure to delete this record", "Message box", MessageBoxButtons.YesNo) == DialogResult.Yes)
                {
                    using (var Context = new StudentDBEntities())
                    {
                        var x = (from s in Context.Semesters
                                 where s.SemesterId == id
                                 select s).FirstOrDefault();
                        if (x != null)
                        {
                            Context.Semesters.Remove(x);
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
