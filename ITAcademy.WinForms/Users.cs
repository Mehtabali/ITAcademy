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
using ITAcademy.DataModels;
using ITAcademy.ServiceLayer;
namespace ITAcademy.WinForms
{
    public partial class Users : Form
    {

        [Dependency]
        public IUserService _userService { get; set; }
        private User _user;
        public Users()
        {
            InitializeComponent();
        }
        public Users(IUserService userService,User user)
             {
                 _userService = userService;
                 _user = user;

            InitializeComponent();
            dgvUsersList.AutoGenerateColumns = false;
        }

        private void Users_Load(object sender, EventArgs e)
        {   
            cmbUserType.Load(_userService.GetAllTypes().ToDataTable(),"TypeName", "Id");
            cmbSearchUser.Load(_userService.GetAllUsers().ToDataTable(), "Name", "Id");
            dgvUsersList.DataSource = _userService.GetAllUsers();
        }

        private void dgvUsersList_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            _user = dgvUsersList.Rows[e.RowIndex].DataBoundItem as User;
            _user.Id =Convert.ToInt32(txtudReg.Text);
            _user.Name = txtudName.Text;
            _user.Mobile = txtudContact.Text;
            _user.Qualification = txtudQualification.Text;
            _user.Salary = Convert.ToInt32(txtudSalary.Text);
            _user.Email = txtudEmail.Text;
            _user.Users_Type_Id =Convert.ToInt32(txtudUserName.Text);
            _user.FatherName = txtudFather.Text;
            _user.HiringDate =  Convert.ToDateTime(txtudHiringDate.Text);
            _user.Designation = cmbudDesignation.Text;

            _userService.UpdateUser(_user);


            

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtudEmail_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
