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
    public partial class UpdateEvaluationUC : UserControl
    {
        int id;
        AdvisorForm form;
        public UpdateEvaluationUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            displayEvaluations();
            guna2DataGridView1.SelectionChanged += DataGridView1_SelectionChanged;
        }

        private void UpdateBtn_Click(object sender, EventArgs e)
        {
            updateEvaluation();
        }

        private void updateEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("UPDATE Evaluation SET Name = @Name, TotalMarks = @TotalMarks, TotalWeightage = @TotalWeightage WHERE Id = @Id", con);
                cmd.Parameters.AddWithValue("@Name", evalNameTxt.Text);
                cmd.Parameters.AddWithValue("@TotalMarks", marksUD.Value);
                cmd.Parameters.AddWithValue("@TotalWeightage", weightageUD.Value);
                cmd.Parameters.AddWithValue("@Id", id);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation Updated Successfully");
                displayEvaluations();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void DataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            if (guna2DataGridView1.SelectedRows.Count > 0)
            {
                DataGridViewRow selectedRow = guna2DataGridView1.SelectedRows[0];
                id = (int)selectedRow.Cells["Id"].Value;
                evalNameTxt.Text = selectedRow.Cells["Name"].Value.ToString();
                marksUD.Value = (int)selectedRow.Cells["TotalMarks"].Value;
                weightageUD.Value = (int)selectedRow.Cells["TotalWeightage"].Value;
            }
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
                SqlCommand cmd = new SqlCommand("SELECT * FROM Evaluation", con);
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

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageEvaluationsControl();
        }
    }
}
