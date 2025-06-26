namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    partial class StudentFeeFrm
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label7 = new System.Windows.Forms.Label();
            this.DDLSection = new Guna.UI2.WinForms.Guna2ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.DLLClasses = new Guna.UI2.WinForms.Guna2ComboBox();
            this.SignUpPanel = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnstudentfee = new Guna.UI2.WinForms.Guna2Button();
            this.txtSearchStdName = new Guna.UI2.WinForms.Guna2TextBox();
            this.FeeDataGridView = new Guna.UI2.WinForms.Guna2DataGridView();
            this.btninsertfee = new System.Windows.Forms.DataGridViewImageColumn();
            this.btnPendingClear = new System.Windows.Forms.DataGridViewImageColumn();
            this.label1 = new System.Windows.Forms.Label();
            this.guna2CustomGradientPanel1 = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SignUpPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.FeeDataGridView)).BeginInit();
            this.guna2CustomGradientPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel5
            // 
            this.panel5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.panel5.Location = new System.Drawing.Point(47, 113);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(275, 10);
            this.panel5.TabIndex = 38;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.panel2.Location = new System.Drawing.Point(370, 113);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(275, 10);
            this.panel2.TabIndex = 37;
            // 
            // label7
            // 
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.SystemColors.Control;
            this.label7.Location = new System.Drawing.Point(54, 33);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(180, 27);
            this.label7.TabIndex = 30;
            this.label7.Text = "Secton Select";
            // 
            // DDLSection
            // 
            this.DDLSection.BackColor = System.Drawing.Color.Transparent;
            this.DDLSection.BorderColor = System.Drawing.Color.Black;
            this.DDLSection.BorderThickness = 2;
            this.DDLSection.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DDLSection.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DDLSection.FillColor = System.Drawing.Color.Black;
            this.DDLSection.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DDLSection.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DDLSection.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DDLSection.ForeColor = System.Drawing.Color.White;
            this.DDLSection.ItemHeight = 30;
            this.DDLSection.Items.AddRange(new object[] {
            "A",
            "B",
            "C"});
            this.DDLSection.Location = new System.Drawing.Point(47, 67);
            this.DDLSection.Name = "DDLSection";
            this.DDLSection.Size = new System.Drawing.Size(275, 36);
            this.DDLSection.TabIndex = 29;
            this.DDLSection.SelectedValueChanged += new System.EventHandler(this.DDLSection_SelectedValueChanged);
            // 
            // label6
            // 
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Gadugi", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.SystemColors.Control;
            this.label6.Location = new System.Drawing.Point(376, 35);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(180, 27);
            this.label6.TabIndex = 28;
            this.label6.Text = "Class Select";
            // 
            // DLLClasses
            // 
            this.DLLClasses.BackColor = System.Drawing.Color.Transparent;
            this.DLLClasses.BorderColor = System.Drawing.Color.Black;
            this.DLLClasses.BorderThickness = 2;
            this.DLLClasses.DrawMode = System.Windows.Forms.DrawMode.OwnerDrawFixed;
            this.DLLClasses.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DLLClasses.Enabled = false;
            this.DLLClasses.FillColor = System.Drawing.Color.Black;
            this.DLLClasses.FocusedColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DLLClasses.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.DLLClasses.Font = new System.Drawing.Font("Segoe UI", 10F);
            this.DLLClasses.ForeColor = System.Drawing.Color.White;
            this.DLLClasses.ItemHeight = 30;
            this.DLLClasses.Items.AddRange(new object[] {
            "5th",
            "6th",
            "7th",
            "8th",
            "9th",
            "10th"});
            this.DLLClasses.Location = new System.Drawing.Point(371, 67);
            this.DLLClasses.Name = "DLLClasses";
            this.DLLClasses.Size = new System.Drawing.Size(275, 36);
            this.DLLClasses.TabIndex = 27;
            this.DLLClasses.SelectedValueChanged += new System.EventHandler(this.DLLClasses_SelectedValueChanged);
            // 
            // SignUpPanel
            // 
            this.SignUpPanel.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.SignUpPanel.BorderThickness = 8;
            this.SignUpPanel.Controls.Add(this.panel1);
            this.SignUpPanel.Controls.Add(this.btnstudentfee);
            this.SignUpPanel.Controls.Add(this.txtSearchStdName);
            this.SignUpPanel.Controls.Add(this.FeeDataGridView);
            this.SignUpPanel.Controls.Add(this.panel5);
            this.SignUpPanel.Controls.Add(this.panel2);
            this.SignUpPanel.Controls.Add(this.label7);
            this.SignUpPanel.Controls.Add(this.DDLSection);
            this.SignUpPanel.Controls.Add(this.label6);
            this.SignUpPanel.Controls.Add(this.DLLClasses);
            this.SignUpPanel.FillColor = System.Drawing.Color.Transparent;
            this.SignUpPanel.FillColor2 = System.Drawing.Color.Transparent;
            this.SignUpPanel.FillColor3 = System.Drawing.Color.Transparent;
            this.SignUpPanel.FillColor4 = System.Drawing.Color.Transparent;
            this.SignUpPanel.Location = new System.Drawing.Point(185, 111);
            this.SignUpPanel.Name = "SignUpPanel";
            this.SignUpPanel.Size = new System.Drawing.Size(1457, 648);
            this.SignUpPanel.TabIndex = 21;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.panel1.Location = new System.Drawing.Point(699, 110);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(275, 10);
            this.panel1.TabIndex = 39;
            // 
            // btnstudentfee
            // 
            this.btnstudentfee.BackColor = System.Drawing.Color.Transparent;
            this.btnstudentfee.BorderThickness = 2;
            this.btnstudentfee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentfee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnstudentfee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnstudentfee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnstudentfee.FillColor = System.Drawing.SystemColors.MenuText;
            this.btnstudentfee.Font = new System.Drawing.Font("Tahoma", 12F, System.Drawing.FontStyle.Bold);
            this.btnstudentfee.ForeColor = System.Drawing.Color.White;
            this.btnstudentfee.Location = new System.Drawing.Point(699, 56);
            this.btnstudentfee.Name = "btnstudentfee";
            this.btnstudentfee.Size = new System.Drawing.Size(275, 49);
            this.btnstudentfee.TabIndex = 41;
            this.btnstudentfee.Text = "Student Fee";
            this.btnstudentfee.UseTransparentBackground = true;
            this.btnstudentfee.Click += new System.EventHandler(this.btnstudentfee_Click);
            // 
            // txtSearchStdName
            // 
            this.txtSearchStdName.BackColor = System.Drawing.Color.Transparent;
            this.txtSearchStdName.BorderColor = System.Drawing.Color.Black;
            this.txtSearchStdName.BorderThickness = 2;
            this.txtSearchStdName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtSearchStdName.DefaultText = "";
            this.txtSearchStdName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtSearchStdName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtSearchStdName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStdName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtSearchStdName.FillColor = System.Drawing.Color.Black;
            this.txtSearchStdName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStdName.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.txtSearchStdName.ForeColor = System.Drawing.Color.White;
            this.txtSearchStdName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtSearchStdName.Location = new System.Drawing.Point(47, 160);
            this.txtSearchStdName.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtSearchStdName.Name = "txtSearchStdName";
            this.txtSearchStdName.PlaceholderForeColor = System.Drawing.Color.LightGray;
            this.txtSearchStdName.PlaceholderText = "Enter Student Name";
            this.txtSearchStdName.SelectedText = "";
            this.txtSearchStdName.Size = new System.Drawing.Size(1374, 41);
            this.txtSearchStdName.TabIndex = 40;
            this.txtSearchStdName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // FeeDataGridView
            // 
            dataGridViewCellStyle7.BackColor = System.Drawing.Color.White;
            this.FeeDataGridView.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle7;
            this.FeeDataGridView.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.FeeDataGridView.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.FeeDataGridView.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.FeeDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.FeeDataGridView.ColumnHeadersHeight = 4;
            this.FeeDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FeeDataGridView.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.btninsertfee,
            this.btnPendingClear});
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle9.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle9.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            dataGridViewCellStyle9.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            dataGridViewCellStyle9.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.FeeDataGridView.DefaultCellStyle = dataGridViewCellStyle9;
            this.FeeDataGridView.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeeDataGridView.Location = new System.Drawing.Point(47, 204);
            this.FeeDataGridView.Name = "FeeDataGridView";
            this.FeeDataGridView.RowHeadersVisible = false;
            this.FeeDataGridView.RowHeadersWidth = 62;
            this.FeeDataGridView.RowTemplate.Height = 28;
            this.FeeDataGridView.Size = new System.Drawing.Size(1374, 421);
            this.FeeDataGridView.TabIndex = 39;
            this.FeeDataGridView.ThemeStyle.AlternatingRowsStyle.BackColor = System.Drawing.Color.White;
            this.FeeDataGridView.ThemeStyle.AlternatingRowsStyle.Font = null;
            this.FeeDataGridView.ThemeStyle.AlternatingRowsStyle.ForeColor = System.Drawing.Color.Empty;
            this.FeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionBackColor = System.Drawing.Color.Empty;
            this.FeeDataGridView.ThemeStyle.AlternatingRowsStyle.SelectionForeColor = System.Drawing.Color.Empty;
            this.FeeDataGridView.ThemeStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.FeeDataGridView.ThemeStyle.GridColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeeDataGridView.ThemeStyle.HeaderStyle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(100)))), ((int)(((byte)(88)))), ((int)(((byte)(255)))));
            this.FeeDataGridView.ThemeStyle.HeaderStyle.BorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.FeeDataGridView.ThemeStyle.HeaderStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeDataGridView.ThemeStyle.HeaderStyle.ForeColor = System.Drawing.Color.White;
            this.FeeDataGridView.ThemeStyle.HeaderStyle.HeaightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.EnableResizing;
            this.FeeDataGridView.ThemeStyle.HeaderStyle.Height = 4;
            this.FeeDataGridView.ThemeStyle.ReadOnly = false;
            this.FeeDataGridView.ThemeStyle.RowsStyle.BackColor = System.Drawing.Color.White;
            this.FeeDataGridView.ThemeStyle.RowsStyle.BorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.SingleHorizontal;
            this.FeeDataGridView.ThemeStyle.RowsStyle.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FeeDataGridView.ThemeStyle.RowsStyle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeeDataGridView.ThemeStyle.RowsStyle.Height = 28;
            this.FeeDataGridView.ThemeStyle.RowsStyle.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(231)))), ((int)(((byte)(229)))), ((int)(((byte)(255)))));
            this.FeeDataGridView.ThemeStyle.RowsStyle.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(71)))), ((int)(((byte)(69)))), ((int)(((byte)(94)))));
            this.FeeDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.FeeDataGridView_CellContentClick);
            // 
            // btninsertfee
            // 
            this.btninsertfee.HeaderText = "FeeClearence";
            this.btninsertfee.MinimumWidth = 8;
            this.btninsertfee.Name = "btninsertfee";
            // 
            // btnPendingClear
            // 
            this.btnPendingClear.HeaderText = "PendingClearence";
            this.btnPendingClear.MinimumWidth = 8;
            this.btnPendingClear.Name = "btnPendingClear";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Stencil", 22F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(546, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(313, 52);
            this.label1.TabIndex = 12;
            this.label1.Text = "Student Fee";
            // 
            // guna2CustomGradientPanel1
            // 
            this.guna2CustomGradientPanel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.guna2CustomGradientPanel1.Controls.Add(this.label1);
            this.guna2CustomGradientPanel1.FillColor = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor2 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor3 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.FillColor4 = System.Drawing.Color.Transparent;
            this.guna2CustomGradientPanel1.Location = new System.Drawing.Point(185, 46);
            this.guna2CustomGradientPanel1.Name = "guna2CustomGradientPanel1";
            this.guna2CustomGradientPanel1.Size = new System.Drawing.Size(1457, 72);
            this.guna2CustomGradientPanel1.TabIndex = 22;
            // 
            // StudentFeeFrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.SignUpPanel);
            this.Controls.Add(this.guna2CustomGradientPanel1);
            this.Name = "StudentFeeFrm";
            this.Size = new System.Drawing.Size(1946, 883);
            this.SignUpPanel.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.FeeDataGridView)).EndInit();
            this.guna2CustomGradientPanel1.ResumeLayout(false);
            this.guna2CustomGradientPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel5;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label label7;
        private Guna.UI2.WinForms.Guna2ComboBox DDLSection;
        private System.Windows.Forms.Label label6;
        private Guna.UI2.WinForms.Guna2ComboBox DLLClasses;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel SignUpPanel;
        private System.Windows.Forms.Label label1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel guna2CustomGradientPanel1;
        private Guna.UI2.WinForms.Guna2DataGridView FeeDataGridView;
        private Guna.UI2.WinForms.Guna2TextBox txtSearchStdName;
        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2Button btnstudentfee;
        private System.Windows.Forms.DataGridViewImageColumn btninsertfee;
        private System.Windows.Forms.DataGridViewImageColumn btnPendingClear;
    }
}
