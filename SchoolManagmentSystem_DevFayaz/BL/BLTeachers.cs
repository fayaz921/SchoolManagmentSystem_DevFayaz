using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.Validations;
using System.Data;
using System.Data.SqlClient;
using System.Reflection;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLTeachers
    {
        private static string Actiontype = "@Actiontype";
        private static string Spname = "Sp_Teachers";

        public static int Insert (TeachersModel model)
        {
            if (!TeacherValidations(model))
            {
                return 0;
            }
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

        public static int Update(TeachersModel model)
        {
            if (!TeacherValidations(model))
            {
                return 0;
            }
            SqlParameter[] prm = new SqlParameter[9];
            prm[0] = new SqlParameter(Actiontype, TeacherEnums.Update);
            prm[1] = new SqlParameter("@Teacher_Id", model.Teacher_Id);
            prm[2] = new SqlParameter("@Teacher_Name", model.Teacher_Name);
            prm[3] = new SqlParameter("@Teacher_Cnic", model.Teacher_Cnic);
            prm[4] = new SqlParameter("@Qualification", model.Qualification);
            prm[5] = new SqlParameter("@Subject", model.Subject);
            prm[6] = new SqlParameter("@Designation", model.Designation);
            prm[7] = new SqlParameter("@Email", model.Email);
            prm[8] = new SqlParameter("@DateofJoining", model.DateofJoining);
            return DataAccessLayer.Setdata(Spname, prm);
        
        }
        public static int Delete(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter(Actiontype,TeacherEnums.Delete);
            prm[1] = new SqlParameter("@Teacher_Id",id);
            return DataAccessLayer.Setdata(Spname,prm);
        }
      

        public static DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter(Actiontype, TeacherEnums.Select);
            return DataAccessLayer.GetData(Spname, prm);
        }

        //Get teacher data for updation from grid view to the teacher form
        public static DataTable GetDataByID(int id)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter(Actiontype, TeacherEnums.GetByID);
            prm[1] = new SqlParameter("@Teacher_Id", id);
            return DataAccessLayer.GetData(Spname, prm);
        }

        //fluent validations 
        public static bool TeacherValidations(TeachersModel model)
        {
            TeachersModelValidations validationRules = new TeachersModelValidations();
            var result = validationRules.Validate(model);
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
