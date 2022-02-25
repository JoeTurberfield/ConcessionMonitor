using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    class PrevStep
    {
        //gets previous step number and checks for data
        public bool prevStep;

        public bool IsComplete(string conNo, int prevStepNo)
        {

                string stepComp = "SELECT * FROM ConcessionLog WHERE ConcessionNo = '" + conNo + "' AND CompletedDate IS NOT NULL AND StepNo = '" + prevStepNo + "'";
                using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                {
                    using (SqlCommand cmd = new SqlCommand(stepComp, con))
                    {
                        SqlDataReader dr;
                        con.Open();
                        dr = cmd.ExecuteReader();
                        if (dr.Read())
                        {
                            prevStep = true;
                        }
                        else
                        {
                            prevStep = false;
                        }
                        con.Close();
                        return prevStep;
                    }
                }

        }
    }
}
