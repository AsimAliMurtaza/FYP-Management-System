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
    public partial class UpdateProject : UserControl
    {
        AdvisorForm form;
        int id;
        public UpdateProject(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayProjects();
            guna2DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string title = TitleTxt.Text;
            string description = Descriptiontxt.Text;

            if (title == "" || description == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            if (!Utilities.IsName(title))
            {
                MessageBox.Show("Invalid Title");
                return;
            }
            else
            {
                updateProject();
            }
            
        }

        private void updateProject()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Project SET Description = @Description, Title = @Title WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Description", Descriptiontxt.Text);
                cmd.Parameters.AddWithValue("@Title", TitleTxt.Text);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Updated Successfully");
                displayProjects();
            }
            catch (Exception)
            {

            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                id = (int)selectedRow.Cells["Id"].Value;
                Descriptiontxt.Text = selectedRow.Cells["Description"].Value.ToString();
                TitleTxt.Text = selectedRow.Cells["Title"].Value.ToString();
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
        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addGroupControlUC();
        }

        private void TitleTxt_TextChanged(object sender, EventArgs e)
        {
            if(!Utilities.IsName(TitleTxt.Text))
            {
                MessageBox.Show("Invalid Title");
                return;
            }
        }

        private void UpdateProject_VisibleChanged(object sender, EventArgs e)
        {
            displayProjects();
        }
    }
}
