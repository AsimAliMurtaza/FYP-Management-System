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
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;


namespace FYPManagement
{
    public partial class UpdateStudentUC : UserControl
    {
        AdvisorForm form;
        public UpdateStudentUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            DisplayStudents();
            setComboBox();
            guna2DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;

        }
        void setComboBox()
        {
            GenderCB.DataSource = new BindingSource(getGenderKeyValuePair("GENDER"), null);
            GenderCB.DisplayMember = "Value";
            GenderCB.ValueMember = "Key";
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
        private void DisplayStudents()
        {
            var con = Configuration.getInstance().getConnection();
            if(con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Student.RegistrationNo, Person.FirstName, Person.LastName, Person.Contact, Person.Email, Person.DateOfBirth, Person.Gender " +
                                "FROM Student " +
                                "INNER JOIN Person ON Student.Id = Person.Id " +
                                "WHERE NOT Person.FirstName LIKE '%-deleted'", con);
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

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                RegNoTxt.Text = selectedRow.Cells["RegistrationNo"].Value.ToString();
                FNameTxt.Text = selectedRow.Cells["FirstName"].Value.ToString();
                LNametxt.Text = selectedRow.Cells["LastName"].Value.ToString();
                ContactTxt.Text = selectedRow.Cells["Contact"].Value.ToString();
                EmailTxt.Text = selectedRow.Cells["Email"].Value.ToString();
                DOB.Value = Convert.ToDateTime(selectedRow.Cells["DateOfBirth"].Value);
                GenderCB.SelectedItem = selectedRow.Cells["Gender"].Value.ToString();
            }
        }

        private void ButtonUpdate_Click(object sender, EventArgs e)
        {
            string regNo = RegNoTxt.Text;
            Student student = new Student(regNo, FNameTxt.Text, LNametxt.Text, ContactTxt.Text, EmailTxt.Text, int.Parse(GenderCB.SelectedValue.ToString()));
            if(student.FirstName == "" || student.LastName == "" || student.Contact == "" || student.Email == "" || student.RegistrationNumber == "")
            {
                MessageBox.Show("Please fill all the fields.");
                return;
            }
            if(Utilities.IsPhone(ContactTxt.Text) && Utilities.IsEmail(EmailTxt.Text) && Utilities.IsName(FNameTxt.Text) && Utilities.IsName(LNametxt.Text))
            {
                UpdateStudent(student);
            }
            else
            {
                MessageBox.Show("Invalid input");
            }
        }

        private void UpdateStudent(Student student)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }

            SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @FirstName, LastName = @LastName, Contact = @Contact, " +
                                                "Email = @Email, DateOfBirth = @DateOfBirth, Gender = @Gender WHERE ID = (SELECT ID FROM Student WHERE RegistrationNo = @RegistrationNo)", con);
            cmd.Parameters.AddWithValue("@FirstName", student.FirstName);
            cmd.Parameters.AddWithValue("@LastName", student.LastName);
            cmd.Parameters.AddWithValue("@Contact", student.Contact);
            cmd.Parameters.AddWithValue("@Email", student.Email);
            cmd.Parameters.AddWithValue("@DateOfBirth", DOB.Value);
            cmd.Parameters.AddWithValue("@Gender", student.gender);
            cmd.Parameters.AddWithValue("@RegistrationNo", student.RegistrationNumber);
            int rowsAffected = cmd.ExecuteNonQuery();
            if (rowsAffected > 0)
            {
                MessageBox.Show("Student details updated successfully.");
                DisplayStudents();
            }
            else
            {
                MessageBox.Show("No student found with the provided registration number.");
            }
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void FNameTxt_TextChanged(object sender, EventArgs e)
        {
            if (!Utilities.IsName(FNameTxt.Text))
            {
                MessageBox.Show("Invalid First Name");
                return;
            }
        }

        private void LNametxt_TextChanged(object sender, EventArgs e)
        {
            if(!Utilities.IsName(LNametxt.Text))
            {
                MessageBox.Show("Invalid Last Name");
                return;
            }
        }
    }
}
