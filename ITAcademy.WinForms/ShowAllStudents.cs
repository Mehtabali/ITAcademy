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

        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            var id = dgvAllStudents.Rows[e.RowIndex].Cells[0].Value;
            MessageBox.Show(id.ToString());
        }
    }
}
