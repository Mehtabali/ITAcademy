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
        //public int StudentId {
        //    get
        //    {
        //        int studentId;
        //        Int32.TryParse(Convert.ToString(dgvAllStudents.Rows[e.RowIndex].Cells[0].Value), out studentId);
        //    }
        //    set;
        //}
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
        int studentId = 0;
        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
           
            Int32.TryParse(Convert.ToString(dgvAllStudents.Rows[e.RowIndex].Cells[0].Value), out studentId);
            //var id = dgvAllStudents.Rows[e.RowIndex].Cells[0].Value;
            Student student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;
            EditOrDeleteStudent _editOrDeleteStudent = new EditOrDeleteStudent(student);

            _editOrDeleteStudent.Show();


            // MessageBox.Show(id.ToString());
        }

        private void dgvAllStudents_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
