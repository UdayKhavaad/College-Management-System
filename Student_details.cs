using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CrystalDecisions.CrystalReports.Engine;
using CrystalDecisions.Shared;
using System.Data.SqlClient;

namespace Cms
{
    public partial class Student_details : Form
    {
        SqlDataAdapter da;
        DataSet ds;
        SqlConnection con;
        SqlCommand cmd;

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True";

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";

        void connection() {
             con = new SqlConnection(s);
             con.Open();
        }

        public Student_details()
        {
            InitializeComponent();
        }

        private void Student_details_Load(object sender, EventArgs e)
        {
            connection();
        }

        private void btnreport_Click(object sender, EventArgs e)
        {
            da = new SqlDataAdapter("select * from NewAddmission ", con);
            ds = new DataSet();
            da.Fill(ds);
            string xml = @"C:\Users\ASUS\source\repos\Cms\data2.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:\Users\ASUS\source\repos\Cms\CrystalReport2.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;


        }
    }
}
