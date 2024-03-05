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
    public partial class StudentsToGroupUC : UserControl
    {
        AdvisorForm form;
        public StudentsToGroupUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            setStudent();
            setGroup();
            DisplayGroupStudents();
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageGroupsControl();
        }

        private void addToGrpBtn_Click(object sender, EventArgs e)
        {
            int studentId = int.Parse(studentCB.SelectedValue.ToString());
            int groupId = int.Parse(groupCB.SelectedValue.ToString());
            AddStudentToGroup(studentId, groupId);
        }
        private void AddStudentToGroup(int studentId, int groupId)
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmdCheckStudentInGroup = new SqlCommand("SELECT COUNT(*) FROM GroupStudent WHERE StudentID = @StudentID AND GroupID = @GroupID", con);
                cmdCheckStudentInGroup.Parameters.AddWithValue("@StudentID", studentId);
                cmdCheckStudentInGroup.Parameters.AddWithValue("@GroupID", groupId);
                int count = (int)cmdCheckStudentInGroup.ExecuteScalar();

                if (count > 0)
                {
                    MessageBox.Show("Student is already in the group.");
                }
                else
                {
                    int activeStatusId = GetStatusId("Active", con);
                    if (activeStatusId == -1)
                    {
                        MessageBox.Show("Error: Active status not found in the lookup table.");
                        return;
                    }

                    SqlCommand cmdAddStudentToGroup = new SqlCommand("INSERT INTO GroupStudent (StudentID, GroupID, Status, AssignmentDate) VALUES (@StudentID, @GroupID, @Status, GETDATE())", con);
                    cmdAddStudentToGroup.Parameters.AddWithValue("@StudentID", studentId);
                    cmdAddStudentToGroup.Parameters.AddWithValue("@GroupID", groupId);
                    cmdAddStudentToGroup.Parameters.AddWithValue("@Status", activeStatusId);
                    int rowsAffected = cmdAddStudentToGroup.ExecuteNonQuery();
                    if (rowsAffected > 0)
                    {
                        MessageBox.Show("Student details updated successfully.");
                        DisplayGroupStudents(); 
                    }
                    else
                    {
                        MessageBox.Show("No student found with the provided registration number.");
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private int GetStatusId(string statusName, SqlConnection con)
        {
            int statusId = -1;
            try
            {
                SqlCommand cmdGetStatusId = new SqlCommand("SELECT Id FROM Lookup WHERE Category = 'STATUS' AND Value = @Value", con);
                cmdGetStatusId.Parameters.AddWithValue("@Value", statusName);
                object result = cmdGetStatusId.ExecuteScalar();
                if (result != null && result != DBNull.Value)
                {
                    statusId = Convert.ToInt32(result);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error fetching status ID: " + ex.Message);
            }
            return statusId;
        }

        private void setStudent()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                    SqlCommand cmd = new SqlCommand("SELECT Id, RegistrationNo FROM Student", con);
                    SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                    DataTable dt = new DataTable();
                    adapter.Fill(dt);

                    studentCB.DataSource = dt;
                    studentCB.DisplayMember = "RegistrationNo";
                    studentCB.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }   

        private void setGroup()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id FROM [Group]", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);

                groupCB.DataSource = dt;
                groupCB.DisplayMember = "Id";
                groupCB.ValueMember = "Id";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void DisplayGroupStudents()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand(@"SELECT DISTINCT
                                    [Group].Id AS GroupId, 
                                    GroupStudent.StudentId as GroupStudentID,
                                    Student.RegistrationNo, 
                                    Person.FirstName, 
                                    Lookup.Value AS Status, 
                                    GroupStudent.AssignmentDate 
                                  FROM 
                                    GroupStudent 
                                  INNER JOIN 
                                    Student ON GroupStudent.StudentId = Student.Id 
                                  INNER JOIN 
                                    Person ON Student.Id = Person.Id 
                                  INNER JOIN 
                                    [Group] ON GroupStudent.GroupId = [Group].Id 
                                  INNER JOIN 
                                    Lookup ON GroupStudent.Status = Lookup.Id 
                                  WHERE 
                                    Lookup.Category = 'STATUS'", con);


                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
                remStdCB.DataSource = dt;
                remStdCB.DisplayMember = "RegistrationNo";
                remStdCB.ValueMember = "RegistrationNo";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }
        private void RemStdBtn_Click(object sender, EventArgs e)
        {
            try
            {
                if (remStdCB.SelectedItem != null)
                {
                    string registrationNo = remStdCB.SelectedValue.ToString();
                    RemoveStudentFromGroup(registrationNo);
                    DisplayGroupStudents();
                }
                else
                {
                    MessageBox.Show("Please select a student registration number.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }

        private void RemoveStudentFromGroup(string registrationNo)
        {
            try
            {
                var con = Configuration.getInstance().getConnection();
                if (con.State == ConnectionState.Closed)
                {
                    con.Open();
                }

                SqlCommand cmd = new SqlCommand("UPDATE GroupStudent SET Status = @Status WHERE StudentId = (SELECT Id FROM Student WHERE RegistrationNo = @RegistrationNo)", con);
                cmd.Parameters.AddWithValue("@Status", GetStatusId("InActive", con));
                cmd.Parameters.AddWithValue("@RegistrationNo", registrationNo);
                int rowsAffected = cmd.ExecuteNonQuery();

                if (rowsAffected > 0)
                {
                    MessageBox.Show("Student removed from group successfully and status set to Inactive.");
                }
                else
                {
                    MessageBox.Show("Failed to remove student from group.");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
            }
        }


        private void dataGridViewGroupStudents_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                RemStdBtn.Enabled = true;
            }
            else
            {
                RemStdBtn.Enabled = false;
            }
        }
    }
}
