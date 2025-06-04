using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using SchoolManagmentSystem_DevFayaz.PL.DashboardForms.SimpleForm;
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
    public partial class Loginform : UserControl
    {
        public Loginform()
        {
            InitializeComponent();
        }

        private void linkLabelLogin_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            RoleVerification roleVerification = new RoleVerification();
            authenticationfrm.ShowRoleverificationform(roleVerification);
        }

        private void linkLabelforgetpassword_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            EmailVerification emailVerification = new EmailVerification();
            authenticationfrm.ShowEmailverificationform(emailVerification);
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

                Checkinguser();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }

        public bool Checkinguser()
        {
            UserinfoModel userinfomodel = new UserinfoModel();
            string textbox = txtusername.Text;
            if (textbox.Contains("@"))
            {
                userinfomodel.User_Email = textbox;
                userinfomodel.User_Name = null;
            }
            else
            {
                userinfomodel.User_Name = textbox;
                userinfomodel.User_Email = null;
            }
            userinfomodel.User_Password = txtpassword.Text;
            BLUserinfo bLUserinfo = new BLUserinfo();
            DataTable dt = new DataTable();
            dt = bLUserinfo.Usercheck(userinfomodel);
            if (dt.Rows.Count > 0)
            {
                Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
                authenticationfrm.Controls.Clear();
                Dashboardfrm dashboardfrm = new Dashboardfrm();
                dashboardfrm.ShowDialog();
                authenticationfrm.Close();
                return true;
            }
            else
            {
                MessageBox.Show("user not found", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return false;
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_')
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
