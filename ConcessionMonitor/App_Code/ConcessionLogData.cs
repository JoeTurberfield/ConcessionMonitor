using System.Configuration;
using System.Data;
using System.Data.SqlClient;

namespace ConcessionMonitor
{

    public class ConcessionLogData
    {
        public DataTable dt = new DataTable();
        public DataSet ds = new DataSet();

        //returns and refreshes the concession log data
        public DataTable BindSource()
        {
            string logData = @"SELECT * FROM vwLogData";
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                //using (SqlCommand cmd = new SqlCommand(logData, con))
                //{
                using (SqlDataAdapter adapter = new SqlDataAdapter(logData, con))
                {
                    ds.Clear();                 
                    adapter.Fill(ds);
                    dt = ds.Tables[0];
                    con.Close();
                    adapter.Dispose();
                }
                //}
            }
            return dt;
        }
        //filtering log data
        public DataTable Filter(string search)
        {
            string logData = @"SELECT * FROM vwLogData WHERE ConcessionNo LIKE '%" + search + "%'"
                + "OR [Serial / Stamp No.] LIKE '%" + search + "%'"
                + "OR [Part Number] LIKE '%" + search + "%'";
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                using (SqlCommand cmd = new SqlCommand(logData, con))
                {
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

        public DataTable LogTable()
        {
            string logData = @"WITH Steps AS (SELECT ConcessionNo, StepNo, StepStatus, Revision
            FROM ConcessionLog), Rev AS
            (SELECT ConcessionNo, MAX(Revision) AS Revision FROM ConcessionLog
                GROUP BY ConcessionNo
            )
         SELECT Steps.ConcessionNo, StepNo, StepStatus FROM Steps
            INNER JOIN Rev ON Steps.ConcessionNo = Rev.ConcessionNo AND Steps.Revision = Rev.Revision";
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            {
                using (SqlCommand cmd = new SqlCommand(logData, con))
                {
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
    }
}
