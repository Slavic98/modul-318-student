using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WinForm.Helpers
{
    public class MailModel
    {
        public MailModel(string body, string recipient, string subject="Fahrplan", bool isHtmlBody=false )
        {
            Body = body;
            Recipient=recipient;
            Subject = subject;
            IsHtmlBody = isHtmlBody;
        }
        public MailModel(string body, string recipient,string sender,string pwd, string subject = "Fahrplan", bool isHtmlBody = false)
        {
            Body = body;
            Recipient = recipient;
            Subject = subject;
            IsHtmlBody = isHtmlBody;
            Sender = sender;
            PassWord = pwd;
        }
        public string Body { get; set; }
        public string Sender { get; set; }
        public string PassWord { get; set; }
        public string Recipient { get; set; }
        public string Subject { get; set; }
        public bool IsHtmlBody { get; set; }
    }
}
