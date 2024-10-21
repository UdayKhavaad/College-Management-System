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
    public partial class Fees : Form
    {
        public Fees()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Fees_Load(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void txtRegNumber_TextChanged(object sender, EventArgs e)
        {
           
           if (txtRegNumber.Text != "")
          
            {
             
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");

        SqlCommand cmd = new SqlCommand();
        cmd.Connection = con;

            cmd.CommandText = "select fname,mname,duration from NewAddmission where NAID = " +txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
        DataSet DS = new DataSet();
        DA.Fill(DS);

        if (DS.Tables[0].Rows.Count != 0)
                {
                    fnameLabel.Text = DS.Tables[0].Rows[0][0].ToString();
                    MnameLabel.Text = DS.Tables[0].Rows[0][1].ToString();
                    durationLabel.Text = DS.Tables[0].Rows[0][2].ToString();

                }
                else
                {
                    fnameLabel.Text = "_________";
                    MnameLabel.Text = "_________";
                    durationLabel.Text = "_________";

                }
                
         
            }

            else
            {
                fnameLabel.Text = "_________";
                MnameLabel.Text = "_________";
                durationLabel.Text = "_________";


            }




        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");

            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from fees where NAID=" + txtRegNumber.Text + "";
            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);


            if (DS.Tables[0].Rows.Count == 0)
            {
                SqlConnection con1 = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");

                SqlCommand cmd1 = new SqlCommand();
                cmd1.Connection = con1;

                cmd1.CommandText = "insert into fees (NAID,fees) values(" + txtRegNumber.Text + "," + txtFees.Text + ")";
                SqlDataAdapter DA1 = new SqlDataAdapter(cmd1);
                DataSet DS1 = new DataSet();
                DA1.Fill(DS1);

                if (MessageBox.Show("Fees Submition Succcessfull.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Asterisk) == DialogResult.OK)
                {
                    txtRegNumber.Text = "";
                    txtFees.Text = "";
                    fnameLabel.Text = "_________";
                    MnameLabel.Text = "_________";
                    durationLabel.Text = "_________";
                }
            }
            else
            {
                MessageBox.Show("Fees is AllReady Submitted.");
                txtRegNumber.Text = "";
                txtFees.Text = "";
                fnameLabel.Text = "_________";
                MnameLabel.Text = "_________";
                durationLabel.Text = "_________";
            }




            

        }
    }
}
