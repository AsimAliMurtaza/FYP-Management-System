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
    public partial class CreateGroupUC : UserControl
    {
        AdvisorForm form;
        public CreateGroupUC(AdvisorForm f)
        {
            InitializeComponent();
            form = f;
        }

        private void BackBtn_Click(object sender, EventArgs e)
        {
            form.addManageGroupsControl();
        }

        private void createGrpBtn_Click(object sender, EventArgs e)
        {
            makeGroup();
        }
        private void makeGroup()
        {
            var con = Configuration.getInstance().getConnection();
            if (con.State == ConnectionState.Closed)
            {
                con.Open();
            }
            try
            {
                SqlCommand cmd = new SqlCommand("INSERT INTO [Group] (Created_On) VALUES (@Created_On)", con);
                cmd.Parameters.AddWithValue("@Created_On", createdOn.Value);
                cmd.ExecuteNonQuery();
                MessageBox.Show("Group Created Successfully");
            }
            catch (Exception er)
            {
                MessageBox.Show(er.Message);
            }
            
        }
    }
}
