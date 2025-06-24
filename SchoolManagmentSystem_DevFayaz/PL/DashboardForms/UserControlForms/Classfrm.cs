using SchoolManagmentSystem_DevFayaz.BL;
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
    public partial class Classfrm : UserControl
    {
        private string Classname { get; set; }
        public Classfrm(string classname)
        {
            InitializeComponent();
            Classname = classname;
            HandleClassRecord(classname);
        }

        public void HandleClassRecord(string classname)
        {
            BLClass bLClass = new BLClass();
            var dt = bLClass.GetClassRecord(classname);
            if (dt.Rows.Count > 0)
            {
                ClassDataGridView.DataSource = dt;
            }
            else
            {
                lblStudentRecordMsg.Visible = true;
            }
        }

        private void ClassDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {

                Managestudetfeefrm managestudetfeefrm = new Managestudetfeefrm();
                managestudetfeefrm.StudentId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["Student_Id"].Value);
                managestudetfeefrm.ClassId = Convert.ToInt32(ClassDataGridView.Rows[e.RowIndex].Cells["Class_Id"].Value);
                string ClassName = ClassDataGridView.Rows[e.RowIndex].Cells["ClassName"].Value.ToString();
                managestudetfeefrm.AssignCurrentFeeClassNameAccording(ClassName);
                managestudetfeefrm.CheckPendingAmount();

                managestudetfeefrm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(managestudetfeefrm);
            }
        }
    }
}
