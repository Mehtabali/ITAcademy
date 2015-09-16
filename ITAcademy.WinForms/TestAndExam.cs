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
using ITAcademy.DataAccessLayer;

namespace ITAcademy.WinForms
{
    public partial class TestAndExam : Form
    {

        [Dependency]
        public ITestService _testService { get; set; }

       
        //public DbConnection _database { get; set; }
        public TestAndExam()
        {
            InitializeComponent();
        }
        public TestAndExam(ITestService testService)
        {

            _testService = testService;
            InitializeComponent();
            
        }

    
        private void TestAndExam_WinForm_Load(object sender, EventArgs e)
        {
            //_database.BindCombo(cmbBatch, "sp_SelectAllBatches", "Name");
            cmbBatch.Load(_testService.GetAllBatches().ToDataTable(), "Name", "Id");
            
          
         
                
        }

        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            var x = cmbBatch.SelectedValue;

        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
