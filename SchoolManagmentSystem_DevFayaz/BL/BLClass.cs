using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLClass
    {
        private static string Actiontype = "@Actiontype";
        private static string Spname = "Sp_Class";

        public static void Insert(ClassModel model)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter(Actiontype, 1);
            prm[1] = new SqlParameter("@ClassName", model.ClassName);
            prm[2] = new SqlParameter("@Section", model.Section);
            prm[3] = new SqlParameter("@Section_Strength", model.Section_Strength);
            prm[4] = new SqlParameter("@Student_Id", model.Student_Id);
            DataAccessLayer.Setdata(Spname, prm);
        }

        public static DataTable GetStudentStrength(string Classname,char sectionname)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter(Actiontype, 4);
            prm[1] = new SqlParameter("@ClassName", Classname);
            prm[2] = new SqlParameter("@Section", sectionname);
            return DataAccessLayer.GetData(Spname, prm);
        }

        public DataTable GetClassRecord(string classname)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter(Actiontype, ClassEnums.ClassRecord);
            prm[1] = new SqlParameter("@ClassName",classname);
            return DataAccessLayer.GetData(Spname, prm);
        }
    }
}
