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
    public partial class Admindashboard : UserControl
    {
        public Admindashboard()
        {
            InitializeComponent();
        }

        public void Showusercontrolfrm(UserControl control)
        {
            PanelAdmindashboard.Controls.Clear();
            control.Dock = DockStyle.Fill;
            PanelAdmindashboard.Controls.Add(control);
        }
        private void btnadmissionform_Click(object sender, EventArgs e)
        {            
            Showusercontrolfrm(new Admissionfrm());
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Teacherfrm());
        }

        private void guna2Panel1_Paint(object sender, PaintEventArgs e)
        {

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

        private void btnlogdata_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new Logfrm());
        }

        private void btnStudentFee_Click(object sender, EventArgs e)
        {
            Showusercontrolfrm(new StudentFeeFrm());
        }

        private void btnloginfrm_Click(object sender, EventArgs e)
        {
            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            dashboardfrm.Controls.Clear();
            Authenticationfrm authfrm = new Authenticationfrm();
            authfrm.ShowDialog();
            authfrm.Showloginform();
            dashboardfrm.Close();

        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
            dashboardfrm.Close();
        }
    }
}
