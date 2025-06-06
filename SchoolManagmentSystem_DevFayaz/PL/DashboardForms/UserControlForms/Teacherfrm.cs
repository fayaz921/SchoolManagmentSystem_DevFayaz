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
            try
            {
                if (Validations())
                {
                    TeachersModel model = new TeachersModel();
                    model.Teacher_Name = txtteachername.Text;
                    model.Teacher_Cnic = txtteachercnic.Text;
                    model.Qualification = DDLqualification.Text;
                    model.Subject = DDLsubject.Text;
                    model.Designation = DDLdesignation.Text;
                    model.Email = txtemail.Text;
                    model.DateofJoining = txtdateofjoining.Value.Date;
                    if (!BLTeachers.TeacherValidations(model))
                    {
                        return;
                    }
                    BLTeachers.Insert(model);
                    MessageBox.Show("Teacher Submitted successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
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

            if (string.IsNullOrEmpty(txtteachername.Text))
            {
                txtteachername.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtteachername.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(txtteachercnic.Text))
            {
                txtteachercnic.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtteachercnic.BorderColor = Color.Green;
            }

            if (string.IsNullOrEmpty(DDLsubject.Text))
            {
                DDLsubject.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                DDLsubject.BorderColor = Color.Green;
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
            if(string.IsNullOrEmpty(txtemail.Text))
            {
                txtemail.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtemail.BorderColor = Color.Green;
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
            txtteachername.Clear();
            txtteachercnic.Clear();
            DDLqualification.Text = null;
            DDLsubject.Text = null;
            DDLdesignation.Text = null;
            txtemail.Clear();
            txtdateofjoining.Text = null;
        }
    }
}
