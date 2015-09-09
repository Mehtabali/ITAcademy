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
            this.menuStripMDI = new System.Windows.Forms.MenuStrip();
            this.administratorToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.admissionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.searchToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.studentToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.attendenceToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.feeInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.testShedulerToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.reportsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.feeToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.salarToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chqngePasswordToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.logOutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStripMDI.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStripMDI
            // 
            this.menuStripMDI.BackColor = System.Drawing.Color.Silver;
            this.menuStripMDI.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.menuStripMDI.Font = new System.Drawing.Font("Segoe UI Symbol", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuStripMDI.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.administratorToolStripMenuItem,
            this.studentToolStripMenuItem,
            this.reportsToolStripMenuItem,
            this.settingsToolStripMenuItem});
            this.menuStripMDI.LayoutStyle = System.Windows.Forms.ToolStripLayoutStyle.Flow;
            this.menuStripMDI.Location = new System.Drawing.Point(0, 0);
            this.menuStripMDI.Name = "menuStripMDI";
            this.menuStripMDI.Padding = new System.Windows.Forms.Padding(11, 6, 4, 6);
            this.menuStripMDI.Size = new System.Drawing.Size(1370, 33);
            this.menuStripMDI.TabIndex = 1;
            this.menuStripMDI.Text = "menuStrip1";
            // 
            // administratorToolStripMenuItem
            // 
            this.administratorToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.admissionToolStripMenuItem,
            this.searchToolStripMenuItem});
            this.administratorToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.administratorToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.administratorToolStripMenuItem.Name = "administratorToolStripMenuItem";
            this.administratorToolStripMenuItem.Size = new System.Drawing.Size(110, 21);
            this.administratorToolStripMenuItem.Text = "Administrator";
            this.administratorToolStripMenuItem.Click += new System.EventHandler(this.administratorToolStripMenuItem_Click);
            // 
            // admissionToolStripMenuItem
            // 
            this.admissionToolStripMenuItem.Name = "admissionToolStripMenuItem";
            this.admissionToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.admissionToolStripMenuItem.Text = "Admission";
            this.admissionToolStripMenuItem.Click += new System.EventHandler(this.admissionToolStripMenuItem_Click);
            // 
            // searchToolStripMenuItem
            // 
            this.searchToolStripMenuItem.Name = "searchToolStripMenuItem";
            this.searchToolStripMenuItem.Size = new System.Drawing.Size(142, 22);
            this.searchToolStripMenuItem.Text = "Search";
            this.searchToolStripMenuItem.Click += new System.EventHandler(this.searchToolStripMenuItem_Click);
            // 
            // studentToolStripMenuItem
            // 
            this.studentToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.attendenceToolStripMenuItem,
            this.attendenceToolStripMenuItem1,
            this.feeInformationToolStripMenuItem,
            this.testShedulerToolStripMenuItem});
            this.studentToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.studentToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.studentToolStripMenuItem.Name = "studentToolStripMenuItem";
            this.studentToolStripMenuItem.Size = new System.Drawing.Size(151, 21);
            this.studentToolStripMenuItem.Text = "Student Information";
            this.studentToolStripMenuItem.Click += new System.EventHandler(this.studentToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem
            // 
            this.attendenceToolStripMenuItem.Name = "attendenceToolStripMenuItem";
            this.attendenceToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.attendenceToolStripMenuItem.Text = "Student Records";
            this.attendenceToolStripMenuItem.Click += new System.EventHandler(this.attendenceToolStripMenuItem_Click);
            // 
            // attendenceToolStripMenuItem1
            // 
            this.attendenceToolStripMenuItem1.Name = "attendenceToolStripMenuItem1";
            this.attendenceToolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.attendenceToolStripMenuItem1.Text = "Attendence";
            this.attendenceToolStripMenuItem1.Click += new System.EventHandler(this.attendenceToolStripMenuItem1_Click);
            // 
            // feeInformationToolStripMenuItem
            // 
            this.feeInformationToolStripMenuItem.Name = "feeInformationToolStripMenuItem";
            this.feeInformationToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.feeInformationToolStripMenuItem.Text = "Fee Information";
            this.feeInformationToolStripMenuItem.Click += new System.EventHandler(this.feeInformationToolStripMenuItem_Click);
            // 
            // testShedulerToolStripMenuItem
            // 
            this.testShedulerToolStripMenuItem.Name = "testShedulerToolStripMenuItem";
            this.testShedulerToolStripMenuItem.Size = new System.Drawing.Size(180, 22);
            this.testShedulerToolStripMenuItem.Text = "Test Sheduler";
            this.testShedulerToolStripMenuItem.Click += new System.EventHandler(this.testShedulerToolStripMenuItem_Click);
            // 
            // reportsToolStripMenuItem
            // 
            this.reportsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.feeToolStripMenuItem,
            this.salarToolStripMenuItem});
            this.reportsToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.reportsToolStripMenuItem.Name = "reportsToolStripMenuItem";
            this.reportsToolStripMenuItem.Size = new System.Drawing.Size(69, 21);
            this.reportsToolStripMenuItem.Text = "Reports";
            // 
            // feeToolStripMenuItem
            // 
            this.feeToolStripMenuItem.Name = "feeToolStripMenuItem";
            this.feeToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.feeToolStripMenuItem.Text = "Fees";
            this.feeToolStripMenuItem.Click += new System.EventHandler(this.feeToolStripMenuItem_Click);
            // 
            // salarToolStripMenuItem
            // 
            this.salarToolStripMenuItem.Name = "salarToolStripMenuItem";
            this.salarToolStripMenuItem.Size = new System.Drawing.Size(113, 22);
            this.salarToolStripMenuItem.Text = "Salary";
            this.salarToolStripMenuItem.Click += new System.EventHandler(this.salarToolStripMenuItem_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.chqngePasswordToolStripMenuItem,
            this.logOutToolStripMenuItem});
            this.settingsToolStripMenuItem.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.settingsToolStripMenuItem.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(70, 21);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // chqngePasswordToolStripMenuItem
            // 
            this.chqngePasswordToolStripMenuItem.Name = "chqngePasswordToolStripMenuItem";
            this.chqngePasswordToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.chqngePasswordToolStripMenuItem.Text = "Change Password";
            this.chqngePasswordToolStripMenuItem.Click += new System.EventHandler(this.chqngePasswordToolStripMenuItem_Click);
            // 
            // logOutToolStripMenuItem
            // 
            this.logOutToolStripMenuItem.Name = "logOutToolStripMenuItem";
            this.logOutToolStripMenuItem.Size = new System.Drawing.Size(184, 22);
            this.logOutToolStripMenuItem.Text = "Log Out";
            this.logOutToolStripMenuItem.Click += new System.EventHandler(this.logOutToolStripMenuItem_Click);
            // 
            // MDIContanier
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 17F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImage = global::ITAcademy.WinForms.Properties.Resources.ItAcademy2;
            this.ClientSize = new System.Drawing.Size(1370, 750);
            this.Controls.Add(this.menuStripMDI);
            this.Font = new System.Drawing.Font("Tempus Sans ITC", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.IsMdiContainer = true;
            this.MainMenuStrip = this.menuStripMDI;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "MDIContanier";
            this.Text = "Professional IT Acedamy";
            this.Load += new System.EventHandler(this.MDIContanier_Load);
            this.menuStripMDI.ResumeLayout(false);
            this.menuStripMDI.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStripMDI;
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
        private System.Windows.Forms.ToolStripMenuItem feeInformationToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem testShedulerToolStripMenuItem;
    }
}