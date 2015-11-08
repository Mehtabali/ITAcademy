using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ITAcademy.DataAccessLayer;
using ITAcademy.DataModels;
using Microsoft.Practices.Unity;
using ITAcademy.ServiceLayer;

namespace ITAcademy.WinForms
{
    public partial class Fees : Form
    {
        [Dependency]
        public IFeeService _feeService { get; set; }
      //  private Fee _fees;
        public Fees()
        {
            InitializeComponent();
        }
        public Fees(IFeeService feeService) {

            feeService = _feeService;
            InitializeComponent();
            dgvList.AutoGenerateColumns = false; 
        
        
        }
        private void Fees_Load(object sender, EventArgs e)
        {
            dgvList.DataSource = _feeService.GetAllFees();
           // cmbCourses.Load(_feeService.GetAllCourses().ToDataTable(), "Name", "Id");
            cmbStudent.Load(_feeService.GetAllStudents().ToDataTable(), "Name", "Id");
           // cmbCrse.Load(_feeService.GetAllCourses().ToDataTable(), "Name", "Id");
            cmbStd.Load(_feeService.GetAllStudents().ToDataTable(), "Name", "Id");
           
            // cmbMonth.Load(_batchService.GetAllBatches().ToDataTable(), "Name", "Id");
           // cmb.Load(_batchService.GetAllCourses().ToDataTable(), "Name", "Id");
           // cmbTeacher.Load(_batchService.GetAllTeacher().ToDataTable(), "Name", "Id");
        }

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }

       /* private void feesBindingSource_CurrentChanged(object sender, EventArgs e)
        {

        } */

        private void grpCurrent_Enter(object sender, EventArgs e)
        {

        }
        int studentId = 0;
        private void cmbStudent_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbStudent.SelectedValue.ToString(), out studentId);
            if(studentId!=0)
                _fees= _feeService.GetFeeDetails(studentId);
            if (_fees != null)
            {
                txtCourse.Text = _fees.CourseName;
                txtAmount.Text = Convert.ToString(_fees.Amount);
                


            }
        }
        int courseId = 0;
        //private void cmbCourses_SelectedIndexChanged(object sender, EventArgs e)
        //{
        //    Int32.TryParse(cmbCourses.SelectedValue.ToString(), out courseId);
        //}

        private void btnCreate_Click(object sender, EventArgs e)
        {
             Fee fees = new Fee();
            fees.Students_Id = studentId;
            fees.Month = cmbMonth.Text;
            fees.Year = cmbYear.Text;
            fees.Courses_Id = courseId;
            fees.Amount = Convert.ToDouble(txtAmount.Text);
            
            //calling function to create fees
            _feeService.CreateFee(fees);
        }

        private void dgvList_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void dgvList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
          _fees = dgvList.Rows[e.RowIndex].DataBoundItem as Fees;

            //txtName.Text = batch.Name;
            //txtNameud.Text = _batch.Name;
            cmbStd.Text = _fees.StudentName;
            cmbCrse.Text = _fees.CourseName;
            cmbMnth.Text = _fees.Month;
            cmbYr.Text= _fees.Year;
            txtAmnt.Text= Convert.ToString(_fees.Amount);
            tabFees.SelectedTab = tabFees.TabPages[2];
        }

      
        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void cmbStd_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbStd.SelectedValue.ToString(), out studentId);
        }

        private void cmbCrse_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(cmbCrse.SelectedValue.ToString(), out courseId);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _fees.Students_Id = studentId;
            _fees.Month = cmbMnth.Text;
            _fees.Year = cmbYr.Text;
            _fees.Courses_Id = courseId;
            _fees.Amount = Convert.ToDouble(txtAmnt.Text);
            _feeService.UpdateFee(_fees);
            
            MessageBox.Show("Batch Updated succesfully");


        }

        private void grpUpdateDelete_Enter(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            _feeService.DeleteFee(_fees.Id);
            cmbStd.SelectedIndex= -1;
            cmbMnth.SelectedIndex = -1;
            cmbYr.SelectedIndex = -1;
            cmbCrse.SelectedIndex = -1;
            txtAmnt.Clear();
            MessageBox.Show("Fee Record delted successfully");


        }

        
    }
}
