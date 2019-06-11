using System.Net;
using System.Net.Mail;

namespace TaskManager.Services
{
    public class EmailSender
    {
        public void SendEmail(string emailSender, string emailGetter, string header, string mainText)
        {
            MailAddress from = new MailAddress(emailSender);
            MailAddress to = new MailAddress(emailGetter);
            MailMessage m = new MailMessage(from, to);

            m.Subject = header;
            m.Body = mainText;
            m.IsBodyHtml = true;

            SmtpClient smtp = new SmtpClient("smtp.gmail.com", 587);

            smtp.Credentials = new NetworkCredential("testtumbler1@gmail.com", "ablihe2v");
            smtp.EnableSsl = true;
            smtp.Send(m);
        }
    }
}
