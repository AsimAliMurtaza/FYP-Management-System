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
    public partial class ViewAdvisorsUC : UserControl
    {
        AdvisorForm form;
        public ViewAdvisorsUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
            DisplayAdvisors();
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorsControl();
        }

        private void guna2DataGridView1_VisibleChanged(object sender, EventArgs e)
        {
            DisplayAdvisors();
        }

    }
}
