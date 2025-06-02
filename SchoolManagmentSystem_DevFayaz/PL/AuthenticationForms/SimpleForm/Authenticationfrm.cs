using SchoolManagmentSystem_DevFayaz.PL.AuthenticationForms.UserControlForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz
{
    public partial class Authenticationfrm : Form
    {
        public Authenticationfrm()
        {
            InitializeComponent();
            Showloginform();
        }

        public void Showloginform()
        {
            flowLayoutPanelAuthentication.Controls.Clear();
            Loginform loginform = new Loginform();
            flowLayoutPanelAuthentication.Controls.Add(loginform);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        public void ShowRoleverificationform(UserControl roleverificationfrm)
        {
            flowLayoutPanelAuthentication.Controls.Clear();
            flowLayoutPanelAuthentication.Controls.Add(roleverificationfrm);
        }

        public void Showsignupform(UserControl signup)
        {
            flowLayoutPanelAuthentication.Controls.Clear();
            flowLayoutPanelAuthentication.Controls.Add(signup);
        }

        public void ShowEmailverificationform(UserControl emailverificationfrm)
        {
            flowLayoutPanelAuthentication.Controls.Clear();
            flowLayoutPanelAuthentication.Controls.Add(emailverificationfrm);
        }

        public void ShowUpdatepasswordform(UserControl updatepasswordform)
        {
            flowLayoutPanelAuthentication.Controls.Clear();
            flowLayoutPanelAuthentication.Controls.Add(updatepasswordform);
        }
    }
}
