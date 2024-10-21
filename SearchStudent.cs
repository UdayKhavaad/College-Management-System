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
    public partial class SearchStudent : Form
    {
        public SearchStudent()
        {
            InitializeComponent();
        }

        private void SearchStudent_Load(object sender, EventArgs e)
        {
            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select NewAddmission.NAID as Student_ID,NewAddmission.fname as Full_Name,NewAddmission.mname as Mother_Name,NewAddmission.gender as Gender,NewAddmission.dob as Date_Of_Birth,NewAddmission.mobile as Mobile,NewAddmission.email as Email_ID,NewAddmission.semester as Semester,NewAddmission.prog as Programming_Language,NewAddmission.sname as School_Name,NewAddmission.duration as Course_Duration,NewAddmission.addres as Address,fees.fees as Fees From NewAddmission inner join fees on NewAddmission.NAID=Fees.NAID";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];

            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select * from NewAddmission where NAID = "+textBox1.Text+"";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            dataGridView1.DataSource = ds.Tables[0];
        }
    }
}
