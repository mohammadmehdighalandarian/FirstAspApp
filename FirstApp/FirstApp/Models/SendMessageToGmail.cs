using System.Net.Mail;

namespace FirstApp.Models
{
    public class SendMessageToGmail
    {
        public  SendMessageToGmail(string from, string Subject, string Body,string senderName)
        {
            MailMessage mail = new MailMessage();
            SmtpClient SmtpServer = new SmtpClient("smtp.gmail.com");
            mail.From = new MailAddress(from);
            mail.To.Add("mohammadmehdi@gmail.com");
            
            mail.Subject = Subject;
            mail.Body = Body;
            mail.IsBodyHtml = true;

            //System.Net.Mail.Attachment attachment;
            // attachment = new System.Net.Mail.Attachment("c:/textfile.txt");
            // mail.Attachments.Add(attachment);

            SmtpServer.Port = 587;
            SmtpServer.Credentials = new System.Net.NetworkCredential("mohammadmehdi@gmail.com", "***");//my Email
            SmtpServer.EnableSsl = true;

            SmtpServer.Send(mail);

        }
    }
}
