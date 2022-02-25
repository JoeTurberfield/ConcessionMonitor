using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public class ShortShip
    {
        public void PartsDateSent(string _conNo, int rev, DateTime partsDate)
        {
            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Declaring the strored procedure and the parameters for the concession input data
                cmd.CommandText = "EXECUTE dbo.USP_StepShortShip @ConcessionNo, @Revision, @PartsDate";
                cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = _conNo;
                cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev;
                cmd.Parameters.Add("@PartsDate", SqlDbType.VarChar, 255).Value = partsDate;


            }
        }


    }
}
