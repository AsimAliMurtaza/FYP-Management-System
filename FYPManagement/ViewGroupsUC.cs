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
    public partial class ViewGroupsUC : UserControl
    {
        AdvisorForm form;
        public ViewGroupsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }
    }
}
