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
    public partial class Attendence : Form
    {
        public Attendence()
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

        private void tabPage1_Click(object sender, EventArgs e)
        {

        }
    }
}
