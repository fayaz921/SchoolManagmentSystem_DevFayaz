using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels
{
    public class AdmissionModel
    {
        //        @type int,
        //@Admission_Id int = null,
        //@Form_Number int = null,
        //@Admission_Date varchar(max) = null,
        //@User_Id int = null,
        //@Student_Id int = null


        public int Admisssion_Id { get; set; }
        public int Form_Number { get; set; }
        public DateTime Admission_Date { get; set; }
        public int Student_Id { get; set; }
    }
}
