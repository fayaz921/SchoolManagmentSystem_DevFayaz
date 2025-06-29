using SchoolManagmentSystem_DevFayaz.BL;
using SchoolManagmentSystem_DevFayaz.Custom_Classes;
using System.Windows.Forms;
using SchoolManagmentSystem_DevFayaz.Enums;
using System;
using SchoolManagmentSystem_DevFayaz.MODELS;

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
            var dt = BLTeachers.Select();
            TeacherDataGridview.DataSource = dt;
        }

        private void btnTeacherAdd_Click(object sender, System.EventArgs e)
        {
            if (UserCreads.UserRole == Role.Admin)
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

        private void TeacherDataGridview_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 0 && e.RowIndex >= 0)
            {
                if (UserCreads.UserRole == Role.Admin)
                {
                    int teacherid = Convert.ToInt32(TeacherDataGridview.Rows[e.RowIndex].Cells["Teacher_Id"].Value);
                    Teacherfrm teacherfrm = new Teacherfrm(teacherid);
                    teacherfrm.Dock = DockStyle.Fill;
                    this.Controls.Clear();
                    this.Controls.Add(teacherfrm);
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
                        int TeacherId = Convert.ToInt32(TeacherDataGridview.Rows[e.RowIndex].Cells["Teacher_Id"].Value);
                        BLTeachers.Delete(TeacherId);
                        getData();
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
