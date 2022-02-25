using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public partial class ConcessionMain : Form
    {
        // Declare variables
        public string _conNo { get; set; }
        public string pdfData { get; set; }
        bool stamp = false;

        // Classes
        ConcessionLogData cld = new ConcessionLogData(); Report r = new Report();

        public ConcessionMain()
        {
            InitializeComponent();
            
        }

        // New concession form open
        private void btnCreateFull_Click(object sender, EventArgs e)
        {          
            ConcessionData nc = new ConcessionData();
            nc.ShowDialog();

            // New concessions added to main datagridview
            dgvLog.DataSource = cld.BindSource();
            CellColour();

            // Show current user
            User();
        }

        private void ConcessionMain_Load(object sender, EventArgs e)
        {
            // Maximize screen
            this.MaximizedBounds = Screen.FromHandle(this.Handle).WorkingArea;
            this.WindowState = FormWindowState.Maximized;

            // Show concession log data in datagridview
            dgvLog.DataSource = cld.BindSource();
            CellColour();

            // Show current user
            User();

            // Set column width for step columns
            foreach (DataGridViewColumn col in dgvLog.Columns)
            {
                for (int i = 13; i < dgvLog.Columns.Count; i++)
                {
                    DataGridViewColumn column = dgvLog.Columns[i];
                    column.Width = 175;
                }
            }
        }

        // Gets user name of current user
        public void User()
        {
            lblUser.Text = "Logged in as: " + Environment.UserName;
        }

        // Colour cell based on value
        public void CellColour()
        {           
            foreach (DataGridViewRow rw in this.dgvLog.Rows)
            {
                if (rw.IsNewRow) continue;
                string data = rw.Cells["ConcessionNo"].Value.ToString();

                // Loop through concessions and check if PDF data is present
                r.Data(data);
                if (r.pdf.Length > 100)
                {
                    // Show pdf link available
                    rw.Cells[4].Value = "PDF Link";
                    rw.Cells[4].Style.ForeColor = Color.Blue;
                    dgvLog.Columns[4].DefaultCellStyle.Font = new Font(dgvLog.DefaultCellStyle.Font, FontStyle.Underline);
                }

                // Colour null and non-null cells initially
                for (int i = 12; i < rw.Cells.Count; i++)
                {
                    if (rw.Cells[i].Value == DBNull.Value)
                    {
                        rw.Cells[i].Style.BackColor = Color.Silver;
                    }
                    if (rw.Cells[i].Value != DBNull.Value)
                    {
                        rw.Cells[i].Style.BackColor = Color.LimeGreen;
                    }
                }

                // Check concessions step status and colour cell
                DataTable dtReturn = new DataTable();
                dtReturn = r.StepStatus(data);
                foreach (DataRow rwDt in dtReturn.Rows)
                {
                    for (int i = 0; i < dtReturn.Rows.Count; i++)
                    {
                        if (dtReturn.Rows[i]["StepStatus"].ToString() == "Rejected")
                        {
                            if (Convert.ToInt32(dtReturn.Rows[i]["StepNo"]) == 1)
                            {
                                rw.Cells[14].Style.BackColor = Color.LightSalmon;
                            }
                            if (Convert.ToInt32(dtReturn.Rows[i]["StepNo"]) == 2)
                            {
                                rw.Cells[15].Style.BackColor = Color.LightSalmon;
                            }
                            if (Convert.ToInt32(dtReturn.Rows[i]["StepNo"]) == 3)
                            {
                                rw.Cells[16].Style.BackColor = Color.LightSalmon;
                            }
                            if (Convert.ToInt32(dtReturn.Rows[i]["StepNo"]) == 4)
                            {
                                rw.Cells[17].Style.BackColor = Color.LightSalmon;
                            }                            
                        }
                    }
                    break;
                }

                // Colour cell based on current step
                switch (Convert.ToString(rw.Cells["Concession Status"].Value))
                {
                    case "Open":
                        rw.Cells["Concession Status"].Style.BackColor = Color.LightGreen;
                        if (rw.Cells["1. Engineering Decision"].Value == DBNull.Value)
                        {
                            rw.Cells["1. Engineering Decision"].Style.BackColor = Color.LightGreen;
                        }
                        else
                        {
                            if (rw.Cells["2. Quality Decision"].Value == DBNull.Value)
                            {
                                rw.Cells["2. Quality Decision"].Style.BackColor = Color.LightGreen;
                            }
                            else
                            {
                                if (rw.Cells["3. Production Director Decision"].Value == DBNull.Value
                                    && rw.Cells["Concession Type"].Value.ToString() == "Full")
                                {
                                    rw.Cells["3. Production Director Decision"].Style.BackColor = Color.LightGreen;
                                }
                                    
                                else
                                {
                                    if (rw.Cells["4. Problem Causing Section"].Value == DBNull.Value)
                                    {
                                        rw.Cells["4. Problem Causing Section"].Style.BackColor = Color.LightGreen;
                                    }
                                }
                            }
                        }
                        break;
                    case "Rejected":
                        rw.Cells["Concession Status"].Style.BackColor = Color.LightSalmon;
                        break;
                    case "Complete":
                        rw.Cells["Concession Status"].Style.BackColor = Color.LimeGreen;
                        break;
                }

                // Colour completed cell
                if (Convert.ToString(rw.Cells["Concession Status"].Value) == "Complete")
                {
                    rw.Cells[13].Style.BackColor = Color.LimeGreen;
                }

                // Colour cell based on open days
                if (Convert.ToInt32(rw.Cells["Open Days"].Value) <= 2)
                {
                rw.Cells["Open Days"].Style.BackColor = Color.LimeGreen;
                }
                if (Convert.ToInt32(rw.Cells["Open Days"].Value) > 2 && Convert.ToInt32(rw.Cells["Open Days"].Value) < 7)
                {
                    rw.Cells["Open Days"].Style.BackColor = Color.Orange;
                }
                if (Convert.ToInt32(rw.Cells["Open Days"].Value) >= 7)
                {
                    rw.Cells["Open Days"].Style.BackColor = Color.Red;
                }
            }

            // Disable users to add new rows
            dgvLog.AllowUserToAddRows = false;

            //disable sort on datagrid columns
            //foreach (DataGridViewColumn column in dgvLog.Columns)
            //{
            //    column.SortMode = DataGridViewColumnSortMode.Automatic;
            //}
        }

        private void dgvLog_CellClick_1(object sender, DataGridViewCellEventArgs e)
        {
            // Variables based on selection           
            _conNo = this.dgvLog.CurrentRow.Cells["ConcessionNo"].Value.ToString(); //concession no. selected
            r.GetStepNo(_conNo); // Return latest step number.
            int stepNo = r.stepNo; 
            r.GetRevison(_conNo); // Returns latest revision.
            int rev = r.rev; 
            string ss = r.stepStatus; //returns step status
            
            var _prevStepNo = stepNo - 1;// Returns previous step no. 
            //this.dgvLog.Columns[e.ColumnIndex].Index - 8;

            // Returns step number based on cell click.
            int stepClick = 0;
            int colIndex = dgvLog.CurrentCell.ColumnIndex;       
            stepClick = StepOnClick(colIndex, stepClick);
            
            //string prevStepName = this.dgvLog.Columns[e.ColumnIndex - 1].Name,

            //check if previous step is complete based on cell click
            PrevStep ps = new PrevStep();
            int stepClickPrev = stepClick - 1;
            ps.IsComplete(_conNo, stepClickPrev); 
            bool prevStep = ps.prevStep; 
            
            //concession data grid values
            var status = this.dgvLog.CurrentRow.Cells["Concession Status"].Value.ToString(); //returns concession status from selected
            string type = dgvLog.CurrentRow.Cells["Concession Type"].Value.ToString(); //returns concession type from selected
            string stepName = this.dgvLog.Columns[e.ColumnIndex].Name; //returns the step column name of selected item

            //sign off step variables
            SignOffStep sos = new SignOffStep();
            sos.lblConNo.Text = "Concession Number: " + _conNo; //label for concession number selected
            //sos.lblStepName.Text = "Step: " + stepName;
            sos.lblStepName.Text = "Step: " + stepName; //sign off step label for step name selected
            sos._stepNo = stepNo; //sign off step, current step number
            sos.nextStep = stepNo + 1; //sign off step, next step number
            sos._conNo = _conNo; //sign off step, concession number
            sos.type = type; //sign off step, concession type
            sos.stepName = stepName;           //step report variables
            StepReport sr = new StepReport();
            sr.conNo = _conNo; //step report, concession number
            sr.stepClick = stepClick; //step report, step from cell click

            //open concession report data for each concession when the concession number is clicked
            if (dgvLog.CurrentCell.ColumnIndex.Equals(0) && e.RowIndex != -1)
            {
                //open concession data form
                ConcessionData nc = new ConcessionData();
                nc.conNo = _conNo;
                nc.ShowDialog();

                //refresh log data
                dgvLog.DataSource = cld.BindSource();
                CellColour();
            }

            //find and open pdf documents
            if (dgvLog.CurrentCell.ColumnIndex.Equals(4) && e.RowIndex != -1)
            {
                Pdf pdf = new Pdf();
                pdf.Open(_conNo);

                // *Edit - Not required anymore. All documents can have PDF.
                //
                //string value = "Stamp";
                //bool contains = type.Contains(value);

                ////check if concession is 'stamp' type
                //if (contains == true || dgvLog.CurrentRow.Cells[2].Value.ToString() == "Short-Ship")
                //{
                //    Pdf pdf = new Pdf();
                //    pdf.Open(_conNo);
                //}
                //else
                //{
                //    try
                //    {
                //        //open PDF file from W:\Drive
                //        System.Diagnostics.Process.Start(@"W:\Machining Check-Sheets\pdf_checksheets\" + pdfData + ".pdf");
                //    }
                //    catch (Exception ex)
                //    {
                //        MessageBox.Show(ex.Message);
                //    }
                //}
            }

            //allow users to update concession approval
            //**update** not needed as handled in by each dept.

            //if (dgvLog.CurrentCell.ColumnIndex.Equals(9) && e.RowIndex != -1)
            //{
            //    Approval apr = new Approval();
            //    //setting values for approval form
            //    apr.lblApproval.Text = "Please select a status for " + _conNo;
            //    apr._conNo = _conNo;
            //    apr.rev = rev;
            //    apr._stepNo = stepNo;
            //    apr.ShowDialog();

            //    //re-binding log data
            //    dgvLog.DataSource = cld.BindSource();
            //    CellColour();
            //}



            //step status data, open Step Report if step of cell clicked is complete else show Sign Off Step
            if (dgvLog.CurrentCell.ColumnIndex.Equals(14) || dgvLog.CurrentCell.ColumnIndex.Equals(15) 
                || dgvLog.CurrentCell.ColumnIndex.Equals(16) || dgvLog.CurrentCell.ColumnIndex.Equals(17) 
                && e.RowIndex != -1)
            {
                if (dgvLog.CurrentCell.Value != DBNull.Value || dgvLog.CurrentRow.Cells[19].Value != DBNull.Value)
                {
                    //open step report form
                    sr.ShowDialog();
                }

                else
                {
                    string prevStepName = this.dgvLog.Columns[e.ColumnIndex - 1].Name,
                        value = "Stamp", 
                        msg = "Step '" + prevStepName + "' must be completed before '" 
                            + stepName + "' can be complete.";              
                    bool contains = type.Contains(value);

                    if (contains == true || dgvLog.CurrentRow.Cells[2].Value.ToString() == "Short-Ship")
                    {
                        sos.ShowDialog();
                        dgvLog.DataSource = cld.BindSource();
                        CellColour();

                        //if (dgvLog.CurrentCell.ColumnIndex.Equals(17) && stepNo > 2)
                        //{
                        //    sos.ShowDialog();
                        //    dgvLog.DataSource = cld.BindSource();
                        //    CellColour();
                        //}
                        //else
                        //{
                        //    MessageBox.Show(msg, _conNo);
                        //}
                        if (dgvLog.CurrentCell.ColumnIndex.Equals(16))
                        {
                            msg = "Production Director not required for " + value;
                            MessageBox.Show(msg, _conNo);
                        }        
                    }
                    else
                    {
                        //check if previous step is complete or is the first step
                        if (prevStep == true || dgvLog.CurrentCell.ColumnIndex.Equals(14))
                        {
                            //open sign off step form
                            sos.ShowDialog();
                            dgvLog.DataSource = cld.BindSource();
                            CellColour();
                        }
                        else if (stamp != true)
                        {                 
                            MessageBox.Show(msg, _conNo);
                        }
                    }                    
                }
            }

            //rejected concessions sign off only for machining and director
            //if (dgvLog.CurrentCell.ColumnIndex.Equals(12) || dgvLog.CurrentCell.ColumnIndex.Equals(13) 
            //&& dgvLog.CurrentRow.Cells[9].Value.ToString() == "Rejected")
            //{
            //    if (dgvLog.CurrentRow.Cells[14].Value == DBNull.Value)
            //    {
            //        sos.ShowDialog();
            //        dgvLog.DataSource = cld.BindSource();
            //        CellColour();
            //    }

                //}
                //else
                //{
                //    if (dgvLog.CurrentCell.ColumnIndex.Equals(13))
                //    {
                //        MessageBox.Show("Concession must be status: 'Rejected'");
                //    }
                //}
        }
        //private void dtp_TextChanged(object sender, EventArgs e)
        //{
        //    dgvLog.CurrentCell.Value = dtp.Text.ToString();
        //}

        private void dgvLog_ColumnHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            CellColour();
        }

        //filter data grid by concession number
        private void txtConSearch_TextChanged_1(object sender, EventArgs e)
        {
            string search = txtConSearch.Text;

            cld.Filter(search);
            dgvLog.DataSource = cld.dt;
            CellColour();

        }

        ToolTip tt = new ToolTip();
        private void txtConSearch_MouseHover(object sender, EventArgs e)
        {
            //int VisibleTime = 2500; 
            tt.Active = true;
            tt.Show("Search Concession, Serial/Stamp or Part Number", txtConSearch, 0, -25);
        }

        //restart app
        //private void btnRefresh_Click(object sender, EventArgs e)
        //{           
        //    Application.Restart();            
        //}

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }

        // Returns the step number selected on the data grid by the cell click. 
        private int StepOnClick(int colIndex, int stepClick)
        {
            switch (colIndex)
            {
                case 14:
                    stepClick = 1;
                    break;
                case 15:
                    stepClick = 2;
                    break;
                case 16:
                    stepClick = 3;
                    break;
                case 17:
                    stepClick = 4;
                    break;
            }
            return stepClick;
        }

        private void txtConSearch_MouseLeave(object sender, EventArgs e)
        {
            tt.Active = false;
        }
    }
}


