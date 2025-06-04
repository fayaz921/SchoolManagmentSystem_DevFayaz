using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
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
    public partial class EmailVerification : UserControl
    {
        public EmailVerification()
        {
            InitializeComponent();
        }

        private void btnlogin_Click(object sender, EventArgs e)
        {
            try
            {

                BLUserinfo bLUserinfo = new BLUserinfo();
                var dt = bLUserinfo.CheckIdentity("", txtEmail.Text);
                if (dt.Rows.Count > 0)
                {
                    string ToEmail = txtEmail.Text;
                    int OTP = OTP_Generator.OTP();
                    int userid = Convert.ToInt32(dt.Rows[0]["User_Id".ToString()]);
                    bLUserinfo.UpdateOTP(userid, OTP);
                    int result = ClassSendMail.Sendmail("mfayaz21703@gmail.com", ToEmail, "Change Password", "Dont share this OTP  " + OTP);
                    if (result == 1)
                    {
                        MessageBox.Show("OTP sended successfully", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
                        UpdatePasswordform updatePasswordform = new UpdatePasswordform();
                        authenticationfrm.ShowUpdatepasswordform(updatePasswordform);

                    }
                    else
                    {
                        MessageBox.Show("Network is not available", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
                else
                {
                    MessageBox.Show("Email not Registered", "INFO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }
        private void guna2Button1_Click(object sender, EventArgs e)
        {
            Authenticationfrm authenticationfrm = (Authenticationfrm)this.FindForm();
            authenticationfrm.Showloginform();
        }
    }
}
