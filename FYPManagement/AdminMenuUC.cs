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
    public partial class AdminMenuUC : UserControl
    {
        AdvisorForm form;
        public AdminMenuUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            form.addAdvisorsControl();
        }
    }
}
