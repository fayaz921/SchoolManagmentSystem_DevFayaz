using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLTeachers
    {
        private static string Actiontype = "@Actiontype";
        private static string Spname = "Sp_Teachers";

        public static int Insert (TeachersModel model)
        {
            SqlParameter[] prm = new SqlParameter[8];
            prm[0] = new SqlParameter(Actiontype, TeacherEnums.Insert);
            prm[1] = new SqlParameter("@Teacher_Name", model.Teacher_Name);
            prm[2] = new SqlParameter("@Teacher_Cnic",model.Teacher_Cnic);
            prm[3] = new SqlParameter("@Qualification",model.Qualification);
            prm[4] = new SqlParameter("@Subject",model.Subject);
            prm[5] = new SqlParameter("@Designation",model.Designation);
            prm[6] = new SqlParameter("@Email",model.Email);
            prm[7] = new SqlParameter("@DateofJoining", model.DateofJoining);
            return DataAccessLayer.Setdata(Spname,prm);
        }
    }
}
