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
    public partial class ManageGroupsUC : UserControl
    {
        AdvisorForm form;
        public ManageGroupsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void viewGrpsBtn_Click(object sender, EventArgs e)
        {
            form.addGroupsViewUC();
        }

        private void AddToGrpBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsToGroupControls();
        }

        private void createGrpBtn_Click(object sender, EventArgs e)
        {
            form.addCreateGroupControls();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }
    }
}
