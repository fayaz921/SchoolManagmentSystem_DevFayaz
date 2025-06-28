using SchoolManagmentSystem_DevFayaz.BL;
using System;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class StudentFeeFrm : UserControl
    {
        public StudentFeeFrm()
        {
            InitializeComponent();
        }
        char section;
        private void DLLClasses_SelectedValueChanged(object sender, EventArgs e)
        {
            section = Convert.ToChar(DDLSection.Text);
            var dt = BLStudentFee.SelectByClassAndSectionName(DLLClasses.Text, section);
            FeeDataGridView.DataSource = dt;
            DLLClasses.Enabled = false;
            btninsertfee.Visible = true;

        }

        private void DDLSection_SelectedValueChanged(object sender, EventArgs e)
        {
            section = Convert.ToChar(DDLSection.Text);
            DLLClasses.Enabled = true;
            btninsertfee.Visible = true;
        }

        public void FeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Managestudetfeefrm managestudetfeefrm = new Managestudetfeefrm();
            if (e.ColumnIndex == 0)
            {

                int studentId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Student_Id"].Value);
                int classId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Class_Id"].Value);
                string classNAme = FeeDataGridView.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
                managestudetfeefrm.ActionType = "Submit";
                managestudetfeefrm.StudentId = studentId;
                managestudetfeefrm.ClassId = classId;
                managestudetfeefrm.AssignCurrentFeeClassNameAccording(classNAme);
                managestudetfeefrm.CheckPendingAmount();
                managestudetfeefrm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(managestudetfeefrm);
            }
            else if (e.ColumnIndex == 1) 
            {
                managestudetfeefrm.ActionType = "Update";
                managestudetfeefrm.StudentId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Student_Id"].Value); ;
                managestudetfeefrm.ClassId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Class_Id"].Value); ;
                managestudetfeefrm.FeeId =Convert.ToInt32( FeeDataGridView.Rows[e.RowIndex].Cells["Fee_Id"].Value.ToString());
                managestudetfeefrm.AssignCurrentFeeClassNameAccording(FeeDataGridView.Rows[e.RowIndex].Cells["ClassName"].Value.ToString());
                managestudetfeefrm.CheckPendingAmount();
                managestudetfeefrm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(managestudetfeefrm);
            }
        }

        private void btnstudentfee_Click(object sender, EventArgs e)
        {
            var dt = BLStudentFee.Select();
            FeeDataGridView.DataSource = dt;
            btninsertfee.Visible = false;
        }

        private void DLLClasses_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DDLSection_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void DLLClasses_SelectedIndexChanged_1(object sender, EventArgs e)
        {

        }
    }
}
