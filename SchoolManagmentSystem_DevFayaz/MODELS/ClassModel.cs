using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels
{
    public class ClassModel
    {
        public int type { get; set; }
        public int Id { get; set; }
        public string ClassName { get; set; }
        public Char Section { get; set; }
        public int Section_Strength { get; set; }
        public int Student_Id { get; set; }
    }
}
