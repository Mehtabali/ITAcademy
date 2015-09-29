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
    public partial class Batches : Form
    {
        [Dependency]
        public IBatchService _batchService { get; set; }
        private Batch _batch;

        public Batches()
        {
            InitializeComponent();
        }
        //constructor injection 
        public Batches(IBatchService batchServices)
        {
            batchServices = _batchService;
            InitializeComponent();
            dgvList.AutoGenerateColumns = false;
        }
        private void Batches_Load(object sender, EventArgs e)
        {


                cmbCourseName.Load(_batchService.GetAllCourses().ToDataTable(), "Name", "Id");
                cmbUsersName.Load(_batchService.GetAllTeacher().ToDataTable(), "Name", "Id");
                dgvList.DataSource = _batchService.GetAllBatches();
                cmbSearch.Load(_batchService.GetAllBatches().ToDataTable(), "Name", "Id");
                cmbCourse.Load(_batchService.GetAllCourses().ToDataTable(), "Name", "Id");
                cmbTeacher.Load(_batchService.GetAllTeacher().ToDataTable(), "Name", "Id");
               
        }


        int userId = 0;
        private void cmbUsersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbUsersName.SelectedValue.ToString(), out userId);
            if (userId != 0)
            {
                lblDesignation.Visible = true;
                lblDesignation.Text = _batchService.GetDesignation(userId);
            }


            //  var x=cmbUsersName.SelectedValue;

        }
        int courseId = 0;
        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbCourseName.SelectedValue.ToString(), out courseId);

        }
        private void lblEnableSearch_Click(object sender, EventArgs e)
        {
            cmbSearch.Load(_batchService.GetAllBatches().ToDataTable(), "Name", "Id");
        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // data reading  from user in textboxes
            Batch batch = new Batch();
            batch.Name = txtName.Text;
            batch.Timings = cmbTimings.Text;
            batch.Courses_Id = userId;
            batch.Users_Id = courseId;
            //calling functio to create batch
            _batchService.CreateBatch(batch);

        }
        int batchId;
        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            // Int32.TryParse(Convert.ToString(dgvList.Rows[e.RowIndex].Cells[0].Value), out batchId);
            _batch = dgvList.Rows[e.RowIndex].DataBoundItem as Batch;

            //txtName.Text = batch.Name;
            txtNameud.Text = _batch.Name;
            cmbTime.Text = _batch.Timings;
            cmbCourse.Text = _batch.CourseName;
            cmbTeacher.Text = _batch.UserName;
            tabBatches.SelectedTab = tabBatches.TabPages[2];

        }
        private void cmbCourse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbCourse.SelectedValue.ToString(), out courseId);
        }
        //int teacherId = 0;
        private void cmbTeacher_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbTeacher.SelectedValue.ToString(), out userId);
        }



        private void btnUpdate_Click(object sender, EventArgs e)
        {

            _batch.Name = txtNameud.Text;
            _batch.Timings = cmbTime.Text;
            _batch.Courses_Id = courseId; 
            _batch.Users_Id = userId;
            _batchService.UpdateBatch(_batch);
            MessageBox.Show("Batch Updated succesfully");
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _batchService.DeleteBatch(_batch.Id);
            txtNameud.Clear();
            cmbTeacher.SelectedIndex = -1;
            cmbCourse.SelectedIndex = -1;
            cmbTime.SelectedIndex = -1;
            MessageBox.Show("Batch Deleted succesfully");


        }

        




    }
}
