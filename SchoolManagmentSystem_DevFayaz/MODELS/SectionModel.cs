using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels
{
    public class SectionModel
    {
        //        @type int,
        //@Section_Id int = null,
        //@Section varchar(max) = null,
        //@Strength int = null,
        //@Student_Id int = null

        public int type { get; set; }
        public int Section_Id { get; set; }
        public string Section { get; set; }
        public int Strength { get; set; }
        public int Student_Id { get; set; }
    }
}
