using System;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    public partial class SignOffStep : Form
    {
        //globals
        public int _stepNo, nextStep, rev;
        public string _conNo, stepName, stat, type, section, machType, from = "ConcessionMonitor@mazak.co.uk";
        bool rej;

        //classes
        ConcessionMain cm = new ConcessionMain(); StepComplete sc = new StepComplete(); Email em = new Email();
        Report r = new Report();

        public SignOffStep()
        {
            InitializeComponent();
            //lblStepName.Text = "Step: " + stepName;
        }
        private void SignOffStep_Load(object sender, EventArgs e)
        {
            //is rejected bool
            rej = false;

            //returns revision number           
            r.GetRevison(_conNo);
            rev = r.rev;
            r.Data(_conNo);
            stat = r.status;
            section = r.section;
            machType = r.machType;

            if (stepName != "4. Problem Causing Section")
            {
                if (stepName != "3. Production Director Decision")
                {
                    //all other depts
                    cboStepComplete.Visible = true;
                }

                //is production director
                else
                {
                    if (stat == "Rejected")
                    {
                        cboStepComplete.Visible = false;
                        rej = true;
                    }
                    else
                    {
                        cboStepComplete.Visible = true;
                    }
                }
            }

            //is problem causing section
            else
            {
                cboStepComplete.Visible = false;
                rej = true;
                btnStepSave.Text = "Accept";
            }

        }

        //save updated concession data when a step is complete
        private void btnStepSave_Click(object sender, EventArgs e)
        {
            string comment = txtStepComment.Text;
            string stepStatus = cboStepComplete.Text;

            if (rej == false)
            {
                if (string.IsNullOrEmpty(cboStepComplete.Text))
                {
                    MessageBox.Show("Select a step status to continue");
                }
                else
                {
                    //string value = "Stamp";
                    //bool contains = type.Contains(value);
                    sc.SignOff(_conNo, rev, _stepNo, comment, stepStatus, type);

                    // Send message to mail class. TURNED OFF FOR TEST.

                    //em.SendMail(_conNo, "An action is required from your department. " +
                    //stepName + " have progressed " + _conNo + " to the next step as status " +
                    //stepStatus + ". Please open Concession Monitor Application to complete actions. Thank You."
                    //, from, "", _stepNo, stepStatus, section, type, machType);

                    // Close the Form.
                    this.Close();

                }
                //sign off step


                //send mail after step sign off
                

                //if (_stepNo == 3 && stepStatus == "Rejected")
                //{
                //    sc.SignOff(_conNo, rev, _stepNo, comment, stepStatus);
                //    this.Close();
                //}
                //else
                //{

                //}

                //if (cboStepComplete.SelectedItem.ToString() == "In Progress" && _stepNo != 4)
                //{
                //    sc.Pending(_conNo);
                //    this.Close();
                //}
                //if (cboStepComplete.SelectedItem.ToString() == "Rejected" && _stepNo != 4)
                //{
                //    sc.SignOff(_conNo, rev, _stepNo, comment, stepStatus);
                //    this.Close();
                //}
                //complete step if approved 
                //if (cboStepComplete.SelectedItem.ToString() == "Approved")
                //{
                //    if (_stepNo == 4 && stepName != "Production_Director" && stepName != "Machining_Rejected")
                //    {
                //        MessageBox.Show("Machining must sign off");
                //    }
                //    else
                //    {
                //        if (stepName == "Production_Director" && _stepNo != 3)
                //        {
                //            _stepNo = 3; nextStep = _stepNo;
                //            sc.NextStep(_conNo, stepName, rev, nextStep, comment);
                //        }
                //        else
                //        {
                //            sc.Approval(_conNo, stepName, rev, _stepNo, comment);
                //        }

                //    }
                //    if (_stepNo == 3)
                //    {
                //        stat = "Completed";
                //        sc.SignOff(_conNo, stat, rev, _stepNo, stepName);
                //        this.Close();
                //    }
                //    else
                //    {
                //        sc.NextStep(_conNo, stepName, rev, nextStep, comment);
                //        this.Close();
                //    }
                //}
            }
            if (rej == true)
            {
                string status = "Accepted";
                sc.Approval(_conNo, stat, rev, _stepNo, comment, status);
                this.Close();
            }
                
        }
        
    }
}