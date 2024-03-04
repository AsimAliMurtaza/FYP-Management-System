using System;
using Lab1;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace FYPManagement
{
    public partial class ViewGroupsUC : UserControl
    {
        AdvisorForm form;
        public ViewGroupsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayGroups();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageGroupsControl();
        }

        private void displayGroups()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM [Group]", con);
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

        private void guna2DataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void tableLayoutPanel1_Paint(object sender, PaintEventArgs e)
        {

        }
    }
}
