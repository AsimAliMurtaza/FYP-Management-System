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
    public partial class AssignAdvisors : UserControl
    {
        AdvisorForm form;
        public AssignAdvisors(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            setAdvRoleComboBox();
            displayProjects();
            displayAdvisor();
            displayAssignedAdvisors();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageGroupsControl();
        }

        private void assignAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int projectId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                int advisorId = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
                int role = Convert.ToInt32(advRoleCB.SelectedValue);
                SqlCommand cmd = new SqlCommand("INSERT INTO ProjectAdvisor (AdvisorId, ProjectId, AdvisorRole, AssignmentDate) VALUES (@advisorId, @projectId, @role, @assignentDate)", con);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.Parameters.AddWithValue("@advisorId", advisorId);
                cmd.Parameters.AddWithValue("@role", role);
                cmd.Parameters.AddWithValue("@assignentDate", DateTime.Now);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Advisor Assigned Successfully");
                displayAssignedAdvisors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void deallocateAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                int projectId = Convert.ToInt32(guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                int advisorId = Convert.ToInt32(guna2DataGridView2.SelectedRows[0].Cells[0].Value);
                SqlCommand cmd = new SqlCommand("DELETE FROM ProjectAdvisor WHERE ProjectId = @projectId AND AdvisorId = @advisorId", con);
                cmd.Parameters.AddWithValue("@advisorId", advisorId);
                cmd.Parameters.AddWithValue("@projectId", projectId);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Advisor Deallocated Successfully");
                displayAssignedAdvisors();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void setAdvRoleComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Value FROM Lookup WHERE Category = 'ADVISOR_ROLE'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                advRoleCB.DataSource = dt;
                advRoleCB.DisplayMember = "Value";
                advRoleCB.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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

        private void displayAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Advisor.Id, Advisor.Designation, Person.FirstName FROM Advisor INNER JOIN Person on Advisor.Id = Person.Id WHERE Person.FirstName NOT LIKE '%-deleted'", con);
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
        private void displayAssignedAdvisors()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT * FROM ProjectAdvisor", con);
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
            assignAdvisor();
        }

        private void DeallocateBtn_Click(object sender, EventArgs e)
        {
            deallocateAdvisor();
        }

        private void AssignAdvisors_VisibleChanged(object sender, EventArgs e)
        {
            displayProjects();
            displayAdvisor();
            displayAssignedAdvisors();
        }
    }
}
