using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.SimpleForm
{
    public partial class Dashboardfrm : Form
    {
        public Dashboardfrm()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        public void Showusercontrolforms(UserControl obj)
        {
            flowLayoutPaneldashboard.Controls.Clear();
            flowLayoutPaneldashboard.Controls.Add(obj);
        }
        private void btnadmissionform_Click(object sender, EventArgs e)
        {
            Admissionfrm admissionfrm = new Admissionfrm();
            Showusercontrolforms(admissionfrm);
        }

        private void btnclass5th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("5th");
            Showusercontrolforms(classfrm);

        }

        private void btnclass6th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("6th");
            Showusercontrolforms(classfrm);
        }

        private void btnclass7th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("7th");
            Showusercontrolforms(classfrm);
        }

        private void btnclass8th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("8th");
            Showusercontrolforms(classfrm);
        }

        private void btnclass9th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("9th");
            Showusercontrolforms(classfrm);
        }

        private void btnclass10th_Click(object sender, EventArgs e)
        {
            Classfrm classfrm = new Classfrm("10th");
            Showusercontrolforms(classfrm);
        }

        private void btnteachers_Click(object sender, EventArgs e)
        {
            Teacherfrm teacherfrm = new Teacherfrm();
            Showusercontrolforms(teacherfrm);
        }

        private void btnemployes_Click(object sender, EventArgs e)
        {
            Employefrm employefrm = new Employefrm();
            Showusercontrolforms(employefrm);
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
    }
}
