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
    public partial class ConcessionReport : Form
    {


        public ConcessionReport()
        {
            InitializeComponent();






        }


        private void ConcessionCreate_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'concessionDataSet3.ConcessionReportType' table. You can move, or remove it, as needed.
            this.concessionReportTypeTableAdapter1.Fill(this.concessionDataSet3.ConcessionReportType);
            // TODO: This line of code loads data into the 'concessionDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.concessionDataSet2.Users);
            // TODO: This line of code loads data into the 'concessionDataSet1.Users' table. You can move, or remove it, as needed.


        }


        private void btnCreate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE dbo.USP_ConcessionInput @ConcessionNo, @TypeID, @SerialNo, @PartNumber," +
                    "@PartName, @MachineType, @Issue, @Cause, @Prevention, @Treatment, @UserID, @CreatedDate";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = txtConNo.Text;
                cmd.Parameters.Add("@TypeID", SqlDbType.Int).Value = cboType.SelectedValue;
                cmd.Parameters.Add("@SerialNo", SqlDbType.VarChar, 10).Value = txtSerial.Text;
                cmd.Parameters.Add("@PartNumber", SqlDbType.VarChar, 20).Value = txtPartNo.Text;
                cmd.Parameters.Add("@PartName", SqlDbType.VarChar, 50).Value = txtPartName.Text;
                cmd.Parameters.Add("@MachineType", SqlDbType.VarChar, 50).Value = txtMachine.Text;
                cmd.Parameters.Add("@Issue", SqlDbType.VarChar, 255).Value = txtIssue.Text;
                cmd.Parameters.Add("@Cause", SqlDbType.VarChar, 255).Value = txtCause.Text;
                cmd.Parameters.Add("@Prevention", SqlDbType.VarChar, 255).Value = txtPrevention.Text;
                cmd.Parameters.Add("@Treatment", SqlDbType.VarChar, 255).Value = txtTreatment.Text;
                cmd.Parameters.Add("@UserID", SqlDbType.Int).Value = cboUser.SelectedValue;
                cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Today;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Concession Created: " + txtConNo.Text);
                    this.Close();
                }

                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex);
                }
            }

        }
        public void ConcessionData()
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            //using (SqlCommand cmd = con.CreateCommand())
            {

                //Declaring the strored procedure and the parameters for the concession input data
                string query = "SELECT * FROM dbo.ConcessionReports WHERE ConcessionNo = 'test1'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtConNo.Text = dr.GetString(0);
                        txtSerial.Text = dr.GetString(2);
                        txtPartNo.Text = dr.GetString(3);
                        txtPartName.Text = dr.GetString(4);
                        txtMachine.Text = dr.GetString(5);
                        txtIssue.Text = dr.GetString(6);
                        txtCause.Text = dr.GetString(7);
                        txtPrevention.Text = dr.GetString(8);
                        txtTreatment.Text = dr.GetString(9);

                    }
                    con.Close();
                }


                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }

            }
        }
    }
}
 





