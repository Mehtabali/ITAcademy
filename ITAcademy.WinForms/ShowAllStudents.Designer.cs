namespace ITAcademy.WinForms
{
    partial class ShowAllStudents
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
            this.grpAllRecords = new System.Windows.Forms.GroupBox();
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
            this.grpAllRecords.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).BeginInit();
            this.SuspendLayout();
            // 
            // grpAllRecords
            // 
            this.grpAllRecords.Controls.Add(this.dgvAllStudents);
            this.grpAllRecords.Location = new System.Drawing.Point(12, 0);
            this.grpAllRecords.Name = "grpAllRecords";
            this.grpAllRecords.Size = new System.Drawing.Size(963, 467);
            this.grpAllRecords.TabIndex = 0;
            this.grpAllRecords.TabStop = false;
            this.grpAllRecords.Text = "All Records";
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
            this.dgvAllStudents.Location = new System.Drawing.Point(6, 28);
            this.dgvAllStudents.Name = "dgvAllStudents";
            this.dgvAllStudents.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvAllStudents.ShowCellErrors = false;
            this.dgvAllStudents.ShowEditingIcon = false;
            this.dgvAllStudents.ShowRowErrors = false;
            this.dgvAllStudents.Size = new System.Drawing.Size(954, 278);
            this.dgvAllStudents.TabIndex = 0;
            this.dgvAllStudents.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvAllStudents_CellContentClick);
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
            // ShowAllStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(987, 522);
            this.Controls.Add(this.grpAllRecords);
            this.Name = "ShowAllStudents";
            this.Text = "ShowAllStudents";
            this.Load += new System.EventHandler(this.ShowAllStudents_Load);
            this.grpAllRecords.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvAllStudents)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grpAllRecords;
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
    }
}