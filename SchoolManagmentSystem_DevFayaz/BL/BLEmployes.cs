using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLEmployes
    {
        private static string Actiontype = "@Actiontype";
        private static string Spname = "Sp_Employes";

        public static int Insert(EmployeModel employeModel)
        {
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter(Actiontype,EmployeEnums.Insert);
            prm[1] = new SqlParameter("@Employe_Name",employeModel.Employe_Name);
            prm[2] = new SqlParameter("@Employe_Cnic",employeModel.Employe_Cnic);
            prm[3] = new SqlParameter("@Qualification",employeModel.Qualification);
            prm[4] = new SqlParameter("@Designation", employeModel.Designation);
            prm[5] = new SqlParameter("@Email",employeModel.Email);
            prm[6] = new SqlParameter("@DateofJoining", employeModel.DateofJoining);
            return DataAccessLayer.Setdata(Spname, prm);
        }
    }
}
