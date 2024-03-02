using System;
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
    public partial class CreateGroupUC : UserControl
    {
        AdvisorForm form;
        public CreateGroupUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void tableLayoutPanel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void createdOn_ValueChanged(object sender, EventArgs e)
        {

        }
    }
}
