namespace SchoolManagmentSystem_DevFayaz.PL.DashboardForms.SimpleForm
{
    partial class Dashboardfrm
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.button1 = new System.Windows.Forms.Button();
            this.Paneldashboard = new Guna.UI2.WinForms.Guna2CustomGradientPanel();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.Red;
            this.button1.Location = new System.Drawing.Point(1851, -1);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(83, 63);
            this.button1.TabIndex = 12;
            this.button1.Text = "❌";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Paneldashboard
            // 
            this.Paneldashboard.FillColor = System.Drawing.Color.Transparent;
            this.Paneldashboard.FillColor2 = System.Drawing.Color.Transparent;
            this.Paneldashboard.FillColor3 = System.Drawing.Color.Transparent;
            this.Paneldashboard.FillColor4 = System.Drawing.Color.Transparent;
            this.Paneldashboard.Location = new System.Drawing.Point(12, 68);
            this.Paneldashboard.Name = "Paneldashboard";
            this.Paneldashboard.Size = new System.Drawing.Size(1946, 910);
            this.Paneldashboard.TabIndex = 16;
            // 
            // Dashboardfrm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(57)))), ((int)(((byte)(0)))), ((int)(((byte)(20)))));
            this.ClientSize = new System.Drawing.Size(1946, 883);
            this.Controls.Add(this.Paneldashboard);
            this.Controls.Add(this.button1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Dashboardfrm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboardfrm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Dashboardfrm_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button button1;
        private Guna.UI2.WinForms.Guna2CustomGradientPanel Paneldashboard;
    }
}