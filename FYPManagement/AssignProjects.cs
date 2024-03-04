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
    public partial class AssignProjects : UserControl
    {
        AdvisorForm form;
        public AssignProjects(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayGroups();
            displayProjects();
            displayAssignedProjects();
        }

        private void btnBack_Click(object sender, EventArgs e)
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Project", con);
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

                guna2DataGridView2.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void displayAssignedProjects()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM GroupProject", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                guna2DataGridView3.DataSource = dt;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void allocateBtn_Click(object sender, EventArgs e)
        {
            allocateProjects();
        }

        private void allocateProjects()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int projectId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                int groupId = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupProject (GroupId, ProjectId, AssignmentDate) VALUES (@groupId, @projectId, @date)", con);
                cmd.Parameters.AddWithValue("@groupId", groupId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@date", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Allocated Successfully");
                displayAssignedProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DeallocateBtn_Click(object sender, EventArgs e)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int projectId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                int groupId = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM GroupProject WHERE GroupId = @groupId AND ProjectId = @projectId", con);
                cmd.Parameters.AddWithValue("@groupId", groupId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Deallocated Successfully");
                displayAssignedProjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
    }
}
