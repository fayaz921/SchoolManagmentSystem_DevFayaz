using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Security.Permissions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class Admissionfrm : UserControl
    {
        private int Formno;
        private int CurrentYear = DateTime.Now.Year;
        public Admissionfrm()
        {
            InitializeComponent();
            GetAdmformno();
        }

        private void GetAdmformno()
        {
            BLAdmission bLAdmission = new BLAdmission();
            var dt = bLAdmission.GetAdmFormNo();
            if (dt.Rows.Count > 0)
            {
                Formno = Convert.ToInt32(dt.Rows[0]["FormNo"].ToString());
                Formno++;
                lblFormNo.Text = Formno.ToString();
            }
            else
            {
                Formno = 1;
                lblFormNo.Text = Formno.ToString();
            }
        }
        string Rollnumber;
        int Stdstrength;
        string Stdstrengthmsg = "Section Student Strength = ";

        private void SectionCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            lblStudentStrength.Visible = true;

            lblStudentStrength.Text = Stdstrengthmsg;
            string classname = DDLclass.Text;
            char section = Convert.ToChar(DDLSection.Text);
            var dt = BLClass.GetStudentStrength(classname, section);
            if (dt.Rows.Count > 0)
            {
                int maxstrength = 50;
                Rollnumber = dt.Rows[0]["Strength"].ToString();
                Stdstrength = Convert.ToInt32(Rollnumber);

                if (Stdstrength > maxstrength)
                {
                    if (section == 'A')
                    {
                        MessageBox.Show("Section A is Full,Switching to Section B");
                        DDLSection.Text = "B";
                    }
                    else if (section == 'B')
                    {
                        MessageBox.Show("Section B is Full,Switching to Section C");
                        DDLSection.Text = "C";
                    }
                    else if (section == 'C')
                    {
                        MessageBox.Show("Section C is Full,Admission closed for this class");
                        DDLSection.Text = null;
                    }
                    else
                    {
                        MessageBox.Show("Select a section");
                    }
                }
                else
                {
                    Stdstrength++;
                    lblStudentStrength.Text += Stdstrength;
                }

            }
        }

        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                StudentsModel students = new StudentsModel();
                students.Student_Name = txtStdName.Text;
                students.Father_Name = txtFname.Text;
                students.Roll_Number = CurrentYear + Rollnumber;
                students.Dob = txtDOB.Value.Date;
                students.Gender = DDLGender.SelectedIndex;
                students.DomicileFront = DomicileFront;
                students.DomicileBack = DomicileBack;
                students.StudentFormBImage = FormBimage;
                int Stdid = BLStudent.Insert(students);
                AdmissionModel admissionModel = new AdmissionModel();
                admissionModel.Form_Number = Formno;
                admissionModel.Admission_Date = DateTime.Now;
                admissionModel.Student_Id = Stdid;
                BLAdmission.Insert(admissionModel);
                ClassModel classModel = new ClassModel();
                classModel.ClassName = DDLclass.Text;
                classModel.Section = Convert.ToChar(DDLSection.Text);
                classModel.Section_Strength = Stdstrength;
                classModel.Student_Id = Stdid;
                BLClass.Insert(classModel);

                MessageBox.Show("Admission successful", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("" + ex.Message);
            }

        }
        string DomicileFront;
        string DomicileBack;
        string FormBimage;
        private void PicBoxDomicilFrontImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DomicileFront = openFileDialog.FileName;
                PicBoxDomicilFrontImage.Image = new Bitmap(DomicileFront);
            }
        }

        private void PicBoxDomicileBack_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                DomicileBack = openFileDialog.FileName;
                PicBoxDomicileBackImage.Image = new Bitmap(DomicileBack);
            }
        }

        private void PicBoxFormBImage_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new OpenFileDialog();
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                FormBimage = openFileDialog.FileName;
                PicBoxFormBImage.Image = new Bitmap(FormBimage);
            }
        }

        private bool Validations()
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(txtStdName.Text))
            {
                txtStdName.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtStdName.BorderColor = Color.Green;
                isvalid = true;
            }
            if(string.IsNullOrEmpty(txtFCNIC.Text))
            {
                txtFCNIC.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtFCNIC.BorderColor= Color.Green;
                isvalid = true;
            }
            if (string.IsNullOrEmpty(txtFname.Text))
            {
                txtFname.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtFname.BorderColor = Color.Green;
                isvalid = true;
            }
            return isvalid;
 
        }

        private void txtStdName_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back )
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtFCNIC_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }

        }

        private void txtFname_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetter(e.KeyChar) || e.KeyChar == ' ' || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }
    }
}
