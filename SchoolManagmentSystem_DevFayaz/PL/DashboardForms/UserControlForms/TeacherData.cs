using SchoolManagmentSystem_DevFayaz.BL;
using System.Windows.Forms;

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
            Teacherfrm teacherfrm = new Teacherfrm();
            teacherfrm.Dock = DockStyle.Fill;
            this.Controls.Clear();
            this.Controls.Add(teacherfrm);
        }
    }
}
