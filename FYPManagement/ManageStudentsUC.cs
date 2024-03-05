using Lab1;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Collections.Specialized.BitVector32;

namespace FYPManagement
{
    public partial class ManageStudentsUC : UserControl
    {
        AdvisorForm form;
        public ManageStudentsUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
            setComboBox();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }
        private void updateStdBtn_Click(object sender, EventArgs e)
        {
            form.addStudentUpdateControls();
        }
        private void viewStdBtn_Click(object sender, EventArgs e)
        {
            form.addStudentViewControls();
        }

        private void addStdBtn_Click(object sender, EventArgs e)
        {
            string regNo = RegNoTxt.Text;
            Student student = new Student(regNo, fNameTxt.Text, LNameTxt.Text, ContactTxt.Text, emailTxt.Text, int.Parse(genderCB.SelectedValue.ToString()));
            addStudent(student);
        }

        private void addStudent(Student student)
        {
            var con = Configuration.getInstance().getConnection();

            SqlCommand cmd = new SqlCommand("INSERT INTO Person (FirstName, LastName, Contact, Email, DateOfBirth, Gender) VALUES (@FirstName, @LastName, @Contact, @Email, @DateOfBirth, @Gender)", con);
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
            cmd.Parameters.AddWithValue("@LastName", student.LastName);
            cmd.Parameters.AddWithValue("@Contact", student.Contact);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@DateOfBirth", DoB.Value);
            cmd.Parameters.AddWithValue("@Gender", student.gender);
            cmd.ExecuteNonQuery();

            SqlCommand cmd3 = new SqlCommand("SELECT Id FROM Person Where FirstName = @FirstName AND LastName = @LastName AND Email = @Email AND Contact = @Contact", con);
            cmd3.Parameters.AddWithValue("@FirstName", student.FirstName);
            cmd3.Parameters.AddWithValue("@LastName", student.LastName);
            cmd3.Parameters.AddWithValue("@Contact", student.Contact);
            cmd3.Parameters.AddWithValue("@Email", student.Email);
            int personId = (int)cmd3.ExecuteScalar();

            SqlCommand cmd2 = new SqlCommand("INSERT INTO Student VALUES (@personId, @RegistrationNo)", con);
            cmd2.Parameters.AddWithValue("@RegistrationNo", student.RegistrationNumber);
            cmd2.Parameters.AddWithValue("@personId", personId);
            cmd2.ExecuteNonQuery();
            MessageBox.Show("Successfully saved");
        }

        void setComboBox()
        {
            genderCB.DataSource = new BindingSource(getGenderKeyValuePair("GENDER"), null);
            genderCB.DisplayMember = "Value";
            genderCB.ValueMember = "Key";
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

    }
}