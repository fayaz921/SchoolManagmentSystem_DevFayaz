using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.MODELS;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class Managestudetfeefrm : UserControl
    {
        public Managestudetfeefrm()
        {
            InitializeComponent();

        }
        public int StudentId { get; set; }
        public int ClassId { get; set; }
        public DateTime FeeDate { get; set; }
        private int CurrentFee { get; set; }
        private int ActualFeeAmount { get; set; }

        public void AssignCurrentFeeClassNameAccording(string ClassName)
        {
            if (ClassName == "5th")
            {
                CurrentFee = 500;
            }
            else if (ClassName == "6th")
            {
                CurrentFee = 700;
            }
            else if (ClassName == "7th")
            {
                CurrentFee = 1000;
            }
            else if (ClassName == "8th")
            {
                CurrentFee = 1400;
            }
            else if (ClassName == "9th")
            {
                CurrentFee = 2000;
            }
            else if (ClassName == "10th")
            {
                CurrentFee = 3000;
            }



        }
        public void CheckPendingAmount()
        {
            var dt = BLStudentFee.CheckPendingAmount(StudentId, ClassId);
            if (dt.Rows.Count > 0)
            {
                string PendingAmount = dt.Rows[0]["Fee_PendingAmount"].ToString();
                txtfeependingamount.Text = PendingAmount;
                lblDateShow.Text = DateTime.Now.ToString();
                int pending = Convert.ToInt32(PendingAmount);
                int Subtotal = CurrentFee + pending;
                txtSubtotal.Text = Subtotal.ToString();
            }
            else
            {
                
                lblDateShow.Text = DateTime.Now.ToString();
                txtSubtotal.Text = CurrentFee.ToString();
                txtfeependingamount.Text = "0";
            }
        }



        private bool CheckFeeSubmit()
        {
            return BLStudentFee.CheckFeeSubmitionDate(DateTime.Now, StudentId);

        }
        private bool CheckAmountExceed()
        {
            int FeePay = Convert.ToInt32(txtfeeamount.Text);
            int Subtotal = Convert.ToInt32(txtSubtotal.Text);

            if (FeePay > Subtotal)
            {
                return false;
            }

            ActualFeeAmount = Subtotal - FeePay;
            return true;
        }
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                if (CheckFeeSubmit())
                {
                    MessageBox.Show("Fee ALready Submited");
                    return;

                }
                if (CheckAmountExceed())
                {

                    StudentfeeModel studentfeemodel = new StudentfeeModel();
                    studentfeemodel.Student_Id = StudentId;
                    studentfeemodel.Class_Id = ClassId;
                    studentfeemodel.Fee_Amount = Convert.ToInt32(txtfeeamount.Text);
                    studentfeemodel.Fee_PendingAmount = ActualFeeAmount;
                    studentfeemodel.Fee_Submitiondate = DateTime.Now;
                    studentfeemodel.Fee_Status = 1;
                    BLStudentFee.Insert(studentfeemodel);
                    MessageBox.Show("Student Fee submitted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else
                {

                    MessageBox.Show("Pay Amount Greater Than Subtotal");
                }
                return;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error" + ex.Message);
                return;
            }
        }
    }
}
