using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public partial class ConcessionReport : Form
    {
        public string _conNo; 
        
        public ConcessionReport()
        {
            InitializeComponent();
            
             
        }
        private void ConcessionReport_Load(object sender, EventArgs e)
        {
            ConcessionData();

        }
        public void ConcessionData()
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                string query = "SELECT * FROM dbo.ConcessionReports WHERE ConcessionNo = '" + _conNo + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        txtConNo.Text = dr.GetString(0);
                        cboType.Text = dr.GetString(1);
                        txtSerial.Text = dr.GetString(2);
                        txtPartNo.Text = dr.GetString(3);
                        txtPartName.Text = dr.GetString(4);
                        cboMachType.Text = dr.GetString(5);
                        txtIssue.Text = dr.GetString(6);
                        txtCause.Text = dr.GetString(7);
                        txtPrevention.Text = dr.GetString(8);
                        txtTreatment.Text = dr.GetString(9);
                        txtUserReport.Text = dr.GetString(10);
                        txtComment.Text = dr.GetString(11);
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
        //delete concession record from concession reports table and log table
        //will input into a deleted table for reference
        private void btnDelete_Click(object sender, EventArgs e)
        {
            //warning message to make user confirm on delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete the concession: " + txtConNo.Text,
            "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //delete record is confirmed, go ahead and run the delete procedure
            if(result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    //Declaring the strored procedure and the parameters for the concession record delete 
                    cmd.CommandText = "EXECUTE USP_ConcessionDelete @ConcessionNo";
                    cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = txtConNo.Text;
                    try
                    {
                        con.Open();
                        cmd.ExecuteNonQuery();
                        con.Close();
                        //MessageBox.Show("Concession successfully deleted: " + txtConNoReport.Text);
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex);
                    }
                }
            }
            //else
            //{
            //    MessageBox.Show("You do not have access rights to Delete for user: " + Environment.UserName);
            //}
            //if delete record is cancelled then tell user
            //if(result == DialogResult.No)
            //{
            //    MessageBox.Show("Delete cancelled");
            //}
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                if (cboType.SelectedItem.ToString() == "Stamp")
                {
                    cmd.CommandText = "EXECUTE dbo.USP_ConcessionInput @ConcessionType, @SerialNo, @PartNumber," +
                        "@PartName, @MachineType, @Issue, @Cause, @Prevention, @Treatment, @CreatedBy, @Comment, @PdfDoc";
                }
                else
                {

                    cmd.CommandText = "EXECUTE dbo.USP_ConcessionInputFull @ConcessionType, @SerialNo, @PartNumber," +
                        "@PartName, @MachineType, @Issue, @Cause, @Prevention, @Treatment, @CreatedBy, @Comment";
                }
                //con no. now done by SQL sequence
                //cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = txtConNo.Text;
                cmd.Parameters.Add("@ConcessionType", SqlDbType.VarChar, 20).Value = cboType.SelectedItem;
                cmd.Parameters.Add("@SerialNo", SqlDbType.VarChar, 10).Value = txtSerial.Text;
                cmd.Parameters.Add("@PartNumber", SqlDbType.VarChar, 20).Value = txtPartNo.Text;
                cmd.Parameters.Add("@PartName", SqlDbType.VarChar, 50).Value = txtPartName.Text;
                cmd.Parameters.Add("@MachineType", SqlDbType.VarChar, 50).Value = cboMachType.Text;
                cmd.Parameters.Add("@Issue", SqlDbType.VarChar, 255).Value = txtIssue.Text;
                cmd.Parameters.Add("@Cause", SqlDbType.VarChar, 255).Value = txtCause.Text;
                cmd.Parameters.Add("@Prevention", SqlDbType.VarChar, 255).Value = txtPrevention.Text;
                cmd.Parameters.Add("@Treatment", SqlDbType.VarChar, 255).Value = txtTreatment.Text;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 50).Value = Environment.UserName;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 20).Value = txtComment.Text;

                //stamp concessions must have pdf doc
                if (cboType.SelectedItem.ToString() == "Stamp")
                {
                    //cmd.Parameters.Add("@PdfDoc", SqlDbType.VarBinary).Value = bytes;
                }

                //date time handled by stored proc
                //cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Today;

                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show("New Concession Created");
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
