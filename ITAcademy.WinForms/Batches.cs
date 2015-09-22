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
        Batch batch =new Batch();

            
        public Batches()
        {
            InitializeComponent();
        }
        //constructor injection 
        public Batches(IBatchService batchServices)
        {
            batchServices = _batchService;
            InitializeComponent();
        }
        private void Batches_Load(object sender, EventArgs e)
        {
            cmbCourseName.Load(_batchService.GetAllCourses().ToDataTable(), "Name", "Id");
            cmbUsersName.Load(_batchService.GetAllTeacher().ToDataTable(), "Name", "Id");


        }

    
        int userId=0;
        private void cmbUsersName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbUsersName.SelectedValue.ToString(), out userId);
            if (userId != 0) {
                lblDesignation.Visible = true;
             lblDesignation.Text=_batchService.GetDesignation(userId); 
            }


          //  var x=cmbUsersName.SelectedValue;

        }
        int courseId = 0;
        private void cmbCourseName_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbCourseName.SelectedValue.ToString(), out courseId);

        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // data reading  from user in textboxes
            batch.Name = txtName.Text;
            batch.Timings = cmbTimings.Text;
            batch.Courses_Id = userId;
            batch.Users_Id = courseId;
            //calling functio to create batch
            _batchService.CreateBatch(batch);

        }

       
       
    }
}
