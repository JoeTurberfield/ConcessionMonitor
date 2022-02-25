using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Configuration;
using System.Windows.Forms;
using System.Data;

namespace ConcessionMonitor
{
    class Report
    {
        public bool e;
        public string type, serial, section, partNo, partName, machType, issue, cause, prevention,
    treatment, comment, status;
        public int stepNo;
        public byte[] pdf;

        public bool Exists(string conNo)
        {
            string stepComp = "SELECT * FROM ConcessionLog WHERE ConcessionNo = '" + conNo + "'";
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                using (SqlCommand cmd = new SqlCommand(stepComp, con))
                {
                    SqlDataReader dr;
                    con.Open();
                    dr = cmd.ExecuteReader();
                    if (dr.Read())
                    {
                        e = true;
                    }
                    else
                    {
                        e = false;
                    }
                    con.Close();
                    return e;
                }
            }

        }

        public int rev;
        public string stepStatus;

        public void GetRevison(string conNo)
        {
            string stepComp = "SELECT ConcessionNo,MAX(Revision),Max(StepStatus) AS Revision FROM " +
                "(SELECT * FROM ConcessionLog WHERE ConcessionNo = '" + conNo + "') x GROUP BY ConcessionNo";


                //"SELECT Revision FROM ConcessionLog WHERE ConcessionNo = '" + conNo + "'";
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                using (SqlCommand cmd = new SqlCommand(stepComp, con))
                {
                    SqlDataReader dr;
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        rev = dr.GetInt32(1);
                        stepStatus = dr.GetString(2);

                    }
                    
                    con.Close();
                }
            }

        }

        public void Data(string conNo)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                string query = "SELECT * FROM dbo.ConcessionReports WHERE ConcessionNo = '" + conNo + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        conNo = dr["ConcessionNo"].ToString();
                        type = dr["ConcessionType"].ToString();
                        serial = dr["SerialStamp"].ToString();
                        section = dr["SectionResponsible"].ToString();
                        partNo = dr["PartNumber"].ToString();
                        partName = dr["PartName"].ToString();
                        machType = dr["MachineType"].ToString();
                        issue = dr["Issue"].ToString();
                        cause = dr["Cause"].ToString();
                        prevention = dr["Prevention"].ToString();
                        treatment = dr["Treatment"].ToString();
                        //txtUserReport.Text = dr.GetString(10);
                        comment = dr["Comment"].ToString();
                        pdf = (byte[])dr["pdfDoc"];
                        status = dr["Status"].ToString();
                    }
                    con.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error: " + ex.Message);
                }
            }
        }

        DataSet ds = new DataSet(); DataTable dt = new DataTable();
        public DataTable StepStatus(string conNo)
        {
            //    string logData = "WITH Steps AS (SELECT ConcessionNo, StepNo, StepStatus, Revision FROM ConcessionLog), Rev AS "
            //+ "(SELECT ConcessionNo, MAX(Revision) AS Revision FROM ConcessionLog GROUP BY ConcessionNo) " 
            //+ "SELECT Steps.ConcessionNo, StepNo, StepStatus FROM Steps "
            //+ "INNER JOIN Rev ON Steps.ConcessionNo = Rev.ConcessionNo AND Steps.Revision = Rev.Revision "
            //+ "WHERE steps.ConcessionNo = '" + conNo + "'";
                using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                {
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "EXECUTE USP_ConcessionLog @ConcessionNo";
                        cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = conNo;

                        using (SqlDataAdapter adapter = new SqlDataAdapter(cmd))
                            {
                                ds.Clear();
                                adapter.Fill(ds);
                                dt = ds.Tables[0];
                                con.Close();
                                adapter.Dispose();
                            }
                    }
                }
                return dt;
            }

        //    SqlCommand cmd = new SqlCommand(query, con);
        //        SqlDataReader dr;
        //        try
        //        {
        //            con.Open();
        //            dr = cmd.ExecuteReader();
        //            while (dr.Read())
        //            {
        //                conNo = dr.GetString(0);
        //                stepNo = dr.GetInt32(1);
        //                stepStatus = dr.GetString(2);
                        
        //            }
        //            con.Close();
        //        }
        //        catch (Exception ex)
        //        {
        //            MessageBox.Show("Error: " + ex.Message);
        //        }
        //    }
        //}

        //returns current step number for concession
        public void GetStepNo(string conNo)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                string query = "SELECT ConcessionNo, MAX(Revision) AS Rev, MAX(StepNo) AS Step FROM ConcessionLog " +
                    "WHERE ConcessionNo = '" + conNo + "' GROUP BY ConcessionNo";

                    //"SELECT MAX([StepNo]) AS Step FROM ConcessionLog WHERE ConcessionNo = '" + conNo + "'";
                SqlCommand cmd = new SqlCommand(query, con);
                SqlDataReader dr;
                try
                {
                    con.Open();
                    dr = cmd.ExecuteReader();
                    while (dr.Read())
                    {
                        stepNo = dr.GetInt32(2);
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
