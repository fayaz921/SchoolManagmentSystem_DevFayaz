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
            try
            {
                if (Validations())
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
                    Cleartextboxes();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }
        private bool Validations()
        {
            bool isvalid = true;

            if (string.IsNullOrEmpty(txtemployename.Text))
            {
                txtemployename.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtemployename.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(txtemployecnic.Text))
            {
                txtemployecnic.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtemployecnic.BorderColor = Color.Green;
            }

            if (string.IsNullOrEmpty(Txtemail.Text))
            {
                Txtemail.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                Txtemail.BorderColor = Color.Green;
            }

            if (string.IsNullOrEmpty(DDLqualification.Text))
            {
                DDLqualification.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                DDLqualification.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(DDLdesignation.Text))
            {
                DDLdesignation.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                DDLdesignation.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(txtdateofjoining.Value.Date.ToString()))
            {
                txtdateofjoining.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtdateofjoining.BorderColor = Color.Green;
            }
            return isvalid;
        }

        private void Cleartextboxes()
        {
            txtemployename.Clear();
            txtemployecnic.Clear();
            DDLqualification.Text = null;
            DDLdesignation.Text = null;
            Txtemail.Clear();
            txtdateofjoining.Text = null;
        }
    }
}
