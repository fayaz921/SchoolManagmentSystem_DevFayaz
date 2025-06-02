using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.Custom_Classes
{
    public class OTP_Generator
    {
        public static int OTP()
        {
            Random random = new Random();
            int otp = random.Next(100000, 999999);
            return otp;
        }
    }
}
