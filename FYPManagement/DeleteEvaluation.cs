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
    public partial class DeleteEvaluation : UserControl
    {
        AdvisorForm form;
        public DeleteEvaluation(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayEvaluations();
        }

        private void delBtn_Click(object sender, EventArgs e)
        {
            softDeleteEvaluation();
        }

        private void displayEvaluations()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("SELECT Id, Name, TotalMarks, TotalWeightage FROM Evaluation WHERE Name NOT LIKE '%-deleted'", con);
                SqlDataAdapter adapter = new SqlDataAdapter(cmd);
                DataTable dt = new DataTable();
                adapter.Fill(dt);
                guna2DataGridView1.DataSource = dt;
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void softDeleteEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Evaluation SET Name = @Name + '-deleted' WHERE Id = @id", con);
                cmd.Parameters.AddWithValue("@id", guna2DataGridView1.SelectedRows[0].Cells[0].Value);
                cmd.Parameters.AddWithValue("@Name", guna2DataGridView1.SelectedRows[0].Cells[1].Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation Deleted Successfully");
                displayEvaluations();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addManageEvaluationsControl();
        }

        private void DeleteEvaluation_VisibleChanged(object sender, EventArgs e)
        {
            displayEvaluations();
        }
    }
}
