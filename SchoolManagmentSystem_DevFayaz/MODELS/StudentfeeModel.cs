using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS
{
    public class StudentfeeModel
    {
        //        @type int,
        //@Fee_Id int=null,
        //@Student_Id int = null,
        //@Class_Id int =null,
        //@Fee_Amount int=null,
        //@Fee_PendingAmount int=null,
        //@Fee_Submitiondate datetime=null,
        //@Fee_Status int=null

        public int Fee_Id { get; set; }
        public int Student_Id { get; set; }
        public int Class_Id { get; set; }
        public int Fee_Amount { get; set; }
        public int Fee_PendingAmount { get; set; }
        public DateTime Fee_Submitiondate { get; set; }
        public int Fee_Status { get; set; }

    }
}
