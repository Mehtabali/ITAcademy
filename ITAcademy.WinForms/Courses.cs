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
using ITAcademy.ServiceLayer;
using ITAcademy.DataModels;
using ITAcademy.DataAccessLayer;
namespace ITAcademy.WinForms
{
    public partial class Courses : Form
    {
        [Dependency]
        public ICourseService _courseService{get; set;}
        private Course _course,course;
        public Courses()
        {
            InitializeComponent();
        }
        public Courses(ICourseService courseService,Course course)
        {
            _course = course;
            _courseService = courseService;
            InitializeComponent();

           // dgvList.AutoGenerateColumns = false;
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            _course = new Course();
            _course.Name = txtName.Text;
            _course.Description = txtDescription.Text;
            _course.Fees = float.Parse(txtFee.Text);
            _course.Duration = txtDuration.Text;
            _courseService.Create(_course);

        }

        private void Courses_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = _courseService.GetAllCourses();
            cmbSearch.Load(_courseService.GetAllCourses().ToDataTable(), "Name", "Id");
        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            course = dgvList.Rows[e.RowIndex].DataBoundItem as Course;

            tabCourse.SelectedTab = tabCourse.TabPages[2];
            txtNameud.Text = course.Name;
            txtDurationud.Text = course.Duration;
            txtDescriptionud.Text = course.Description;
            txtFeeud.Text = Convert.ToString(course.Fees);
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNameud.Clear();
            txtFeeud.Clear();
            txtDescriptionud.Clear();
            txtDurationud.Clear();
            _courseService.Delete(course.Id);
            MessageBox.Show("Deleted");
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _course.Name = txtNameud.Text;
            _course.Fees =  float.Parse(txtFeeud.Text);
            _course.Duration = txtDuration.Text;
            _course.Description = txtDuration.Text;
            _courseService.Update(_course);
         //   MessageBox.Show("Updated");
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

      
    
    
    }
}
