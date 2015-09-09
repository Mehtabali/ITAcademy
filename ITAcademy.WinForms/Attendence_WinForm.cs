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
    public partial class Attendence_WinForm : Form
    {
        public Attendence_WinForm()
        {
            InitializeComponent();
        }

        private void Attendence_WinForm_Load(object sender, EventArgs e)
        {
            txtTodayDate.Text = DateTime.Now.ToString();

        }

        private void txtAttenenceDate_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void groupBox6_Enter(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }
    }
}
