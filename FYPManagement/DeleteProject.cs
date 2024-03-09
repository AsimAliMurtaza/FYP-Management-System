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
    public partial class DeleteProject : UserControl
    {
        AdvisorForm form;
        public DeleteProject(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayProjects();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addManageProjectControlUC();
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

        private void softDeleteProject()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int index = guna2DataGridView1.CurrentCell.RowIndex;
                string id = guna2DataGridView1.Rows[index].Cells[0].Value.ToString();
                SqlCommand cmd2 = new SqlCommand("SELECT Title FROM Project WHERE Id = @Id", con);
                cmd2.Parameters.AddWithValue("@Id", id);
                string title = cmd2.ExecuteScalar().ToString();

                SqlCommand cmd = new SqlCommand("UPDATE Project SET Title = @title + '-deleted' WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Deleted Successfully");
                displayProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            softDeleteProject();
        }

        private void DeleteProject_VisibleChanged(object sender, EventArgs e)
        {
            displayProjects();
        }
    }
}
