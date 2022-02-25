using System;
using System.Collections.Generic;
using System.Net.Mail;
using System.Windows.Forms;

namespace ConcessionMonitor
{
    class Email
    {
        MailMessage message = new MailMessage();

        private string smtpClientHost = "ymuk-gwsv2"; //"smtp-mail.outlook.com"; // "mail.jp-admin.co.uk" 
        public Dictionary<string, string> dicMailTo = new Dictionary<string, string>();

        public void SendMail(string Subject, string Body, string FromEmail, string FromName, int stepNo, string stepStatus, 
            string section, string type, string machType)
        {
            try
            {
                SmtpClient smtpClient = new SmtpClient();

                MailAddress fromAddress = new MailAddress(FromEmail, FromName);
                smtpClient.Host = smtpClientHost;
                smtpClient.Port = 25; //587; 
                message.From = fromAddress;

                Body += "<br/><br/><br/>Please do not reply to this Email.";
                //Body += "<br/>Open the Concession Monitor Application to add updates.";

                // Skip director email for Stamp and Short-Ships
                if(stepNo == 2 && (type == "Stamp" || type == "Short-Ship"))
                {
                    stepNo = 3;
                }

                switch (stepNo)
                {
                    //concession create, send to engineering
                    case 0:
                        //message.CC.Add("jturberfield@mazak.co.uk"); 

                        // Send to product groups by machine type.
                        if(machType == "VCN430A/530C" || machType == "VTC530C/760C")
                        {
                            message.CC.Add("tperrin@mazak.co.uk");
                        }
                        if (machType == "QT200/250" || machType == "QT300/350")
                        {
                            message.CC.Add("jmoffat@mazak.co.uk");
                        }
                        if (machType == "VTC800")
                        {
                            message.CC.Add("rwellings@mazak.co.uk");
                        }

                        message.Subject += "Engineering";
                        break;

                    //step 1 complete, send mail to quality
                    case 1:
                        //message.CC.Add("jturberfield@mazak.co.uk");
                        message.Subject = "Quality";
                        message.CC.Add("cbills@mazak.co.uk");
                        break;

                    //step 2 complete, send email to director
                    case 2:
                        //message.CC.Add("jturberfield@mazak.co.uk");
                        message.Subject = "Director";
                        message.CC.Add("sastley@mazak.co.uk");
                        break;

                    //step 3 complete and concession rejected, send to machining
                    case 3:

                        //message.CC.Add("jturberfield@mazak.co.uk");
                        message.Subject = stepStatus;
                        DeptMail(section);

                        //if (stepStatus == "Rejected")
                        //{
                        //    message.CC.Add("jturberfield@mazak.co.uk");
                        //    DeptMail(section);
                        //}
                        //else
                        //{
                        //    //send to section responsible
                        //    message.CC.Add("jturberfield@mazak.co.uk");
                        //    DeptMail(section);
                        //}
                        break;
                        // Accepted rejected concessions. Mail back to problem causing section.
                    case 4:
                        DeptMail(section);
                        //message.CC.Add("jturberfield@mazak.co.uk");
                        //message.Subject = "Rejected";
                        break;


                }
                message.Subject += ": " + Subject;
                message.IsBodyHtml = true;
                message.Priority = MailPriority.Normal;
                message.Body = "<span style=\"font-family:Arial;font-size: 10pt;\">" + Body + "</span>"; // 'Regex.Replace(Body, "<[^>]*>", " ") 

                // Send mail.
                smtpClient.Send(message);
            }
            catch (Exception ex)
            {
                string Report = ex.Message;

            }
        }

        //concession complete, send mail to section responsible
        public void DeptMail(string section)
        {
            switch (section) 
            {
                case "Quality":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;                 
                    message.CC.Add("cbills@mazak.co.uk");
                    message.CC.Add("ghodgkins@mazak.co.uk");
                    message.CC.Add("gbarnes@mazak.co.uk");
                    break;
                case "QT Lathe Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("dsimkin@mazak.co.uk");
                    message.CC.Add("jmoffat@mazak.co.uk");
                    break;
                case "VTC/VCN Commodity Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("atame@mazak.co.uk");
                    message.CC.Add("tperrin@mazak.co.uk");
                    message.CC.Add("alee@mazak.co.uk");
                    break;
                case "VTC800 Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("atame@mazak.co.uk");
                    message.CC.Add("rwellings@mazak.co.uk");
                    message.CC.Add("alee@mazak.co.uk");
                    break;
                case "Logistics":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("kbuckley@mazak.co.uk");
                    message.CC.Add("lwillems@mazak.co.uk");
                    break;
                case "EDM":
                    message.Subject = section;
                    message.CC.Add("jturberfield@mazak.co.uk");                 
                    message.CC.Add("kbuckley@mazak.co.uk");
                    message.CC.Add("whenley@mazak.co.uk");
                    break;
                case "Machining":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("schapman@mazak.co.uk");
                    message.CC.Add("dastley@mazak.co.uk");
                    message.CC.Add("pjohnstone@mazak.co.uk");
                    message.CC.Add("jmurphy@mazak.co.uk");
                    message.CC.Add("mjacobs@mazak.co.uk");
                    break;
                case "SMD":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("wprice@mazak.co.uk");
                    message.CC.Add("mscott@mazak.co.uk");
                    message.CC.Add("nperry@mazak.co.uk");
                    message.CC.Add("awatkins@mazak.co.uk");
                    break;
                case "Purchasing":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("medwards@mazak.co.uk");
                    message.CC.Add("plawrence@mazak.co.uk");
                    break;
                case "General Assembly":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("ebrzezicki@mazak.co.uk");
                    message.CC.Add("rhayes@mazak.co.uk");
                    break;
                case "Elec/Modular/Unit":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("rlorenzosmith@mazak.co.uk");
                    message.CC.Add("rhayes@mazak.co.uk");
                    break;
                case "Powder Line":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("wprice@mazak.co.uk");
                    message.CC.Add("cgrubb@mazak.co.uk");
                    break;
                case "Shipping":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("cbills@mazak.co.uk");
                    message.CC.Add("ghodgkins@mazak.co.uk");
                    message.CC.Add("bbryant@mazak.co.uk");
                    break;
            }
           
        }
    }
}
