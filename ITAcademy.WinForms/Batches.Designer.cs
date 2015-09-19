namespace ITAcademy.WinForms
{
    partial class Batches
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.cmbCourseId = new System.Windows.Forms.ComboBox();
            this.cmbTimings = new System.Windows.Forms.ComboBox();
            this.cmbUsersId = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.cmbCourseId);
            this.groupBox1.Controls.Add(this.cmbTimings);
            this.groupBox1.Controls.Add(this.cmbUsersId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(276, 43);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(52, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Id";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(276, 157);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Users Id";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 157);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Timings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(6, 47);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Batch Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(451, 298);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // cmbCourseId
            // 
            this.cmbCourseId.FormattingEnabled = true;
            this.cmbCourseId.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.cmbCourseId.Location = new System.Drawing.Point(357, 40);
            this.cmbCourseId.Name = "cmbCourseId";
            this.cmbCourseId.Size = new System.Drawing.Size(184, 21);
            this.cmbCourseId.TabIndex = 4;
            // 
            // cmbTimings
            // 
            this.cmbTimings.FormattingEnabled = true;
            this.cmbTimings.Items.AddRange(new object[] {
            "kioo",
            "kkioo",
            "kkii"});
            this.cmbTimings.Location = new System.Drawing.Point(62, 154);
            this.cmbTimings.Name = "cmbTimings";
            this.cmbTimings.Size = new System.Drawing.Size(173, 21);
            this.cmbTimings.TabIndex = 3;
            // 
            // cmbUsersId
            // 
            this.cmbUsersId.FormattingEnabled = true;
            this.cmbUsersId.Items.AddRange(new object[] {
            "1",
            "2"});
            this.cmbUsersId.Location = new System.Drawing.Point(342, 149);
            this.cmbUsersId.Name = "cmbUsersId";
            this.cmbUsersId.Size = new System.Drawing.Size(184, 21);
            this.cmbUsersId.TabIndex = 2;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 40);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(173, 20);
            this.txtName.TabIndex = 0;
            // 
            // Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "Batches";
            this.Text = "Batches";
            this.Load += new System.EventHandler(this.Batches_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCourseId;
        private System.Windows.Forms.ComboBox cmbTimings;
        private System.Windows.Forms.ComboBox cmbUsersId;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}