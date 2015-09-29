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
        Student student;
        public IStudentService _studentService { get; set; }
     
        public Students()
        {
            InitializeComponent();
        }

        //Constructor injection
        public Students(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
            dgvAllStudents.AutoGenerateColumns = false;

        }
         private void Students_Load(object sender, EventArgs e)
        {
            dgvAllStudents.DataSource = _studentService.GetAllStudents();
        }
        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            Student student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;

            txtNameud.Text = student.Name;
            txtudAddress.Text = student.Address;
            txtudCity.Text = student.City;
            txtudContact.Text = student.Mobile;
            txtudDob.Text =   Convert.ToString(student.DOB);
            txtudEmail.Text = student.Email;
            txtudFather.Text = student.FatherName;
            dtpudAdmission.Text = Convert.ToString(student.AdmissionDate);
            tabStudent.SelectedTab = tabStudent.TabPages[2];

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
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

        private void btnUpdate_Click(object sender, EventArgs e)
        {
        
        }

    
        }

      

   
    }
}
