using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
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
        int? ID = null;
        public Teacherfrm()
        {
            InitializeComponent();
        }

        public Teacherfrm(int id)
        {
            InitializeComponent();
            ID = id;
            LoadTeachersData();
        }

        public void LoadTeachersData()
        {
            var dt = BLTeachers.GetDataByID(ID.Value);
            if (dt.Rows.Count > 0)
            {
                lblteacherid.Text = dt.Rows[0]["Teacher_Id"].ToString();
                txtteachername.Text = dt.Rows[0]["Teacher_Name"].ToString();
                txtteachercnic.Text = dt.Rows[0]["Teacher_Cnic"].ToString();
                DDLqualification.Text = dt.Rows[0]["Qualification"].ToString();
                DDLsubject.Text = dt.Rows[0]["Subject"].ToString();
                DDLdesignation.Text = dt.Rows[0]["Designation"].ToString() ;
                txtemail.Text = dt.Rows[0]["Email"].ToString();
                txtdateofjoining.Value = Convert.ToDateTime(dt.Rows[0]["DateofJoining"]);
                //if (dt.Rows[0]["Email"] != DBNull.Value)
                //    txtemail.Text = dt.Rows[0]["Email"].ToString();
                //else
                //    txtemail.Clear();

                //if (dt.Rows[0]["DateOfJoining"] != DBNull.Value)
                //    txtdateofjoining.Value = Convert.ToDateTime(dt.Rows[0]["DateOfJoining"]);
                //else
                //    txtdateofjoining.Value = DateTime.Today; // or leave it unchanged
            
        }

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
                    LogModel logModel = new LogModel();
                    logModel.UserId = UserCreads.UserId;
                    logModel.Message = "New Teacher Added: TeacherName:" + model.Teacher_Name + ",Email:" + model.Email;
                    logModel.CreateAt = DateTime.Now;
                    //BL_Log.Insert(logModel);
                    //BLTeachers.Insert(model);
                    if (ID.HasValue)
                    {
                        model.Teacher_Id = ID.Value;
                        BLTeachers.Update(model);
                        MessageBox.Show("Teacherdata Updated successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        BLTeachers.Insert(model);
                       MessageBox.Show("Teacherdata Submitted successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
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
