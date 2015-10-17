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
            this.tabpageAdmission = new System.Windows.Forms.TabPage();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.btnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpWholeAdmissionForm = new System.Windows.Forms.GroupBox();
            this.dtpAdmission = new System.Windows.Forms.DateTimePicker();
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblRegistration = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.tabPageView = new System.Windows.Forms.TabPage();
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
            this.tabStudent.SuspendLayout();
            this.tabpageAdmission.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpWholeAdmissionForm.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPageView.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.tabPageUpdate.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabStudent
            // 
            this.tabStudent.Controls.Add(this.tabpageAdmission);
            this.tabStudent.Controls.Add(this.tabPageView);
            this.tabStudent.Controls.Add(this.tabPageUpdate);
            this.tabStudent.Location = new System.Drawing.Point(0, 0);
            this.tabStudent.Name = "tabStudent";
            this.tabStudent.SelectedIndex = 0;
            this.tabStudent.Size = new System.Drawing.Size(1154, 547);
            this.tabStudent.TabIndex = 0;
            // 
            // tabpageAdmission
            // 
            this.tabpageAdmission.Controls.Add(this.grpButtons);
            this.tabpageAdmission.Controls.Add(this.grpWholeAdmissionForm);
            this.tabpageAdmission.Location = new System.Drawing.Point(4, 22);
            this.tabpageAdmission.Name = "tabpageAdmission";
            this.tabpageAdmission.Padding = new System.Windows.Forms.Padding(3);
            this.tabpageAdmission.Size = new System.Drawing.Size(1146, 521);
            this.tabpageAdmission.TabIndex = 0;
            this.tabpageAdmission.Text = "Admission";
            this.tabpageAdmission.UseVisualStyleBackColor = true;
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.btnSave);
            this.grpButtons.Controls.Add(this.btnReset);
            this.grpButtons.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpButtons.Location = new System.Drawing.Point(144, 446);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(745, 47);
            this.grpButtons.TabIndex = 31;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Actions";
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(500, 19);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(88, 22);
            this.btnSave.TabIndex = 27;
            this.btnSave.Text = "Save";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(619, 19);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(84, 22);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            // 
            // grpWholeAdmissionForm
            // 
            this.grpWholeAdmissionForm.Controls.Add(this.dtpAdmission);
            this.grpWholeAdmissionForm.Controls.Add(this.txtRegistrationNumber);
            this.grpWholeAdmissionForm.Controls.Add(this.txtName);
            this.grpWholeAdmissionForm.Controls.Add(this.txtDob);
            this.grpWholeAdmissionForm.Controls.Add(this.cmbGender);
            this.grpWholeAdmissionForm.Controls.Add(this.txtEmail);
            this.grpWholeAdmissionForm.Controls.Add(this.txtPin);
            this.grpWholeAdmissionForm.Controls.Add(this.txtCity);
            this.grpWholeAdmissionForm.Controls.Add(this.label13);
            this.grpWholeAdmissionForm.Controls.Add(this.label11);
            this.grpWholeAdmissionForm.Controls.Add(this.label10);
            this.grpWholeAdmissionForm.Controls.Add(this.label3);
            this.grpWholeAdmissionForm.Controls.Add(this.label2);
            this.grpWholeAdmissionForm.Controls.Add(this.lblRegistration);
            this.grpWholeAdmissionForm.Controls.Add(this.label14);
            this.grpWholeAdmissionForm.Controls.Add(this.label9);
            this.grpWholeAdmissionForm.Controls.Add(this.label8);
            this.grpWholeAdmissionForm.Controls.Add(this.label7);
            this.grpWholeAdmissionForm.Controls.Add(this.label6);
            this.grpWholeAdmissionForm.Controls.Add(this.txtContactNumber);
            this.grpWholeAdmissionForm.Controls.Add(this.txtFatherName);
            this.grpWholeAdmissionForm.Controls.Add(this.txtAddress);
            this.grpWholeAdmissionForm.Controls.Add(this.groupBox1);
            this.grpWholeAdmissionForm.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.grpWholeAdmissionForm.Location = new System.Drawing.Point(144, 23);
            this.grpWholeAdmissionForm.Name = "grpWholeAdmissionForm";
            this.grpWholeAdmissionForm.Size = new System.Drawing.Size(745, 417);
            this.grpWholeAdmissionForm.TabIndex = 30;
            this.grpWholeAdmissionForm.TabStop = false;
            this.grpWholeAdmissionForm.Text = "Admission Form";
            // 
            // dtpAdmission
            // 
            this.dtpAdmission.Location = new System.Drawing.Point(454, 363);
            this.dtpAdmission.Name = "dtpAdmission";
            this.dtpAdmission.Size = new System.Drawing.Size(249, 20);
            this.dtpAdmission.TabIndex = 49;
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRegistrationNumber.Location = new System.Drawing.Point(33, 66);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(234, 20);
            this.txtRegistrationNumber.TabIndex = 32;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.txtRegistrationNumber_TextChanged);
            // 
            // txtName
            // 
            this.txtName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtName.Location = new System.Drawing.Point(33, 116);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(234, 20);
            this.txtName.TabIndex = 2;
            // 
            // txtDob
            // 
            this.txtDob.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtDob.Location = new System.Drawing.Point(33, 171);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(234, 20);
            this.txtDob.TabIndex = 30;
            // 
            // cmbGender
            // 
            this.cmbGender.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(454, 267);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(249, 21);
            this.cmbGender.TabIndex = 1;
            this.cmbGender.Text = "Select Gender";
            // 
            // txtEmail
            // 
            this.txtEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtEmail.Location = new System.Drawing.Point(33, 363);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(234, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // txtPin
            // 
            this.txtPin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtPin.Location = new System.Drawing.Point(454, 219);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(249, 20);
            this.txtPin.TabIndex = 47;
            // 
            // txtCity
            // 
            this.txtCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtCity.Location = new System.Drawing.Point(454, 313);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(249, 20);
            this.txtCity.TabIndex = 45;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label13.Location = new System.Drawing.Point(36, 347);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label11.Location = new System.Drawing.Point(460, 196);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Pin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label10.Location = new System.Drawing.Point(457, 345);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(80, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Admission Date";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label3.Location = new System.Drawing.Point(456, 249);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Location = new System.Drawing.Point(457, 295);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "City";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.lblRegistration.Location = new System.Drawing.Point(30, 50);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(103, 13);
            this.lblRegistration.TabIndex = 38;
            this.lblRegistration.Text = "Registration Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label14.Location = new System.Drawing.Point(30, 251);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Contact Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label9.Location = new System.Drawing.Point(30, 100);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = " Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label8.Location = new System.Drawing.Point(30, 154);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label7.Location = new System.Drawing.Point(30, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label6.Location = new System.Drawing.Point(30, 297);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Father Name";
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtContactNumber.Location = new System.Drawing.Point(33, 267);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(234, 20);
            this.txtContactNumber.TabIndex = 31;
            // 
            // txtFatherName
            // 
            this.txtFatherName.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtFatherName.Location = new System.Drawing.Point(33, 313);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(234, 20);
            this.txtFatherName.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtAddress.Location = new System.Drawing.Point(33, 219);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(234, 20);
            this.txtAddress.TabIndex = 28;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox1.Location = new System.Drawing.Point(454, 66);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(249, 125);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Photo";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(149, 105);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(34, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Zoom";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 105);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse Photo";
            // 
            // tabPageView
            // 
            this.tabPageView.Controls.Add(this.dgvAllStudents);
            this.tabPageView.Location = new System.Drawing.Point(4, 22);
            this.tabPageView.Name = "tabPageView";
            this.tabPageView.Padding = new System.Windows.Forms.Padding(3);
            this.tabPageView.Size = new System.Drawing.Size(1146, 521);
            this.tabPageView.TabIndex = 1;
            this.tabPageView.Text = "View All";
            this.tabPageView.UseVisualStyleBackColor = true;
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
            this.dgvAllStudents.Location = new System.Drawing.Point(39, 92);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStudents.ShowCellErrors = false;
            this.dgvAllStudents.ShowEditingIcon = false;
            this.dgvAllStudents.ShowRowErrors = false;
            this.dgvAllStudents.Size = new System.Drawing.Size(954, 278);
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
            this.tabPageUpdate.Controls.Add(this.groupBox4);
            this.tabPageUpdate.Controls.Add(this.groupBox2);
            this.tabPageUpdate.Location = new System.Drawing.Point(4, 22);
            this.tabPageUpdate.Name = "tabPageUpdate";
            this.tabPageUpdate.Size = new System.Drawing.Size(1146, 521);
            this.tabPageUpdate.TabIndex = 2;
            this.tabPageUpdate.Text = "Update/Delete";
            this.tabPageUpdate.UseVisualStyleBackColor = true;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.btnUpdate);
            this.groupBox4.Controls.Add(this.btnDelete);
            this.groupBox4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox4.Location = new System.Drawing.Point(144, 464);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(745, 47);
            this.groupBox4.TabIndex = 32;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Actions";
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(500, 19);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(88, 22);
            this.btnUpdate.TabIndex = 27;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            this.btnUpdate.Click += new System.EventHandler(this.btnUpdate_Click);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(619, 19);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(84, 22);
            this.btnDelete.TabIndex = 28;
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
            this.groupBox2.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox2.Location = new System.Drawing.Point(144, 23);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(745, 417);
            this.groupBox2.TabIndex = 31;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Admission Form";
            // 
            // dtpudAdmission
            // 
            this.dtpudAdmission.Location = new System.Drawing.Point(454, 363);
            this.dtpudAdmission.Name = "dtpudAdmission";
            this.dtpudAdmission.Size = new System.Drawing.Size(249, 20);
            this.dtpudAdmission.TabIndex = 50;
            // 
            // cmbudGender
            // 
            this.cmbudGender.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cmbudGender.FormattingEnabled = true;
            this.cmbudGender.Location = new System.Drawing.Point(454, 267);
            this.cmbudGender.Name = "cmbudGender";
            this.cmbudGender.Size = new System.Drawing.Size(249, 21);
            this.cmbudGender.TabIndex = 49;
            // 
            // txtRegNum
            // 
            this.txtRegNum.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtRegNum.Location = new System.Drawing.Point(33, 66);
            this.txtRegNum.Name = "txtRegNum";
            this.txtRegNum.Size = new System.Drawing.Size(234, 20);
            this.txtRegNum.TabIndex = 32;
            // 
            // txtNameud
            // 
            this.txtNameud.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtNameud.Location = new System.Drawing.Point(30, 116);
            this.txtNameud.Name = "txtNameud";
            this.txtNameud.Size = new System.Drawing.Size(234, 20);
            this.txtNameud.TabIndex = 2;
            // 
            // txtudDob
            // 
            this.txtudDob.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudDob.Location = new System.Drawing.Point(33, 171);
            this.txtudDob.Name = "txtudDob";
            this.txtudDob.Size = new System.Drawing.Size(234, 20);
            this.txtudDob.TabIndex = 30;
            // 
            // txtudEmail
            // 
            this.txtudEmail.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudEmail.Location = new System.Drawing.Point(33, 363);
            this.txtudEmail.Name = "txtudEmail";
            this.txtudEmail.Size = new System.Drawing.Size(234, 20);
            this.txtudEmail.TabIndex = 48;
            // 
            // txtudPin
            // 
            this.txtudPin.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudPin.Location = new System.Drawing.Point(454, 219);
            this.txtudPin.Name = "txtudPin";
            this.txtudPin.Size = new System.Drawing.Size(249, 20);
            this.txtudPin.TabIndex = 47;
            // 
            // txtudCity
            // 
            this.txtudCity.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudCity.Location = new System.Drawing.Point(454, 313);
            this.txtudCity.Name = "txtudCity";
            this.txtudCity.Size = new System.Drawing.Size(249, 20);
            this.txtudCity.TabIndex = 45;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Location = new System.Drawing.Point(36, 347);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(32, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "Email";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label4.Location = new System.Drawing.Point(460, 196);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(22, 13);
            this.label4.TabIndex = 42;
            this.label4.Text = "Pin";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label5.Location = new System.Drawing.Point(457, 345);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(80, 13);
            this.label5.TabIndex = 41;
            this.label5.Text = "Admission Date";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label12.Location = new System.Drawing.Point(456, 249);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 40;
            this.label12.Text = "Gender";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label15.Location = new System.Drawing.Point(457, 295);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(24, 13);
            this.label15.TabIndex = 39;
            this.label15.Text = "City";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label16.Location = new System.Drawing.Point(30, 50);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(103, 13);
            this.label16.TabIndex = 38;
            this.label16.Text = "Registration Number";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label17.Location = new System.Drawing.Point(30, 251);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(84, 13);
            this.label17.TabIndex = 37;
            this.label17.Text = "Contact Number";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label18.Location = new System.Drawing.Point(30, 100);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(38, 13);
            this.label18.TabIndex = 36;
            this.label18.Text = " Name";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label19.Location = new System.Drawing.Point(30, 154);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(68, 13);
            this.label19.TabIndex = 35;
            this.label19.Text = "Date Of Birth";
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label20.Location = new System.Drawing.Point(30, 203);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(45, 13);
            this.label20.TabIndex = 34;
            this.label20.Text = "Address";
            // 
            // label21
            // 
            this.label21.AutoSize = true;
            this.label21.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.label21.Location = new System.Drawing.Point(30, 297);
            this.label21.Name = "label21";
            this.label21.Size = new System.Drawing.Size(68, 13);
            this.label21.TabIndex = 33;
            this.label21.Text = "Father Name";
            // 
            // txtudContact
            // 
            this.txtudContact.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudContact.Location = new System.Drawing.Point(33, 267);
            this.txtudContact.Name = "txtudContact";
            this.txtudContact.Size = new System.Drawing.Size(234, 20);
            this.txtudContact.TabIndex = 31;
            // 
            // txtudFather
            // 
            this.txtudFather.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudFather.Location = new System.Drawing.Point(33, 313);
            this.txtudFather.Name = "txtudFather";
            this.txtudFather.Size = new System.Drawing.Size(234, 20);
            this.txtudFather.TabIndex = 29;
            // 
            // txtudAddress
            // 
            this.txtudAddress.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.txtudAddress.Location = new System.Drawing.Point(33, 219);
            this.txtudAddress.Name = "txtudAddress";
            this.txtudAddress.Size = new System.Drawing.Size(234, 20);
            this.txtudAddress.TabIndex = 28;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.linkLabel3);
            this.groupBox3.Controls.Add(this.linkLabel4);
            this.groupBox3.ForeColor = System.Drawing.SystemColors.HotTrack;
            this.groupBox3.Location = new System.Drawing.Point(454, 66);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(249, 125);
            this.groupBox3.TabIndex = 26;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Student Photo";
            // 
            // linkLabel3
            // 
            this.linkLabel3.AutoSize = true;
            this.linkLabel3.Location = new System.Drawing.Point(149, 105);
            this.linkLabel3.Name = "linkLabel3";
            this.linkLabel3.Size = new System.Drawing.Size(34, 13);
            this.linkLabel3.TabIndex = 1;
            this.linkLabel3.TabStop = true;
            this.linkLabel3.Text = "Zoom";
            // 
            // linkLabel4
            // 
            this.linkLabel4.AutoSize = true;
            this.linkLabel4.Location = new System.Drawing.Point(6, 105);
            this.linkLabel4.Name = "linkLabel4";
            this.linkLabel4.Size = new System.Drawing.Size(73, 13);
            this.linkLabel4.TabIndex = 0;
            this.linkLabel4.TabStop = true;
            this.linkLabel4.Text = "Browse Photo";
            // 
            // Students
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1159, 545);
            this.Controls.Add(this.tabStudent);
            this.Name = "Students";
            this.Text = "Students";
            this.Load += new System.EventHandler(this.Students_Load);
            this.tabStudent.ResumeLayout(false);
            this.tabpageAdmission.ResumeLayout(false);
            this.grpButtons.ResumeLayout(false);
            this.grpWholeAdmissionForm.ResumeLayout(false);
            this.grpWholeAdmissionForm.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPageView.ResumeLayout(false);
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
        private System.Windows.Forms.GroupBox grpWholeAdmissionForm;
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.ComboBox cmbGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblRegistration;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
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
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.Button btnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Button btnDelete;
        public System.Windows.Forms.TabPage tabpageAdmission;
        public System.Windows.Forms.TabPage tabPageView;
        public System.Windows.Forms.TabPage tabPageUpdate;
        private System.Windows.Forms.ComboBox cmbudGender;
        private System.Windows.Forms.DateTimePicker dtpAdmission;
        private System.Windows.Forms.DateTimePicker dtpudAdmission;
    }
}