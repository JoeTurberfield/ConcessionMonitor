using System;
using System.Configuration;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.IO;

namespace ConcessionMonitor
{

    public class Pdf
    {

        public byte[] _DataPdf { get; set; }

        //write bytes to a temp file
        public void Write(byte[] DataPdf, string pdfPath)
        {
            using (FileStream fs = new FileStream(pdfPath, FileMode.OpenOrCreate, FileAccess.Write))
            {
                int counter = DataPdf.Length;
                fs.Write(DataPdf, 0, counter);
                _DataPdf = DataPdf;
            }
        }
        //open pdf file
        public void Open(string conNo)
        {
            //check directory exists or create new directory
            FileInfo fi = new FileInfo(@"C:\PdfTemp\temp");
            fi.Directory.Create();

            byte[] bytes;

            using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
            using (SqlCommand cmd = con.CreateCommand())
            {
                //Select the latest PDF file.
                cmd.CommandText = "WITH Pdf AS (SELECT ConcessionNo, PdfDoc, Revision FROM ConcessionReports), "
                    + "Rev AS (SELECT ConcessionNo, MAX(Revision) AS Revision FROM ConcessionReports GROUP BY ConcessionNo) "
                    + "SELECT Pdf.ConcessionNo, Pdf.PdfDoc, Rev.Revision FROM Pdf INNER JOIN Rev ON Pdf.ConcessionNo = Rev.ConcessionNo "
                    + "AND Pdf.Revision = Rev.Revision WHERE Pdf.ConcessionNo = '" + conNo + "'";
                try
                {
                    con.Open();

                    //read document bytes and open file locally
                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            bytes = (byte[])dr["PdfDoc"];

                            using (FileStream fs = File.Create(@"C:\PdfTemp\temp.pdf"))
                            {
                                fs.Write(bytes, 0, bytes.Length);
                                System.Diagnostics.Process.Start(@"C:\PdfTemp\temp.pdf");
                            }
                        }                         
                    }
                    con.Close();
                }
                catch(Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
