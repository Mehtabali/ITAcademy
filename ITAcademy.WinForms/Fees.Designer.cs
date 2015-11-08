namespace ITAcademy.WinForms
{
    partial class Fee
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
            this.tabFees = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpCurrent = new System.Windows.Forms.GroupBox();
            this.btnCreate = new System.Windows.Forms.Button();
            this.txtAmount = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.txtCourses = new System.Windows.Forms.TextBox();
            this.cmbMonth = new System.Windows.Forms.ComboBox();
            this.txtMonth = new System.Windows.Forms.TextBox();
            this.cmbYear = new System.Windows.Forms.ComboBox();
            this.txtStudent = new System.Windows.Forms.TextBox();
            this.cmbStudent = new System.Windows.Forms.ComboBox();
            this.txtYear = new System.Windows.Forms.TextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.grpPrevious = new System.Windows.Forms.GroupBox();
            this.dgvList = new System.Windows.Forms.DataGridView();
            this.ClmStudentName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmMonth = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmYear = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmAmount = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.clmCourse = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPage3 = new System.Windows.Forms.TabPage();
            this.grpUpdateDelete = new System.Windows.Forms.GroupBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.cmbCrse = new System.Windows.Forms.ComboBox();
            this.cmbYr = new System.Windows.Forms.ComboBox();
            this.cmbMnth = new System.Windows.Forms.ComboBox();
            this.cmbStd = new System.Windows.Forms.ComboBox();
            this.txtAmnt = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCourse = new System.Windows.Forms.TextBox();
            this.tabFees.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpCurrent.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.grpPrevious.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).BeginInit();
            this.tabPage3.SuspendLayout();
            this.grpUpdateDelete.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabFees
            // 
            this.tabFees.Controls.Add(this.tabPage1);
            this.tabFees.Controls.Add(this.tabPage2);
            this.tabFees.Controls.Add(this.tabPage3);
            this.tabFees.Location = new System.Drawing.Point(0, 2);
            this.tabFees.Name = "tabFees";
            this.tabFees.SelectedIndex = 0;
            this.tabFees.Size = new System.Drawing.Size(953, 520);
            this.tabFees.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpCurrent);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(945, 494);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "tabPage1";
            this.tabPage1.UseVisualStyleBackColor = true;
            this.tabPage1.Click += new System.EventHandler(this.tabPage1_Click);
            // 
            // grpCurrent
            // 
            this.grpCurrent.Controls.Add(this.txtCourse);
            this.grpCurrent.Controls.Add(this.btnCreate);
            this.grpCurrent.Controls.Add(this.txtAmount);
            this.grpCurrent.Controls.Add(this.textBox1);
            this.grpCurrent.Controls.Add(this.txtCourses);
            this.grpCurrent.Controls.Add(this.cmbMonth);
            this.grpCurrent.Controls.Add(this.txtMonth);
            this.grpCurrent.Controls.Add(this.cmbYear);
            this.grpCurrent.Controls.Add(this.txtStudent);
            this.grpCurrent.Controls.Add(this.cmbStudent);
            this.grpCurrent.Controls.Add(this.txtYear);
            this.grpCurrent.Location = new System.Drawing.Point(18, 14);
            this.grpCurrent.Name = "grpCurrent";
            this.grpCurrent.Size = new System.Drawing.Size(848, 199);
            this.grpCurrent.TabIndex = 8;
            this.grpCurrent.TabStop = false;
            this.grpCurrent.Text = "Current Fee Record";
            this.grpCurrent.Enter += new System.EventHandler(this.grpCurrent_Enter);
            // 
            // btnCreate
            // 
            this.btnCreate.Location = new System.Drawing.Point(414, 115);
            this.btnCreate.Name = "btnCreate";
            this.btnCreate.Size = new System.Drawing.Size(153, 23);
            this.btnCreate.TabIndex = 12;
            this.btnCreate.Text = "Create Record";
            this.btnCreate.UseVisualStyleBackColor = true;
            this.btnCreate.Click += new System.EventHandler(this.btnCreate_Click);
            // 
            // txtAmount
            // 
            this.txtAmount.Location = new System.Drawing.Point(530, 58);
            this.txtAmount.Name = "txtAmount";
            this.txtAmount.ReadOnly = true;
            this.txtAmount.Size = new System.Drawing.Size(134, 20);
            this.txtAmount.TabIndex = 11;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(414, 58);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 10;
            this.textBox1.Text = "Amount";
            // 
            // txtCourses
            // 
            this.txtCourses.Location = new System.Drawing.Point(414, 20);
            this.txtCourses.Name = "txtCourses";
            this.txtCourses.Size = new System.Drawing.Size(100, 20);
            this.txtCourses.TabIndex = 8;
            this.txtCourses.Text = "Courses";
            // 
            // cmbMonth
            // 
            this.cmbMonth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMonth.FormattingEnabled = true;
            this.cmbMonth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April ",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMonth.Location = new System.Drawing.Point(133, 57);
            this.cmbMonth.Name = "cmbMonth";
            this.cmbMonth.Size = new System.Drawing.Size(134, 21);
            this.cmbMonth.TabIndex = 3;
            // 
            // txtMonth
            // 
            this.txtMonth.Location = new System.Drawing.Point(6, 56);
            this.txtMonth.Name = "txtMonth";
            this.txtMonth.Size = new System.Drawing.Size(112, 20);
            this.txtMonth.TabIndex = 2;
            this.txtMonth.Text = "Month";
            // 
            // cmbYear
            // 
            this.cmbYear.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYear.FormattingEnabled = true;
            this.cmbYear.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYear.Location = new System.Drawing.Point(133, 92);
            this.cmbYear.Name = "cmbYear";
            this.cmbYear.Size = new System.Drawing.Size(134, 21);
            this.cmbYear.TabIndex = 5;
            // 
            // txtStudent
            // 
            this.txtStudent.Location = new System.Drawing.Point(6, 19);
            this.txtStudent.Name = "txtStudent";
            this.txtStudent.Size = new System.Drawing.Size(112, 20);
            this.txtStudent.TabIndex = 1;
            this.txtStudent.Text = "Student Name";
            // 
            // cmbStudent
            // 
            this.cmbStudent.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStudent.FormattingEnabled = true;
            this.cmbStudent.Location = new System.Drawing.Point(133, 19);
            this.cmbStudent.Name = "cmbStudent";
            this.cmbStudent.Size = new System.Drawing.Size(134, 21);
            this.cmbStudent.TabIndex = 0;
            this.cmbStudent.SelectedIndexChanged += new System.EventHandler(this.cmbStudent_SelectedIndexChanged);
            // 
            // txtYear
            // 
            this.txtYear.Location = new System.Drawing.Point(6, 93);
            this.txtYear.Name = "txtYear";
            this.txtYear.Size = new System.Drawing.Size(112, 20);
            this.txtYear.TabIndex = 4;
            this.txtYear.Text = "Year";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.grpPrevious);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(945, 494);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "tabPage2";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // grpPrevious
            // 
            this.grpPrevious.Controls.Add(this.dgvList);
            this.grpPrevious.Location = new System.Drawing.Point(26, 40);
            this.grpPrevious.Name = "grpPrevious";
            this.grpPrevious.Size = new System.Drawing.Size(860, 349);
            this.grpPrevious.TabIndex = 8;
            this.grpPrevious.TabStop = false;
            this.grpPrevious.Text = "Previous Fee Records";
            // 
            // dgvList
            // 
            this.dgvList.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.dgvList.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvList.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ClmStudentName,
            this.clmMonth,
            this.clmYear,
            this.clmAmount,
            this.clmCourse});
            this.dgvList.Location = new System.Drawing.Point(107, 22);
            this.dgvList.Name = "dgvList";
            this.dgvList.Size = new System.Drawing.Size(647, 305);
            this.dgvList.TabIndex = 8;
            this.dgvList.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellContentClick);
            this.dgvList.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvList_CellDoubleClick);
            // 
            // ClmStudentName
            // 
            this.ClmStudentName.DataPropertyName = "StudentName";
            this.ClmStudentName.HeaderText = "Student Name";
            this.ClmStudentName.Name = "ClmStudentName";
            // 
            // clmMonth
            // 
            this.clmMonth.DataPropertyName = "Month";
            this.clmMonth.HeaderText = "Month";
            this.clmMonth.Name = "clmMonth";
            // 
            // clmYear
            // 
            this.clmYear.DataPropertyName = "Year";
            this.clmYear.HeaderText = "Year";
            this.clmYear.Name = "clmYear";
            // 
            // clmAmount
            // 
            this.clmAmount.DataPropertyName = "Amount";
            this.clmAmount.HeaderText = "Amount";
            this.clmAmount.Name = "clmAmount";
            // 
            // clmCourse
            // 
            this.clmCourse.DataPropertyName = "CourseName";
            this.clmCourse.HeaderText = "Course";
            this.clmCourse.Name = "clmCourse";
            // 
            // tabPage3
            // 
            this.tabPage3.Controls.Add(this.grpUpdateDelete);
            this.tabPage3.Location = new System.Drawing.Point(4, 22);
            this.tabPage3.Name = "tabPage3";
            this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage3.Size = new System.Drawing.Size(945, 494);
            this.tabPage3.TabIndex = 2;
            this.tabPage3.Text = "tabPage3";
            this.tabPage3.UseVisualStyleBackColor = true;
            // 
            // grpUpdateDelete
            // 
            this.grpUpdateDelete.Controls.Add(this.btnDelete);
            this.grpUpdateDelete.Controls.Add(this.btnUpdate);
            this.grpUpdateDelete.Controls.Add(this.cmbCrse);
            this.grpUpdateDelete.Controls.Add(this.cmbYr);
            this.grpUpdateDelete.Controls.Add(this.cmbMnth);
            this.grpUpdateDelete.Controls.Add(this.cmbStd);
            this.grpUpdateDelete.Controls.Add(this.txtAmnt);
            this.grpUpdateDelete.Controls.Add(this.label5);
            this.grpUpdateDelete.Controls.Add(this.label4);
            this.grpUpdateDelete.Controls.Add(this.label3);
            this.grpUpdateDelete.Controls.Add(this.label2);
            this.grpUpdateDelete.Controls.Add(this.label1);
            this.grpUpdateDelete.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpUpdateDelete.Location = new System.Drawing.Point(56, 46);
            this.grpUpdateDelete.Name = "grpUpdateDelete";
            this.grpUpdateDelete.Size = new System.Drawing.Size(549, 231);
            this.grpUpdateDelete.TabIndex = 0;
            this.grpUpdateDelete.TabStop = false;
            this.grpUpdateDelete.Text = "Update/Delete Record";
            this.grpUpdateDelete.Enter += new System.EventHandler(this.grpUpdateDelete_Enter);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(383, 180);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 15;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(287, 180);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 14;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // cmbCrse
            // 
            this.cmbCrse.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbCrse.FormattingEnabled = true;
            this.cmbCrse.Location = new System.Drawing.Point(287, 60);
            this.cmbCrse.Name = "cmbCrse";
            this.cmbCrse.Size = new System.Drawing.Size(121, 21);
            this.cmbCrse.TabIndex = 13;
            this.cmbCrse.SelectedIndexChanged += new System.EventHandler(this.cmbCrse_SelectedIndexChanged);
            // 
            // cmbYr
            // 
            this.cmbYr.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbYr.FormattingEnabled = true;
            this.cmbYr.Items.AddRange(new object[] {
            "2010",
            "2011",
            "2012",
            "2013",
            "2014",
            "2015",
            "2016",
            "2017",
            "2018",
            "2019",
            "2020",
            "2021",
            "2022",
            "2023",
            "2024",
            "2025"});
            this.cmbYr.Location = new System.Drawing.Point(23, 180);
            this.cmbYr.Name = "cmbYr";
            this.cmbYr.Size = new System.Drawing.Size(121, 21);
            this.cmbYr.TabIndex = 12;
            // 
            // cmbMnth
            // 
            this.cmbMnth.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbMnth.FormattingEnabled = true;
            this.cmbMnth.Items.AddRange(new object[] {
            "January",
            "February",
            "March",
            "April ",
            "May ",
            "June",
            "July",
            "August",
            "September",
            "October",
            "November",
            "December"});
            this.cmbMnth.Location = new System.Drawing.Point(23, 125);
            this.cmbMnth.Name = "cmbMnth";
            this.cmbMnth.Size = new System.Drawing.Size(121, 21);
            this.cmbMnth.TabIndex = 11;
            // 
            // cmbStd
            // 
            this.cmbStd.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbStd.FormattingEnabled = true;
            this.cmbStd.Location = new System.Drawing.Point(23, 60);
            this.cmbStd.Name = "cmbStd";
            this.cmbStd.Size = new System.Drawing.Size(121, 21);
            this.cmbStd.TabIndex = 10;
            this.cmbStd.SelectedIndexChanged += new System.EventHandler(this.cmbStd_SelectedIndexChanged);
            // 
            // txtAmnt
            // 
            this.txtAmnt.Location = new System.Drawing.Point(290, 126);
            this.txtAmnt.Name = "txtAmnt";
            this.txtAmnt.Size = new System.Drawing.Size(100, 20);
            this.txtAmnt.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(287, 102);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(43, 13);
            this.label5.TabIndex = 8;
            this.label5.Text = "Amount";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(284, 35);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(71, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Course Name";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(20, 164);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(29, 13);
            this.label3.TabIndex = 4;
            this.label3.Text = "Year";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(20, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(37, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Month";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(20, 35);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Student Name";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtCourse
            // 
            this.txtCourse.Location = new System.Drawing.Point(530, 19);
            this.txtCourse.Name = "txtCourse";
            this.txtCourse.ReadOnly = true;
            this.txtCourse.Size = new System.Drawing.Size(134, 20);
            this.txtCourse.TabIndex = 13;
            // 
            // Fee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 573);
            this.Controls.Add(this.tabFees);
            this.Name = "Fee";
            this.Text = "Fees_WinForm";
            this.Load += new System.EventHandler(this.Fees_Load);
            this.tabFees.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.grpCurrent.ResumeLayout(false);
            this.grpCurrent.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.grpPrevious.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvList)).EndInit();
            this.tabPage3.ResumeLayout(false);
            this.grpUpdateDelete.ResumeLayout(false);
            this.grpUpdateDelete.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabFees;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.ComboBox cmbStudent;
        private System.Windows.Forms.TextBox txtStudent;
        private System.Windows.Forms.ComboBox cmbYear;
        private System.Windows.Forms.TextBox txtYear;
        private System.Windows.Forms.ComboBox cmbMonth;
        private System.Windows.Forms.TextBox txtMonth;
        //  private ITAcademyDatabaseDataSet iTAcademyDatabaseDataSet;
        private System.Windows.Forms.GroupBox grpCurrent;
        private System.Windows.Forms.TextBox txtCourses;
        private System.Windows.Forms.TextBox txtAmount;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnCreate;
        private System.Windows.Forms.GroupBox grpPrevious;
        private System.Windows.Forms.DataGridView dgvList;
        private System.Windows.Forms.TabPage tabPage3;
        private System.Windows.Forms.GroupBox grpUpdateDelete;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtAmnt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ComboBox cmbStd;
        private System.Windows.Forms.ComboBox cmbCrse;
        private System.Windows.Forms.ComboBox cmbYr;
        private System.Windows.Forms.ComboBox cmbMnth;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.DataGridViewTextBoxColumn ClmStudentName;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmMonth;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmYear;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmAmount;
        private System.Windows.Forms.DataGridViewTextBoxColumn clmCourse;
        private System.Windows.Forms.TextBox txtCourse;
        //  private ITAcademyDatabaseDataSetTableAdapters.FeesTableAdapter feesTableAdapter;
    }
}