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


        private void mngStdBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void mngAdvBtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorsControl();
        }

        private void ManageProjectsBtn_Click(object sender, EventArgs e)
        {
            form.addGroupControlUC();
        }

        private void manageGroupsBtn_Click(object sender, EventArgs e)
        {
            form.addManageGroupsControl();
        }
    }
}
