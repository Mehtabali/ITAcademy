namespace ITAcademy.WinForms
{
    partial class Tests
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
            this.tabTest = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnGenerateNotification = new System.Windows.Forms.Button();
            this.btnSchedule = new System.Windows.Forms.Button();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.lblName = new System.Windows.Forms.Label();
            this.dtpTestDate = new System.Windows.Forms.DateTimePicker();
            this.label9 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txtDescription = new System.Windows.Forms.TextBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.txtTotalMarks = new System.Windows.Forms.TextBox();
            this.txtPassingMarks = new System.Windows.Forms.TextBox();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tabUpdateDelete = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnInActive = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.txtTeacherud = new System.Windows.Forms.TextBox();
            this.txtCourseud = new System.Windows.Forms.TextBox();
            this.cmbBatchud = new System.Windows.Forms.ComboBox();
            this.dtpTestDateud = new System.Windows.Forms.DateTimePicker();
            this.label10 = new System.Windows.Forms.Label();
            this.txtNameud = new System.Windows.Forms.TextBox();
            this.label17 = new System.Windows.Forms.Label();
            this.txtTotalMarksud = new System.Windows.Forms.TextBox();
            this.txtPassingMarksud = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMessage = new System.Windows.Forms.TextBox();
            this.txtSubject = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.btnSendMail = new System.Windows.Forms.Button();
            this.dgvMailInfo = new System.Windows.Forms.DataGridView();
            this.clmBatchId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMailFrom = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPassword = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmReceiverMail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmSmtpAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmPortNumber = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.listViewTest = new System.Windows.Forms.TableLayoutPanel();
            this.tabTest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabUpdateDelete.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailInfo)).BeginInit();
            this.SuspendLayout();
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.tabPage2);
            this.tabTest.Controls.Add(this.tabUpdateDelete);
            this.tabTest.Controls.Add(this.tabPage1);
            this.tabTest.Location = new System.Drawing.Point(2, 2);
            this.tabTest.Name = "tabTest";
            this.tabTest.SelectedIndex = 0;
            this.tabTest.Size = new System.Drawing.Size(1056, 666);
            this.tabTest.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.BackColor = System.Drawing.Color.DimGray;
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(1048, 640);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Scheduler";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnGenerateNotification);
            this.groupBox4.Controls.Add(this.btnSchedule);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(262, 452);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 59);
            this.groupBox4.TabIndex = 2;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(613, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 30);
            this.btnReset.TabIndex = 11;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNotification
            // 
            this.btnGenerateNotification.Location = new System.Drawing.Point(456, 23);
            this.btnGenerateNotification.Name = "btnGenerateNotification";
            this.btnGenerateNotification.Size = new System.Drawing.Size(144, 30);
            this.btnGenerateNotification.TabIndex = 10;
            this.btnGenerateNotification.Text = "Generate Notification";
            this.btnGenerateNotification.UseVisualStyleBackColor = true;
            this.btnGenerateNotification.Click += new System.EventHandler(this.btnGenerateNotification_Click);
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(319, 23);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(107, 30);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
            this.btnSchedule.Click += new System.EventHandler(this.btnSchedule_Click);
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.txtName);
            this.groupBox3.Controls.Add(this.lblName);
            this.groupBox3.Controls.Add(this.dtpTestDate);
            this.groupBox3.Controls.Add(this.label9);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Controls.Add(this.txtDescription);
            this.groupBox3.Controls.Add(this.txtCourse);
            this.groupBox3.Controls.Add(this.txtTeacher);
            this.groupBox3.Controls.Add(this.txtTotalMarks);
            this.groupBox3.Controls.Add(this.txtPassingMarks);
            this.groupBox3.Controls.Add(this.cmbBatch);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label5);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.label3);
            this.groupBox3.Controls.Add(this.label2);
            this.groupBox3.Controls.Add(this.label1);
            this.groupBox3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox3.Location = new System.Drawing.Point(262, 115);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 331);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Schedule Test";
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.Color.Black;
            this.txtName.Location = new System.Drawing.Point(83, 90);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 28);
            this.txtName.TabIndex = 1;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.ForeColor = System.Drawing.Color.White;
            this.lblName.Location = new System.Drawing.Point(79, 64);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(95, 20);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Test Name";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Location = new System.Drawing.Point(83, 261);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(207, 28);
            this.dtpTestDate.TabIndex = 4;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(79, 238);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 20);
            this.label9.TabIndex = 34;
            this.label9.Text = "Test Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(477, 232);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(106, 20);
            this.label7.TabIndex = 32;
            this.label7.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.ForeColor = System.Drawing.Color.Black;
            this.txtDescription.Location = new System.Drawing.Point(481, 255);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(207, 70);
            this.txtDescription.TabIndex = 8;
            // 
            // txtCourse
            // 
            this.txtCourse.ForeColor = System.Drawing.Color.Black;
            this.txtCourse.Location = new System.Drawing.Point(481, 144);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(207, 28);
            this.txtCourse.TabIndex = 6;
            // 
            // txtTeacher
            // 
            this.txtTeacher.ForeColor = System.Drawing.Color.Black;
            this.txtTeacher.Location = new System.Drawing.Point(83, 144);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(207, 28);
            this.txtTeacher.TabIndex = 2;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.ForeColor = System.Drawing.Color.Black;
            this.txtTotalMarks.Location = new System.Drawing.Point(83, 198);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(207, 28);
            this.txtTotalMarks.TabIndex = 3;
            // 
            // txtPassingMarks
            // 
            this.txtPassingMarks.ForeColor = System.Drawing.Color.Black;
            this.txtPassingMarks.Location = new System.Drawing.Point(481, 198);
            this.txtPassingMarks.Name = "txtPassingMarks";
            this.txtPassingMarks.Size = new System.Drawing.Size(207, 28);
            this.txtPassingMarks.TabIndex = 7;
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.ForeColor = System.Drawing.Color.Black;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Items.AddRange(new object[] {
            "Select Batch"});
            this.cmbBatch.Location = new System.Drawing.Point(481, 90);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(207, 28);
            this.cmbBatch.TabIndex = 5;
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(477, 121);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(65, 20);
            this.label8.TabIndex = 17;
            this.label8.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(79, 121);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(171, 20);
            this.label5.TabIndex = 14;
            this.label5.Text = "Associated Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(477, 175);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(128, 20);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passing Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(79, 175);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 20);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 20);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(477, 67);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Batch";
            // 
            // tabUpdateDelete
            // 
            this.tabUpdateDelete.BackColor = System.Drawing.Color.DimGray;
            this.tabUpdateDelete.Controls.Add(this.groupBox6);
            this.tabUpdateDelete.Controls.Add(this.groupBox5);
            this.tabUpdateDelete.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tabUpdateDelete.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateDelete.Name = "tabUpdateDelete";
            this.tabUpdateDelete.Size = new System.Drawing.Size(1048, 640);
            this.tabUpdateDelete.TabIndex = 2;
            this.tabUpdateDelete.Text = "Update/Delete";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInActive);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btnUpdate);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(262, 469);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(713, 59);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions ";
            // 
            // btnInActive
            // 
            this.btnInActive.Location = new System.Drawing.Point(584, 23);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(99, 30);
            this.btnInActive.TabIndex = 10;
            this.btnInActive.Text = "Inactive";
            this.btnInActive.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(423, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 30);
            this.button2.TabIndex = 9;
            this.button2.Text = "Generate Notification";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(329, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 30);
            this.btnUpdate.TabIndex = 8;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.txtTeacherud);
            this.groupBox5.Controls.Add(this.txtCourseud);
            this.groupBox5.Controls.Add(this.cmbBatchud);
            this.groupBox5.Controls.Add(this.dtpTestDateud);
            this.groupBox5.Controls.Add(this.label10);
            this.groupBox5.Controls.Add(this.txtNameud);
            this.groupBox5.Controls.Add(this.label17);
            this.groupBox5.Controls.Add(this.txtTotalMarksud);
            this.groupBox5.Controls.Add(this.txtPassingMarksud);
            this.groupBox5.Controls.Add(this.label11);
            this.groupBox5.Controls.Add(this.label12);
            this.groupBox5.Controls.Add(this.label13);
            this.groupBox5.Controls.Add(this.label14);
            this.groupBox5.Controls.Add(this.label15);
            this.groupBox5.Controls.Add(this.label16);
            this.groupBox5.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox5.Location = new System.Drawing.Point(262, 115);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(712, 348);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            this.groupBox5.Text = "Update/Delete";
            // 
            // txtTeacherud
            // 
            this.txtTeacherud.ForeColor = System.Drawing.Color.White;
            this.txtTeacherud.Location = new System.Drawing.Point(476, 155);
            this.txtTeacherud.Name = "txtTeacherud";
            this.txtTeacherud.ReadOnly = true;
            this.txtTeacherud.Size = new System.Drawing.Size(207, 28);
            this.txtTeacherud.TabIndex = 6;
            // 
            // txtCourseud
            // 
            this.txtCourseud.ForeColor = System.Drawing.Color.White;
            this.txtCourseud.Location = new System.Drawing.Point(114, 155);
            this.txtCourseud.Name = "txtCourseud";
            this.txtCourseud.ReadOnly = true;
            this.txtCourseud.Size = new System.Drawing.Size(207, 28);
            this.txtCourseud.TabIndex = 2;
            // 
            // cmbBatchud
            // 
            this.cmbBatchud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchud.ForeColor = System.Drawing.Color.White;
            this.cmbBatchud.FormattingEnabled = true;
            this.cmbBatchud.Items.AddRange(new object[] {
            "Select Batch"});
            this.cmbBatchud.Location = new System.Drawing.Point(476, 103);
            this.cmbBatchud.Name = "cmbBatchud";
            this.cmbBatchud.Size = new System.Drawing.Size(207, 28);
            this.cmbBatchud.TabIndex = 5;
            // 
            // dtpTestDateud
            // 
            this.dtpTestDateud.Location = new System.Drawing.Point(117, 273);
            this.dtpTestDateud.Name = "dtpTestDateud";
            this.dtpTestDateud.Size = new System.Drawing.Size(204, 28);
            this.dtpTestDateud.TabIndex = 4;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.Color.White;
            this.label10.Location = new System.Drawing.Point(113, 250);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(87, 20);
            this.label10.TabIndex = 37;
            this.label10.Text = "Test Date";
            // 
            // txtNameud
            // 
            this.txtNameud.ForeColor = System.Drawing.Color.White;
            this.txtNameud.Location = new System.Drawing.Point(114, 101);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(207, 28);
            this.txtNameud.TabIndex = 1;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(113, 78);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(95, 20);
            this.label17.TabIndex = 34;
            this.label17.Text = "Test Name";
            // 
            // txtTotalMarksud
            // 
            this.txtTotalMarksud.ForeColor = System.Drawing.Color.White;
            this.txtTotalMarksud.Location = new System.Drawing.Point(117, 209);
            this.txtTotalMarksud.Name = "txtTotalMarksud";
            this.txtTotalMarksud.Size = new System.Drawing.Size(207, 28);
            this.txtTotalMarksud.TabIndex = 3;
            // 
            // txtPassingMarksud
            // 
            this.txtPassingMarksud.ForeColor = System.Drawing.Color.White;
            this.txtPassingMarksud.Location = new System.Drawing.Point(476, 209);
            this.txtPassingMarksud.Name = "txtPassingMarksud";
            this.txtPassingMarksud.Size = new System.Drawing.Size(207, 28);
            this.txtPassingMarksud.TabIndex = 7;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.Color.White;
            this.label11.Location = new System.Drawing.Point(113, 132);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 20);
            this.label11.TabIndex = 17;
            this.label11.Text = "Course";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(472, 132);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(171, 20);
            this.label12.TabIndex = 14;
            this.label12.Text = "Associated Teacher";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.Color.White;
            this.label13.Location = new System.Drawing.Point(472, 186);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(128, 20);
            this.label13.TabIndex = 13;
            this.label13.Text = "Passing Marks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.Color.White;
            this.label14.Location = new System.Drawing.Point(113, 186);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(109, 20);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 20);
            this.label15.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(472, 78);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(59, 20);
            this.label16.TabIndex = 8;
            this.label16.Text = "Batch";
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.dgvMailInfo);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Size = new System.Drawing.Size(1048, 640);
            this.tabPage1.TabIndex = 3;
            this.tabPage1.Text = "Notification";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.btnSendMail);
            this.groupBox1.Controls.Add(this.txtMessage);
            this.groupBox1.Controls.Add(this.txtSubject);
            this.groupBox1.Controls.Add(this.label18);
            this.groupBox1.Location = new System.Drawing.Point(90, 239);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(873, 260);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Compose Message";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(55, 32);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(43, 13);
            this.label6.TabIndex = 2;
            this.label6.Text = "Subject";
            // 
            // txtMessage
            // 
            this.txtMessage.Location = new System.Drawing.Point(118, 76);
            this.txtMessage.Multiline = true;
            this.txtMessage.Name = "txtMessage";
            this.txtMessage.Size = new System.Drawing.Size(598, 106);
            this.txtMessage.TabIndex = 5;
            // 
            // txtSubject
            // 
            this.txtSubject.Location = new System.Drawing.Point(118, 25);
            this.txtSubject.Name = "txtSubject";
            this.txtSubject.Size = new System.Drawing.Size(598, 20);
            this.txtSubject.TabIndex = 4;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Location = new System.Drawing.Point(55, 76);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(50, 13);
            this.label18.TabIndex = 3;
            this.label18.Text = "Message";
            // 
            // btnSendMail
            // 
            this.btnSendMail.Location = new System.Drawing.Point(641, 219);
            this.btnSendMail.Name = "btnSendMail";
            this.btnSendMail.Size = new System.Drawing.Size(75, 23);
            this.btnSendMail.TabIndex = 1;
            this.btnSendMail.Text = "Send Mail";
            this.btnSendMail.UseVisualStyleBackColor = true;
            this.btnSendMail.Click += new System.EventHandler(this.btnSendMail_Click);
            // 
            // dgvMailInfo
            // 
            this.dgvMailInfo.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMailInfo.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.clmBatchId,
            this.clmStudentId,
            this.clmStudentName,
            this.clmMailFrom,
            this.clmPassword,
            this.clmReceiverMail,
            this.clmSmtpAddress,
            this.clmPortNumber});
            this.dgvMailInfo.Location = new System.Drawing.Point(90, 74);
            this.dgvMailInfo.Name = "dgvMailInfo";
            this.dgvMailInfo.Size = new System.Drawing.Size(873, 150);
            this.dgvMailInfo.TabIndex = 0;
            // 
            // clmBatchId
            // 
            this.clmBatchId.HeaderText = "Batch Id";
            this.clmBatchId.Name = "clmBatchId";
            // 
            // clmStudentId
            // 
            this.clmStudentId.DataPropertyName = "StudentId";
            this.clmStudentId.HeaderText = "Studnet Id";
            this.clmStudentId.Name = "clmStudentId";
            // 
            // clmStudentName
            // 
            this.clmStudentName.DataPropertyName = "StudentName";
            this.clmStudentName.HeaderText = "Student Name";
            this.clmStudentName.Name = "clmStudentName";
            // 
            // clmMailFrom
            // 
            this.clmMailFrom.DataPropertyName = "SenderEmail";
            this.clmMailFrom.HeaderText = "Sender Mail";
            this.clmMailFrom.Name = "clmMailFrom";
            // 
            // clmPassword
            // 
            this.clmPassword.DataPropertyName = "Password";
            this.clmPassword.HeaderText = "Password";
            this.clmPassword.Name = "clmPassword";
            // 
            // clmReceiverMail
            // 
            this.clmReceiverMail.DataPropertyName = "StudentEmail";
            this.clmReceiverMail.HeaderText = "Receiver Mail";
            this.clmReceiverMail.Name = "clmReceiverMail";
            // 
            // clmSmtpAddress
            // 
            this.clmSmtpAddress.DataPropertyName = "SmtpAddress";
            this.clmSmtpAddress.HeaderText = "Smtp Address";
            this.clmSmtpAddress.Name = "clmSmtpAddress";
            // 
            // clmPortNumber
            // 
            this.clmPortNumber.DataPropertyName = "PortNumber";
            this.clmPortNumber.HeaderText = "PortNumber";
            this.clmPortNumber.Name = "clmPortNumber";
            // 
            // listViewTest
            // 
            this.listViewTest.AutoScroll = true;
            this.listViewTest.BackColor = System.Drawing.Color.White;
            this.listViewTest.ColumnCount = 1;
            this.listViewTest.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listViewTest.Location = new System.Drawing.Point(1064, 26);
            this.listViewTest.Name = "listViewTest";
            this.listViewTest.RowCount = 1;
            this.listViewTest.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.listViewTest.Size = new System.Drawing.Size(290, 638);
            this.listViewTest.TabIndex = 6;
            // 
            // Tests
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1366, 680);
            this.ControlBox = false;
            this.Controls.Add(this.listViewTest);
            this.Controls.Add(this.tabTest);
            this.Name = "Tests";
            this.Text = "TestAndExam_WinForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.TestAndExam_WinForm_Load);
            this.tabTest.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabUpdateDelete.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabPage1.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMailInfo)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TabPage tabUpdateDelete;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnInActive;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.TextBox txtTeacherud;
        private System.Windows.Forms.TextBox txtCourseud;
        private System.Windows.Forms.ComboBox cmbBatchud;
        private System.Windows.Forms.DateTimePicker dtpTestDateud;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtNameud;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.TextBox txtTotalMarksud;
        private System.Windows.Forms.TextBox txtPassingMarksud;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.Label lblName;
        private System.Windows.Forms.DateTimePicker dtpTestDate;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtDescription;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.TextBox txtTotalMarks;
        private System.Windows.Forms.TextBox txtPassingMarks;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerateNotification;
        private System.Windows.Forms.Button btnSchedule;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btnSendMail;
        private System.Windows.Forms.DataGridView dgvMailInfo;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmBatchId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentId;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMailFrom;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPassword;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmReceiverMail;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmSmtpAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmPortNumber;
        private System.Windows.Forms.TextBox txtMessage;
        private System.Windows.Forms.TextBox txtSubject;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TableLayoutPanel listViewTest;

    }
}