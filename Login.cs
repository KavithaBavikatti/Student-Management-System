using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAFESystem1
{
    public partial class Login : Form
    {
        public static string staticUserName;
        public static string staticUserId;
       
        public Login()
        {
            InitializeComponent();
            
        }
        private void Login_Load(object sender, EventArgs e)
        {            
            this.AcceptButton = btnLogin;
        }
        private void btnLogin_Click_1(object sender, EventArgs e)
        {
            if (!clsValidation.ValidateForEmptiness(txtUserName.Text))
            {
                MessageBox.Show("User Name is required");
            }

            else
           if (!clsValidation.ValidateForEmptiness(txtPassword.Text))
            {
                MessageBox.Show("Password is required");
            }

            else
            {
                using (var Context = new StudentDBEntities())
                {
                    var result = (from user in Context.LoginUsers
                                  where user.UserName == txtUserName.Text && user.Password == txtPassword.Text
                                  select user).FirstOrDefault();

                    if (result != null)
                    {
                        staticUserId = result.UserId;
                        staticUserName = txtUserName.Text;
                        if (result.UserType == "Admin")
                        {
                            MainMenu fm = new MainMenu();
                            fm.Show();
                            this.Hide();
                        }
                        else if (result.UserType == "Student")
                        {
                            Form fm = new StudentMainMenu();
                            fm.Show();
                            this.Hide();
                        }
                        else
                        {
                            Form fm = new TeacherMainMenu();
                            fm.Show();
                            this.Hide();
                        }

                    }
                    else
                    {
                        MessageBox.Show("Invalid Userid/password");
                    }

                }


            }

        }

        private void searchCourseToEnrolToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form fm = new SearchCourseForm();
            fm.Show();
            this.Hide();
        }
    }
}
