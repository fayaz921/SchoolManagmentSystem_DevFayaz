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
    public partial class Employedashboard : UserControl
    {
        public Employedashboard()
        {
            InitializeComponent();
        }

        public void Showusercontrolfrm(UserControl frm)
        {
            PanelEmployedashboard.Controls.Clear();
            frm.Dock = DockStyle.Fill;
            PanelEmployedashboard.Controls.Add(frm);
        }

        private void btnadmissionform_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Admissionfrm());
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Teacherfrm());
        }

        private void btnemployes_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Employefrm());
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

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new StudentFeeFrm());
        }

        private void btnlogout_Click(object sender, EventArgs e)
        {
            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            dashboardfrm.Controls.Clear();
            Authenticationfrm authenticationfrm = new Authenticationfrm();
            authenticationfrm.ShowDialog();
            authenticationfrm.Showloginform();
            dashboardfrm.Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            dashboardfrm.Close();
        }
    }
}
