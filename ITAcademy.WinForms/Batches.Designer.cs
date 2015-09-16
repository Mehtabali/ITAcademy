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
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbUsersTypesId = new System.Windows.Forms.ComboBox();
            this.cmbCourseId = new System.Windows.Forms.ComboBox();
            this.cmbTimings = new System.Windows.Forms.ComboBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnCreate);
            this.groupBox1.Controls.Add(this.cmbTimings);
            this.groupBox1.Controls.Add(this.cmbCourseId);
            this.groupBox1.Controls.Add(this.cmbUsersTypesId);
            this.groupBox1.Controls.Add(this.txtName);
            this.groupBox1.Location = new System.Drawing.Point(21, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(587, 386);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(41, 39);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(160, 20);
            this.txtName.TabIndex = 0;
            // 
            // cmbUsersTypesId
            // 
            this.cmbUsersTypesId.FormattingEnabled = true;
            this.cmbUsersTypesId.Location = new System.Drawing.Point(342, 110);
            this.cmbUsersTypesId.Name = "cmbUsersTypesId";
            this.cmbUsersTypesId.Size = new System.Drawing.Size(184, 21);
            this.cmbUsersTypesId.TabIndex = 2;
            // 
            // cmbCourseId
            // 
            this.cmbCourseId.FormattingEnabled = true;
            this.cmbCourseId.Location = new System.Drawing.Point(41, 110);
            this.cmbCourseId.Name = "cmbCourseId";
            this.cmbCourseId.Size = new System.Drawing.Size(160, 21);
            this.cmbCourseId.TabIndex = 3;
            // 
            // cmbTimings
            // 
            this.cmbTimings.FormattingEnabled = true;
            this.cmbTimings.Location = new System.Drawing.Point(342, 38);
            this.cmbTimings.Name = "cmbTimings";
            this.cmbTimings.Size = new System.Drawing.Size(184, 21);
            this.cmbTimings.TabIndex = 4;
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(451, 157);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 23);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(631, 421);
            this.Controls.Add(this.groupBox1);
            this.Name = "Batches";
            this.Text = "Batches";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbTimings;
        private System.Windows.Forms.ComboBox cmbCourseId;
        private System.Windows.Forms.ComboBox cmbUsersTypesId;
        private System.Windows.Forms.TextBox txtName;
    }
}