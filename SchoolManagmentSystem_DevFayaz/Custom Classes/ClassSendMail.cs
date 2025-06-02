using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.Custom_Classes
{
    public static class ClassSendMail
    {
        public static int Sendmail(string from, string to, string subject, string body)
        {
            try
            {

                MailMessage mailMessage = new MailMessage();
                mailMessage.From = new MailAddress(from);
                mailMessage.To.Add(to);
                mailMessage.Subject = subject;
                mailMessage.Body = body;
                mailMessage.IsBodyHtml = true;
                SmtpClient smtpClient = new SmtpClient();
                smtpClient.Host = "smtp.gmail.com";
                smtpClient.Port = 587;
                smtpClient.Credentials = new NetworkCredential(from, "mlwv owot maqz vmuq");
                smtpClient.EnableSsl = true;
                smtpClient.Send(mailMessage);
                return 1;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message, "Email Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return 0;
            }
        }
    }
}
