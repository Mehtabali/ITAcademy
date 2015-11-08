using ITAcademy.DataModels;
using ITAcademy.ServiceLayer;
using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ITAcademy.WinForms
{
    public partial class Students : Form
    {

        [Dependency]
      
        public IStudentService _studentService { get; set; }
       private  Student _student;
       private Student student; // to get value of select row from data list
        public Students()
        {
            InitializeComponent();
        }

        //Constructor injection
        public Students(IStudentService studentService,Student student)
        {
            _studentService = studentService;
            _student = student;
            InitializeComponent();
            dgvAllStudents.AutoGenerateColumns = false;

        }
         private void Students_Load(object sender, EventArgs e)
        {
            dgvAllStudents.DataSource = _studentService.GetAllStudents();
            dgvUpdate.DataSource = _studentService.GetAllStudents();
//student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;



        }
        private void dgvAllStudents_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;

            txtNameud.Text = student.Name;
            txtudAddress.Text = student.Address;
            txtudCity.Text = student.City;
            txtudContact.Text = student.Mobile;
            txtudDob.Text =   Convert.ToString(student.DOB);
            txtudEmail.Text = student.Email;
            txtudFather.Text = student.FatherName;
         //   dtpudAdmission.MinDate = new System.DateTime();
                Convert.ToString(student.AdmissionDate);
            tabStudent.SelectedTab = tabStudent.TabPages[1];

        }

        private void btnSave_Click(object sender, EventArgs e)
       {
            //_student.Name = txtName.Text;
            //_student.Mobile = txtContactNumber.Text;
            //_student.Email = txtEmail.Text;
            //_student.FatherName = txtFatherName.Text;
            //_student.Gender = cmbGender.Text;
            //_student.Address = txtAddress.Text;
            //_student.City = txtCity.Text;
            //_student.PIN = txtPin.Text;
            //DateTime date;
            //DateTime.TryParse(dtpudAdmission.Text, out date);
            //_student.DOB = date;
       

//            ValidationContext context = new ValidationContext(_student, null, null);
        //    IList<ValidationResult> errors = new List<ValidationResult>();

        //    if (!Validator.TryValidateObject(_student, context, errors, true))
        //    {
        //        foreach (ValidationResult result in errors)
        //            MessageBox.Show(result.ErrorMessage);
        //    }
        //    else
        //    {
        //        MessageBox.Show("Validated");
        //        _studentService.CreateStudent(_student);
        //    }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            _student.Name = txtNameud.Text;
            _student.Mobile = txtudContact.Text =
            _student.PIN = txtudPin.Text;
            _student.Gender = cmbudGender.Text;
            _student.DOB = Convert.ToDateTime(txtudDob.Text);
            _student.Email = txtudEmail.Text;
            _student.Address = txtudAddress.Text;
            _student.AdmissionDate = Convert.ToDateTime(dtpudAdmission.Text);
            _student.FatherName = txtudFather.Text;
            _student.City = txtudCity.Text;
            _studentService.UpdateStudent(_student);
            MessageBox.Show("Updated");

        }

        private void txtRegistrationNumber_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            txtNameud.Clear();
            txtudAddress.Clear();
            txtudCity.Clear();
            txtudFather.Clear();
            txtudDob.Clear();
            txtudContact.Clear();
            txtudPin.Clear();
            txtudCity.Clear();
            txtudEmail.Clear();
            dtpudAdmission.Text = "";
            _studentService.DeleteStudent(student.Id);
           
            MessageBox.Show("Deleted");
        }

        //private void dgvUpdate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        //{

        //    student = dgvAllStudents.Rows[e.RowIndex].DataBoundItem as Student;

        //    txtNameud.Text = student.Name;
        //    txtudAddress.Text = student.Address;
        //    txtudCity.Text = student.City;
        //    txtudContact.Text = student.Mobile;
        //    txtudDob.Text = Convert.ToString(student.DOB);
        //    txtudEmail.Text = student.Email;
        //    txtudFather.Text = student.FatherName;
        //    //   dtpudAdmission.MinDate = new System.DateTime();
        //    Convert.ToString(student.AdmissionDate);
        //    tabStudent.SelectedTab = tabStudent.TabPages[2];



        //    _student.Name = txtNameud.Text;
        //    _student.Mobile = txtudContact.Text =
        //    _student.PIN = txtudPin.Text;
        //    _student.Gender = cmbudGender.Text;
        //    _student.DOB = Convert.ToDateTime(txtudDob.Text);
        //    _student.Email = txtudEmail.Text;
        //    _student.Address = txtudAddress.Text;
        //    _student.AdmissionDate = Convert.ToDateTime(dtpudAdmission.Text);
        //    _student.FatherName = txtudFather.Text;
        //    _student.City = txtudCity.Text;
        //    _studentService.UpdateStudent(_student);

        //}
        int i;
        private void dgvUpdate_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            i = e.RowIndex;
            DataGridViewRow row = dgvUpdate.Rows[i];
            textBox1.Text = row.Cells[0].Value.ToString();
            textBox2.Text = row.Cells[1].Value.ToString();
            textBox3.Text = row.Cells[2].Value.ToString();


        }

        private void button1_Click(object sender, EventArgs e)
        {

            DataGridViewRow row = dgvUpdate.Rows[i];
            row.Cells[0].Value=textBox1.Text;
            row.Cells[1].Value=textBox2.Text;
            row.Cells[2].Value =textBox3.Text;

            SqlConnection sc = new SqlConnection();
           // SqlCommand com = new SqlCommand();
            sc.ConnectionString = ("data source=HP-PC;initial catalog=ITAcademyDatabase;integrated security=true");
            sc.Open();
          //  SqlCommand com = new SqlCommand("INSERT INTO Test VALUES (" +textBox1.Text+ ",'" + textBox2.Text + "', '" + textBox3.Text +"'",sc);
            SqlCommand command1 = new SqlCommand("INSERT INTO Test VALUES (@sitid1, @incident1, @nature1)", sc);
            command1.Parameters.AddWithValue("@sitid1",textBox1.Text);
            command1.Parameters.AddWithValue("@incident1",textBox2.Text);
            command1.Parameters.AddWithValue("@nature1", textBox3.Text);
           // com.Connection = sc;
           // com.CommandText = (@"INSERT INTO Test(Id,Name,Mobile) VALUES('"+textBox1.Text+ "''"+textBox2.Text+ "'+'" +textBox3.Text+"');");
           // com.CommandText = ("INSERT INTO Test VALUES('" + textBox1.Text + "''" + textBox2.Text + "'+'" + textBox3.Text + "')");
          


          //  com.CommandText = ("INSERT INTO Students(Name,Mobile,Email,FatherName,Gender,Address,City,State,PIN,DOB,ImagePath) values();");
         
            command1.ExecuteNonQuery();
            sc.Close();


        }

       

    
        }

      

   
    }

