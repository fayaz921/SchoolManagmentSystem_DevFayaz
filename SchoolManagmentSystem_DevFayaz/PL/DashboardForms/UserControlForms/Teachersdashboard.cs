using SchoolManagmentSystem_DevFayaz.PL.AuthenticationForms.UserControlForms;
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

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class Teachersdashboard : UserControl
    {
        public Teachersdashboard()
        {
            InitializeComponent();
        }

        public void Showusercontrolfrm(UserControl frm)
        {
            PanelTeacherdashboard.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelTeacherdashboard.Controls.Add(frm);
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Teacherfrm());
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new StudentFeeFrm());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            Authenticationfrm auth = new Authenticationfrm();
            Loginform loginform = new Loginform();
            auth.ShowDialog();
            auth.Showloginform();
            dashboardfrm.Close();
        }
    }
}
