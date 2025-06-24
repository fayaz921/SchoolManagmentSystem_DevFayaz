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
    public partial class Studentsdashboard : UserControl
    {
        public Studentsdashboard()
        {
            InitializeComponent();
        }

        private void Showusercontrolfrm(UserControl userControl)
        {
            PanelStudentdashboard.Controls.Clear();
            userControl.Dock = DockStyle.Fill;
            PanelStudentdashboard.Controls.Add(userControl);
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new StudentFeeFrm());
        }

        private void btnclass5th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("5th"));
        }

        private void btnclass6th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("6th"));
        }

        private void btnclass7th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("7th"));
        }

        private void btnclass8th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("8th"));
        }

        private void btnclass9th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("9th"));
        }

        private void btnclass10th_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Classfrm("10th"));
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {

            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            dashboardfrm.Controls.Clear();
            Authenticationfrm authfrm = new Authenticationfrm();
            authfrm.ShowDialog();
            authfrm.Showloginform();
            dashboardfrm.Close();

            //Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            //dashboardfrm.Controls.Clear();
            //Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            //authenticationfrm.ShowDialog();
            //authenticationfrm.Showloginform();
            //dashboardfrm.Close();
        }
    }
}
