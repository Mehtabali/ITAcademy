namespace ITAcademy.WinForms
{
    partial class Attendence_WinForm
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
            this.btnSearch1 = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.gridStudents = new System.Windows.Forms.DataGridView();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.comboBox4 = new System.Windows.Forms.ComboBox();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.txtTodayDate = new System.Windows.Forms.TextBox();
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
            this.groupBox2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).BeginInit();
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
            this.tabCtrlAttendence.Size = new System.Drawing.Size(972, 688);
            this.tabCtrlAttendence.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.groupBox6);
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(964, 662);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Attendence Sheet";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox6
            // 
            this.groupBox6.Controls.Add(this.btnCancel1);
            this.groupBox6.Controls.Add(this.btnSearch1);
            this.groupBox6.Location = new System.Drawing.Point(143, 179);
            this.groupBox6.Name = "groupBox6";
            this.groupBox6.Size = new System.Drawing.Size(695, 72);
            this.groupBox6.TabIndex = 13;
            this.groupBox6.TabStop = false;
            // 
            // btnCancel1
            // 
            this.btnCancel1.Location = new System.Drawing.Point(548, 31);
            this.btnCancel1.Name = "btnCancel1";
            this.btnCancel1.Size = new System.Drawing.Size(75, 23);
            this.btnCancel1.TabIndex = 1;
            this.btnCancel1.Text = "Cancel";
            this.btnCancel1.UseVisualStyleBackColor = true;
            // 
            // btnSearch1
            // 
            this.btnSearch1.Location = new System.Drawing.Point(431, 31);
            this.btnSearch1.Name = "btnSearch1";
            this.btnSearch1.Size = new System.Drawing.Size(75, 23);
            this.btnSearch1.TabIndex = 0;
            this.btnSearch1.Text = "View";
            this.btnSearch1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.gridStudents);
            this.groupBox2.Location = new System.Drawing.Point(143, 274);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(695, 335);
            this.groupBox2.TabIndex = 0;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Students in this Batch";
            // 
            // gridStudents
            // 
            this.gridStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.gridStudents.Location = new System.Drawing.Point(18, 19);
            this.gridStudents.Name = "gridStudents";
            this.gridStudents.Size = new System.Drawing.Size(649, 272);
            this.gridStudents.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.comboBox4);
            this.groupBox1.Controls.Add(this.comboBox1);
            this.groupBox1.Controls.Add(this.textBox6);
            this.groupBox1.Controls.Add(this.txtTodayDate);
            this.groupBox1.Location = new System.Drawing.Point(143, 21);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(695, 152);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // comboBox4
            // 
            this.comboBox4.AllowDrop = true;
            this.comboBox4.FormattingEnabled = true;
            this.comboBox4.Location = new System.Drawing.Point(370, 19);
            this.comboBox4.Name = "comboBox4";
            this.comboBox4.Size = new System.Drawing.Size(177, 21);
            this.comboBox4.TabIndex = 7;
            this.comboBox4.Text = "Select Teacher ";
            // 
            // comboBox1
            // 
            this.comboBox1.AllowDrop = true;
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(45, 18);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(177, 21);
            this.comboBox1.TabIndex = 6;
            this.comboBox1.Text = "Select Batch";
            // 
            // textBox6
            // 
            this.textBox6.Location = new System.Drawing.Point(45, 66);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(177, 20);
            this.textBox6.TabIndex = 5;
            this.textBox6.Text = "Select Course";
            // 
            // txtTodayDate
            // 
            this.txtTodayDate.Location = new System.Drawing.Point(370, 66);
            this.txtTodayDate.Name = "txtTodayDate";
            this.txtTodayDate.ReadOnly = true;
            this.txtTodayDate.Size = new System.Drawing.Size(177, 20);
            this.txtTodayDate.TabIndex = 4;
            this.txtTodayDate.TextChanged += new System.EventHandler(this.txtAttenenceDate_TextChanged);
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
            // Attendence_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(984, 750);
            this.Controls.Add(this.tabCtrlAttendence);
            this.Name = "Attendence_WinForm";
            this.Text = "Attendence_WinForm";
            this.Load += new System.EventHandler(this.Attendence_WinForm_Load);
            this.tabCtrlAttendence.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.groupBox6.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.gridStudents)).EndInit();
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
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.DataGridView gridStudents;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.ComboBox comboBox3;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.GroupBox groupBox6;
        private System.Windows.Forms.Button btnCancel1;
        private System.Windows.Forms.Button btnSearch1;
        private System.Windows.Forms.GroupBox groupBox5;
        private System.Windows.Forms.Button btnSearch;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.TextBox txtTodayDate;
        private System.Windows.Forms.ComboBox comboBox4;
    }
}