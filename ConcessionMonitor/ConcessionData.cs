using System;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public partial class ConcessionData : Form
    {
        //globals
        public string conNo, status;
        public string pdfPath { get; set; }
        public byte[] bytes; //pdf bytes
        bool ee; //if concession exists
        int rev; //concession revision number

        //classes
        Report r = new Report(); Email em = new Email();

        public ConcessionData()
        {
            InitializeComponent();
            //lblFile.Text = pdf;
            //this.lboPdf.DragDrop += new
            //DragEventHandler(this.lboPdf_DragDrop);
            //this.lboPdf.DragEnter += new
            //DragEventHandler(this.lboPdf_DragEnter);
            //Pdf = txtPartNo.Text;
        }

        public void ConcessionCreate_Load(object sender, EventArgs e)
        {
            //if concession exists
            r.Exists(conNo); ee = r.e;
            
            //return revision
            r.GetRevison(conNo); rev = r.rev;

            //hide stamp label
            lblStamp.Visible = false;      

            if (ee == true)
            {
                //return concession data
                r.Data(conNo);
                cboType.Text = r.type;
                txtSerial.Text = r.serial;
                cboDept.Text = r.section;
                txtPartNo.Text = r.partNo;
                txtPartName.Text = r.partName;
                cboMachType.Text = r.machType;
                txtIssue.Text = r.issue;
                txtCause.Text = r.cause;
                txtPrevention.Text = r.prevention;
                txtTreatment.Text = r.treatment;
                txtComment.Text = r.comment;                       
                btnDelete.Visible = true;
                status = r.status;

                if ((lboPdf.Items.Count <= 0))
                {
                    bytes = r.pdf;
                }
            }

            if(r.type == "Short-Ship")
            {
                lblPartsDate.Visible = true;
                dtpPartsDate.Visible = true;
            }
        }

        //save new concession data into database
        private void btnCreate_Click(object sender, EventArgs e)            
        {
            DateTime partsDate = dtpPartsDate.Value;

            // Validate PDF for new records ONLY.
            if (lboPdf.Items.Count <= 0 && ee == false && cboType.SelectedItem.ToString() == "Stamp")
            {
                lblPdfError.Visible = true;
            }
            else
            {
                lblPdfError.Visible = false;
            }
            //validating input on required fields
            if ((string.IsNullOrEmpty(txtSerial.Text)) || (string.IsNullOrEmpty(cboMachType.Text))
                || (string.IsNullOrEmpty(cboType.Text)) || (string.IsNullOrEmpty(cboDept.Text)) || lblPdfError.Visible == true)
            {
                ValidateInput();
            }
            //input concession record
            else
            {
                using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    //Declaring the strored procedure and the parameters for the concession input data
                    if ((lboPdf.Items.Count <= 0) && ee == false)
                    {
                        bytes = Array.Empty<byte>();
                    }
                    //con no. now done by SQL sequence. if concession exists then use existing conNo
                    if (ee == true)
                    {
                        cmd.CommandText = "EXECUTE dbo.USP_ConcessionInputUpdate @ConcessionNo, @Revision, @Status, @ConcessionType, " +
                            "@SerialNo, @Section, @PartNumber, @PartName, @MachineType, @Issue, @Cause, @Prevention, @Treatment, @Comment, @PdfDoc";

                        cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = conNo;
                        cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev + 1;
                        cmd.Parameters.Add("@Status", SqlDbType.VarChar, 20).Value = status;

                    }
                    else
                    {
                        cmd.CommandText = "EXECUTE dbo.USP_ConcessionInput @Revision, @ConcessionType, @SerialNo, @Section, @PartNumber," +
                            "@PartName, @MachineType, @Issue, @Cause, @Prevention, @Treatment, @Comment, @PdfDoc";

                        cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = 1;
                    }
                    cmd.Parameters.Add("@ConcessionType", SqlDbType.VarChar, 20).Value = cboType.SelectedItem;
                    cmd.Parameters.Add("@SerialNo", SqlDbType.VarChar, 10).Value = txtSerial.Text;
                    cmd.Parameters.Add("@Section", SqlDbType.VarChar, 50).Value = cboDept.SelectedItem;
                    cmd.Parameters.Add("@PartNumber", SqlDbType.VarChar, 20).Value = txtPartNo.Text;
                    cmd.Parameters.Add("@PartName", SqlDbType.VarChar, 50).Value = txtPartName.Text;
                    cmd.Parameters.Add("@MachineType", SqlDbType.VarChar, 50).Value = cboMachType.Text;
                    cmd.Parameters.Add("@Issue", SqlDbType.VarChar, 255).Value = txtIssue.Text;
                    cmd.Parameters.Add("@Cause", SqlDbType.VarChar, 255).Value = txtCause.Text;
                    cmd.Parameters.Add("@Prevention", SqlDbType.VarChar, 255).Value = txtPrevention.Text;
                    cmd.Parameters.Add("@Treatment", SqlDbType.VarChar, 255).Value = txtTreatment.Text;

                    //username handled in stored procedure
                    //cmd.Parameters.Add("@CreatedBy", SqlDbType.VarChar, 50).Value = Environment.UserName;
                    cmd.Parameters.Add("@Comment", SqlDbType.VarChar, 255).Value = txtComment.Text;

                    //stamp concessions must have pdf doc
                    cmd.Parameters.Add("@PdfDoc", SqlDbType.VarBinary).Value = bytes;

                    //date time handled by stored proc
                    //cmd.Parameters.Add("@CreatedDate", SqlDbType.DateTime).Value = DateTime.Today;

                    try
                    {
                        con.Open();
                        //cmd.ExecuteNonQuery();
                        var conID = cmd.ExecuteScalar();
                        con.Close();
                        if (ee == true)
                        {
                            int newRev = rev + 1;
                            MessageBox.Show("Concession updated to Revision: " + newRev);
                        }
                        else
                        {
                            // TURNED OFF FOR TEST
                            //    string from = "ConcessionMonitor@mazak.co.uk";
                            //em.SendMail("New Concession - " + conID, "An action is required from your department. " +
                            //    "A new Concession has been created " + conID + 
                            //    " .Please open the Concession Monitor Application to complete actions. Thank You.", 
                            //    from, "", 0, "", "test", "", cboMachType.Text);

                            MessageBox.Show("New Concession Created: " + conID);
                        }
                        this.Close();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("Error " + ex.Message);
                    }
                }

                if (r.type == "Short-Ship")
                {
                    using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                    using (SqlCommand cmd = con.CreateCommand())
                    {
                        cmd.CommandText = "EXECUTE dbo.USP_PartsSent @ConcessionNo, @Revision, @PartsDate";

                        cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = conNo;
                        cmd.Parameters.Add("@Revision", SqlDbType.Int).Value = rev + 1;
                        cmd.Parameters.Add("@PartsDate", SqlDbType.DateTime).Value = partsDate;
                        try
                        {
                            con.Open();
                            cmd.ExecuteNonQuery();
                            con.Close();
                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show("Error " + ex.Message);
                        }
                    }
                }

            }
        }

        //full and stamp concession displays
        private void cboType_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cboType.Text))
            {
                lblTypeError.Visible = true;
            }
            else
            {
                lblTypeError.Visible = false;
            }
            if (cboType.SelectedItem.ToString() == "Stamp")
            {
                lblSerialNo.Visible = false;
                txtSerial.Visible = true;
                lblStamp.Visible = true;
                lblIssue.Visible = false;
                txtIssue.Visible = false;
                lblCause.Visible = false;
                txtCause.Visible = false;
                lblPrevention.Visible = false;
                txtPrevention.Visible = false;
                lblTreatment.Visible = false;
                txtTreatment.Visible = false;
                lboPdf.Visible = true;
            }
            if (cboType.SelectedItem.ToString() == "Full")
            {
                lblSerialNo.Visible = true;
                txtSerial.Visible = true;
                lblStamp.Visible = false;
                lblIssue.Visible = true;
                txtIssue.Visible = true;
                lblCause.Visible = true;
                txtCause.Visible = true;
                lblPrevention.Visible = true;
                txtPrevention.Visible = true;
                lblTreatment.Visible = true;
                txtTreatment.Visible = true;
                lboPdf.Visible = true;
                lblPdfError.Visible = false;
            }
            if (cboType.SelectedItem.ToString() == "Short-Ship")
            {
                lblSerialNo.Visible = true;
                txtSerial.Visible = true;
                lblStamp.Visible = false;
                lblIssue.Visible = false;
                txtIssue.Visible = false;
                lblCause.Visible = false;
                txtCause.Visible = false;
                lblPrevention.Visible = false;
                txtPrevention.Visible = false;
                lblTreatment.Visible = false;
                txtTreatment.Visible = false;
                lboPdf.Visible = true;
            }
        }

        //drag and drop files into list box
        private void lboPdf_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.All;
            else
                e.Effect = DragDropEffects.None;
        }

        private void lboPdf_DragDrop(object sender, DragEventArgs e)
        {
            if (lboPdf.Items.Count > 0)
            {
                MessageBox.Show("A file is already allocated");
            }
            else
            {
                //drop file name onto form
                string[] s = (string[])e.Data.GetData(DataFormats.FileDrop, false);
                int i;
                for (i = 0; i < s.Length; i++)
                    lboPdf.Items.Add((s[i]));

                //get file path
                pdfPath = String.Join("", s);

                //read file bytes
                bytes = System.IO.File.ReadAllBytes(pdfPath);

                //write pdf bytes to file
                Pdf pdf = new Pdf();
                pdf.Write(bytes, pdfPath);
            }
        }

        private void PdfDrop(DragEventArgs e)
        {
            
        }

        private void btnPdf_Click(object sender, EventArgs e)
        {

        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            //warning message to make user confirm on delete
            DialogResult result = MessageBox.Show("Are you sure you want to delete the concession: " + conNo,
            "Delete Record", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            //delete record is confirmed, go ahead and run the delete procedure
            if (result == DialogResult.Yes)
            {
                using (SqlConnection con = new SqlConnection((ConfigurationManager.ConnectionStrings["ConcessionConString"].ConnectionString)))
                using (SqlCommand cmd = con.CreateCommand())
                {
                    //Declaring the strored procedure and the parameters for the concession record delete 
                    cmd.CommandText = "EXECUTE USP_ConcessionDelete @ConcessionNo";
                    cmd.Parameters.Add("@ConcessionNo", SqlDbType.VarChar, 20).Value = conNo;
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


        private void txtSerial_TextChanged(object sender, EventArgs e)
        {
            // Validation of input on text change
            if (string.IsNullOrEmpty(txtSerial.Text))
            {
                lblSerialError.Visible = true;
            }
            else
            {
                lblSerialError.Visible = false;
            }
        }

        private void cboMachType_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validation of input on text change
            if (string.IsNullOrEmpty(cboMachType.Text))
            {
                lblMachError.Visible = true;
            }
            else
            {
                lblMachError.Visible = false;
            }

        }
        
        private void cboDept_SelectedIndexChanged(object sender, EventArgs e)
        {
            // Validation of input on text change
            if (string.IsNullOrEmpty(cboDept.Text))
            {
                lblDeptError.Visible = true;
            }
            else
            {
                lblDeptError.Visible = false;
            }
        }

        // Show error labels on text box input validation.
        private void ValidateInput()
        {
            if (string.IsNullOrEmpty(txtSerial.Text))
            {
                lblSerialError.Visible = true;
            }
            else
            {
                lblSerialError.Visible = false;
            }

            if (string.IsNullOrEmpty(cboMachType.Text))
            {
                lblMachError.Visible = true;
            }
            else
            {
                lblMachError.Visible = false;
            }

            if (string.IsNullOrEmpty(cboType.Text))
            {
                lblTypeError.Visible = true;
            }
            else
            {
                lblTypeError.Visible = false;
            }

            if (string.IsNullOrEmpty(cboDept.Text))
            {
                lblDeptError.Visible = true;
            }
            else
            {
                lblDeptError.Visible = false;
            }
        }
    }
}







