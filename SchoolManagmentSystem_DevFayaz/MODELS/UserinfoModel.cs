using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels
{
    public class UserinfoModel
    {
        public int type { get; set; }
        public int User_Id { get; set; }
        public string User_Name { get; set; }
        public string User_Email { get; set; }
        public int User_Role { get; set; }
        public string User_Password { get; set; }
        public string User_Image { get; set; }
        public int User_Status { get; set; }
        public int User_OTP { get; set; }
    }
}
