using Microsoft.SqlServer.Server;
using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLStudent
    {
        private static string Actiontype = "@Actiontype";
        private static string Spname = "Sp_Students";
        public static int Insert(StudentsModel students)
        {
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter(Actiontype, 1);
            prm[1] = new SqlParameter("@Student_Name", students.Student_Name);
            prm[2] = new SqlParameter("@Father_Name", students.Father_Name);
            prm[3] = new SqlParameter("@Roll_Number", students.Roll_Number);
            prm[4] = new SqlParameter("@Dob", students.Dob);
            prm[5] = new SqlParameter("@Gender", students.Gender);
            prm[6] = new SqlParameter("@DomicileFront", students.DomicileFront);
            prm[7] = new SqlParameter("@DomicileBack", students.DomicileBack);
            prm[8] = new SqlParameter("@StudentFormBImage", students.StudentFormBImage);
            var dt = DataAccessLayer.GetData(Spname, prm);
            int Stdid = Convert.ToInt32(dt.Rows[0]["Student_Id"].ToString());
            return Stdid;
        }
    }
}
