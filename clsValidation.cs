using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TAFESystem1
{
    class clsValidation
    {

        public static void AddDeleteButtonToGridView(DataGridView gridView)
        {
            DataGridViewLinkColumn Deletelink = new DataGridViewLinkColumn();
            Deletelink.UseColumnTextForLinkValue = true;
            Deletelink.HeaderText = "Delete";
            Deletelink.DataPropertyName = "lnkColumn";
            Deletelink.LinkBehavior = LinkBehavior.SystemDefault;
            Deletelink.Text = "Delete";
            gridView.Columns.Add(Deletelink);
        }
       
            public static bool ValidateForEmptiness(String str)
            {
                if (str == "")
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool ValidateForLength(String str, int len)
            {
                if (str.Length != len)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool ValidateForNumeric(String str)
            {
                try
                {
                    int num = int.Parse(str);
                    return true;
                }
                catch
                {
                    return false;
                }
            }

            public static bool ValidateCombobox(ComboBox cmb)
            {
                if (cmb.SelectedIndex == -1)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static bool ValidateRadiobuttons(RadioButton rdb1, RadioButton rdb2)
            {
                if (rdb1.Checked == false && rdb2.Checked == false)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }

            public static Boolean ValidateEmail(TextBox email, out String message)
            {

                if (email.Text == String.Empty)
                {
                    message = "Email is reuired";
                    return false;
                }
                else
                if (email.Text.IndexOf("@") == -1)
                {
                    message = "Email must have a @ character";
                    return false;
                }
                else
                if (email.Text[0] == '@')
                {
                    message = "Email must not contain @ at the first position";
                    return false;
                }
                else
                if (email.Text[email.Text.Length - 1] == '@')
                {
                    message = "Email must not contain @ at the last position";
                    return false;
                }
                else
                if (email.Text.IndexOf('@') != email.Text.LastIndexOf('@'))
                {
                    message = "Email must not contain more than one @ character";
                    return false;
                }
                else
                if (email.Text.IndexOf("@.") != -1 || email.Text.IndexOf(".@") != -1)
                {
                    message = "Email must not have a @ and dot(.) characters togather";
                    return false;
                }
                else
                {
                    message = "";
                    return true;
                }

            }

        }
    
}
