using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.MODELS;
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
    public partial class Teacherfrm : UserControl
    {
        public Teacherfrm()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            TeachersModel model = new TeachersModel();
            model.Teacher_Name = txtteachername.Text;
            model.Teacher_Cnic = txtteachercnic.Text;
            model.Qualification  = DDLqualification.Text;
            model.Subject = DDLsubject.Text;
            model.Designation = DDLdesignation.Text;
            BLTeachers.Insert(model);
            MessageBox.Show("Teacher Submitted successfully","INFO",MessageBoxButtons.OK,MessageBoxIcon.Information);
        }
    }
}
