﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagement
{
    public partial class ViewStudentsUC : UserControl
    {
        AdvisorForm form;
        public ViewStudentsUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}
