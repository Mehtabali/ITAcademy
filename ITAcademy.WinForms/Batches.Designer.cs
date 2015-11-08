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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cmbTime = new System.Windows.Forms.ComboBox();
            this.cmbTeacher = new System.Windows.Forms.ComboBox();
            this.cmbCourse = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txtNameud = new System.Windows.Forms.TextBox();
            this.tabPage5 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.clmId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmTimings = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourseName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmUserName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.lblEnableSearch = new System.Windows.Forms.Label();
            this.btnSearchf = new System.Windows.Forms.Button();
            this.cmbSearch = new System.Windows.Forms.ComboBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.CreateBatch = new System.Windows.Forms.GroupBox();
            this.lblDesignation = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.cmbCourseName = new System.Windows.Forms.ComboBox();
            this.cmbTimings = new System.Windows.Forms.ComboBox();
            this.cmbUsersName = new System.Windows.Forms.ComboBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.tabBatches = new System.Windows.Forms.TabControl();
            this.tabPage3.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.tabPage5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.CreateBatch.SuspendLayout();
            this.tabBatches.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabPage3
            // 
            this.tabPage3.BackColor = System.Drawing.Color.DimGray;
            this.tabPage3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage3.Controls.Add(this.groupBox5);
            this.tabPage3.Controls.Add(this.groupBox2);
            this.tabPage3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Size = new System.Drawing.Size(1348, 665);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "Update/Delete";
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnUpdate);
            this.groupBox5.Controls.Add(this.btnDelete);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.ForeColor = System.Drawing.Color.Black;
            this.groupBox5.Location = new System.Drawing.Point(319, 359);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(823, 69);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Actions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(496, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 36);
            this.btnUpdate.TabIndex = 4;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(584, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 36);
            this.btnDelete.TabIndex = 5;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.DimGray;
            this.groupBox2.Controls.Add(this.cmbTime);
            this.groupBox2.Controls.Add(this.cmbTeacher);
            this.groupBox2.Controls.Add(this.cmbCourse);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txtNameud);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(319, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(823, 238);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Update/Delete Record";
            // 
            // cmbTime
            // 
            this.cmbTime.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTime.ForeColor = System.Drawing.Color.Black;
            this.cmbTime.FormattingEnabled = true;
            this.cmbTime.Items.AddRange(new object[] {
            "11:00 to 1:00",
            "2:00 to 4:00",
            "9:00 to 11:00"});
            this.cmbTime.Location = new System.Drawing.Point(78, 113);
            this.cmbTime.Name = "cmbTime";
            this.cmbTime.Size = new System.Drawing.Size(260, 28);
            this.cmbTime.TabIndex = 1;
            // 
            // cmbTeacher
            // 
            this.cmbTeacher.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTeacher.ForeColor = System.Drawing.Color.Black;
            this.cmbTeacher.FormattingEnabled = true;
            this.cmbTeacher.Items.AddRange(new object[] {
            "Select Course"});
            this.cmbTeacher.Location = new System.Drawing.Point(399, 118);
            this.cmbTeacher.Name = "cmbTeacher";
            this.cmbTeacher.Size = new System.Drawing.Size(260, 28);
            this.cmbTeacher.TabIndex = 3;
            this.cmbTeacher.SelectedIndexChanged += new System.EventHandler(this.cmbTeacher_SelectedIndexChanged);
            // 
            // cmbCourse
            // 
            this.cmbCourse.BackColor = System.Drawing.Color.Black;
            this.cmbCourse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourse.ForeColor = System.Drawing.Color.Black;
            this.cmbCourse.FormattingEnabled = true;
            this.cmbCourse.Items.AddRange(new object[] {
            "Select Course"});
            this.cmbCourse.Location = new System.Drawing.Point(399, 62);
            this.cmbCourse.Name = "cmbCourse";
            this.cmbCourse.Size = new System.Drawing.Size(260, 28);
            this.cmbCourse.TabIndex = 2;
            this.cmbCourse.SelectedIndexChanged += new System.EventHandler(this.cmbCourse_SelectedIndexChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(680, 125);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(115, 20);
            this.label5.TabIndex = 10;
            this.label5.Text = "Designation";
            this.label5.Visible = false;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(396, 40);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(119, 20);
            this.label6.TabIndex = 9;
            this.label6.Text = "Course Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(396, 97);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(131, 20);
            this.label7.TabIndex = 8;
            this.label7.Text = "Teacher Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(75, 97);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(78, 20);
            this.label8.TabIndex = 7;
            this.label8.Text = "Timings";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(75, 40);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(113, 20);
            this.label9.TabIndex = 6;
            this.label9.Text = "Batch Name";
            // 
            // txtNameud
            // 
            this.txtNameud.ForeColor = System.Drawing.Color.Black;
            this.txtNameud.Location = new System.Drawing.Point(78, 62);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(260, 28);
            this.txtNameud.TabIndex = 0;
            // 
            // tabPage5
            // 
            this.tabPage5.BackColor = System.Drawing.Color.DimGray;
            this.tabPage5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage5.Controls.Add(this.groupBox4);
            this.tabPage5.Controls.Add(this.groupBox1);
            this.tabPage5.ForeColor = System.Drawing.Color.Black;
            this.tabPage5.Location = new System.Drawing.Point(4, 22);
            this.tabPage5.Name = "tabPage5";
            this.tabPage5.Size = new System.Drawing.Size(1348, 665);
            this.tabPage5.TabIndex = 4;
            this.tabPage5.Text = "View Records";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dgvList);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(319, 251);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(898, 268);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Records";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.Color.DimGray;
            this.dgvList.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvList.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.dgvList.ColumnHeadersHeight = 25;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmId,
            this.clmName,
            this.clmTimings,
            this.clmCourseName,
            this.clmUserName});
            this.dgvList.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvList.GridColor = System.Drawing.SystemColors.ControlText;
            this.dgvList.Location = new System.Drawing.Point(34, 27);
            this.dgvList.Name = "dgvList";
            this.dgvList.RowHeadersWidth = 50;
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.Blue;
            dataGridViewCellStyle1.Padding = new System.Windows.Forms.Padding(5);
            this.dgvList.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvList.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvList.Size = new System.Drawing.Size(826, 229);
            this.dgvList.TabIndex = 1;
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // clmId
            // 
            this.clmId.DataPropertyName = "Id";
            this.clmId.DividerWidth = 2;
            this.clmId.HeaderText = "Id";
            this.clmId.Name = "clmId";
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
            this.clmTimings.DataPropertyName = "Timings";
            this.clmTimings.DividerWidth = 2;
            this.clmTimings.HeaderText = "Timings";
            this.clmTimings.Name = "clmTimings";
            this.clmTimings.Width = 150;
            // 
            // clmCourseName
            // 
            this.clmCourseName.DataPropertyName = "CourseName";
            this.clmCourseName.DividerWidth = 2;
            this.clmCourseName.HeaderText = "Course";
            this.clmCourseName.Name = "clmCourseName";
            this.clmCourseName.Width = 150;
            // 
            // clmUserName
            // 
            this.clmUserName.DataPropertyName = "UserName";
            this.clmUserName.DividerWidth = 2;
            this.clmUserName.HeaderText = "User Name";
            this.clmUserName.Name = "clmUserName";
            this.clmUserName.Width = 150;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.lblEnableSearch);
            this.groupBox1.Controls.Add(this.btnSearchf);
            this.groupBox1.Controls.Add(this.cmbSearch);
            this.groupBox1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.ForeColor = System.Drawing.Color.Black;
            this.groupBox1.Location = new System.Drawing.Point(319, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(898, 118);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Search Batch";
            // 
            // lblEnableSearch
            // 
            this.lblEnableSearch.AutoSize = true;
            this.lblEnableSearch.Location = new System.Drawing.Point(262, 24);
            this.lblEnableSearch.Name = "lblEnableSearch";
            this.lblEnableSearch.Size = new System.Drawing.Size(129, 20);
            this.lblEnableSearch.TabIndex = 3;
            this.lblEnableSearch.Text = "enable Search";
            this.lblEnableSearch.Click += new System.EventHandler(this.lblEnableSearch_Click);
            // 
            // btnSearchf
            // 
            this.btnSearchf.Location = new System.Drawing.Point(578, 48);
            this.btnSearchf.Name = "btnSearchf";
            this.btnSearchf.Size = new System.Drawing.Size(82, 28);
            this.btnSearchf.TabIndex = 2;
            this.btnSearchf.Text = "Search";
            this.btnSearchf.UseVisualStyleBackColor = true;
            // 
            // cmbSearch
            // 
            this.cmbSearch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbSearch.FormattingEnabled = true;
            this.cmbSearch.Location = new System.Drawing.Point(266, 48);
            this.cmbSearch.Name = "cmbSearch";
            this.cmbSearch.Size = new System.Drawing.Size(279, 28);
            this.cmbSearch.TabIndex = 0;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Controls.Add(this.CreateBatch);
            this.tabPage2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1348, 665);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Create New";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnCreate);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.ForeColor = System.Drawing.Color.Black;
            this.groupBox3.Location = new System.Drawing.Point(319, 364);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(823, 59);
            this.groupBox3.TabIndex = 11;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Actions";
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(584, 19);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(75, 32);
            this.btnCreate.TabIndex = 4;
            this.btnCreate.Text = "Create";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // CreateBatch
            // 
            this.CreateBatch.Controls.Add(this.lblDesignation);
            this.CreateBatch.Controls.Add(this.label4);
            this.CreateBatch.Controls.Add(this.label3);
            this.CreateBatch.Controls.Add(this.label2);
            this.CreateBatch.Controls.Add(this.label1);
            this.CreateBatch.Controls.Add(this.cmbCourseName);
            this.CreateBatch.Controls.Add(this.cmbTimings);
            this.CreateBatch.Controls.Add(this.cmbUsersName);
            this.CreateBatch.Controls.Add(this.txtName);
            this.CreateBatch.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CreateBatch.ForeColor = System.Drawing.Color.Black;
            this.CreateBatch.Location = new System.Drawing.Point(319, 115);
            this.CreateBatch.Name = "CreateBatch";
            this.CreateBatch.Size = new System.Drawing.Size(823, 233);
            this.CreateBatch.TabIndex = 0;
            this.CreateBatch.TabStop = false;
            this.CreateBatch.Text = "Create Batch";
            // 
            // lblDesignation
            // 
            this.lblDesignation.AutoSize = true;
            this.lblDesignation.ForeColor = System.Drawing.Color.White;
            this.lblDesignation.Location = new System.Drawing.Point(665, 150);
            this.lblDesignation.Name = "lblDesignation";
            this.lblDesignation.Size = new System.Drawing.Size(115, 20);
            this.lblDesignation.TabIndex = 10;
            this.lblDesignation.Text = "Designation";
            this.lblDesignation.Visible = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(396, 54);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(119, 20);
            this.label4.TabIndex = 9;
            this.label4.Text = "Course Name";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(396, 118);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(131, 20);
            this.label3.TabIndex = 8;
            this.label3.Text = "Teacher Name";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(75, 118);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 20);
            this.label2.TabIndex = 7;
            this.label2.Text = "Timings";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(75, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(113, 20);
            this.label1.TabIndex = 6;
            this.label1.Text = "Batch Name";
            // 
            // cmbCourseName
            // 
            this.cmbCourseName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCourseName.ForeColor = System.Drawing.Color.White;
            this.cmbCourseName.FormattingEnabled = true;
            this.cmbCourseName.Items.AddRange(new object[] {
            "Select Course"});
            this.cmbCourseName.Location = new System.Drawing.Point(400, 77);
            this.cmbCourseName.Name = "cmbCourseName";
            this.cmbCourseName.Size = new System.Drawing.Size(260, 28);
            this.cmbCourseName.TabIndex = 2;
            this.cmbCourseName.SelectedIndexChanged += new System.EventHandler(this.cmbCourseName_SelectedIndexChanged);
            // 
            // cmbTimings
            // 
            this.cmbTimings.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbTimings.ForeColor = System.Drawing.Color.White;
            this.cmbTimings.FormattingEnabled = true;
            this.cmbTimings.Items.AddRange(new object[] {
            "9:00 to 11:00",
            "12:00 to 2:00",
            "5:00 to 7:00",
            "9:00 to 11:00 "});
            this.cmbTimings.Location = new System.Drawing.Point(78, 142);
            this.cmbTimings.Name = "cmbTimings";
            this.cmbTimings.Size = new System.Drawing.Size(249, 28);
            this.cmbTimings.TabIndex = 1;
            // 
            // cmbUsersName
            // 
            this.cmbUsersName.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbUsersName.ForeColor = System.Drawing.Color.White;
            this.cmbUsersName.FormattingEnabled = true;
            this.cmbUsersName.Items.AddRange(new object[] {
            "Select User"});
            this.cmbUsersName.Location = new System.Drawing.Point(399, 142);
            this.cmbUsersName.Name = "cmbUsersName";
            this.cmbUsersName.Size = new System.Drawing.Size(260, 28);
            this.cmbUsersName.TabIndex = 3;
            this.cmbUsersName.SelectedIndexChanged += new System.EventHandler(this.cmbUsersName_SelectedIndexChanged);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(78, 77);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(249, 28);
            this.txtName.TabIndex = 0;
            // 
            // tabBatches
            // 
            this.tabBatches.Controls.Add(this.tabPage2);
            this.tabBatches.Controls.Add(this.tabPage5);
            this.tabBatches.Controls.Add(this.tabPage3);
            this.tabBatches.HotTrack = true;
            this.tabBatches.Location = new System.Drawing.Point(0, 0);
            this.tabBatches.Name = "tabBatches";
            this.tabBatches.SelectedIndex = 0;
            this.tabBatches.Size = new System.Drawing.Size(1356, 691);
            this.tabBatches.TabIndex = 3;
            // 
            // Batches
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.DimGray;
            this.ClientSize = new System.Drawing.Size(1368, 680);
            this.ControlBox = false;
            this.Controls.Add(this.tabBatches);
            this.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.Name = "Batches";
            this.Text = "Batches";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Batches_Load);
            this.tabPage3.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.tabPage5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.CreateBatch.ResumeLayout(false);
            this.CreateBatch.PerformLayout();
            this.tabBatches.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.TextBox txtNameud;
        private System.Windows.Forms.TabPage tabPage5;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label lblEnableSearch;
        private System.Windows.Forms.Button btnSearchf;
        private System.Windows.Forms.ComboBox cmbSearch;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox CreateBatch;
        private System.Windows.Forms.Label lblDesignation;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.ComboBox cmbCourseName;
        private System.Windows.Forms.ComboBox cmbTimings;
        private System.Windows.Forms.ComboBox cmbUsersName;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TabControl tabBatches;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmTimings;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourseName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmUserName;
        private System.Windows.Forms.ComboBox cmbTime;
        private System.Windows.Forms.ComboBox cmbTeacher;
        private System.Windows.Forms.ComboBox cmbCourse;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.GroupBox groupBox3;

    }
}