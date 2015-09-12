namespace ITAcademy.WinForms
{
    partial class Admission_WinForm
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
            this.linkLabel2 = new System.Windows.Forms.LinkLabel();
            this.linkLabel1 = new System.Windows.Forms.LinkLabel();
            this.brnSave = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.grpButtons = new System.Windows.Forms.GroupBox();
            this.grpWholeAdmissionForm = new System.Windows.Forms.GroupBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtGuardianNumber = new System.Windows.Forms.TextBox();
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
            this.txtRegistrationNumber = new System.Windows.Forms.TextBox();
            this.txtContactNumber = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtName = new System.Windows.Forms.TextBox();
            this.cmbGender = new System.Windows.Forms.ComboBox();
            this.groupBox1.SuspendLayout();
            this.grpButtons.SuspendLayout();
            this.grpWholeAdmissionForm.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.linkLabel2);
            this.groupBox1.Controls.Add(this.linkLabel1);
            this.groupBox1.Location = new System.Drawing.Point(464, 50);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(224, 136);
            this.groupBox1.TabIndex = 26;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Student Photo";
            // 
            // linkLabel2
            // 
            this.linkLabel2.AutoSize = true;
            this.linkLabel2.Location = new System.Drawing.Point(144, 121);
            this.linkLabel2.Name = "linkLabel2";
            this.linkLabel2.Size = new System.Drawing.Size(34, 13);
            this.linkLabel2.TabIndex = 1;
            this.linkLabel2.TabStop = true;
            this.linkLabel2.Text = "Zoom";
            // 
            // linkLabel1
            // 
            this.linkLabel1.AutoSize = true;
            this.linkLabel1.Location = new System.Drawing.Point(6, 121);
            this.linkLabel1.Name = "linkLabel1";
            this.linkLabel1.Size = new System.Drawing.Size(73, 13);
            this.linkLabel1.TabIndex = 0;
            this.linkLabel1.TabStop = true;
            this.linkLabel1.Text = "Browse Photo";
            // 
            // brnSave
            // 
            this.brnSave.Location = new System.Drawing.Point(541, 11);
            this.brnSave.Name = "brnSave";
            this.brnSave.Size = new System.Drawing.Size(96, 31);
            this.brnSave.TabIndex = 27;
            this.brnSave.Text = "Save";
            this.brnSave.UseVisualStyleBackColor = true;
            this.brnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnReset
            // 
            this.btnReset.Location = new System.Drawing.Point(671, 11);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(92, 31);
            this.btnReset.TabIndex = 28;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // grpButtons
            // 
            this.grpButtons.Controls.Add(this.brnSave);
            this.grpButtons.Controls.Add(this.btnReset);
            this.grpButtons.Location = new System.Drawing.Point(12, 503);
            this.grpButtons.Name = "grpButtons";
            this.grpButtons.Size = new System.Drawing.Size(777, 47);
            this.grpButtons.TabIndex = 29;
            this.grpButtons.TabStop = false;
            this.grpButtons.Text = "Actions";
            this.grpButtons.Enter += new System.EventHandler(this.groupBox2_Enter);
            // 
            // grpWholeAdmissionForm
            // 
            this.grpWholeAdmissionForm.Controls.Add(this.cmbGender);
            this.grpWholeAdmissionForm.Controls.Add(this.txtEmail);
            this.grpWholeAdmissionForm.Controls.Add(this.txtPin);
            this.grpWholeAdmissionForm.Controls.Add(this.txtCity);
            this.grpWholeAdmissionForm.Controls.Add(this.txtGuardianNumber);
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
            this.grpWholeAdmissionForm.Controls.Add(this.txtRegistrationNumber);
            this.grpWholeAdmissionForm.Controls.Add(this.txtContactNumber);
            this.grpWholeAdmissionForm.Controls.Add(this.txtDob);
            this.grpWholeAdmissionForm.Controls.Add(this.txtFatherName);
            this.grpWholeAdmissionForm.Controls.Add(this.txtAddress);
            this.grpWholeAdmissionForm.Controls.Add(this.txtName);
            this.grpWholeAdmissionForm.Controls.Add(this.groupBox1);
            this.grpWholeAdmissionForm.Location = new System.Drawing.Point(12, 14);
            this.grpWholeAdmissionForm.Name = "grpWholeAdmissionForm";
            this.grpWholeAdmissionForm.Size = new System.Drawing.Size(777, 483);
            this.grpWholeAdmissionForm.TabIndex = 29;
            this.grpWholeAdmissionForm.TabStop = false;
            this.grpWholeAdmissionForm.Text = "Admission Form";
            this.grpWholeAdmissionForm.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(122, 393);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(179, 20);
            this.txtEmail.TabIndex = 48;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(524, 232);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(179, 20);
            this.txtPin.TabIndex = 47;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(524, 333);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(179, 20);
            this.txtCity.TabIndex = 45;
            // 
            // txtGuardianNumber
            // 
            this.txtGuardianNumber.Location = new System.Drawing.Point(524, 393);
            this.txtGuardianNumber.Name = "txtGuardianNumber";
            this.txtGuardianNumber.Size = new System.Drawing.Size(179, 20);
            this.txtGuardianNumber.TabIndex = 44;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(30, 393);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(32, 13);
            this.label13.TabIndex = 43;
            this.label13.Text = "Email";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(432, 239);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(22, 13);
            this.label11.TabIndex = 42;
            this.label11.Text = "Pin";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(367, 393);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(97, 13);
            this.label10.TabIndex = 41;
            this.label10.Text = "Gaurdian\'s Contact";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(412, 287);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(42, 13);
            this.label3.TabIndex = 40;
            this.label3.Text = "Gender";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(430, 333);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(24, 13);
            this.label2.TabIndex = 39;
            this.label2.Text = "City";
            // 
            // lblRegistration
            // 
            this.lblRegistration.AutoSize = true;
            this.lblRegistration.Location = new System.Drawing.Point(6, 72);
            this.lblRegistration.Name = "lblRegistration";
            this.lblRegistration.Size = new System.Drawing.Size(103, 13);
            this.lblRegistration.TabIndex = 38;
            this.lblRegistration.Text = "Registration Number";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(6, 271);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(84, 13);
            this.label14.TabIndex = 37;
            this.label14.Text = "Contact Number";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(7, 118);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(38, 13);
            this.label9.TabIndex = 36;
            this.label9.Text = " Name";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(6, 165);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(68, 13);
            this.label8.TabIndex = 35;
            this.label8.Text = "Date Of Birth";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(6, 211);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(45, 13);
            this.label7.TabIndex = 34;
            this.label7.Text = "Address";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 335);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(68, 13);
            this.label6.TabIndex = 33;
            this.label6.Text = "Father Name";
            // 
            // txtRegistrationNumber
            // 
            this.txtRegistrationNumber.Location = new System.Drawing.Point(122, 73);
            this.txtRegistrationNumber.Name = "txtRegistrationNumber";
            this.txtRegistrationNumber.Size = new System.Drawing.Size(179, 20);
            this.txtRegistrationNumber.TabIndex = 32;
            this.txtRegistrationNumber.TextChanged += new System.EventHandler(this.textBox11_TextChanged_1);
            // 
            // txtContactNumber
            // 
            this.txtContactNumber.Location = new System.Drawing.Point(122, 272);
            this.txtContactNumber.Name = "txtContactNumber";
            this.txtContactNumber.Size = new System.Drawing.Size(179, 20);
            this.txtContactNumber.TabIndex = 31;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(122, 166);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(179, 20);
            this.txtDob.TabIndex = 30;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(122, 332);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(179, 20);
            this.txtFatherName.TabIndex = 29;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(122, 212);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(179, 20);
            this.txtAddress.TabIndex = 28;
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(123, 118);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(179, 20);
            this.txtName.TabIndex = 27;
            // 
            // cmbGender
            // 
            this.cmbGender.FormattingEnabled = true;
            this.cmbGender.Items.AddRange(new object[] {
            "Male",
            "Female"});
            this.cmbGender.Location = new System.Drawing.Point(524, 287);
            this.cmbGender.Name = "cmbGender";
            this.cmbGender.Size = new System.Drawing.Size(179, 21);
            this.cmbGender.TabIndex = 49;
            this.cmbGender.Text = "Select Gender";
            // 
            // Admission_WinForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(827, 562);
            this.Controls.Add(this.grpWholeAdmissionForm);
            this.Controls.Add(this.grpButtons);
            this.Name = "Admission_WinForm";
            this.Text = "Admission_WinForm";
            this.Load += new System.EventHandler(this.Admission_WinForm_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.grpButtons.ResumeLayout(false);
            this.grpWholeAdmissionForm.ResumeLayout(false);
            this.grpWholeAdmissionForm.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.LinkLabel linkLabel2;
        private System.Windows.Forms.LinkLabel linkLabel1;
        private System.Windows.Forms.Button brnSave;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.GroupBox grpButtons;
        private System.Windows.Forms.GroupBox grpWholeAdmissionForm;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtGuardianNumber;
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
        private System.Windows.Forms.TextBox txtRegistrationNumber;
        private System.Windows.Forms.TextBox txtContactNumber;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.ComboBox cmbGender;
    }
}