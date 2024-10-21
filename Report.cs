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
using System.IO;
using System.Data.SqlClient;

namespace Cms
{
    public partial class Report : Form
    {
        SqlConnection con;
        SqlDataAdapter da;
        DataTable dt;
        DataSet ds;

        private CrystalDecisions.CrystalReports.Engine.ReportDocument cr = new CrystalDecisions.CrystalReports.Engine.ReportDocument();

        static string Crypath = "";

        string s = @"Data Source=(LocalDB)\MSSQLLocalDB;AttachDbFilename=C:\Users\ASUS\source\repos\Cms\College.mdf;Integrated Security=True";

        public Report()
        {
            InitializeComponent();
        }
        void conn()
        {
            con = new SqlConnection(s);
            con.Open();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            conn();
            SqlDataAdapter da = new SqlDataAdapter("select * from fees", con);
            DataSet ds = new DataSet();
            da.Fill(ds);
            string xml = @"C:/Users/ASUS/source/repos/Cms/data.xml";
            ds.WriteXmlSchema(xml);

            Crypath = @"C:/Users/ASUS/source/repos/Cms/CrystalReport1.rpt";
            cr.Load(Crypath);
            cr.SetDataSource(ds);
            cr.Database.Tables[0].SetDataSource(ds);
            cr.Refresh();
            crystalReportViewer1.ReportSource = cr;


        }

        private void Report_Load(object sender, EventArgs e)
        {
            conn();
        }

        private void crystalReportViewer1_Load(object sender, EventArgs e)
        {

        }
    }
}
