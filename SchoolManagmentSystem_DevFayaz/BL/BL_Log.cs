using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System.Data.SqlClient;

namespace SchoolManagmentSystem_DevFayaz.BL
{
    public class BL_Log
    {
        public static void  Insert (LogModel model)
        {
            SqlParameter[] prm = new SqlParameter[5];
            prm[0] = new SqlParameter("@Actiontype", 1);
            prm[1] = new SqlParameter("@UserId", model.UserId);
            prm[2] = new SqlParameter("@Message",model.Message);
            prm[3] = new SqlParameter("@CreateAt", model.CreateAt);
            prm[4] = new SqlParameter("@Std_Id", model.Std_Id);
            DataAccessLayer.GetData("Sp_Log", prm);
            
        }
    }
}
