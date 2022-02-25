using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Sql;
using System.Data.SqlClient;
using System.Data;
using System.Configuration;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public class StepComplete
    {
        private DataTable dtLog = new DataTable();
        public DataTable IsComplete()
        {
            //Execute the stored procedure to show dgvLog data
            string query = "SELECT ConcessionNo FROM ConcessionLog WHERE Complete = 0";
            SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString);
            SqlCommand cmd = new SqlCommand(query, con);
            con.Open();
            //Create adapter
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            //Query the database and return the result to the datatable
            da.Fill(dtLog);
            con.Close();
            da.Dispose();
            return dtLog;
        }

        public void SignOffOld(string _conNo, string stat, int rev, int _stepNo, string stepName)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "EXECUTE USP_SignOff @ConcessionNo, @Status, @Revision, @StepNo, @StepName, @CompletedBy";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 20).Value = stat;
                cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmd.Parameters.Add("@StepNo", SqlDbType.Int).Value = _stepNo;
                cmd.Parameters.Add("@StepName", SqlDbType.VarChar, 20).Value = stepName;
                cmd.Parameters.Add("@CompletedBy", SqlDbType.VarChar, 50).Value = Environment.UserName;

                // "UPDATE dbo.ConcessionReports SET CompletedDate = getdate() WHERE ConcessionNo = '" + _conNo + "'";
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //Email em = new Email();
                    //em.SendMail();
                    //this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void Pending(string _conNo)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE dbo.USP_Pending @ConcessionNo";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    MessageBox.Show(_conNo + " status set to Pending");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }

        }

        public void SignOff(string _conNo, int rev, int _stepNo, string comment, string stepStatus, string type)
        {
            int NextStep = _stepNo + 1;

            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE dbo.USP_StepSignOff @ConcessionNo, @Revision, @StepNo, @CreatedBy, @Comment, @StepStatus, @NextStep, @Type";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmd.Parameters.Add("@StepNo", SqlDbType.Int).Value = _stepNo;
                cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 20).Value = Environment.UserName;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 255).Value = comment;
                cmd.Parameters.Add("@StepStatus", SqlDbType.VarChar, 20).Value = stepStatus;
                cmd.Parameters.Add("@NextStep", SqlDbType.VarChar, 20).Value = NextStep;
                cmd.Parameters.Add("@Type", SqlDbType.VarChar, 20).Value = type;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                    //MessageBox.Show(_conNo + " status set to Rejected. Awaiting Machining Approval");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error " + ex.Message);
                }
            }
        }
        

        public void Approval(string _conNo, string stepName, int rev, int _stepNo, string comment, string status)
        {
            using (SqlConnection con = new SqlConnection(ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString))
            using (SqlCommand cmd = con.CreateCommand())
            {
                cmd.CommandText = "EXECUTE USP_RejectedApproval @ConcessionNo, @Revision, @StepNo, @Comment, @Status";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmd.Parameters.Add("@StepNo", SqlDbType.Int).Value = _stepNo;

                //user handled in stored procedure 
                //cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 20).Value = Environment.UserName;
                cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 255).Value = comment;
                cmd.Parameters.Add("@Status", SqlDbType.VarChar, 255).Value = status;
                //cmdUpd.Parameters.Add("@CompletedDate", SqlDbType.DateTime).Value = DateTime.Today;
                try
                {
                    con.Open();
                    cmd.ExecuteNonQuery();
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        public void NextStep(string _conNo, string stepName, int rev, int nextStep, string comment)
        {
            using (SqlConnection conIns = new SqlConnection(ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString))
            using (SqlCommand cmdIns = conIns.CreateCommand())
            {
                //Saving completed step date
                cmdIns.CommandText = "EXECUTE USP_StepComplete @ConcessionNo, @Revision, @StepNo, @CreatedBy, @EntryDate";
                cmdIns.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmdIns.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmdIns.Parameters.Add("@StepNo", SqlDbType.Int).Value = nextStep;
                cmdIns.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 20).Value = Environment.UserName;
                cmdIns.Parameters.Add("@EntryDate", SqlDbType.DateTime).Value = DateTime.Today;
                try
                {
                    conIns.Open();
                    cmdIns.ExecuteNonQuery();
                    conIns.Close();
                    MessageBox.Show(" Complete for " + _conNo);
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }
    }
}
