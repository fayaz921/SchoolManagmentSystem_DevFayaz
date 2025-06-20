using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
using System.Windows.Forms;
using SchoolManagmentSystem_DevFayaz.Enums;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class TeacherData : UserControl
    {
        public TeacherData()
        {
            InitializeComponent();
            getData();
        }
        private void getData()
        {
            var dt = BLTeachers.GetData();
            TeacherDataGridview.DataSource = dt;
        }

        private void btnTeacherAdd_Click(object sender, System.EventArgs e)
        {
            if(UserCreads.UserRole == Role.Admin)
            {

            Teacherfrm teacherfrm = new Teacherfrm();
            teacherfrm.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(teacherfrm);
            }
            else
            {
                MessageBox.Show("Only Admin Can Access This Page");
            }
        }
    }
}
