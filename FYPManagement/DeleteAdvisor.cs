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
    public partial class DeleteAdvisor : UserControl
    {
        AdvisorForm form;
        public DeleteAdvisor(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            DisplayAdvisors();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            softDeleteAdvisor();
        }

        private void DisplayAdvisors()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT 
                                    Person.FirstName, 
                                    Person.LastName, 
                                    Person.Contact, 
                                    Person.Email, 
                                    Person.DateOfBirth, 
                                    Person.Gender,
                                    Advisor.Designation,
                                    Advisor.Salary
                                  FROM 
                                    Advisor 
                                  INNER JOIN 
                                    Person ON Advisor.Id = Person.Id 
                                    WHERE  Person.FirstName NOT LIKE '%-deleted'", con);

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

        private void softDeleteAdvisor()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName + '-deleted' WHERE FirstName= @FirstName AND LastName = @LastName AND Email = @Email AND Contact = @Contact", con);
                cmd.Parameters.AddWithValue("@FirstName", guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                cmd.Parameters.AddWithValue("@LastName", guna2DataGridView1.SelectedRows[0].Cells[1].Value.ToString());
                cmd.Parameters.AddWithValue("@Contact", guna2DataGridView1.SelectedRows[0].Cells[2].Value.ToString());
                cmd.Parameters.AddWithValue("@Email", guna2DataGridView1.SelectedRows[0].Cells[3].Value.ToString());
                cmd.ExecuteNonQuery();
                MessageBox.Show("Advisor Deleted Successfully");
                DisplayAdvisors();

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorsControl();
        }

        private void DeleteAdvisor_VisibleChanged(object sender, EventArgs e)
        {
            DisplayAdvisors();
        }
    }
}
