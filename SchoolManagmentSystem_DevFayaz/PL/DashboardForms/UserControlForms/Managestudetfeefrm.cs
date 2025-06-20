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
        private void btnsubmit_Click(object sender, EventArgs e)
        {
            try
            {

                StudentfeeModel studentfeemodel = new StudentfeeModel();
                studentfeemodel.Student_Id = StudentId;
                studentfeemodel.Class_Id = ClassId;
                studentfeemodel.Fee_Amount = Convert.ToInt32(txtfeeamount.Text);
                studentfeemodel.Fee_PendingAmount = Convert.ToInt32(txtfeependingamount.Text);
                studentfeemodel.Fee_Submitiondate = DateTime.Now;
                studentfeemodel.Fee_Status = 1;
                BLStudentFee bLStudentFee = new BLStudentFee();
                bLStudentFee.Insert(studentfeemodel);
                MessageBox.Show("Student Fee submitted successfully", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error"+ex.Message);
                return;
            }
        }
    }
}
