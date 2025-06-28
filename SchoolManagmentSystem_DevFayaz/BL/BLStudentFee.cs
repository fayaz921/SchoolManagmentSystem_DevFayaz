using SchoolManagmentSystem_DevFayaz.DL;
using SchoolManagmentSystem_DevFayaz.Enums;
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
    public static class BLStudentFee
    {
        public static void Insert(StudentfeeModel model)
        {
            SqlParameter[] prm = new SqlParameter[7];
            prm[0] = new SqlParameter("@type",StudentFeeEnums.Insert);
            prm[1] = new SqlParameter("@Student_Id", model.Student_Id);
            prm[2] = new SqlParameter("@Class_Id", model.Class_Id);
            prm[3] = new SqlParameter("@Fee_Amount",model.Fee_Amount);
            prm[4] = new SqlParameter("@Fee_PendingAmount",model.Fee_PendingAmount);
            prm[5] = new SqlParameter("@Fee_Submitiondate",model.Fee_Submitiondate);
            prm[6] = new SqlParameter("@Fee_Status",model.Fee_Status);
            DataAccessLayer.Setdata("Sp_Studentfee", prm);
        }

        public static DataTable Select()
        {
            SqlParameter[] prm = new SqlParameter[1];
            prm[0] = new SqlParameter("@type", StudentFeeEnums.Select);
            return DataAccessLayer.GetData("Sp_Studentfee", prm);

        }

        public static DataTable CheckPendingAmount(int std_id, int class_Id)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", 4);
            prm[1] = new SqlParameter("@Student_Id", std_id);
            prm[2] = new SqlParameter("@Class_Id", class_Id);
          return  DataAccessLayer.GetData("Sp_Studentfee", prm);

        }

        public static bool CheckFeeSubmitionDate(DateTime CurrentDate, int std_id)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", 5);
            prm[1] = new SqlParameter("@Fee_Submitiondate", CurrentDate);
            prm[2] = new SqlParameter("@Student_Id", std_id);
            var dt= DataAccessLayer.GetData("Sp_Studentfee", prm);
            if(dt.Rows.Count>0)
            {
                return true;
            }
            return false;


        }

        public static DataTable SelectByClassAndSectionName(string classname, char section)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", 8);
            prm[1] = new SqlParameter("@ClassName", classname);
            prm[2] = new SqlParameter("@Section", section);


            var dt = DataAccessLayer.GetData("Sp_Studentfee", prm);


            if (dt.Rows.Count > 0)
            {
                // Add new column only once
                if (!dt.Columns.Contains("Status"))
                    dt.Columns.Add("Status", typeof(string));

                foreach (DataRow row in dt.Rows)
                {
                    int feeStatus = Convert.ToInt32(row["Fee_Status"]);

                    if (feeStatus == 0)
                        row["Status"] = "Pending";
                    else if (feeStatus == 1)
                        row["Status"] = "Approved";
                    else
                        row["Status"] = "Unknown";
                }
                dt.Columns.Remove("Fee_Status");
            }


            return dt;
        }

        public static void UpdatePendingFee(int PendingAmount , int fee_id)
        {
            SqlParameter[] prm = new SqlParameter[3];
            prm[0] = new SqlParameter("@type", 7);
            prm[1] = new SqlParameter("@Fee_Id", fee_id);
            prm[2] = new SqlParameter("@Fee_PendingAmount", PendingAmount);
            DataAccessLayer.Setdata("Sp_Studentfee", prm);
        }

    }
}
