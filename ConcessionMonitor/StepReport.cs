using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Configuration;

namespace ConcessionMonitor
{
    public partial class StepReport : Form
    {
        ConcessionMain cm = new ConcessionMain();
        public StepReport()
        {
            InitializeComponent();
        }

        public string conNo, com, comp;
        public int stepClick;


        private void StepData()
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                string query = "SELECT * FROM dbo.ConcessionLog WHERE ConcessionNo = '" + conNo + "' AND StepNo = '" + stepClick + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {                      
                        if (dr["Comment"] == DBNull.Value)
                        {
                            com = "No comment available.";
                        }
                        else
                        {
                            com = dr.GetString(4);
                        }
                        if (dr["CompletedDate"] == DBNull.Value)
                        {
                            comp = "Complete Date: N/A";
                        }
                        else
                        {
                            comp = "Complete Date: " + dr.GetDateTime(6).ToString();
                        }
                        lblConNoR.Text = "Concession Number: " + dr.GetString(1);
                        lblRev.Text = "Revision: " + dr.GetInt32(2).ToString();
                        lblStepNameR.Text = "Step No. " + dr.GetInt32(3).ToString();
                        lblUserR.Text = "Signed Off: " + dr.GetString(4);
                        txtStepCommentR.Text = com;
                        lblStartR.Text = "Start Date: " + dr.GetDateTime(6).ToString();
                        lblCompR.Text = comp;

                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        private void StepReport_Load(object sender, EventArgs e)
        {
            StepData();
        }

    }
}
