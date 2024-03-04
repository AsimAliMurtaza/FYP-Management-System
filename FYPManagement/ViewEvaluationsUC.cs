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
    public partial class ViewEvaluationsUC : UserControl
    {
        AdvisorForm form;
        public ViewEvaluationsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayEvaluations();
        }

        private void displayEvaluations()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageEvaluationsControl();
        }
    }
}
