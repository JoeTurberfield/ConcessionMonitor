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
                            message.CC.Add("VCN430A@mazak.co.uk");
                        }
                        if (machType == "QT200/250" || machType == "QT300/350")
                        {
                            message.CC.Add("QT200@mazak.co.uk");
                        }
                        if (machType == "VTC800")
                        {
                            message.CC.Add("VTC800@mazak.co.uk");
                        }

                        message.Subject += "Engineering";
                        break;

                    //step 1 complete, send mail to quality
                    case 1:
                        //message.CC.Add("jturberfield@mazak.co.uk");
                        message.Subject = "Quality";
                        message.CC.Add("Quality@mazak.co.uk");
                        break;

                    //step 2 complete, send email to director
                    case 2:
                        //message.CC.Add("jturberfield@mazak.co.uk");
                        message.Subject = "Director";
                        message.CC.Add("Director@mazak.co.uk");
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
                    message.CC.Add("Quality@mazak.co.uk");
                    break;
                case "QT Lathe Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("QT@mazak.co.uk");
                    break;
                case "VTC/VCN Commodity Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("VTC/VCN@mazak.co.uk");
                    break;
                case "VTC800 Group":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("VTC800@mazak.co.uk");
                    break;
                case "Logistics":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("Logistics@mazak.co.uk");
                    break;
                case "EDM":
                    message.Subject = section;
                    message.CC.Add("jturberfield@mazak.co.uk");                 
                    message.CC.Add("EDM@mazak.co.uk");
                    break;
                case "Machining":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("Machining@mazak.co.uk");
                    break;
                case "SMD":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("SMD@mazak.co.uk");
                    break;
                case "Purchasing":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("Purchasing@mazak.co.uk");
                    break;
                case "General Assembly":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("GeneralAssembly@mazak.co.uk");
                    break;
                case "Elec/Modular/Unit":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("ElecModularUnit@mazak.co.uk");
                    break;
                case "Powder Line":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("Powder@mazak.co.uk");
                    break;
                case "Shipping":
                    //message.CC.Add("jturberfield@mazak.co.uk");
                    message.Subject = section;
                    message.CC.Add("Shipping@mazak.co.uk");
                    break;
            }
           
        }
    }
}
