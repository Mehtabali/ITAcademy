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
    public partial class Attendence : Form
    {

        [Dependency]
        public IAttendanceService _attendanceService{get;set;}
        private TestTransition _testTransition;
        DbConnection connection;

        public Attendence()
        {
            InitializeComponent();
        }
        public Attendence(IAttendanceService attendanceService)
        {
            _attendanceService = attendanceService;
            InitializeComponent();
        }

        private void Attendence_WinForm_Load(object sender, EventArgs e)
        {
            //txtTodayDate.Text = DateTime.Now.ToString();
            cmbBatch.Load(_attendanceService.GetAllBatches().ToDataTable(),"Name","Id");

        }
       int batchId=0;
        private void cmbBatch_SelectedIndexChanged(object sender, EventArgs e)
        {
            Int32.TryParse(Convert.ToString(cmbBatch.SelectedIndex), out batchId);
            if (batchId != 0) {

                _testTransition = _attendanceService.GetBatchDetails(batchId);
                if (_testTransition != null) {
                   txtCourse.Text=_testTransition.CourseName;
                   txtTeacher.Text = _testTransition.TeacherName;
                
                }
            }
        }
        DataTable datatable;

        private void btnView_Click(object sender, EventArgs e)
        {
            datatable = _attendanceService.GetBatchStudents(batchId).ToDataTable();
            DataTableReader dtr = datatable.CreateDataReader();
            Label lbl, lblSerialNumber, lblName, lblId, lblIsAttend;

            lblName = new Label();
            lblIsAttend = new Label();
            lblId = new Label();
            CheckBox chk;
            int sn = 1;
            int x = 40;
            int y = 70;
            while (dtr.Read()) {
                lblSerialNumber = new Label();
                lblSerialNumber.Text = (sn++).ToString();
                lblSerialNumber.Location = new Point(x, y);
                grpStudents.Controls.Add(lblSerialNumber);
                lblId = new Label();
                x = x + lblSerialNumber.Width;
                lblId.Text = dtr["studentId"].ToString();
                lblId.Location = new Point(x, y);
                grpStudents.Controls.Add(lblId);
                lblName = new Label();
                x = x + lblId.Width;
                lblName.Text = dtr["studentName"].ToString();
                lblName.Location = new Point(x,y);
                grpStudents.Controls.Add(lblName);
                chk = new CheckBox();
                chk.Checked = true;
                x = x + lblName.Width;
                grpStudents.Controls.Add(chk);
                chk.Location = new Point(x+130,y);
                y = y + 21;
                x = 40;


            
            }
               
        }

       
    }
}
