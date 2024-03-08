using iTextSharp.text.pdf;
using iTextSharp.text;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using iText.Layout.Properties;
using iText.Kernel.Colors;
using Lab1;

namespace FYPManagement
{
    public partial class ManageReports : UserControl
    {
        AdvisorForm form;
        viewReport1 viewReport1 = new viewReport1();
        viewReport2 viewReport2 = new viewReport2();
        viewReport3 viewReport3 = new viewReport3();
        public ManageReports(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void viewRep1_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(viewReport1);
            rep1Btn.Dock = DockStyle.Fill;
        }

        private void rep2Btn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(viewReport2);    
            viewReport2.Dock = DockStyle.Fill;
        }

        private void rep3Btn_Click(object sender, EventArgs e)
        {
            tableLayoutPanel2.Controls.Clear();
            tableLayoutPanel2.Controls.Add(viewReport3);
            viewReport3.Dock = DockStyle.Fill;
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }
    }
}