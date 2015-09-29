using ITAcademy.DataModels;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    public partial class ShowAllStudents : Form
    {
        [Dependency]

        public IStudentService _studentService { get; set; }

        public ShowAllStudents()
        {
            InitializeComponent();
        }
        //Constructor injection
        public ShowAllStudents(IStudentService studentService)
        {
            _studentService = studentService;

            InitializeComponent();
            dgvAllStudents.AutoGenerateColumns = false;
        }
        private void ShowAllStudents_Load(object sender, EventArgs e)
        {
            //Load all students from here
            dgvAllStudents.DataSource = _studentService.GetAllStudents();
        }
        public int studentId = 0;
        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {

            Int32.TryParse(Convert.ToString(dgvAllStudents.Rows[e.RowIndex].Cells[0].Value), out studentId);
            //Ise comment hi rkhte hain ..taaki u should remember and reference bhi rahe ki kese id nikalte hian grid k colun se
            //oky
            //var id = dgvAllStudents.Rows[e.RowIndex].Cells[0].Value;
            Student student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;
            EditOrDelete _editOrDeleteStudent = new EditOrDelete(_studentService,student);

            _editOrDeleteStudent.Show();


            // MessageBox.Show(id.ToString());
        }

        private void dgvAllStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
