﻿using System;
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
    public partial class AllBatches : Form
    {
        public AllBatches()
        {
            InitializeComponent();
        }

        private void AllBatches_Load(object sender, EventArgs e)
        {
            AllBatches childBatch = new AllBatches();
            //childBatch.ismdi
        }
    }
}
