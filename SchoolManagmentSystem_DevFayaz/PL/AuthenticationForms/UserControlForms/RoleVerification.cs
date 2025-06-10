using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.AuthenticationForms.UserControlForms
{
    public partial class RoleVerification : UserControl
    {
        public RoleVerification()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

                if (Checktextboxes())
                {
                    if (CheckAdmin())
                    {
                        MessageBox.Show("Wellcome Admin Fayaz ", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
                        Signupform signupform = new Signupform();
                        authenticationfrm.Showsignupform(signupform);
                    }
                    else
                    {
                        MessageBox.Show("You are not Admin", "info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }





        }

        public bool CheckAdmin()
        {
            UserinfoModel userinfoModel = new UserinfoModel();
            userinfoModel.User_Name = txtusername.Text;
            userinfoModel.User_Email = txtusername.Text;
            userinfoModel.User_Password = txtpassword.Text;
            BLUserinfo bLUserinfo = new BLUserinfo();
            DataTable dt = new DataTable();
            dt = bLUserinfo.Admin(userinfoModel);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        private bool Checktextboxes()
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(txtusername.Text))
            {
                txtusername.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtusername.BorderColor = Color.Green;

            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                txtpassword.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtpassword.BorderColor = Color.Green;
            }
            return isvalid;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            authenticationfrm.Showloginform();
        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtpassword.Text !="")
            {
                btnshowhide.Visible = true;
            }
            else
            {
                btnshowhide.Visible = false;
            }
        }

        private void btnshowhide_MouseEnter(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '\0';
            btnshowhide.Text = "H";
        }

        private void btnshowhide_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            btnshowhide.Text = "S";
        }
    }
}
