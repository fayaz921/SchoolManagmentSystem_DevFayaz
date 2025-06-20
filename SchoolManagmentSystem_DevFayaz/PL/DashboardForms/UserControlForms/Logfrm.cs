using SchoolManagmentSystem_DevFayaz.BL;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class Logfrm : UserControl
    {
        public Logfrm()
        {
            InitializeComponent();
            LogDataGridView.DataSource = BL_Log.Select();
        }

        private void Logfrm_Load(object sender, System.EventArgs e)
        {

        }
    }
}
