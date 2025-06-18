using SchoolManagmentSystem_DevFayaz.Enums;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS
{
    public class LogModel
    {
        public int Actiontype { get; set; }
        public  int UserId { get; set; }
        public  int Std_Id { get; set; }
        public  string Message { get; set; }
        public  DateTime CreateAt { get; set; }
    }
}
