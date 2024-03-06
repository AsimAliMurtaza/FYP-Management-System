using Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FYPManagement
{
    public partial class VIewProjectsUC : UserControl
    {
        AdvisorForm form;
        public VIewProjectsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayProjects();
        }
        private void displayProjects()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Title, Description FROM Project WHERE Title NOT LIKE '%-deleted'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addGroupControlUC();
        }

        private void guna2DataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            displayProjects();
        }
    }
}
