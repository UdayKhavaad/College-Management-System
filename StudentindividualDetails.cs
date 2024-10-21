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
    public partial class StudentindividualDetails : Form
    {
        public StudentindividualDetails()
        {
            InitializeComponent();
        }

        private void StudentindividualDetails_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void labelAddress_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label7_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void label9_Click(object sender, EventArgs e)
        {

        }

        private void label10_Click(object sender, EventArgs e)
        {

        }

        private void label11_Click(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            labelFullName.Text = "________";
            labelMName.Text = "________";
            labelGender.Text = "________";
            labelDOB.Text = "________";
            labelMobile.Text = "________";
            labelEmail.Text = "________";
            labelStandard.Text = "________";
            labelMedium.Text = "________";
            labelSName.Text = "________";
            labelYear.Text = "________";
            labelAddress.Text = "________";

            textBox1.Text = "";
        }

        private void btnShowDetails_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ASUS\source\repos\Cms\College.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText="select * from NewAddmission where NAID = "+textBox1.Text+"";

            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            if (ds.Tables[0].Rows.Count != 0)
            {
                labelFullName.Text = ds.Tables[0].Rows[0][1].ToString();
                labelMName.Text = ds.Tables[0].Rows[0][2].ToString();
                labelGender.Text = ds.Tables[0].Rows[0][3].ToString();
                labelDOB.Text = ds.Tables[0].Rows[0][4].ToString();
                labelMobile.Text = ds.Tables[0].Rows[0][5].ToString();
                labelEmail.Text = ds.Tables[0].Rows[0][6].ToString();
                labelStandard.Text = ds.Tables[0].Rows[0][7].ToString();
                labelMedium.Text = ds.Tables[0].Rows[0][8].ToString();
                labelSName.Text = ds.Tables[0].Rows[0][9].ToString();
                labelYear.Text = ds.Tables[0].Rows[0][10].ToString();
                labelAddress.Text = ds.Tables[0].Rows[0][11].ToString();
            }
            else
            {
                MessageBox.Show("No Record Found", "No Match", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
