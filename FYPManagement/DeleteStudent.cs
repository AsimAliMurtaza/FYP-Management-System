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
    public partial class DeleteStudent : UserControl
    {
        AdvisorForm form;
        string name;
        public DeleteStudent(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            DisplayStudents();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            softDeleteStudent();
        }

        private void DisplayStudents()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
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

        private void softDeleteStudent()
        {

            string regNo = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            getStudentFirstName();
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Person SET FirstName = @Name + '-deleted' FROM Person INNER JOIN Student ON Student.Id = Person.Id WHERE RegistrationNo = @regNO", con);
                cmd.Parameters.AddWithValue("@Name", name);
                cmd.Parameters.AddWithValue("@regNO", regNo);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Student Deleted Successfully");
                DisplayStudents();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void getStudentFirstName()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                string regNo = guna2DataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                SqlCommand cmd = new SqlCommand("SELECT FirstName FROM Person INNER JOIN Student ON Student.Id = Person.Id WHERE RegistrationNo = @regNO", con);
                cmd.Parameters.AddWithValue("@regNO", regNo);
                name = (string)cmd.ExecuteScalar();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void guna2Button1_Click(object sender, EventArgs e)
        {
            form.addStudentsControl();
        }

        private void DeleteStudent_VisibleChanged(object sender, EventArgs e)
        {
            DisplayStudents();
        }
    }
}
