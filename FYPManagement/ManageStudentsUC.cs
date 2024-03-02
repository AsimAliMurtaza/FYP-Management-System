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
    public partial class ManageStudentsUC : UserControl
    {
        AdvisorForm form;
        public ManageStudentsUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }

        private void guna2Button2_Click(object sender, EventArgs e)
        {
            form.addStudentViewControl();
        }
    }
}
