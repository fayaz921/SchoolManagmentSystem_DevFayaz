using SchoolManagmentSystem_DevFayaz.DL;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using SchoolManagmentSystem_DevFayaz.Enums;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLAdmission
    {
        public static void Insert(AdmissionModel model)
        {
            SqlParameter[] sp = new SqlParameter[4];
            sp[0] = new SqlParameter("@type", UserEnums.Insert);
            sp[1] = new SqlParameter("@Form_Number", model.Form_Number);
            sp[2] = new SqlParameter("@Admission_Date", model.Admission_Date);
            sp[3] = new SqlParameter("@Student_Id", model.Student_Id);
            DataAccessLayer.Setdata("Sp_Admission", sp);
        }


        public DataTable GetAdmFormNo()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@type", AdmissionEnum.GetFormNo);
            return DataAccessLayer.GetData("Sp_Admission", prm);

        }

        public static void Update(AdmissionModel model)
        {
            SqlParameter[] sp = new SqlParameter[5];
            sp[0] = new SqlParameter("@type", UserEnums.Update);
            sp[1] = new SqlParameter("@Admission_Id", model.Admisssion_Id);
            sp[2] = new SqlParameter("@Form_Number", model.Form_Number);
            sp[3] = new SqlParameter("@Admission_Date", model.Admission_Date);
            sp[4] = new SqlParameter("@Student_Id", model.Student_Id);
            DataAccessLayer.Setdata("Sp_Admission", sp);      
        }
        public int Delete(AdmissionModel model)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@type", UserEnums.Delete);
            sp[1] = new SqlParameter("@Admission_Id", model.Admisssion_Id);
            int result = DataAccessLayer.Setdata("Sp_Admission", sp);
            return result;
        }
        public DataTable Select()
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@type", UserEnums.Select);
            DataTable dt = new DataTable();
            dt = DataAccessLayer.GetData("Sp_Admission", sp);
            return dt;
        }

    }
}
