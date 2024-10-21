using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Cms
{
    public partial class UpgradeSemester : Form
    {
        SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ASUS\source\repos\Cms\College.mdf; Integrated Security = True");

        public UpgradeSemester()
        {
            InitializeComponent();
        }

       
        SqlCommand cmd;

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Upgrade_Click(object sender, EventArgs e)
        {
            string query = $"Update NewAddmission SET semester = '{comboBox2.Text}' WHERE semester = '{comboBox1.Text}'";

            con.Open();

            cmd = new SqlCommand(query,con);

            cmd.ExecuteNonQuery();

            MessageBox.Show("Semester Updated!");

        }
    }
}
