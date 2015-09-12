namespace ITAcademy.WinForms
{
    partial class MDIContanier
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chqngePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.lblLogoText = new System.Windows.Forms.Label();
            this.feeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.scheduleTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.updateTestInfoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.cancelTestToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.toolStripMenuItem1,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1370, 24);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(92, 20);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.Click += new System.EventHandler(this.admissionToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(130, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendenceToolStripMenuItem,
            this.attendenceToolStripMenuItem1,
            this.feeInformationToolStripMenuItem});
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(126, 20);
            this.studentToolStripMenuItem.Text = "Student Information";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(177, 22);
            this.attendenceToolStripMenuItem.Text = "Student Records";
            this.attendenceToolStripMenuItem.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem1
            // 
            this.attendenceToolStripMenuItem1.Name = "attendenceToolStripMenuItem1";
            this.attendenceToolStripMenuItem1.Size = new System.Drawing.Size(177, 22);
            this.attendenceToolStripMenuItem1.Text = "Attendence";
            this.attendenceToolStripMenuItem1.Click += new System.EventHandler(this.attendenceToolStripMenuItem1_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feeToolStripMenuItem,
            this.salarToolStripMenuItem});
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(59, 20);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // feeToolStripMenuItem
            // 
            this.feeToolStripMenuItem.Name = "feeToolStripMenuItem";
            this.feeToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.feeToolStripMenuItem.Text = "Fees";
            this.feeToolStripMenuItem.Click += new System.EventHandler(this.feeToolStripMenuItem_Click);
            // 
            // salarToolStripMenuItem
            // 
            this.salarToolStripMenuItem.Name = "salarToolStripMenuItem";
            this.salarToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.salarToolStripMenuItem.Text = "Salary";
            this.salarToolStripMenuItem.Click += new System.EventHandler(this.salarToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chqngePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // chqngePasswordToolStripMenuItem
            // 
            this.chqngePasswordToolStripMenuItem.Name = "chqngePasswordToolStripMenuItem";
            this.chqngePasswordToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.chqngePasswordToolStripMenuItem.Text = "Change Password";
            this.chqngePasswordToolStripMenuItem.Click += new System.EventHandler(this.chqngePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(168, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // lblLogoText
            // 
            this.lblLogoText.AutoSize = true;
            this.lblLogoText.BackColor = System.Drawing.Color.Black;
            this.lblLogoText.Font = new System.Drawing.Font("Lucida Handwriting", 72F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLogoText.ForeColor = System.Drawing.Color.White;
            this.lblLogoText.Location = new System.Drawing.Point(197, 195);
            this.lblLogoText.Name = "lblLogoText";
            this.lblLogoText.Size = new System.Drawing.Size(932, 124);
            this.lblLogoText.TabIndex = 3;
            this.lblLogoText.Text = "The IT Academy";
            this.lblLogoText.Visible = false;
            this.lblLogoText.Click += new System.EventHandler(this.label1_Click);
            // 
            // feeInformationToolStripMenuItem
            // 
            this.feeInformationToolStripMenuItem.Name = "feeInformationToolStripMenuItem";
            this.feeInformationToolStripMenuItem.Size = new System.Drawing.Size(160, 22);
            this.feeInformationToolStripMenuItem.Text = "Fee Information";
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scheduleTestToolStripMenuItem,
            this.updateTestInfoToolStripMenuItem,
            this.cancelTestToolStripMenuItem});
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(96, 20);
            this.toolStripMenuItem1.Text = "Test Scheduler";
            this.toolStripMenuItem1.Click += new System.EventHandler(this.toolStripMenuItem1_Click);
            // 
            // scheduleTestToolStripMenuItem
            // 
            this.scheduleTestToolStripMenuItem.Name = "scheduleTestToolStripMenuItem";
            this.scheduleTestToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.scheduleTestToolStripMenuItem.Text = "Schedule Test";
            // 
            // updateTestInfoToolStripMenuItem
            // 
            this.updateTestInfoToolStripMenuItem.Name = "updateTestInfoToolStripMenuItem";
            this.updateTestInfoToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.updateTestInfoToolStripMenuItem.Text = "Update Test Info";
            // 
            // cancelTestToolStripMenuItem
            // 
            this.cancelTestToolStripMenuItem.Name = "cancelTestToolStripMenuItem";
            this.cancelTestToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.cancelTestToolStripMenuItem.Text = "Cancel Test";
            // 
            // MDIContanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.lblLogoText);
            this.Controls.Add(this.menuStrip1);
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "MDIContanier";
            this.Text = "Professional IT Acedamy";
            this.Load += new System.EventHandler(this.MDIContanier_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem administratorToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem admissionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem searchToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem studentToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem reportsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem feeToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem salarToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem chqngePasswordToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem logOutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem attendenceToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem viewToolStripMenuItem1;
        public System.Windows.Forms.Label lblLogoText;
        private System.Windows.Forms.ToolStripMenuItem feeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem scheduleTestToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem updateTestInfoToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem cancelTestToolStripMenuItem;
    }
}