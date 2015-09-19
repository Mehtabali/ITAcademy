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
         //   cmbCourseId.Load(_batchService.


        }

        private void btnCreate_Click(object sender, EventArgs e)
        {
            // data reading  from user in textboxes
            batch.Name = txtName.Text;
            batch.Timings = cmbTimings.Text;
            batch.Courses_Id = Convert.ToInt32(cmbCourseId.Text); 
            batch.Users_Id = Convert.ToInt32(cmbUsersId.Text);
            //calling functio to create batch
            _batchService.CreateBatch(batch);

        }

       
    }
}
