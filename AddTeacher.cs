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
    public partial class AddTeacher : Form
    {
        public AddTeacher()
        {
            InitializeComponent();
        }

        private void btnSave_Click(object sender, EventArgs e)
        {

            String gender = "";
            bool isChecked = radioButtonMale.Checked;

            if(isChecked)
            {
                gender = radioButtonMale.Text;
            }
            else
            {
                gender = radioButtonFemale.Text;
            }


            SqlConnection con = new SqlConnection(@"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True");
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = con;

            cmd.CommandText = "insert into teacher (fname,gender,dob,mobile,email,semester,prog,yer,adr) values('"+txtFName.Text+"','"+gender+"','"+dateTimePickerDOB.Text+"',"+txtMobile.Text+",'"+txtEmail.Text+"','"+txtSsemester.Text+"','"+txtProgramming.Text+"','"+txtDuration.Text+"','"+txtAddress.Text+"')";
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSet ds = new DataSet();
            da.Fill(ds);

            MessageBox.Show("Data Saved.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
