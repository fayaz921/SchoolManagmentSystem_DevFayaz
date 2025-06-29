using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
using SchoolManagmentSystem_DevFayaz.Enums;
using SchoolManagmentSystem_DevFayaz.MODELS;
using SchoolManagmentSystem_DevFayaz.MODELS.Dashboardmodels;
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
            if (UserCreads.UserRole == Role.Admin)
            {
                Employefrm employefrm = new Employefrm();
                employefrm.Dock = DockStyle.Fill;
                this.Controls.Clear();
                this.Controls.Add(employefrm);
            }
            else
            {
                MessageBox.Show("You are not admin");
            }
        }

        private void EmployeDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {

                if (UserCreads.UserRole == Role.Admin)
                {
                    int EmployeId = Convert.ToInt32(EmployeDataGridview.Rows[e.RowIndex].Cells["Employe_Id"].Value);
                    Employefrm employefrm = new Employefrm(EmployeId);
                    employefrm.Dock = DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(employefrm);
                }
                else
                {
                    MessageBox.Show("You are not admin");
                }

            }

            if (e.ColumnIndex == 1 && e.RowIndex >= 0)
            {
                if (UserCreads.UserRole == Role.Admin)
                {
                    DialogResult result = MessageBox.Show("Are you sure you want to delete this record?",
                                                         "Confirm Deletion", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);

                    if (result == DialogResult.Yes)
                    {
                        int employeid = Convert.ToInt32(EmployeDataGridview.Rows[e.RowIndex].Cells["Employe_Id"].Value);
                        BLEmployes.Delete(employeid);
                        Getdata();
                    }
                }
                else
                {
                    MessageBox.Show("You are not admin");
                }
            }
        }
    }
}
