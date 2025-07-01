using SchoolManagmentSystem_DevFayaz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.Custom_Classes
{
    public static  class UserCreads
    {
        public static int UserId { get; set; }
        public static string UserName { get; set; }
        public static Role UserRole { get; set; }
        public static string Message { get; set; }
        public static DateTime CreateAt { get; set; }
    }
}
