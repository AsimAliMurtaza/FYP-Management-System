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
    public partial class ManageProjects : UserControl
    {
        AdvisorForm form;
        public ManageProjects(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addPrjBtn_Click(object sender, EventArgs e)
        {
            string title = PrjTitletxt.Text;
            string description = PrjDescTxt.Text;

            if (title == "" || description == "")
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                addProject(title, description);
            }
        }

        private void addProject(string title, string description)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Project (Title, Description) VALUES (@title, @description)", con);
                cmd.Parameters.AddWithValue("@title", title);
                cmd.Parameters.AddWithValue("@description", description);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Project Added Successfully");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
            
        }

        private void viewPrjBtn_Click(object sender, EventArgs e)
        {
            form.viewProjectsControl();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }

        private void updatePrjBtn_Click(object sender, EventArgs e)
        {
            form.addUpdateProjectControl();
        }

        private void DeleteProjectBtn_Click(object sender, EventArgs e)
        {
            form.addDeleteProjectControl();
        }
    }
}
