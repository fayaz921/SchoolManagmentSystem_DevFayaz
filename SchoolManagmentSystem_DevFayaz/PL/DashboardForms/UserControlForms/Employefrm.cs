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
    public partial class Employefrm : UserControl
    {
        public Employefrm()
        {
            InitializeComponent();
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            EmployeModel employeModel = new EmployeModel();
            employeModel.Employe_Name = txtemployename.Text;
            employeModel.Employe_Cnic = txtemployecnic.Text;
            employeModel.Qualification = DDLqualification.Text;
            employeModel.Designation = DDLdesignation.Text;
            employeModel.Email = Txtemail.Text;
            employeModel.DateofJoining = txtdateofjoining.Value.Date;
            BLEmployes.Insert(employeModel);
            MessageBox.Show("Employe submitted successfully");
        }
    }
}
