using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SchoolManagmentSystem_DevFayaz.DL
{
    public static class DataAccessLayer
    {
        static SqlConnection con = new SqlConnection("data source = M-FAYAZ ; initial catalog = DBSMSProject ; integrated security = true");

        public static int Setdata(String sp_Name, SqlParameter[] prm)
        {
            int result = 0;
            SqlCommand cmd = new SqlCommand(sp_Name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            con.Open();
            result = cmd.ExecuteNonQuery();
            con.Close();
            return result;
        }
        public static DataTable GetData(String sp_Name, SqlParameter[] prm)
        {
            SqlCommand cmd = new SqlCommand(sp_Name, con);
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.Parameters.AddRange(prm);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataTable dt = new DataTable();
            da.Fill(dt);
            return dt;
        }
    }
}
