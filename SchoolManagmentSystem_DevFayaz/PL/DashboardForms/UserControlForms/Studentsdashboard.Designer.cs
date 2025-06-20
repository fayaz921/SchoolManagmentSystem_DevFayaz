namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.UserControlForms
{
    partial class Studentsdashboard
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
            this.flowLayoutPaneldashboard = new System.Windows.Forms.FlowLayoutPanel();
            this.guna2Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.btnStudentFee = new Guna.UI2.WinForms.Guna2Button();
            this.btnloginfrm = new Guna.UI2.WinForms.Guna2Button();
            this.button1 = new System.Windows.Forms.Button();
            this.guna2Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // flowLayoutPaneldashboard
            // 
            this.flowLayoutPaneldashboard.Location = new System.Drawing.Point(0, 100);
            this.flowLayoutPaneldashboard.Name = "flowLayoutPaneldashboard";
            this.flowLayoutPaneldashboard.Size = new System.Drawing.Size(1928, 844);
            this.flowLayoutPaneldashboard.TabIndex = 19;
            // 
            // guna2Panel1
            // 
            this.guna2Panel1.Controls.Add(this.btnStudentFee);
            this.guna2Panel1.Controls.Add(this.btnloginfrm);
            this.guna2Panel1.Controls.Add(this.button1);
            this.guna2Panel1.Location = new System.Drawing.Point(3, 4);
            this.guna2Panel1.Name = "guna2Panel1";
            this.guna2Panel1.Size = new System.Drawing.Size(1922, 90);
            this.guna2Panel1.TabIndex = 18;
            // 
            // btnStudentFee
            // 
            this.btnStudentFee.BackColor = System.Drawing.Color.Transparent;
            this.btnStudentFee.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.btnStudentFee.BorderRadius = 15;
            this.btnStudentFee.BorderThickness = 3;
            this.btnStudentFee.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnStudentFee.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnStudentFee.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnStudentFee.FillColor = System.Drawing.SystemColors.MenuText;
            this.btnStudentFee.Font = new System.Drawing.Font("Tahoma", 10F, System.Drawing.FontStyle.Bold);
            this.btnStudentFee.ForeColor = System.Drawing.Color.White;
            this.btnStudentFee.Location = new System.Drawing.Point(608, 16);
            this.btnStudentFee.Name = "btnStudentFee";
            this.btnStudentFee.Size = new System.Drawing.Size(211, 55);
            this.btnStudentFee.TabIndex = 27;
            this.btnStudentFee.Text = "Fees";
            this.btnStudentFee.UseTransparentBackground = true;
            // 
            // btnloginfrm
            // 
            this.btnloginfrm.BackColor = System.Drawing.Color.Transparent;
            this.btnloginfrm.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(170)))), ((int)(((byte)(69)))));
            this.btnloginfrm.BorderRadius = 15;
            this.btnloginfrm.BorderThickness = 1;
            this.btnloginfrm.DisabledState.BorderColor = System.Drawing.Color.DarkGray;
            this.btnloginfrm.DisabledState.CustomBorderColor = System.Drawing.Color.DarkGray;
            this.btnloginfrm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(169)))), ((int)(((byte)(169)))), ((int)(((byte)(169)))));
            this.btnloginfrm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(141)))), ((int)(((byte)(141)))), ((int)(((byte)(141)))));
            this.btnloginfrm.FillColor = System.Drawing.Color.Black;
            this.btnloginfrm.Font = new System.Drawing.Font("Segoe UI Semibold", 16F, System.Drawing.FontStyle.Bold);
            this.btnloginfrm.ForeColor = System.Drawing.Color.Red;
            this.btnloginfrm.Location = new System.Drawing.Point(31, 16);
            this.btnloginfrm.Name = "btnloginfrm";
            this.btnloginfrm.Size = new System.Drawing.Size(82, 56);
            this.btnloginfrm.TabIndex = 25;
            this.btnloginfrm.Text = "🔙";
            this.btnloginfrm.UseTransparentBackground = true;
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1820, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 66);
            this.button1.TabIndex = 12;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // Studentsdashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.Controls.Add(this.flowLayoutPaneldashboard);
            this.Controls.Add(this.guna2Panel1);
            this.Name = "Studentsdashboard";
            this.Size = new System.Drawing.Size(1946, 883);
            this.guna2Panel1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel flowLayoutPaneldashboard;
        private Guna.UI2.WinForms.Guna2Panel guna2Panel1;
        private Guna.UI2.WinForms.Guna2Button btnStudentFee;
        private Guna.UI2.WinForms.Guna2Button btnloginfrm;
        private System.Windows.Forms.Button button1;
    }
}
