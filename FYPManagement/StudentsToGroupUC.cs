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
    public partial class StudentsToGroupUC : UserControl
    {
        AdvisorForm form;
        public StudentsToGroupUC(AdvisorForm form)
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
