using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
using SchoolManagmentSystem_DevFayaz.Enums;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    public partial class Employedata : UserControl
    {
        public Employedata()
        {
            InitializeComponent();
            Getdata();
        }

        public void Getdata()
        {
            var dt = BLEmployes.Select();
            EmployeDataGridview.DataSource = dt;
        }

        private void btnEmployeAdd_Click(object sender, EventArgs e)
        {
            if (UserCreads.UserRole==Role.Admin)
            {
                Teacherfrm teacherfrm = new Teacherfrm();
                teacherfrm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(teacherfrm);
            }
            else
            {
                MessageBox.Show("You are not admin");
            }
        }

        private void EmployeDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0)
            {
                
            }
        }
    }
}
