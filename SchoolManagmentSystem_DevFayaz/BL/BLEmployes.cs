using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.Validations;
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
            if (!EmployeValidations(employeModel))
            {
                return 0;
            }
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

        public static bool EmployeValidations(EmployeModel employeModel)
        {
            EmployeModelValidations validationRules = new EmployeModelValidations();
            var result = validationRules.Validate(employeModel);
            if (result.IsValid)
            {
                return true;
            }
            else
            {
                MessageBox.Show(result.Errors[0].ErrorMessage);
                return false;
            }
        }
    }
}
