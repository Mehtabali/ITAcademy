namespace ITAcademy.WinForms
{
    partial class Students
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
            this.tabStudent = new System.Windows.Forms.TabControl();
            this.tabPageView = new System.Windows.Forms.TabPage();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.dgvUpdate = new System.Windows.Forms.DataGridView();
            this.dgvAllStudents = new System.Windows.Forms.DataGridView();
            this.colId = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colGender = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tabPageUpdate = new System.Windows.Forms.TabPage();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.btnDelete = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.dtpudAdmission = new System.Windows.Forms.DateTimePicker();
            this.cmbudGender = new System.Windows.Forms.ComboBox();
            this.txtRegNum = new System.Windows.Forms.TextBox();
            this.txtNameud = new System.Windows.Forms.TextBox();
            this.txtudDob = new System.Windows.Forms.TextBox();
            this.txtudEmail = new System.Windows.Forms.TextBox();
            this.txtudPin = new System.Windows.Forms.TextBox();
            this.txtudCity = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label20 = new System.Windows.Forms.Label();
            this.label21 = new System.Windows.Forms.Label();
            this.txtudContact = new System.Windows.Forms.TextBox();
            this.txtudFather = new System.Windows.Forms.TextBox();
            this.txtudAddress = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.linkLabel3 = new System.Windows.Forms.LinkLabel();
            this.linkLabel4 = new System.Windows.Forms.LinkLabel();
            this.button1 = new System.Windows.Forms.Button();
            this.tabStudent.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabPageView);
            this.tabStudent.Controls.Add(this.tabPageUpdate);
            this.tabStudent.Location = new System.Drawing.Point(0, 0);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(1365, 668);
            this.tabStudent.TabIndex = 0;
            // 
            // tabPageView
            // 
            this.tabPageView.BackColor = System.Drawing.Color.DimGray;
            this.tabPageView.Controls.Add(this.button1);
            this.tabPageView.Controls.Add(this.textBox3);
            this.tabPageView.Controls.Add(this.textBox2);
            this.tabPageView.Controls.Add(this.textBox1);
            this.tabPageView.Controls.Add(this.dgvUpdate);
            this.tabPageView.Controls.Add(this.dgvAllStudents);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1357, 642);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "View All";
            // 
            // textBox3
            // 
            this.textBox3.Location = new System.Drawing.Point(200, 254);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(100, 20);
            this.textBox3.TabIndex = 4;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(200, 305);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(100, 20);
            this.textBox2.TabIndex = 3;
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(200, 205);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(100, 20);
            this.textBox1.TabIndex = 2;
            // 
            // dgvUpdate
            // 
            this.dgvUpdate.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvUpdate.Location = new System.Drawing.Point(3, 37);
            this.dgvUpdate.Name = "dgvUpdate";
            this.dgvUpdate.Size = new System.Drawing.Size(240, 150);
            this.dgvUpdate.TabIndex = 1;
            this.dgvUpdate.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvUpdate_CellClick);
            this.dgvUpdate.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStudents_CellDoubleClick);
            // 
            // dgvAllStudents
            // 
            this.dgvAllStudents.AllowUserToAddRows = false;
            this.dgvAllStudents.AllowUserToDeleteRows = false;
            this.dgvAllStudents.AllowUserToResizeRows = false;
            this.dgvAllStudents.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvAllStudents.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colId,
            this.colName,
            this.colMobile,
            this.colEmail,
            this.colFatherName,
            this.colGender,
            this.colAddress,
            this.colCity,
            this.colPin,
            this.colDob});
            this.dgvAllStudents.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvAllStudents.Location = new System.Drawing.Point(711, 78);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStudents.ShowCellErrors = false;
            this.dgvAllStudents.ShowEditingIcon = false;
            this.dgvAllStudents.ShowRowErrors = false;
            this.dgvAllStudents.Size = new System.Drawing.Size(515, 278);
            this.dgvAllStudents.TabIndex = 1;
            this.dgvAllStudents.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStudents_CellDoubleClick);
            // 
            // colId
            // 
            this.colId.DataPropertyName = "Id";
            this.colId.HeaderText = "Id";
            this.colId.Name = "colId";
            this.colId.Visible = false;
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colFatherName
            // 
            this.colFatherName.DataPropertyName = "FatherName";
            this.colFatherName.HeaderText = "Father Name";
            this.colFatherName.Name = "colFatherName";
            // 
            // colGender
            // 
            this.colGender.DataPropertyName = "Gender";
            this.colGender.HeaderText = "Gender";
            this.colGender.Name = "colGender";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            // 
            // colPin
            // 
            this.colPin.DataPropertyName = "PIN";
            this.colPin.HeaderText = "PIN";
            this.colPin.Name = "colPin";
            // 
            // colDob
            // 
            this.colDob.DataPropertyName = "DOB";
            this.colDob.HeaderText = "DOB";
            this.colDob.Name = "colDob";
            // 
            // tabPageUpdate
            // 
            this.tabPageUpdate.BackColor = System.Drawing.Color.DimGray;
            this.tabPageUpdate.Controls.Add(this.groupBox4);
            this.tabPageUpdate.Controls.Add(this.groupBox2);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(1357, 642);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update/Delete";
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.ForeColor = System.Drawing.Color.Black;
            this.groupBox4.Location = new System.Drawing.Point(319, 550);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 67);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(501, 27);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 30);
            this.btnUpdate.TabIndex = 13;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(620, 27);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 30);
            this.btnDelete.TabIndex = 14;
            this.btnDelete.Text = "Delete";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.dtpudAdmission);
            this.groupBox2.Controls.Add(this.cmbudGender);
            this.groupBox2.Controls.Add(this.txtRegNum);
            this.groupBox2.Controls.Add(this.txtNameud);
            this.groupBox2.Controls.Add(this.txtudDob);
            this.groupBox2.Controls.Add(this.txtudEmail);
            this.groupBox2.Controls.Add(this.txtudPin);
            this.groupBox2.Controls.Add(this.txtudCity);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label12);
            this.groupBox2.Controls.Add(this.label15);
            this.groupBox2.Controls.Add(this.label16);
            this.groupBox2.Controls.Add(this.label17);
            this.groupBox2.Controls.Add(this.label18);
            this.groupBox2.Controls.Add(this.label19);
            this.groupBox2.Controls.Add(this.label20);
            this.groupBox2.Controls.Add(this.label21);
            this.groupBox2.Controls.Add(this.txtudContact);
            this.groupBox2.Controls.Add(this.txtudFather);
            this.groupBox2.Controls.Add(this.txtudAddress);
            this.groupBox2.Controls.Add(this.groupBox3);
            this.groupBox2.Font = new System.Drawing.Font("Lucida Handwriting", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox2.ForeColor = System.Drawing.Color.Black;
            this.groupBox2.Location = new System.Drawing.Point(319, 115);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 429);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admission Form";
            // 
            // dtpudAdmission
            // 
            this.dtpudAdmission.Location = new System.Drawing.Point(454, 388);
            this.dtpudAdmission.Name = "dtpudAdmission";
            this.dtpudAdmission.Size = new System.Drawing.Size(249, 28);
            this.dtpudAdmission.TabIndex = 12;
            // 
            // cmbudGender
            // 
            this.cmbudGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbudGender.ForeColor = System.Drawing.Color.White;
            this.cmbudGender.FormattingEnabled = true;
            this.cmbudGender.Location = new System.Drawing.Point(455, 280);
            this.cmbudGender.Name = "cmbudGender";
            this.cmbudGender.Size = new System.Drawing.Size(249, 28);
            this.cmbudGender.TabIndex = 10;
            // 
            // txtRegNum
            // 
            this.txtRegNum.ForeColor = System.Drawing.Color.White;
            this.txtRegNum.Location = new System.Drawing.Point(33, 76);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(234, 28);
            this.txtRegNum.TabIndex = 1;
            // 
            // txtNameud
            // 
            this.txtNameud.ForeColor = System.Drawing.Color.White;
            this.txtNameud.Location = new System.Drawing.Point(33, 130);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(234, 28);
            this.txtNameud.TabIndex = 2;
            // 
            // txtudDob
            // 
            this.txtudDob.ForeColor = System.Drawing.Color.White;
            this.txtudDob.Location = new System.Drawing.Point(33, 184);
            this.txtudDob.Name = "txtudDob";
            this.txtudDob.Size = new System.Drawing.Size(234, 28);
            this.txtudDob.TabIndex = 3;
            // 
            // txtudEmail
            // 
            this.txtudEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudEmail.Location = new System.Drawing.Point(34, 391);
            this.txtudEmail.Name = "txtudEmail";
            this.txtudEmail.Size = new System.Drawing.Size(234, 28);
            this.txtudEmail.TabIndex = 7;
            // 
            // txtudPin
            // 
            this.txtudPin.ForeColor = System.Drawing.Color.White;
            this.txtudPin.Location = new System.Drawing.Point(455, 226);
            this.txtudPin.Name = "txtudPin";
            this.txtudPin.Size = new System.Drawing.Size(249, 28);
            this.txtudPin.TabIndex = 9;
            // 
            // txtudCity
            // 
            this.txtudCity.ForeColor = System.Drawing.Color.White;
            this.txtudCity.Location = new System.Drawing.Point(454, 334);
            this.txtudCity.Name = "txtudCity";
            this.txtudCity.Size = new System.Drawing.Size(249, 28);
            this.txtudCity.TabIndex = 11;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(34, 371);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 20);
            this.label1.TabIndex = 43;
            this.label1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(457, 203);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 20);
            this.label4.TabIndex = 42;
            this.label4.Text = "Pin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(450, 365);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(142, 20);
            this.label5.TabIndex = 41;
            this.label5.Text = "Admission Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.Color.White;
            this.label12.Location = new System.Drawing.Point(451, 257);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(70, 20);
            this.label12.TabIndex = 40;
            this.label12.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.Color.White;
            this.label15.Location = new System.Drawing.Point(457, 311);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(43, 20);
            this.label15.TabIndex = 39;
            this.label15.Text = "City";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.Color.White;
            this.label16.Location = new System.Drawing.Point(30, 53);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(189, 20);
            this.label16.TabIndex = 38;
            this.label16.Text = "Registration Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.Color.White;
            this.label17.Location = new System.Drawing.Point(33, 269);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(149, 20);
            this.label17.TabIndex = 37;
            this.label17.Text = "Contact Number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.Color.White;
            this.label18.Location = new System.Drawing.Point(29, 107);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(63, 20);
            this.label18.TabIndex = 36;
            this.label18.Text = " Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.Color.White;
            this.label19.Location = new System.Drawing.Point(30, 161);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(122, 20);
            this.label19.TabIndex = 35;
            this.label19.Text = "Date Of Birth";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.Color.White;
            this.label20.Location = new System.Drawing.Point(30, 215);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(73, 20);
            this.label20.TabIndex = 34;
            this.label20.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.Color.White;
            this.label21.Location = new System.Drawing.Point(33, 321);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(119, 20);
            this.label21.TabIndex = 33;
            this.label21.Text = "Father Name";
            // 
            // txtudContact
            // 
            this.txtudContact.ForeColor = System.Drawing.Color.White;
            this.txtudContact.Location = new System.Drawing.Point(33, 292);
            this.txtudContact.Name = "txtudContact";
            this.txtudContact.Size = new System.Drawing.Size(234, 28);
            this.txtudContact.TabIndex = 5;
            // 
            // txtudFather
            // 
            this.txtudFather.ForeColor = System.Drawing.Color.White;
            this.txtudFather.Location = new System.Drawing.Point(34, 345);
            this.txtudFather.Name = "txtudFather";
            this.txtudFather.Size = new System.Drawing.Size(234, 28);
            this.txtudFather.TabIndex = 6;
            // 
            // txtudAddress
            // 
            this.txtudAddress.ForeColor = System.Drawing.Color.White;
            this.txtudAddress.Location = new System.Drawing.Point(34, 238);
            this.txtudAddress.Name = "txtudAddress";
            this.txtudAddress.Size = new System.Drawing.Size(234, 28);
            this.txtudAddress.TabIndex = 4;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.linkLabel4);
            this.groupBox3.ForeColor = System.Drawing.Color.White;
            this.groupBox3.Location = new System.Drawing.Point(454, 53);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 147);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Photo";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(149, 105);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(55, 20);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Zoom";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(6, 105);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(119, 20);
            this.linkLabel4.TabIndex = 8;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Browse Photo";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(200, 348);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 5;
            this.button1.Text = "button1";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1368, 680);
            this.ControlBox = false;
            this.Controls.Add(this.tabStudent);
            this.Name = "Students";
            this.Text = "Students";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Students_Load);
            this.tabStudent.ResumeLayout(false);
            this.tabPageView.ResumeLayout(false);
            this.tabPageView.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvUpdate)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.tabPageUpdate.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabStudent;
        private System.Windows.Forms.DataGridView dgvAllStudents;
        private System.Windows.Forms.DataGridViewTextBoxColumn colId;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colGender;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDob;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.TextBox txtRegNum;
        private System.Windows.Forms.TextBox txtNameud;
        private System.Windows.Forms.TextBox txtudDob;
        private System.Windows.Forms.TextBox txtudEmail;
        private System.Windows.Forms.TextBox txtudPin;
        private System.Windows.Forms.TextBox txtudCity;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label20;
        private System.Windows.Forms.Label label21;
        private System.Windows.Forms.TextBox txtudContact;
        private System.Windows.Forms.TextBox txtudFather;
        private System.Windows.Forms.TextBox txtudAddress;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.LinkLabel linkLabel3;
        private System.Windows.Forms.LinkLabel linkLabel4;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TabPage tabPageView;
        public System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.ComboBox cmbudGender;
        private System.Windows.Forms.DateTimePicker dtpudAdmission;
        private System.Windows.Forms.DataGridView dgvUpdate;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
    }
}