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
    public partial class Admission_WinForm : Form
    {
        [Dependency]
        public IStudentService _studentService { get; set; }
        public Admission_WinForm()
        {

        }
        public Admission_WinForm(IStudentService studentService)
        {
            _studentService = studentService;
            InitializeComponent();
        }

        private void textBox10_TextChanged(object sender, EventArgs e)
        {

        }

        private void Admission_WinForm_Load(object sender, EventArgs e)
        {
            //lblLogoText.Visible = false;
            //MDIContanier mdi = new MDIContanier();
            //mdi.lblLogoText.Text = "";

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox11_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            //Take data from user 
            Student student = new Student();
            //  student.Name = "Mehtab";
            student.City = "Delhi";
            student.UpdatedBy = 1;
            student.CreatedBy = 2;

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
    }
}
