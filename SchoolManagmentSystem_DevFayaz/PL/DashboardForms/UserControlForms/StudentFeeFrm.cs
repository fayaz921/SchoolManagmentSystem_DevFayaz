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

        private void FeeDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }



        public void GetStudentRecordByClassAndSectionName()
        {
         
        }
        char section;
        private void DLLClasses_SelectedValueChanged(object sender, EventArgs e)
        {
             section = Convert.ToChar(DDLSection.Text);
            var dt = BLClass.SelectByClassAndSectionName(DLLClasses.Text, section);
            FeeDataGridView.DataSource = dt;
            DLLClasses.Enabled = false;


        }

        private void DDLSection_SelectedValueChanged(object sender, EventArgs e)
        {
            section = Convert.ToChar(DDLSection.Text);
            DLLClasses.Enabled = true;

        }
    }
}
