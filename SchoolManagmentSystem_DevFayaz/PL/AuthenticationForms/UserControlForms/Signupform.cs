using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.AuthenticationForms.UserControlForms
{
    public partial class Signupform : UserControl
    {
        public Signupform()
        {
            InitializeComponent();
        }

        private void linkLabelSignup_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            authenticationfrm.Showloginform();
        }

        string filepath;
        private void btnsignup_Click(object sender, EventArgs e)
        {
            try
            {

                if (PlValidations())
                {

                    if (Getdata())
                    {
                        MessageBox.Show("Email OR Username Already Exist");

                    }
                    else
                    {
                        UserinfoModel userinfomodel = new UserinfoModel();
                        userinfomodel.User_Name = txtusername.Text;
                        userinfomodel.User_Email = txtemail.Text;
                        userinfomodel.User_Password = txtpassword.Text;
                        userinfomodel.User_Image = filepath;
                        userinfomodel.User_Role = Convert.ToInt32(Role.Employee | Role.Teacher | Role.Student);
                        userinfomodel.User_Status = Convert.ToInt32(txtuserstatus.Text);
                        userinfomodel.User_OTP = Convert.ToInt32(txtuserotp.Text);
                        BLUserinfo bLUserinfo = new BLUserinfo();
                        if(!bLUserinfo.UserValidation(userinfomodel))
                        {
                            return;
                        }
                        bLUserinfo.Insert(userinfomodel);
                        MessageBox.Show("signup successfully");
                        Cleartextboxes();

                        Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
                        authenticationfrm.Showloginform();
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }

        public bool Getdata()
        {

            BLUserinfo bLUserinfo = new BLUserinfo();
            DataTable dt = new DataTable();
            dt = bLUserinfo.CheckIdentity(txtusername.Text, txtemail.Text);
            if (dt.Rows.Count > 0)
            {
                return true;
            }
            else
            {
                return false;

            }
        }
        public bool PlValidations()
        {
            bool isvalid = true;

            if (string.IsNullOrEmpty(txtusername.Text))
            {
                txtusername.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtusername.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(txtpassword.Text))
            {
                txtpassword.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtpassword.BorderColor = Color.Green;
            }

            if (string.IsNullOrEmpty(txtemail.Text))
            {
                txtemail.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtemail.BorderColor = Color.Green;
            }

            if (string.IsNullOrEmpty(txtuserstatus.Text))
            {
                txtuserstatus.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtuserstatus.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(txtuserotp.Text))
            {
                txtuserotp.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtuserotp.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(comboboxRole.Text))
            {
                comboboxRole.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                comboboxRole.BorderColor = Color.Green;
            }
            if (string.IsNullOrEmpty(filepath))
            {
                picbox.FillColor = Color.Red;
                isvalid = false;
            }
            else
            {
                picbox.FillColor = Color.White;
                isvalid = true;
            }

            return isvalid;
        }
        public void Cleartextboxes()
        {
            txtusername.Clear();
            txtpassword.Clear();
            txtemail.Clear();
            txtuserstatus.Clear();
            txtuserotp.Clear();
            comboboxRole.Items.Clear();
            picbox.Image = null;
        }

        private void picbox_Click(object sender, EventArgs e)
        {
            try
            {

                OpenFileDialog openFileDialog = new OpenFileDialog();
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    filepath = openFileDialog.FileName;
                    picbox.Image = Bitmap.FromFile(filepath);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }
        }

        private void txtusername_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtemail_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '@' || e.KeyChar == '.' || e.KeyChar == '_')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtpassword_KeyPress(object sender, KeyPressEventArgs e)
        {
            //if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back || e.KeyChar == '.' || e.KeyChar == '_')
            //{
            //    e.Handled = false;
            //}
            //else
            //{
            //    e.Handled = true;
            //}
        }

        private void txtuserstatus_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void txtuserotp_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }

        private void comboboxRole_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (char.IsLetterOrDigit(e.KeyChar) || e.KeyChar == (char)Keys.Back)
            {
                e.Handled = false;
            }
            else
            {
                e.Handled = true;
            }
        }


        private void comboboxRole_SelectedValueChanged(object sender, EventArgs e)
        {

        }

        private void txtpassword_TextChanged(object sender, EventArgs e)
        {
            if(btnshowhide.Text !="")
            {
                btnshowhide.Visible = true;

            }
            else
            {
                btnshowhide.Visible = false;
            }
        }

        private void btnshowhide_MouseEnter(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '\0';
            btnshowhide.Text = "H";
        }

        private void btnshowhide_MouseLeave(object sender, EventArgs e)
        {
            txtpassword.PasswordChar = '*';
            btnshowhide.Text = "S";
        }
    }
}

