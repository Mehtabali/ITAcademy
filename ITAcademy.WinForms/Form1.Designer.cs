namespace ITAcademy.WinForms
{
    partial class Form1
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
            System.Windows.Forms.ListViewItem listViewItem4 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem5 = new System.Windows.Forms.ListViewItem("");
            System.Windows.Forms.ListViewItem listViewItem6 = new System.Windows.Forms.ListViewItem("");
            this.tabTest = new System.Windows.Forms.TabControl();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage4 = new System.Windows.Forms.TabPage();
            this.listViewTest = new System.Windows.Forms.ListView();
            this.tabTest.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.tabUpdateDelete.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.tabControl1.SuspendLayout();
            this.tabPage4.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabTest
            // 
            this.tabTest.Controls.Add(this.tabPage2);
            this.tabTest.Controls.Add(this.tabUpdateDelete);
            this.tabTest.Location = new System.Drawing.Point(184, -44);
            this.tabTest.Name = "tabTest";
            this.tabTest.SelectedIndex = 0;
            this.tabTest.Size = new System.Drawing.Size(833, 553);
            this.tabTest.TabIndex = 2;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox2);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(825, 527);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Test Scheduler";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.groupBox4);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Location = new System.Drawing.Point(14, 20);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(778, 501);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Schedule Test";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnReset);
            this.groupBox4.Controls.Add(this.btnGenerateNotification);
            this.groupBox4.Controls.Add(this.btnSchedule);
            this.groupBox4.Location = new System.Drawing.Point(25, 351);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(727, 59);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions ";
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(631, 23);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(75, 23);
            this.btnReset.TabIndex = 0;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // btnGenerateNotification
            // 
            this.btnGenerateNotification.Location = new System.Drawing.Point(456, 23);
            this.btnGenerateNotification.Name = "btnGenerateNotification";
            this.btnGenerateNotification.Size = new System.Drawing.Size(144, 23);
            this.btnGenerateNotification.TabIndex = 10;
            this.btnGenerateNotification.Text = "Generate Notification";
            this.btnGenerateNotification.UseVisualStyleBackColor = true;
            // 
            // btnSchedule
            // 
            this.btnSchedule.Location = new System.Drawing.Point(351, 23);
            this.btnSchedule.Name = "btnSchedule";
            this.btnSchedule.Size = new System.Drawing.Size(75, 23);
            this.btnSchedule.TabIndex = 9;
            this.btnSchedule.Text = "Schedule";
            this.btnSchedule.UseVisualStyleBackColor = true;
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
            this.groupBox3.Location = new System.Drawing.Point(25, 19);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(727, 314);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 34);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(207, 20);
            this.txtName.TabIndex = 36;
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Location = new System.Drawing.Point(17, 41);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(59, 13);
            this.lblName.TabIndex = 35;
            this.lblName.Text = "Test Name";
            // 
            // dtpTestDate
            // 
            this.dtpTestDate.Location = new System.Drawing.Point(131, 204);
            this.dtpTestDate.Name = "dtpTestDate";
            this.dtpTestDate.Size = new System.Drawing.Size(207, 20);
            this.dtpTestDate.TabIndex = 33;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(33, 210);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(54, 13);
            this.label9.TabIndex = 34;
            this.label9.Text = "Test Date";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(388, 190);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(60, 13);
            this.label7.TabIndex = 32;
            this.label7.Text = "Description";
            // 
            // txtDescription
            // 
            this.txtDescription.Location = new System.Drawing.Point(481, 187);
            this.txtDescription.Multiline = true;
            this.txtDescription.Name = "txtDescription";
            this.txtDescription.Size = new System.Drawing.Size(207, 110);
            this.txtDescription.TabIndex = 1;
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(481, 87);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(207, 20);
            this.txtCourse.TabIndex = 31;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Location = new System.Drawing.Point(133, 87);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(207, 20);
            this.txtTeacher.TabIndex = 30;
            // 
            // txtTotalMarks
            // 
            this.txtTotalMarks.Location = new System.Drawing.Point(133, 129);
            this.txtTotalMarks.Name = "txtTotalMarks";
            this.txtTotalMarks.Size = new System.Drawing.Size(207, 20);
            this.txtTotalMarks.TabIndex = 29;
            // 
            // txtPassingMarks
            // 
            this.txtPassingMarks.Location = new System.Drawing.Point(481, 136);
            this.txtPassingMarks.Name = "txtPassingMarks";
            this.txtPassingMarks.Size = new System.Drawing.Size(207, 20);
            this.txtPassingMarks.TabIndex = 28;
            // 
            // cmbBatch
            // 
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Items.AddRange(new object[] {
            "Select Batch"});
            this.cmbBatch.Location = new System.Drawing.Point(481, 29);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(207, 21);
            this.cmbBatch.TabIndex = 19;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(408, 90);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(40, 13);
            this.label8.TabIndex = 17;
            this.label8.Text = "Course";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(6, 90);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(102, 13);
            this.label5.TabIndex = 14;
            this.label5.Text = "Associated Teacher";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(372, 136);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(76, 13);
            this.label4.TabIndex = 13;
            this.label4.Text = "Passing Marks";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(19, 136);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 12;
            this.label3.Text = "Total Marks";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(19, 111);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(380, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(68, 13);
            this.label1.TabIndex = 8;
            this.label1.Text = "Select Batch";
            // 
            // tabUpdateDelete
            // 
            this.tabUpdateDelete.Controls.Add(this.groupBox6);
            this.tabUpdateDelete.Controls.Add(this.groupBox5);
            this.tabUpdateDelete.Location = new System.Drawing.Point(4, 22);
            this.tabUpdateDelete.Name = "tabUpdateDelete";
            this.tabUpdateDelete.Size = new System.Drawing.Size(825, 527);
            this.tabUpdateDelete.TabIndex = 2;
            this.tabUpdateDelete.Text = "Update/Delete";
            this.tabUpdateDelete.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnInActive);
            this.groupBox6.Controls.Add(this.button2);
            this.groupBox6.Controls.Add(this.btnUpdate);
            this.groupBox6.Location = new System.Drawing.Point(61, 408);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(727, 59);
            this.groupBox6.TabIndex = 2;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions ";
            // 
            // btnInActive
            // 
            this.btnInActive.Location = new System.Drawing.Point(631, 23);
            this.btnInActive.Name = "btnInActive";
            this.btnInActive.Size = new System.Drawing.Size(75, 23);
            this.btnInActive.TabIndex = 0;
            this.btnInActive.Text = "Inactive";
            this.btnInActive.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(456, 23);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(144, 23);
            this.button2.TabIndex = 10;
            this.button2.Text = "Generate Notification";
            this.button2.UseVisualStyleBackColor = true;
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(351, 23);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 9;
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
            this.groupBox5.Location = new System.Drawing.Point(61, 54);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(727, 348);
            this.groupBox5.TabIndex = 1;
            this.groupBox5.TabStop = false;
            // 
            // txtTeacherud
            // 
            this.txtTeacherud.Location = new System.Drawing.Point(472, 94);
            this.txtTeacherud.Name = "txtTeacherud";
            this.txtTeacherud.ReadOnly = true;
            this.txtTeacherud.Size = new System.Drawing.Size(207, 20);
            this.txtTeacherud.TabIndex = 42;
            // 
            // txtCourseud
            // 
            this.txtCourseud.Location = new System.Drawing.Point(133, 94);
            this.txtCourseud.Name = "txtCourseud";
            this.txtCourseud.ReadOnly = true;
            this.txtCourseud.Size = new System.Drawing.Size(207, 20);
            this.txtCourseud.TabIndex = 41;
            // 
            // cmbBatchud
            // 
            this.cmbBatchud.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatchud.FormattingEnabled = true;
            this.cmbBatchud.Items.AddRange(new object[] {
            "Select Batch"});
            this.cmbBatchud.Location = new System.Drawing.Point(472, 34);
            this.cmbBatchud.Name = "cmbBatchud";
            this.cmbBatchud.Size = new System.Drawing.Size(207, 21);
            this.cmbBatchud.TabIndex = 38;
            // 
            // dtpTestDateud
            // 
            this.dtpTestDateud.Location = new System.Drawing.Point(133, 205);
            this.dtpTestDateud.Name = "dtpTestDateud";
            this.dtpTestDateud.Size = new System.Drawing.Size(204, 20);
            this.dtpTestDateud.TabIndex = 36;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(46, 207);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(54, 13);
            this.label10.TabIndex = 37;
            this.label10.Text = "Test Date";
            // 
            // txtNameud
            // 
            this.txtNameud.Location = new System.Drawing.Point(133, 42);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(207, 20);
            this.txtNameud.TabIndex = 35;
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(22, 49);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(59, 13);
            this.label17.TabIndex = 34;
            this.label17.Text = "Test Name";
            // 
            // txtTotalMarksud
            // 
            this.txtTotalMarksud.Location = new System.Drawing.Point(133, 136);
            this.txtTotalMarksud.Name = "txtTotalMarksud";
            this.txtTotalMarksud.Size = new System.Drawing.Size(207, 20);
            this.txtTotalMarksud.TabIndex = 29;
            // 
            // txtPassingMarksud
            // 
            this.txtPassingMarksud.Location = new System.Drawing.Point(481, 136);
            this.txtPassingMarksud.Name = "txtPassingMarksud";
            this.txtPassingMarksud.Size = new System.Drawing.Size(207, 20);
            this.txtPassingMarksud.TabIndex = 28;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(41, 94);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(40, 13);
            this.label11.TabIndex = 17;
            this.label11.Text = "Course";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(354, 94);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(102, 13);
            this.label12.TabIndex = 14;
            this.label12.Text = "Associated Teacher";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(372, 136);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(76, 13);
            this.label13.TabIndex = 13;
            this.label13.Text = "Passing Marks";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(19, 136);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(63, 13);
            this.label14.TabIndex = 12;
            this.label14.Text = "Total Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(19, 111);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(0, 13);
            this.label15.TabIndex = 11;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(413, 34);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(35, 13);
            this.label16.TabIndex = 8;
            this.label16.Text = "Batch";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage4);
            this.tabControl1.Location = new System.Drawing.Point(514, -44);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(271, 553);
            this.tabControl1.TabIndex = 3;
            // 
            // tabPage4
            // 
            this.tabPage4.Controls.Add(this.listViewTest);
            this.tabPage4.Location = new System.Drawing.Point(4, 22);
            this.tabPage4.Name = "tabPage4";
            this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage4.Size = new System.Drawing.Size(263, 527);
            this.tabPage4.TabIndex = 1;
            this.tabPage4.Text = "Test Updates";
            this.tabPage4.UseVisualStyleBackColor = true;
            // 
            // listViewTest
            // 
            this.listViewTest.Items.AddRange(new System.Windows.Forms.ListViewItem[] {
            listViewItem4,
            listViewItem5,
            listViewItem6});
            this.listViewTest.Location = new System.Drawing.Point(16, 20);
            this.listViewTest.Name = "listViewTest";
            this.listViewTest.Size = new System.Drawing.Size(231, 488);
            this.listViewTest.TabIndex = 0;
            this.listViewTest.UseCompatibleStateImageBehavior = false;
            this.listViewTest.View = System.Windows.Forms.View.List;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1168, 517);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.tabTest);
            this.Name = "Form1";
            this.Text = "Form1";
            this.tabTest.ResumeLayout(false);
            this.tabPage2.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.tabUpdateDelete.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox5.PerformLayout();
            this.tabControl1.ResumeLayout(false);
            this.tabPage4.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabTest;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnGenerateNotification;
        private System.Windows.Forms.Button btnSchedule;
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
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage4;
        private System.Windows.Forms.ListView listViewTest;

    }
}

