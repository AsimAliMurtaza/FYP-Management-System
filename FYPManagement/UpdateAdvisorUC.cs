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
    public partial class UpdateAdvisorUC : UserControl
    {
        AdvisorForm form;
        public UpdateAdvisorUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
            DisplayAdvisors();
            setGenderComboBox();
            setDesignationComboBox();
            guna2DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            string dob = DOB.Value.ToString("yyyy-MM-dd");
            Advisor advisor = new Advisor(FNameTxt.Text, LNameTxt.Text, ContactTxt.Text, EmailTxt.Text, designationsCB.SelectedValue.ToString(), SalaryTxt.Text, int.Parse(GenderCB.SelectedValue.ToString()), dob);
            UpdateAdvisor(advisor);
        }
        private void UpdateAdvisor(Advisor advisor)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmdd = new SqlCommand("SELECT Id FROM Person WHERE FirstName = @FirstName AND LastName = @LastName AND Contact = @Contact AND Email = @Email", con); // Pass the connection object
                cmdd.Parameters.AddWithValue("@FirstName", advisor.FirstName);
                cmdd.Parameters.AddWithValue("@LastName", advisor.LastName);
                cmdd.Parameters.AddWithValue("@Contact", advisor.Contact);
                cmdd.Parameters.AddWithValue("@Email", advisor.Email);
                int id = (int)cmdd.ExecuteScalar();
                if (id > 0)
                {
                    SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, " +
                                                    "Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE Id = @Id;" +
                                                    "UPDATE Advisor SET Designation = @Designation, Salary = @Salary WHERE Id = @Id", con);
                    cmd.Parameters.AddWithValue("@FirstName", advisor.FirstName);
                    cmd.Parameters.AddWithValue("@LastName", advisor.LastName);
                    cmd.Parameters.AddWithValue("@Contact", advisor.Contact);
                    cmd.Parameters.AddWithValue("@Email", advisor.Email);
                    cmd.Parameters.AddWithValue("@DateOfBirth", advisor.dob);
                    cmd.Parameters.AddWithValue("@Gender", advisor.gender);
                    cmd.Parameters.AddWithValue("@Designation", advisor.Designation);
                    cmd.Parameters.AddWithValue("@Salary", advisor.Salary);
                    cmd.Parameters.AddWithValue("@Id", id);
                    int rowsAffected = cmd.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Advisor details updated successfully.");
                        DisplayAdvisors();
                    }
                    else
                    {
                        MessageBox.Show("No advisor found with the provided ID.");
                    }
                }
                else
                {
                    MessageBox.Show("No advisor found with the provided details.");
                    return;
                }

            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
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
                                    Person ON Advisor.Id = Person.Id", con);

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
        void setGenderComboBox()
        {
            GenderCB.DataSource = new BindingSource(getGenderKeyValuePair("GENDER"), null);
            GenderCB.DisplayMember = "Value";
            GenderCB.ValueMember = "Key";
        }
        void setDesignationComboBox()
        {
            designationsCB.DataSource = new BindingSource(getGenderKeyValuePair("DESIGNATION"), null);
            designationsCB.DisplayMember = "Value";
            designationsCB.ValueMember = "Key";
        }
        private Dictionary<int, string> getGenderKeyValuePair(string category)
        {
            Dictionary<int, string> keyValuePairs = new Dictionary<int, string>();
            var con = Configuration.getInstance().getConnection();
            SqlCommand cmd = new SqlCommand("SELECT Id, Value FROM Lookup WHERE Category = @category", con);
            cmd.Parameters.AddWithValue("@category", category);
            SqlDataReader reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                int id = Convert.ToInt32(reader["Id"]);
                string value = reader["Value"].ToString();
                keyValuePairs.Add(id, value);
            }
            reader.Close();
            return keyValuePairs;

        }
        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                FNameTxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                LNameTxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                ContactTxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                EmailTxt.Text = selectedRow.Cells["Email"].Value.ToString();
                DOB.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                GenderCB.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
                designationsCB.SelectedItem = selectedRow.Cells["Designation"].Value.ToString();
                SalaryTxt.Text = selectedRow.Cells["Salary"].Value.ToString();
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorsControl();
        }
    }
}
