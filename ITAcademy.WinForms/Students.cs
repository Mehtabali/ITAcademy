using ITAcademy.DataModels;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    public partial class Students : Form
    {

        [Dependency]
      
        public IStudentService _studentService { get; set; }
       private  Student _student;
       private Student student; // to get value of select row from data list
        public Students()
        {
            InitializeComponent();
        }

        //Constructor injection
        public Students(IStudentService studentService,Student student)
        {
            _studentService = studentService;
            _student = student;
            InitializeComponent();
            dgvAllStudents.AutoGenerateColumns = false;

        }
         private void Students_Load(object sender, EventArgs e)
        {
            dgvAllStudents.DataSource = _studentService.GetAllStudents();
        }
        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;

            txtNameud.Text = student.Name;
            txtudAddress.Text = student.Address;
            txtudCity.Text = student.City;
            txtudContact.Text = student.Mobile;
            txtudDob.Text =   Convert.ToString(student.DOB);
            txtudEmail.Text = student.Email;
            txtudFather.Text = student.FatherName;
         //   dtpudAdmission.MinDate = new System.DateTime();
                Convert.ToString(student.AdmissionDate);
            tabStudent.SelectedTab = tabStudent.TabPages[2];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            _student.Name = txtName.Text;
            _student.Mobile = txtContactNumber.Text;
            _student.Email = txtEmail.Text;
            _student.FatherName = txtFatherName.Text;
            _student.Gender = cmbGender.Text;
            _student.Address = txtAddress.Text;
            _student.City = txtCity.Text;
            _student.PIN = txtPin.Text;
            DateTime date;
            DateTime.TryParse(dtpudAdmission.Text, out date);
            _student.DOB = date;
       

            ValidationContext context = new ValidationContext(_student, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(_student, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                MessageBox.Show("Validated");
                _studentService.CreateStudent(_student);
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _student.Name = txtNameud.Text;
            _student.Mobile = txtudContact.Text =
            _student.PIN = txtudPin.Text;
            _student.Gender = cmbudGender.Text;
            _student.DOB = Convert.ToDateTime(txtudDob.Text);
            _student.Email = txtudEmail.Text;
            _student.Address = txtudAddress.Text;
            _student.AdmissionDate = Convert.ToDateTime(dtpudAdmission.Text);
            _student.FatherName = txtudFather.Text;
            _student.City = txtudCity.Text;
            _studentService.UpdateStudent(_student);
            MessageBox.Show("Updated");

        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNameud.Clear();
            txtudAddress.Clear();
            txtudCity.Clear();
            txtudFather.Clear();
            txtudDob.Clear();
            txtudContact.Clear();
            txtudPin.Clear();
            txtudCity.Clear();
            txtudEmail.Clear();
            dtpudAdmission.Text = "";
            _studentService.DeleteStudent(student.Id);
           
            MessageBox.Show("Deleted");
        }

    
        }

      

   
    }

