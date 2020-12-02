using System;
using System.Text;
using System.Net.Mail;
using System.Net.Mime;

namespace Newsletter_Creation
{
    class Message
    {
        public void SendMessage(String[] to,String from, String password, String subject, String imagePath)
        {
            MailMessage message = new System.Net.Mail.MailMessage();
            foreach(String toS in to)
            {
                message.To.Add(toS);
            }
            LinkedResource emailImage = new LinkedResource(imagePath,MediaTypeNames.Image.Jpeg);

            message.Subject = subject;
            String body = System.IO.File.ReadAllText(HTMLManager.HTML_FILE);
            //message.Body = body;

            AlternateView htmlView = AlternateView.CreateAlternateViewFromString(body, Encoding.UTF8, MediaTypeNames.Text.Html);
            emailImage.ContentId = "bodyID";
            htmlView.LinkedResources.Add(emailImage);
            message.AlternateViews.Add(htmlView);
            message.IsBodyHtml = true;
            MailAddress fromAddres = new MailAddress(from);
            message.From = fromAddres;
            SmtpClient client = new SmtpClient("smtp.office365.com");
            client.Port = 587;
            client.UseDefaultCredentials = false;
            client.Credentials = new System.Net.NetworkCredential(from, password);
            client.DeliveryMethod = SmtpDeliveryMethod.Network;
            client.EnableSsl = true;
            client.Send(message);






        }

    }
}
