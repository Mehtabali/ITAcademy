namespace ITAcademy.WinForms
{
    partial class EditOrDeleteStudent
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
            this.txtName = new System.Windows.Forms.TextBox();
            this.txtDob = new System.Windows.Forms.TextBox();
            this.txtAddress = new System.Windows.Forms.TextBox();
            this.txtPin = new System.Windows.Forms.TextBox();
            this.txtFatherName = new System.Windows.Forms.TextBox();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.txtCity = new System.Windows.Forms.TextBox();
            this.txtGender = new System.Windows.Forms.TextBox();
            this.txtEmail = new System.Windows.Forms.TextBox();
            this.dgvShowOne = new System.Windows.Forms.DataGridView();
            this.colName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colCity = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colEmail = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colAddress = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colFatherName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colPin = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colDob = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.colMobile = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnUpdate = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOne)).BeginInit();
            this.SuspendLayout();
            // 
            // txtName
            // 
            this.txtName.Location = new System.Drawing.Point(131, 13);
            this.txtName.Name = "txtName";
            this.txtName.Size = new System.Drawing.Size(149, 20);
            this.txtName.TabIndex = 0;
            // 
            // txtDob
            // 
            this.txtDob.Location = new System.Drawing.Point(139, 210);
            this.txtDob.Name = "txtDob";
            this.txtDob.Size = new System.Drawing.Size(141, 20);
            this.txtDob.TabIndex = 1;
            // 
            // txtAddress
            // 
            this.txtAddress.Location = new System.Drawing.Point(485, 117);
            this.txtAddress.Name = "txtAddress";
            this.txtAddress.Size = new System.Drawing.Size(134, 20);
            this.txtAddress.TabIndex = 2;
            // 
            // txtPin
            // 
            this.txtPin.Location = new System.Drawing.Point(485, 164);
            this.txtPin.Name = "txtPin";
            this.txtPin.Size = new System.Drawing.Size(134, 20);
            this.txtPin.TabIndex = 4;
            // 
            // txtFatherName
            // 
            this.txtFatherName.Location = new System.Drawing.Point(485, 66);
            this.txtFatherName.Name = "txtFatherName";
            this.txtFatherName.Size = new System.Drawing.Size(134, 20);
            this.txtFatherName.TabIndex = 5;
            this.txtFatherName.TextChanged += new System.EventHandler(this.txtFatherName_TextChanged);
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(485, 21);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(134, 20);
            this.txtMobile.TabIndex = 6;
            // 
            // txtCity
            // 
            this.txtCity.Location = new System.Drawing.Point(131, 164);
            this.txtCity.Name = "txtCity";
            this.txtCity.Size = new System.Drawing.Size(149, 20);
            this.txtCity.TabIndex = 7;
            // 
            // txtGender
            // 
            this.txtGender.Location = new System.Drawing.Point(131, 127);
            this.txtGender.Name = "txtGender";
            this.txtGender.Size = new System.Drawing.Size(149, 20);
            this.txtGender.TabIndex = 8;
            this.txtGender.TextChanged += new System.EventHandler(this.textBox9_TextChanged);
            // 
            // txtEmail
            // 
            this.txtEmail.Location = new System.Drawing.Point(131, 91);
            this.txtEmail.Name = "txtEmail";
            this.txtEmail.Size = new System.Drawing.Size(149, 20);
            this.txtEmail.TabIndex = 9;
            // 
            // dgvShowOne
            // 
            this.dgvShowOne.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvShowOne.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.colName,
            this.colCity,
            this.colEmail,
            this.colAddress,
            this.colFatherName,
            this.colPin,
            this.colDob,
            this.colMobile});
            this.dgvShowOne.Location = new System.Drawing.Point(59, 267);
            this.dgvShowOne.Name = "dgvShowOne";
            this.dgvShowOne.Size = new System.Drawing.Size(818, 150);
            this.dgvShowOne.TabIndex = 10;
            this.dgvShowOne.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            // 
            // colName
            // 
            this.colName.DataPropertyName = "Name";
            this.colName.HeaderText = "Name";
            this.colName.Name = "colName";
            // 
            // colCity
            // 
            this.colCity.DataPropertyName = "City";
            this.colCity.HeaderText = "City";
            this.colCity.Name = "colCity";
            // 
            // colEmail
            // 
            this.colEmail.DataPropertyName = "Email";
            this.colEmail.HeaderText = "Email";
            this.colEmail.Name = "colEmail";
            // 
            // colAddress
            // 
            this.colAddress.DataPropertyName = "Address";
            this.colAddress.HeaderText = "Address";
            this.colAddress.Name = "colAddress";
            // 
            // colFatherName
            // 
            this.colFatherName.DataPropertyName = "FatherName";
            this.colFatherName.HeaderText = "Father Name";
            this.colFatherName.Name = "colFatherName";
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
            // colMobile
            // 
            this.colMobile.DataPropertyName = "Mobile";
            this.colMobile.HeaderText = "Mobile";
            this.colMobile.Name = "colMobile";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(132, 52);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(148, 20);
            this.textBox1.TabIndex = 13;
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(745, 39);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(75, 23);
            this.btnDelete.TabIndex = 11;
            this.btnDelete.Text = "Delete Student ";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnUpdate
            // 
            this.btnUpdate.Location = new System.Drawing.Point(758, 161);
            this.btnUpdate.Name = "btnUpdate";
            this.btnUpdate.Size = new System.Drawing.Size(75, 23);
            this.btnUpdate.TabIndex = 12;
            this.btnUpdate.Text = "Update";
            this.btnUpdate.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(22, 16);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 14;
            this.label1.Text = "Name";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(22, 59);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(35, 13);
            this.label7.TabIndex = 20;
            this.label7.Text = "label7";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(22, 98);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(32, 13);
            this.label6.TabIndex = 25;
            this.label6.Text = "Email";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(32, 217);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 24;
            this.label5.Text = "label5";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(32, 171);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(35, 13);
            this.label4.TabIndex = 23;
            this.label4.Text = "label4";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(425, 171);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 22;
            this.label3.Text = "label3";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 139);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(35, 13);
            this.label2.TabIndex = 21;
            this.label2.Text = "label2";
            // 
            // EditOrDeleteStudent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(965, 448);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnUpdate);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dgvShowOne);
            this.Controls.Add(this.txtEmail);
            this.Controls.Add(this.txtGender);
            this.Controls.Add(this.txtCity);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.txtFatherName);
            this.Controls.Add(this.txtPin);
            this.Controls.Add(this.txtAddress);
            this.Controls.Add(this.txtDob);
            this.Controls.Add(this.txtName);
            this.Name = "EditOrDeleteStudent";
            this.Text = "EditOrDeleteStudent";
            this.Load += new System.EventHandler(this.EditOrDeleteStudent_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvShowOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtName;
        private System.Windows.Forms.TextBox txtDob;
        private System.Windows.Forms.TextBox txtAddress;
        private System.Windows.Forms.TextBox txtPin;
        private System.Windows.Forms.TextBox txtFatherName;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.TextBox txtCity;
        private System.Windows.Forms.TextBox txtGender;
        private System.Windows.Forms.TextBox txtEmail;
        private System.Windows.Forms.DataGridView dgvShowOne;
        private System.Windows.Forms.DataGridViewTextBoxColumn colName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colCity;
        private System.Windows.Forms.DataGridViewTextBoxColumn colEmail;
        private System.Windows.Forms.DataGridViewTextBoxColumn colAddress;
        private System.Windows.Forms.DataGridViewTextBoxColumn colFatherName;
        private System.Windows.Forms.DataGridViewTextBoxColumn colPin;
        private System.Windows.Forms.DataGridViewTextBoxColumn colDob;
        private System.Windows.Forms.DataGridViewTextBoxColumn colMobile;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button btnDelete;
        private System.Windows.Forms.Button btnUpdate;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
    }
}