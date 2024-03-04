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
    public partial class ManageEvaluationsUC : UserControl
    {
        AdvisorForm form;
        public ManageEvaluationsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
        }

        private void addEvalBtn_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(evalNameTxt.Text))
            {
                MessageBox.Show("Please fill all the fields");
            }
            else
            {
                addEvaluation();

            }
        }

        private void addEvaluation()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO Evaluation (Name, TotalMarks, TotalWeightage) VALUES (@name, @totalMarks, @totalWeightage)", con);
                cmd.Parameters.AddWithValue("@name", evalNameTxt.Text);
                cmd.Parameters.AddWithValue("@totalMarks", marksUD.Value);
                cmd.Parameters.AddWithValue("@totalWeightage", weightageUD.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Evaluation Added Successfully");
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addAdminDashboardControl();
        }

        private void viewEvalBtn_Click(object sender, EventArgs e)
        {
            form.addViewEvaluationsControl();
        }

        private void updateEvalBtn_Click(object sender, EventArgs e)
        {
            form.addUpdateEvaluationControl();
        }

        private void doEvalBtn_Click(object sender, EventArgs e)
        {
            form.addEvaluateGroupsControl();
        }
    }
}
