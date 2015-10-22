namespace ITAcademy.WinForms
{
    partial class Courses
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.tabCourse = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.CreateBatch = new System.Windows.Forms.GroupBox();
            this.txtDuration = new System.Windows.Forms.TextBox();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtFee = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnableSearch = new System.Windows.Forms.Label();
            this.btnSearchf = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtDurationud = new System.Windows.Forms.TextBox();
            this.txtDescriptionud = new System.Windows.Forms.TextBox();
            this.txtFeeud = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.txtNameud = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox2.SuspendLayout();
            this.tabCourse.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.CreateBatch.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage3.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.tabCourse);
            this.groupBox2.Location = new System.Drawing.Point(12, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(1140, 563);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "groupBox2";
            // 
            // tabCourse
            // 
            this.tabCourse.Controls.Add(this.tabPage1);
            this.tabCourse.Controls.Add(this.tabPage2);
            this.tabCourse.Controls.Add(this.tabPage3);
            this.tabCourse.Location = new System.Drawing.Point(3, 16);
            this.tabCourse.Name = "tabCourse";
            this.tabCourse.SelectedIndex = 0;
            this.tabCourse.Size = new System.Drawing.Size(1110, 527);
            this.tabCourse.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.CreateBatch);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1102, 501);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Create Course";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // CreateBatch
            // 
            this.CreateBatch.Controls.Add(this.txtDuration);
            this.CreateBatch.Controls.Add(this.txtDescription);
            this.CreateBatch.Controls.Add(this.txtFee);
            this.CreateBatch.Controls.Add(this.label4);
            this.CreateBatch.Controls.Add(this.label3);
            this.CreateBatch.Controls.Add(this.label2);
            this.CreateBatch.Controls.Add(this.label1);
            this.CreateBatch.Controls.Add(this.btnCreate);
            this.CreateBatch.Controls.Add(this.txtName);
            this.CreateBatch.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.CreateBatch.Location = new System.Drawing.Point(152, 135);
            this.CreateBatch.Name = "CreateBatch";
            this.CreateBatch.Size = new System.Drawing.Size(823, 261);
            this.CreateBatch.TabIndex = 1;
            this.CreateBatch.TabStop = false;
            this.CreateBatch.Text = "Create Batch";
            // 
            // txtDuration
            // 
            this.txtDuration.Location = new System.Drawing.Point(78, 122);
            this.txtDuration.Name = "txtDuration";
            this.txtDuration.Size = new System.Drawing.Size(249, 20);
            this.txtDuration.TabIndex = 12;
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(523, 62);
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(249, 20);
            this.txtDescription.TabIndex = 11;
            // 
            // txtFee
            // 
            this.txtFee.Location = new System.Drawing.Point(523, 122);
            this.txtFee.Name = "txtFee";
            this.txtFee.Size = new System.Drawing.Size(249, 20);
            this.txtFee.TabIndex = 10;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(520, 40);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 9;
            this.label4.Text = "Description";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(520, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(25, 13);
            this.label3.TabIndex = 8;
            this.label3.Text = "Fee";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(75, 97);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(47, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "Duration";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(75, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(71, 13);
            this.label1.TabIndex = 6;
            this.label1.Text = "Course Name";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(523, 163);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 22);
            this.btnCreate.TabIndex = 5;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(78, 62);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 20);
            this.txtName.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1102, 501);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "View Courses";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvList);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(102, 230);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(898, 268);
            this.groupBox4.TabIndex = 6;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Records";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmTimings,
            this.clmCourseName,
            this.clmUserName});
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvList.Location = new System.Drawing.Point(28, 26);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 50;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Black;
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(864, 229);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnableSearch);
            this.groupBox1.Controls.Add(this.btnSearchf);
            this.groupBox1.Controls.Add(this.cmbSearch);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(102, 93);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 118);
            this.groupBox1.TabIndex = 5;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Course";
            // 
            // lblEnableSearch
            // 
            this.lblEnableSearch.AutoSize = true;
            this.lblEnableSearch.Location = new System.Drawing.Point(329, 16);
            this.lblEnableSearch.Name = "lblEnableSearch";
            this.lblEnableSearch.Size = new System.Drawing.Size(76, 13);
            this.lblEnableSearch.TabIndex = 3;
            this.lblEnableSearch.Text = "enable Search";
            // 
            // btnSearchf
            // 
            this.btnSearchf.Location = new System.Drawing.Point(522, 74);
            this.btnSearchf.Name = "btnSearchf";
            this.btnSearchf.Size = new System.Drawing.Size(82, 23);
            this.btnSearchf.TabIndex = 2;
            this.btnSearchf.Text = "Search";
            this.btnSearchf.UseVisualStyleBackColor = true;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(325, 47);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(279, 21);
            this.cmbSearch.TabIndex = 0;
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.groupBox3);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1102, 501);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update/Delete";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDelete);
            this.groupBox3.Controls.Add(this.txtDurationud);
            this.groupBox3.Controls.Add(this.txtDescriptionud);
            this.groupBox3.Controls.Add(this.txtFeeud);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label6);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.btnUpdate);
            this.groupBox3.Controls.Add(this.txtNameud);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(140, 130);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 251);
            this.groupBox3.TabIndex = 2;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Update/Delete Course";
            // 
            // txtDurationud
            // 
            this.txtDurationud.Location = new System.Drawing.Point(78, 122);
            this.txtDurationud.Name = "txtDurationud";
            this.txtDurationud.Size = new System.Drawing.Size(249, 20);
            this.txtDurationud.TabIndex = 12;
            // 
            // txtDescriptionud
            // 
            this.txtDescriptionud.Location = new System.Drawing.Point(523, 62);
            this.txtDescriptionud.Name = "txtDescriptionud";
            this.txtDescriptionud.Size = new System.Drawing.Size(249, 20);
            this.txtDescriptionud.TabIndex = 11;
            // 
            // txtFeeud
            // 
            this.txtFeeud.Location = new System.Drawing.Point(523, 122);
            this.txtFeeud.Name = "txtFeeud";
            this.txtFeeud.Size = new System.Drawing.Size(249, 20);
            this.txtFeeud.TabIndex = 10;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(520, 40);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(60, 13);
            this.label5.TabIndex = 9;
            this.label5.Text = "Description";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(520, 97);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(25, 13);
            this.label6.TabIndex = 8;
            this.label6.Text = "Fee";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(75, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(47, 13);
            this.label7.TabIndex = 7;
            this.label7.Text = "Duration";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(75, 40);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(71, 13);
            this.label8.TabIndex = 6;
            this.label8.Text = "Course Name";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(523, 163);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 22);
            this.btnUpdate.TabIndex = 5;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // txtNameud
            // 
            this.txtNameud.Location = new System.Drawing.Point(78, 62);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(249, 20);
            this.txtNameud.TabIndex = 0;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(625, 163);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 22);
            this.btnDelete.TabIndex = 13;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            this.clmId.DividerWidth = 2;
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
            this.clmId.Visible = false;
            this.clmId.Width = 150;
            // 
            // clmName
            // 
            this.clmName.DataPropertyName = "Name";
            this.clmName.DividerWidth = 2;
            this.clmName.HeaderText = "Name";
            this.clmName.Name = "clmName";
            this.clmName.Width = 150;
            // 
            // clmTimings
            // 
            this.clmTimings.DataPropertyName = "Duration";
            this.clmTimings.DividerWidth = 2;
            this.clmTimings.HeaderText = "Duration";
            this.clmTimings.Name = "clmTimings";
            this.clmTimings.Width = 150;
            // 
            // clmCourseName
            // 
            this.clmCourseName.DataPropertyName = "Fee";
            this.clmCourseName.DividerWidth = 2;
            this.clmCourseName.HeaderText = "Fee";
            this.clmCourseName.Name = "clmCourseName";
            this.clmCourseName.Width = 150;
            // 
            // clmUserName
            // 
            this.clmUserName.DataPropertyName = "Description";
            this.clmUserName.DividerWidth = 2;
            this.clmUserName.HeaderText = "Description";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.Width = 150;
            // 
            // Courses
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1251, 603);
            this.Controls.Add(this.groupBox2);
            this.Name = "Courses";
            this.Text = "Courses";
            this.Load += new System.EventHandler(this.Courses_Load);
            this.groupBox2.ResumeLayout(false);
            this.tabCourse.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.CreateBatch.ResumeLayout(false);
            this.CreateBatch.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage3.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TabControl tabCourse;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox CreateBatch;
        private System.Windows.Forms.TextBox txtDuration;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtFee;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEnableSearch;
        private System.Windows.Forms.Button btnSearchf;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtDurationud;
        private System.Windows.Forms.TextBox txtDescriptionud;
        private System.Windows.Forms.TextBox txtFeeud;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.TextBox txtNameud;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;


    }
}