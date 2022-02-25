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
    public partial class Approval : Form
    {
        public string _conNo { get; set; }
        public int _stepNo { get; set; }
        public int rev;


        public Approval()
        {
            InitializeComponent();
            
        }


        private void btnReject_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE dbo.USP_Reject @ConcessionNo, @Revision, @CreatedBy, @Comment";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 20).Value = Environment.UserName;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 255).Value = "";
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(_conNo + " status set to Rejected");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }

        private void btnPending_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE USP_Pending @ConcessionNo";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(_conNo + " status set to Pending");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        private void btnApprove_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE USP_Approve @ConcessionNo, @StepNo, @CreatedBy, @Comment";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@StepNo", SqlDbType.Int).Value = _stepNo;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 20).Value = Environment.UserName;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 255).Value = "";
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(_conNo + " status set to Approved");
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
    }
}
