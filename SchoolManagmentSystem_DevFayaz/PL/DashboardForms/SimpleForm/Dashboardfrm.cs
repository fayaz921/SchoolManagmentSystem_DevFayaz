using SchoolManagmentSystem_DevFayaz.Custom_Classes;
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
            //CheckDashboardAuthorization();         
        }
        public void CheckDashboardAuthorization()
        {
            Paneldashboard.Controls.Clear();
            if (UserCreads.UserRole == Role.Admin)
            {
                Admindashboard admindashboard = new Admindashboard();
                admindashboard.Dock = DockStyle.Fill;
                Paneldashboard.Controls.Add(admindashboard);
            }
            else if (UserCreads.UserRole == Role.Employee)
            {
                Employedashboard employedashboard = new Employedashboard();
                employedashboard.Dock = DockStyle.Fill;
                Paneldashboard.Controls.Add(employedashboard);
            }
            else if (UserCreads.UserRole == Role.Teacher)
            {
                Teachersdashboard teachersdashboard = new Teachersdashboard();
                teachersdashboard.Dock = DockStyle.Fill;
                Paneldashboard.Controls.Add(teachersdashboard);
            }
            else if (UserCreads.UserRole == Role.Student)
            {
                Studentsdashboard studentsdashboard = new Studentsdashboard();
                studentsdashboard.Dock = DockStyle.Fill;
                Paneldashboard.Controls.Add(studentsdashboard);
            }

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Dashboardfrm_Load(object sender, EventArgs e)
        {
            CheckDashboardAuthorization();
        }
        //public void Showusercontrolforms(UserControl obj)
        //{
        //    flowLayoutPaneldashboard.Controls.Clear();           
        //    flowLayoutPaneldashboard.Controls.Add(obj);
        //}
        //    private void btnadmissionform_Click(object sender, EventArgs e)
        //    {
        //        Admissionfrm admissionfrm = new Admissionfrm();
        //        Showusercontrolforms(admissionfrm);
        //    }

        //    private void btnclass5th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("5th");
        //        Showusercontrolforms(classfrm);

        //    }

        //    private void btnclass6th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("6th");
        //        Showusercontrolforms(classfrm);
        //    }

        //    private void btnclass7th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("7th");
        //        Showusercontrolforms(classfrm);
        //    }

        //    private void btnclass8th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("8th");
        //        Showusercontrolforms(classfrm);
        //    }

        //    private void btnclass9th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("9th");
        //        Showusercontrolforms(classfrm);
        //    }

        //    private void btnclass10th_Click(object sender, EventArgs e)
        //    {
        //        Classfrm classfrm = new Classfrm("10th");
        //        Showusercontrolforms(classfrm);
        //    }

        //    private void btnteachers_Click(object sender, EventArgs e)
        //    {         
        //            TeacherData teacherdataFrm = new TeacherData();
        //            Showusercontrolforms(teacherdataFrm);       
        //    }

        //    private void btnemployes_Click(object sender, EventArgs e)
        //    {
        //        Employefrm employefrm = new Employefrm();
        //        Showusercontrolforms(employefrm);
        //    }

        //    private void btnloginfrm_Click(object sender, EventArgs e)
        //    {
        //        Dashboardfrm dashboardfrm = (Dashboardfrm)this.FindForm();
        //        dashboardfrm.Controls.Clear();
        //        Authenticationfrm authfrm = new Authenticationfrm();
        //        authfrm.ShowDialog();
        //        authfrm.Showloginform();
        //        dashboardfrm.Close();

        //    }

        //    private void btnlogdata_Click(object sender, EventArgs e)
        //    {
        //        Logfrm logfrm = new Logfrm();
        //        Showusercontrolforms(logfrm);
        //    }

        //    private void btnStudentFee_Click(object sender, EventArgs e)
        //    {
        //        StudentFeeFrm obj = new StudentFeeFrm();
        //        Showusercontrolforms(obj);
        //    }

        //    private void guna2Button1_Click(object sender, EventArgs e)
        //    {
        //        Admindashboard frm = new Admindashboard();
        //        Showusercontrolforms(frm);
        //    }
    }
}
