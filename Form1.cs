using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cms
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            menuStrip1.Visible = false;
            label6.Visible = false;
            pictureBox3.Visible = false;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {








        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void teacherToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            String username = textBox1.Text;
            String password = textBox2.Text;

            if(username == "student" && password == "1234")
            {
                menuStrip1.Visible = true;
                panel1.Visible = false;
                pictureBox3.Visible = true;
                label6.Visible = true;
            }
            else
            {
                MessageBox.Show("Invalidid userid or password", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void newAdmissionToolStripMenuItem_Click(object sender, EventArgs e)
       {
          
        }

        private void admissionToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void newAdmissionToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            NewAddmision na = new NewAddmision();
            na.Show();
        }

        private void upgradeSemesterToolStripMenuItem_Click(object sender, EventArgs e)
        {
            UpgradeSemester na = new UpgradeSemester();
            na.Show();
        }

        private void feesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Fees fs = new Fees();
            fs.Show();
        }

        private void searchStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchStudent ss = new SearchStudent();
            ss.Show();
        }

        private void individualDetailsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            StudentindividualDetails sid = new StudentindividualDetails();
            sid.Show();
        }

        private void addTeacherInformationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AddTeacher at = new AddTeacher();
            at.Show();
        }

        private void searchToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SearchTeacher st = new SearchTeacher();
            st.Show();
        }

        private void removeStudentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RemoveStudent rs = new RemoveStudent();
            rs.Show();
        }

        private void aboutUsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Aboutus au = new Aboutus();
            au.Show();
        }

        private void exitSystemToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (MessageBox.Show("Are you Sure? This will Delete Your UNSAVED Data", "Confirmation Dialog!", MessageBoxButtons.OKCancel, MessageBoxIcon.Warning) == DialogResult.OK) ;
            {
                Application.Exit();
            }


            
        }

        private void reportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void feesReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Report re = new Report();
            re.Show();
        }

        private void studentDetailsReportToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Student_details sd = new Student_details();
            sd.Show();
        }
    }
}
