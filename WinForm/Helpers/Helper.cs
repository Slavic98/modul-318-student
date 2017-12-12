using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.Office.Interop.Outlook;
using OutlookApp = Microsoft.Office.Interop.Outlook.Application;

namespace WinForm.Helpers
{
    public static class Helper
    {

        public static void SendResultsViaMAil(DataGridView dataGridView,MailModel mailModel)
        {

            String datatable = "<table width='100%' style='border:Solid 1px Black;'>";
            for (int i = 0; i < dataGridView.Columns.Count; i++)
            {
                datatable+="<td>" +dataGridView.Columns[i].HeaderText + "</td>";
            }
            foreach (DataGridViewRow row in dataGridView.Rows)
            {
                datatable += "<tr>";
                foreach (DataGridViewCell cell in row.Cells)
                {
                    datatable += "<td>" + cell.Value + "</td>";
                }
                datatable += "</tr>";
            }
            datatable += "</table>";

            mailModel.IsHtmlBody = true;
            mailModel.Body += datatable;
            SendEmailWithOutlook(mailModel);
        }

        /// <summary>
        /// Send Email with Gmail smtpClient
        /// </summary>
        public static void SendGmail(MailModel mailModel)
        {
            MailMessage msgtosend = null;
            try
            {
                System.Net.NetworkCredential credentials = new System.Net.NetworkCredential(mailModel.Sender, mailModel.PassWord);
                SmtpClient smtpcl = new SmtpClient
                {
                    Host = "smtp.gmail.com",
                    EnableSsl = true,
                    Credentials = credentials
                };

                msgtosend = new MailMessage
                {
                    From = new MailAddress(mailModel.Sender),
                    Subject = mailModel.Subject,
                    Body = mailModel.Body,
                    IsBodyHtml = mailModel.IsHtmlBody
                };
                msgtosend.To.Add(new MailAddress(mailModel.Recipient));
                smtpcl.Send(msgtosend);
            }
            catch (System.Exception e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                msgtosend?.Dispose();
            }
        }

        public static void SendEmailWithOutlook(MailModel mailModel)
        {
            try
            {
                OutlookApp outlookApp = new OutlookApp();
                MailItem mailItem = outlookApp.CreateItem(OlItemType.olMailItem);

                mailItem.To = mailModel.Recipient;
                mailItem.Subject = mailModel.Subject;

                if (mailModel.IsHtmlBody)
                    mailItem.HTMLBody = mailModel.Body;
                else
                    mailItem.Body = mailModel.Body;
                mailItem.Send();
                MessageBox.Show("Mail erfolgreich übermittelt", "Email-Versand");
            }

            catch (System.Exception exp)
            {
                MessageBox.Show(
                    $"Das E-Mail konnte nicht übermittelt werden.\n\nBitte nehmen Sie mit dem Entwickler Kontakt auf.\n\n Fehler : {exp.Message}",
                    "Fehler beim Mailversand", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
}
