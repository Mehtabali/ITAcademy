using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Practices.Unity;
using ITAcademy.ServiceLayer;
using ITAcademy.DataModels;
using System.ComponentModel.DataAnnotations;
namespace ITAcademy.WinForms
{
    public partial class AdmissionForm : Form
    {
        [Dependency]
        public IStudentService _studentService { get; set; }
        Student student = new Student();
        public AdmissionForm()
        {
            InitializeComponent();

        }

        //Constructor Injection
        public AdmissionForm(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
        }
        private void btnSave_Click(object sender, EventArgs e)
        {
            //Ta1ke data from user 
          
            student.Name = txtName.Text;
            student.Mobile = txtContactNumber.Text;
            student.Email = txtEmail.Text;
            student.FatherName = txtFatherName.Text;
            student.Gender = cmbGender.Text;
            student.Address = txtAddress.Text;
            student.City = txtCity.Text;
            student.PIN= txtPin.Text;
            student.DOB = Convert.ToDateTime(txtDob.Text);
       

            ValidationContext context = new ValidationContext(student, null, null);
            IList<ValidationResult> errors = new List<ValidationResult>();

            if (!Validator.TryValidateObject(student, context, errors, true))
            {
                foreach (ValidationResult result in errors)
                    MessageBox.Show(result.ErrorMessage);
            }
            else
            {
                MessageBox.Show("Validated");
                _studentService.CreateStudent(student);
            }
        }


        private void btnReset_Click(object sender, EventArgs e)
        {
            student.Name = txtName.Text = "";

        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void AdmissionForm_Load(object sender, EventArgs e)
        {

        }

    
    }
}
