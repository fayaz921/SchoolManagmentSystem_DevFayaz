using System;

namespace SchoolManagmentSystem_DevFayaz.MODELS
{
    public class StudentsModel
    {
        public int type { get; set; }
        public int Student_Id { get; set; }
        public string Student_Name { get; set; }
        public string Father_Name { get; set; }
        public string Roll_Number { get; set; }
        public DateTime Dob { get; set; }
        public int Gender { get; set; }     
        public string DomicileFront { get; set; }
        public string DomicileBack { get; set; }
        public string StudentFormBImage { get; set; }
    }
}
