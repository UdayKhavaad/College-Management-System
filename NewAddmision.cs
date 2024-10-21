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

namespace Cms
{
    public partial class NewAddmision : Form
    {
        public NewAddmision()
        {
            InitializeComponent();
        }

        private void NewAddmision_Load(object sender, EventArgs e)
        {

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ASUS\source\repos\Cms\College.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "select max(NAID) from NewAddmission";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);

            Int64 abc = Convert.ToInt64(DS.Tables[0].Rows[0][0]);
            label14.Text = (abc+1).ToString();

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label8_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String name = txtFullName.Text;
            String mname = txtMotherName.Text;
            String gender = "";
            bool isChecked = radioButtonMale.Checked;
            if (isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }
            String dob = dateTimePickerDOB.Text;
            long mobile = long.Parse(txtMobile.Text);
            String email = txtEmail.Text;
            String semester = txtSemester.Text;
            String Program = txtProgramming.Text;
            String duration = txtDuration.Text;
            String add = txtAddress.Text;
            String sname = txtSchoolName.Text;

            SqlConnection con = new SqlConnection(@"Data Source = (LocalDB)\MSSQLLocalDB; AttachDbFilename = C:\Users\ASUS\source\repos\Cms\College.mdf; Integrated Security = True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = $"insert into NewAddmission (fname,mname,gender,dob,mobile,email,semester,prog,sname,duration,addres) values('{name}','{mname}','{gender}','{dob}','{mobile}','{email}','{semester}','{Program}','{sname}','{duration}','{add}')";

            SqlDataAdapter DA = new SqlDataAdapter(cmd);
            DataSet DS = new DataSet();
            DA.Fill(DS);
            con.Close();
            MessageBox.Show("Data Savedd. Remember the Refgistration ID", "DATA", MessageBoxButtons.OK, MessageBoxIcon.Hand);


        }

        private void btnReset_Click(object sender, EventArgs e)
        {
            txtFullName.Clear();
            txtAddress.Clear();
            txtMotherName.Clear();
            radioButtonFemale.Checked = false;
            radioButtonMale.Checked = false;
            txtMobile.Clear();
            txtEmail.Clear();
            txtProgramming.ResetText();
            txtSemester.ResetText();
            txtSchoolName.Clear();
            txtDuration.ResetText();

        }
    }
}
