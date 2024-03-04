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
    public partial class EvaluateGroupsUC : UserControl
    {
        AdvisorForm form;
        public EvaluateGroupsUC(AdvisorForm form)
        {
            InitializeComponent();
            this.form = form;
            setGroupComboBox();
            setEvalComboBox();
            displayEvaluatedGroups();
        }

        private void EvaluateBtn_Click(object sender, EventArgs e)
        {
            EvaluateGroup();
        }


        void setGroupComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Id, Created_On FROM [Group]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<string, int> groups = new Dictionary<string, int>();
            while (reader.Read())
            {
                groups.Add(reader.GetDateTime(1).ToString(), reader.GetInt32(0));
            }
            groupIDCB.DataSource = new BindingSource(groups, null);
            groupIDCB.DisplayMember = "Value";
            groupIDCB.ValueMember = "Key";
            reader.Close();
        }
        void setEvalComboBox()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT Id, Name FROM [Evaluation]", con);
            SqlDataReader reader = cmd.ExecuteReader();
            Dictionary<int, string> groups = new Dictionary<int, string>();
            while (reader.Read())
            {
                groups.Add(reader.GetInt32(0), reader.GetString(1));
            }
            EvalIDCB.DataSource = new BindingSource(groups, null);
            EvalIDCB.DisplayMember = "Value";
            EvalIDCB.ValueMember = "Key";
            reader.Close();
        }

        private void EvaluateGroup()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO GroupEvaluation (GroupId, EvaluationId, ObtainedMarks, EvaluationDate) VALUES (@groupId, @evalId, @obtainedMarks, @evalDate)", con);
                cmd.Parameters.AddWithValue("@groupId", ((KeyValuePair<string, int>)groupIDCB.SelectedItem).Value);
                cmd.Parameters.AddWithValue("@evalId", ((KeyValuePair<int, string>)EvalIDCB.SelectedItem).Key);
                cmd.Parameters.AddWithValue("@obtainedMarks", ObtmarksUD.Value);
                cmd.Parameters.AddWithValue("@evalDate", evalDate.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Group Evaluated Successfully");
                displayEvaluatedGroups();
            }
            catch (Exception er)
            {
                MessageBox.Show("Error: " + er.Message);
            }
        }

        private void displayEvaluatedGroups()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            SqlCommand cmd = new SqlCommand("SELECT * FROM GroupEvaluation", con);
            SqlDataReader reader = cmd.ExecuteReader();
            DataTable dt = new DataTable();
            dt.Load(reader);
            guna2DataGridView1.DataSource = dt;
            reader.Close();
        }

        private void backBtn_Click(object sender, EventArgs e)
        {
            form.addManageEvaluationsControl();
        }
    }
}
