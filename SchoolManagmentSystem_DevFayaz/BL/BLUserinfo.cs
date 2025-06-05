using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.Validations;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BLUserinfo
    {
        private string Sp_Type = "@type";
        private string SP_Name = "Sp_Userinfo";
        public void Insert(UserinfoModel model)
        {
            if (!UserValidation(model))
            {
                return;
            }
            SqlParameter[] sp = new SqlParameter[8];
            sp[0] = new SqlParameter("@type", UserEnums.Insert);
            sp[1] = new SqlParameter("@User_Name", model.User_Name);
            sp[2] = new SqlParameter("@User_Email", model.User_Email);
            sp[3] = new SqlParameter("@User_Role", model.User_Role);
            sp[4] = new SqlParameter("@User_Password", model.User_Password);
            sp[5] = new SqlParameter("@User_Image", model.User_Image);
            sp[6] = new SqlParameter("@User_Status", model.User_Status);
            sp[7] = new SqlParameter("@User_OTP", model.User_OTP);
             DataAccessLayer.Setdata("Sp_Userinfo", sp);
            //return result;
        }
        public int Update(UserinfoModel model)
        {
            SqlParameter[] sp = new SqlParameter[9];
            sp[0] = new SqlParameter("@type", UserEnums.Update);
            sp[1] = new SqlParameter("@User_Id", model.User_Id);
            sp[2] = new SqlParameter("@User_Namw", model.User_Name);
            sp[3] = new SqlParameter("@User_Email", model.User_Email);
            sp[4] = new SqlParameter("@User_Role", model.User_Role);
            sp[5] = new SqlParameter("@User_Password", model.User_Password);
            sp[6] = new SqlParameter("@User_Image", model.User_Image);
            sp[7] = new SqlParameter("@User_Status", model.User_Status);
            sp[8] = new SqlParameter("@User_OTP", model.User_OTP);
            int result = DataAccessLayer.Setdata("Sp_Userinfo", sp);
            return result;
        }
        public int Delete(UserinfoModel model)
        {
            SqlParameter[] sp = new SqlParameter[2];
            sp[0] = new SqlParameter("@type", UserEnums.Delete);
            sp[1] = new SqlParameter("@User_Id", model.User_Id);
            int result = DataAccessLayer.Setdata("Sp_Userinfo", sp);
            return result;

        }
        public DataTable Select()
        {
            SqlParameter[] sp = new SqlParameter[1];
            sp[0] = new SqlParameter("@type", UserEnums.Select);
            DataTable dt = new DataTable();
            dt = DataAccessLayer.GetData("Sp_Userinfo", sp);
            return dt;
        }


        //for signup
        public DataTable CheckIdentity(string userName = null, string email = null)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", UserEnums.CheckIdentity);
            prm[1] = new SqlParameter("@User_Name", userName);
            prm[2] = new SqlParameter("@User_Email", email);
            DataTable dt = new DataTable();
            dt = DataAccessLayer.GetData("Sp_Userinfo", prm);
            return dt;

        }
        public DataTable Admin(UserinfoModel userinfoModel)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@type", UserEnums.Admin);
            prm[1] = new SqlParameter("@User_Name", userinfoModel.User_Name);
            prm[2] = new SqlParameter("@User_Email", userinfoModel.User_Email);
            prm[3] = new SqlParameter("@User_Password", userinfoModel.User_Password);
            prm[4] = new SqlParameter("@User_Role", Role.Admin);

            DataTable dt = new DataTable();
            dt = DataAccessLayer.GetData("Sp_Userinfo", prm);
            return dt;
        }

        //for login
        public DataTable Usercheck(UserinfoModel userinfoModel)
        {
            SqlParameter[] prm = new SqlParameter[4];
            prm[0] = new SqlParameter("@type", UserEnums.Usercheck);
            prm[1] = new SqlParameter("@User_Name", userinfoModel.User_Name);
            prm[2] = new SqlParameter("@User_Email", userinfoModel.User_Email);
            prm[3] = new SqlParameter("@User_Password", userinfoModel.User_Password);
            DataTable dt = new DataTable();
            dt = DataAccessLayer.GetData("Sp_Userinfo", prm);
            return dt;
        }


        public void UpdateOTP(int UserId, int otp)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", UserEnums.UpdateOTP);
            prm[1] = new SqlParameter("@User_Id", UserId);
            prm[2] = new SqlParameter("@User_OTP", otp);
            DataAccessLayer.Setdata("Sp_Userinfo", prm);
        }

        public DataTable OTPVerify(int otp)
        {
            SqlParameter[] prm = new SqlParameter[2];
            prm[0] = new SqlParameter("@type", UserEnums.CheckOTP);
            prm[1] = new SqlParameter("User_OTP", otp);
            return DataAccessLayer.GetData(SP_Name, prm);
        }

        public void UpdatePassword(int otp, string newpassword)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter(Sp_Type, UserEnums.UpdatePassword);
            prm[1] = new SqlParameter("User_OTP", otp);
            prm[2] = new SqlParameter("@User_Password", newpassword);
            DataAccessLayer.Setdata(SP_Name, prm);
        }

        public bool UserValidation(UserinfoModel obj)
        {
            UserInfoValidations validationRules = new UserInfoValidations();
            var result = validationRules.Validate(obj);
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
