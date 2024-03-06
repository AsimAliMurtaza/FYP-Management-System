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
    public partial class ManageAdvisorsUC : UserControl
    {
        AdvisorForm form;
        public ManageAdvisorsUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
            setGenderComboBox();
            setDesignationComboBox();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }

        private void addAdvBtn_Click(object sender, EventArgs e)
        {
            Advisor advisor = new Advisor(FNameTxt.Text, LNameTxt.Text, ContactTxt.Text, EmailTxt.Text, designationsCB.SelectedValue.ToString(), SalaryTxt.Text, int.Parse(GenderCB.SelectedValue.ToString()));
            addAdvisor(advisor);
        }
        private void addAdvisor(Advisor advisor)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", advisor.FirstName);
            cmd.Parameters.AddWithValue("@LastName", advisor.LastName);
            cmd.Parameters.AddWithValue("@Contact", advisor.Contact);
            cmd.Parameters.AddWithValue("@Email", advisor.Email);
            cmd.Parameters.AddWithValue("@DateOfBirth", DOB.Value);
            cmd.Parameters.AddWithValue("@Gender", advisor.gender);
            cmd.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("SELECT Id FROM Person Where FirstName = @FirstName AND LastName = @LastName AND Email = @Email AND Contact = @Contact", con);
            cmd3.Parameters.AddWithValue("@FirstName", advisor.FirstName);
            cmd3.Parameters.AddWithValue("@LastName", advisor.LastName);
            cmd3.Parameters.AddWithValue("@Contact", advisor.Contact);
            cmd3.Parameters.AddWithValue("@Email", advisor.Email);
            int personId = (int)cmd3.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO Advisor VALUES (@personId, @Designation, @Salary)", con);
            cmd2.Parameters.AddWithValue("@Designation", advisor.Designation);
            cmd2.Parameters.AddWithValue("@Salary", advisor.Salary);
            cmd2.Parameters.AddWithValue("@personId", personId);

            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
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

        private void viewAdvBtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorViewControls();
        }

        private void updateAdvbtn_Click(object sender, EventArgs e)
        {
            form.addAdvisorUpdateControlUC();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            form.addDeleteAdvisorControl();
        }
    }
}
