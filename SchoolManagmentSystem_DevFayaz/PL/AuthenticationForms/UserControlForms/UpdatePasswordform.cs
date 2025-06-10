using SchoolManagmentSystem_DevFayaz.BL;
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
    public partial class UpdatePasswordform : UserControl
    {
        public UpdatePasswordform()
        {
            InitializeComponent();
        }
        private void btnupdatepassword_Click(object sender, EventArgs e)
        {
            try
            {

                if (Textboxvalidations())
                {
                    BLUserinfo bLUserinfo = new BLUserinfo();
                    int otp = Convert.ToInt32(txtotp.Text);
                    var dt = bLUserinfo.OTPVerify(otp);
                    if (dt.Rows.Count > 0)
                    {
                        if (txtnewpassword.Text != txtconfirmpassword.Text)
                        {
                            MessageBox.Show("Password didn't match", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }
                        else
                        {
                            bLUserinfo.UpdatePassword(otp, txtnewpassword.Text);
                            MessageBox.Show("Password changed successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
                            authenticationfrm.Showloginform();
                        }
                    }
                    else
                    {
                        MessageBox.Show("Invalid OTP", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
            }

        }

        public bool Textboxvalidations()
        {
            bool isvalid = true;
            if (string.IsNullOrEmpty(txtotp.Text))
            {
                txtotp.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtotp.BorderColor = Color.Green;
                isvalid = true;
            }

            if (string.IsNullOrEmpty(txtnewpassword.Text))
            {
                txtnewpassword.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtnewpassword.BorderColor = Color.Green;
                isvalid = true;
            }
            if (string.IsNullOrEmpty(txtconfirmpassword.Text))
            {
                txtconfirmpassword.BorderColor = Color.Red;
                isvalid = false;
            }
            else
            {
                txtconfirmpassword.BorderColor = Color.Green;
                isvalid = true;
            }
            return isvalid;
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            EmailVerification emailVerification = new EmailVerification();
            authenticationfrm.ShowEmailverificationform(emailVerification);
        }

        private void txtnewpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtnewpassword.Text !="")
            {
                btnshowhideNp.Visible = true;
            }
            else
            {
                btnshowhideNp.Visible = false;
            }
        }

        private void btnshowhideNp_MouseEnter(object sender, EventArgs e)
        {
            txtnewpassword.PasswordChar = '\0';
            btnshowhideNp.Text = "H";
        }

        private void btnshowhideNp_MouseLeave(object sender, EventArgs e)
        {
            txtnewpassword.PasswordChar = '*';
            btnshowhideNp.Text = "S";
        }

        private void txtconfirmpassword_TextChanged(object sender, EventArgs e)
        {
            if(txtconfirmpassword.Text !="")
            {
                btnshowhideCp.Visible = true;
            }
            else
            {
                btnshowhideCp.Visible = false;
            }
        }

        private void btnshowhideCp_MouseEnter(object sender, EventArgs e)
        {
            txtconfirmpassword.PasswordChar = '\0';
            btnshowhideCp.Text = "H";
        }

        private void btnshowhideCp_MouseLeave(object sender, EventArgs e)
        {
            txtconfirmpassword.PasswordChar= '*';
            btnshowhideCp.Text = "S";
        }
    }
}
