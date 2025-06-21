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
            var dt = BLClass.SelectByClassAndSectionName(DLLClasses.Text, section);
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
            if (e.ColumnIndex == 0)
            {
                int studentId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Student_Id"].Value);
                int classId = Convert.ToInt32(FeeDataGridView.Rows[e.RowIndex].Cells["Class_Id"].Value);

                Managestudetfeefrm managestudetfeefrm = new Managestudetfeefrm();
                managestudetfeefrm.StudentId = studentId;
                managestudetfeefrm.ClassId = classId;

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
    }
}
