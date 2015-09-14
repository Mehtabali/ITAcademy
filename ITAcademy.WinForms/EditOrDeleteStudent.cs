using Microsoft.Practices.Unity;
using ITAcademy.ServiceLayer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITAcademy.DataModels;

namespace ITAcademy.WinForms
{
    public partial class EditOrDeleteStudent : Form
    {
        [Dependency]
        public IStudentService _studentService { get; set; }
        public EditOrDeleteStudent()
        {
            InitializeComponent();
        }
        public EditOrDeleteStudent(IStudentService studentService)
        {
            _studentService = studentService;

            InitializeComponent();
            dgvShowOne.AutoGenerateColumns = false;
        }
        private Student _student;
        public EditOrDeleteStudent(Student student)
        {
            _student = student;
            BindStudent(student);
        }

        private void BindStudent(Student student)
        {
            if (student != null)
            {
                //txtName.Text = student.Name;
                textBox1.Text = student.Name;
            }
        }
        private void EditOrDeleteStudent_Load(object sender, EventArgs e)
        {
            // ShowAllStudents _showAllStudents = new ShowAllStudents();


            dgvShowOne.DataSource = _studentService.GetStudent(3);




        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFatherName_TextChanged(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _studentService.DeleteStudent(2);
        }
    }
}
