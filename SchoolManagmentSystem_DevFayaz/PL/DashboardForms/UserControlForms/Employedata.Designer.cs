namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    partial class Employedata
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.btnEmployeAdd = new Guna.UI2.WinForms.Guna2Button();
            this.guna2CustomGradientPanel2 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.EmployeDataGridview = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btnUpdate = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnDelete = new System.Windows.Forms.DataGridViewImageColumn();
            this.guna2CustomGradientPanel2.SuspendLayout();
            this.guna2CustomGradientPanel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EmployeDataGridview)).BeginInit();
            this.SuspendLayout();
            // 
            // btnEmployeAdd
            // 
            this.btnEmployeAdd.AutoRoundedCorners = true;
            this.btnEmployeAdd.BackColor = System.Drawing.Color.Transparent;
            this.btnEmployeAdd.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.btnEmployeAdd.BorderThickness = 2;
            this.btnEmployeAdd.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeAdd.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnEmployeAdd.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnEmployeAdd.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnEmployeAdd.FillColor = System.Drawing.Color.Black;
            this.btnEmployeAdd.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnEmployeAdd.ForeColor = System.Drawing.Color.White;
            this.btnEmployeAdd.Location = new System.Drawing.Point(253, 89);
            this.btnEmployeAdd.Name = "btnEmployeAdd";
            this.btnEmployeAdd.Size = new System.Drawing.Size(308, 56);
            this.btnEmployeAdd.TabIndex = 28;
            this.btnEmployeAdd.Text = "Add Employe";
            this.btnEmployeAdd.UseTransparentBackground = true;
            this.btnEmployeAdd.Click += new System.EventHandler(this.btnEmployeAdd_Click);
            // 
            // guna2CustomGradientPanel2
            // 
            this.guna2CustomGradientPanel2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.guna2CustomGradientPanel2.Controls.Add(this.label1);
            this.guna2CustomGradientPanel2.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel2.Location = new System.Drawing.Point(253, 151);
            this.guna2CustomGradientPanel2.Name = "guna2CustomGradientPanel2";
            this.guna2CustomGradientPanel2.Size = new System.Drawing.Size(1329, 53);
            this.guna2CustomGradientPanel2.TabIndex = 27;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(551, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(246, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Employes";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.guna2CustomGradientPanel1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.guna2CustomGradientPanel1.BorderThickness = 8;
            this.guna2CustomGradientPanel1.Controls.Add(this.EmployeDataGridview);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(251, 154);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1331, 616);
            this.guna2CustomGradientPanel1.TabIndex = 26;
            // 
            // EmployeDataGridview
            // 
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.White;
            this.EmployeDataGridview.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            this.EmployeDataGridview.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EmployeDataGridview.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.EmployeDataGridview.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.EmployeDataGridview.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.EmployeDataGridview.ColumnHeadersHeight = 4;
            this.EmployeDataGridview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeDataGridview.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btnUpdate,
            this.btnDelete});
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle3.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle3.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.EmployeDataGridview.DefaultCellStyle = dataGridViewCellStyle3;
            this.EmployeDataGridview.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeDataGridview.Location = new System.Drawing.Point(42, 59);
            this.EmployeDataGridview.Name = "EmployeDataGridview";
            this.EmployeDataGridview.RowHeadersVisible = false;
            this.EmployeDataGridview.RowHeadersWidth = 62;
            this.EmployeDataGridview.RowTemplate.Height = 28;
            this.EmployeDataGridview.Size = new System.Drawing.Size(1261, 522);
            this.EmployeDataGridview.TabIndex = 1;
            this.EmployeDataGridview.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeDataGridview.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.EmployeDataGridview.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.EmployeDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.EmployeDataGridview.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.EmployeDataGridview.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.EmployeDataGridview.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.EmployeDataGridview.ThemeStyle.HeaderStyle.Height = 4;
            this.EmployeDataGridview.ThemeStyle.ReadOnly = false;
            this.EmployeDataGridview.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.EmployeDataGridview.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.EmployeDataGridview.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeDataGridview.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeDataGridview.ThemeStyle.RowsStyle.Height = 28;
            this.EmployeDataGridview.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.EmployeDataGridview.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.EmployeDataGridview.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EmployeDataGridview_CellContentClick);
            // 
            // btnUpdate
            // 
            this.btnUpdate.HeaderText = "Update";
            this.btnUpdate.MinimumWidth = 8;
            this.btnUpdate.Name = "btnUpdate";
            // 
            // btnDelete
            // 
            this.btnDelete.HeaderText = "Delete";
            this.btnDelete.MinimumWidth = 8;
            this.btnDelete.Name = "btnDelete";
            // 
            // Employedata
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.btnEmployeAdd);
            this.Controls.Add(this.guna2CustomGradientPanel2);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "Employedata";
            this.Size = new System.Drawing.Size(1946, 883);
            this.guna2CustomGradientPanel2.ResumeLayout(false);
            this.guna2CustomGradientPanel2.PerformLayout();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EmployeDataGridview)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Button btnEmployeAdd;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel2;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView EmployeDataGridview;
        private System.Windows.Forms.DataGridViewImageColumn btnUpdate;
        private System.Windows.Forms.DataGridViewImageColumn btnDelete;
    }
}
