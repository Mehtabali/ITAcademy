﻿namespace ITAcademy.WinForms
{
    partial class Attendence
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
            this.tabCtrlAttendence = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox6 = new System.Windows.Forms.GroupBox();
            this.btnCancel1 = new System.Windows.Forms.Button();
            this.btnView = new System.Windows.Forms.Button();
            this.grpStudents = new System.Windows.Forms.GroupBox();
            this.lblIdHeader = new System.Windows.Forms.Label();
            this.lblNameHeader = new System.Windows.Forms.Label();
            this.lblIsAttendHeader = new System.Windows.Forms.Label();
            this.lblSerialHeader = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.dtpToday = new System.Windows.Forms.DateTimePicker();
            this.txtTeacher = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblBatch = new System.Windows.Forms.Label();
            this.cmbBatch = new System.Windows.Forms.ComboBox();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.groupBox5 = new System.Windows.Forms.GroupBox();
            this.btnSearch = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.comboBox3 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.tabCtrlAttendence.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox6.SuspendLayout();
            this.grpStudents.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.groupBox5.SuspendLayout();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabCtrlAttendence
            // 
            this.tabCtrlAttendence.Controls.Add(this.tabPage1);
            this.tabCtrlAttendence.Controls.Add(this.tabPage2);
            this.tabCtrlAttendence.Location = new System.Drawing.Point(0, 12);
            this.tabCtrlAttendence.Name = "tabCtrlAttendence";
            this.tabCtrlAttendence.SelectedIndex = 0;
            this.tabCtrlAttendence.Size = new System.Drawing.Size(1356, 688);
            this.tabCtrlAttendence.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BackColor = System.Drawing.Color.DimGray;
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.grpStudents);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(1348, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendence Sheet";
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCancel1);
            this.groupBox6.Controls.Add(this.btnView);
            this.groupBox6.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox6.Location = new System.Drawing.Point(319, 273);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(695, 58);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            this.groupBox6.Text = "Actions";
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(525, 19);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 33);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            // 
            // btnView
            // 
            this.btnView.Location = new System.Drawing.Point(444, 19);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(75, 33);
            this.btnView.TabIndex = 0;
            this.btnView.Text = "Get Details";
            this.btnView.UseVisualStyleBackColor = true;
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // grpStudents
            // 
            this.grpStudents.Controls.Add(this.lblIdHeader);
            this.grpStudents.Controls.Add(this.lblNameHeader);
            this.grpStudents.Controls.Add(this.lblIsAttendHeader);
            this.grpStudents.Controls.Add(this.lblSerialHeader);
            this.grpStudents.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.grpStudents.Location = new System.Drawing.Point(319, 347);
            this.grpStudents.Name = "grpStudents";
            this.grpStudents.Size = new System.Drawing.Size(695, 319);
            this.grpStudents.TabIndex = 0;
            this.grpStudents.TabStop = false;
            this.grpStudents.Text = "Students in this Batch";
            // 
            // lblIdHeader
            // 
            this.lblIdHeader.AutoSize = true;
            this.lblIdHeader.ForeColor = System.Drawing.Color.White;
            this.lblIdHeader.Location = new System.Drawing.Point(127, 40);
            this.lblIdHeader.Name = "lblIdHeader";
            this.lblIdHeader.Size = new System.Drawing.Size(101, 20);
            this.lblIdHeader.TabIndex = 3;
            this.lblIdHeader.Text = "Student Id";
            // 
            // lblNameHeader
            // 
            this.lblNameHeader.AutoSize = true;
            this.lblNameHeader.ForeColor = System.Drawing.Color.White;
            this.lblNameHeader.Location = new System.Drawing.Point(243, 40);
            this.lblNameHeader.Name = "lblNameHeader";
            this.lblNameHeader.Size = new System.Drawing.Size(130, 20);
            this.lblNameHeader.TabIndex = 2;
            this.lblNameHeader.Text = "Student Name";
            // 
            // lblIsAttendHeader
            // 
            this.lblIsAttendHeader.AutoSize = true;
            this.lblIsAttendHeader.ForeColor = System.Drawing.Color.White;
            this.lblIsAttendHeader.Location = new System.Drawing.Point(466, 40);
            this.lblIsAttendHeader.Name = "lblIsAttendHeader";
            this.lblIsAttendHeader.Size = new System.Drawing.Size(81, 20);
            this.lblIsAttendHeader.TabIndex = 1;
            this.lblIsAttendHeader.Text = "IsAttend";
            // 
            // lblSerialHeader
            // 
            this.lblSerialHeader.AutoSize = true;
            this.lblSerialHeader.ForeColor = System.Drawing.Color.White;
            this.lblSerialHeader.Location = new System.Drawing.Point(31, 40);
            this.lblSerialHeader.Name = "lblSerialHeader";
            this.lblSerialHeader.Size = new System.Drawing.Size(91, 20);
            this.lblSerialHeader.TabIndex = 0;
            this.lblSerialHeader.Text = "Serial No.";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.dtpToday);
            this.groupBox1.Controls.Add(this.txtTeacher);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.lblBatch);
            this.groupBox1.Controls.Add(this.cmbBatch);
            this.groupBox1.Controls.Add(this.txtCourse);
            this.groupBox1.Location = new System.Drawing.Point(319, 115);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(366, 75);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(103, 20);
            this.label3.TabIndex = 13;
            this.label3.Text = "Select Date";
            // 
            // dtpToday
            // 
            this.dtpToday.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpToday.Location = new System.Drawing.Point(370, 98);
            this.dtpToday.Name = "dtpToday";
            this.dtpToday.Size = new System.Drawing.Size(230, 28);
            this.dtpToday.TabIndex = 12;
            // 
            // txtTeacher
            // 
            this.txtTeacher.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtTeacher.ForeColor = System.Drawing.Color.White;
            this.txtTeacher.Location = new System.Drawing.Point(370, 37);
            this.txtTeacher.Name = "txtTeacher";
            this.txtTeacher.ReadOnly = true;
            this.txtTeacher.Size = new System.Drawing.Size(230, 28);
            this.txtTeacher.TabIndex = 11;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(367, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 20);
            this.label2.TabIndex = 10;
            this.label2.Text = "Teacher";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(42, 78);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(65, 20);
            this.label1.TabIndex = 9;
            this.label1.Text = "Course";
            // 
            // lblBatch
            // 
            this.lblBatch.AutoSize = true;
            this.lblBatch.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBatch.ForeColor = System.Drawing.Color.White;
            this.lblBatch.Location = new System.Drawing.Point(42, 14);
            this.lblBatch.Name = "lblBatch";
            this.lblBatch.Size = new System.Drawing.Size(112, 20);
            this.lblBatch.TabIndex = 8;
            this.lblBatch.Text = "Select Batch";
            // 
            // cmbBatch
            // 
            this.cmbBatch.AllowDrop = true;
            this.cmbBatch.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbBatch.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbBatch.ForeColor = System.Drawing.Color.White;
            this.cmbBatch.FormattingEnabled = true;
            this.cmbBatch.Location = new System.Drawing.Point(45, 37);
            this.cmbBatch.Name = "cmbBatch";
            this.cmbBatch.Size = new System.Drawing.Size(248, 28);
            this.cmbBatch.TabIndex = 6;
            this.cmbBatch.SelectedIndexChanged += new System.EventHandler(this.cmbBatch_SelectedIndexChanged);
            // 
            // txtCourse
            // 
            this.txtCourse.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCourse.Location = new System.Drawing.Point(46, 101);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(248, 28);
            this.txtCourse.TabIndex = 5;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.groupBox5);
            this.tabPage2.Controls.Add(this.groupBox4);
            this.tabPage2.Controls.Add(this.groupBox3);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(964, 662);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Attendence Records";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // groupBox5
            // 
            this.groupBox5.Controls.Add(this.btnSearch);
            this.groupBox5.Controls.Add(this.btnCancel);
            this.groupBox5.Location = new System.Drawing.Point(36, 161);
            this.groupBox5.Name = "groupBox5";
            this.groupBox5.Size = new System.Drawing.Size(902, 72);
            this.groupBox5.TabIndex = 12;
            this.groupBox5.TabStop = false;
            // 
            // btnSearch
            // 
            this.btnSearch.Location = new System.Drawing.Point(810, 31);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.Size = new System.Drawing.Size(75, 23);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Text = "Cancel";
            this.btnSearch.UseVisualStyleBackColor = true;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(688, 31);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(75, 23);
            this.btnCancel.TabIndex = 0;
            this.btnCancel.Text = "Search";
            this.btnCancel.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.dataGridView1);
            this.groupBox4.Location = new System.Drawing.Point(36, 239);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(902, 289);
            this.groupBox4.TabIndex = 0;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Student Attendence Record";
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(8, 45);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(877, 211);
            this.dataGridView1.TabIndex = 12;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.comboBox3);
            this.groupBox3.Controls.Add(this.comboBox2);
            this.groupBox3.Controls.Add(this.textBox2);
            this.groupBox3.Location = new System.Drawing.Point(36, 22);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(902, 123);
            this.groupBox3.TabIndex = 0;
            this.groupBox3.TabStop = false;
            // 
            // comboBox3
            // 
            this.comboBox3.AllowDrop = true;
            this.comboBox3.FormattingEnabled = true;
            this.comboBox3.Location = new System.Drawing.Point(381, 27);
            this.comboBox3.Name = "comboBox3";
            this.comboBox3.Size = new System.Drawing.Size(177, 21);
            this.comboBox3.TabIndex = 11;
            this.comboBox3.Text = "Select Batch";
            // 
            // comboBox2
            // 
            this.comboBox2.AllowDrop = true;
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(71, 27);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(177, 21);
            this.comboBox2.TabIndex = 10;
            this.comboBox2.Text = "Select Reg Number";
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(71, 80);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(177, 20);
            this.textBox2.TabIndex = 8;
            this.textBox2.Text = "Select Date";
            // 
            // Attendence
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 680);
            this.ControlBox = false;
            this.Controls.Add(this.tabCtrlAttendence);
            this.Name = "Attendence";
            this.Text = "Attendence_WinForm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Attendence_WinForm_Load);
            this.tabCtrlAttendence.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.grpStudents.ResumeLayout(false);
            this.grpStudents.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.groupBox5.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabCtrlAttendence;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.GroupBox grpStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox cmbBatch;
        private System.Windows.Forms.TextBox txtCourse;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnView;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Label lblBatch;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.DateTimePicker dtpToday;
        private System.Windows.Forms.TextBox txtTeacher;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblIdHeader;
        private System.Windows.Forms.Label lblNameHeader;
        private System.Windows.Forms.Label lblIsAttendHeader;
        private System.Windows.Forms.Label lblSerialHeader;
    }
}