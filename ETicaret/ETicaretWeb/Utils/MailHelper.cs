using ETicaretCore.Entities;
using System.Net;
using System.Net.Mail;

namespace ETicaretWeb.Utils;

public class MailHelper
{
    public static async Task SendMailAsync(Contact contact)
    {
        SmtpClient smtpClient = new SmtpClient("mail",587);
        smtpClient.Credentials = new NetworkCredential("","");
        smtpClient.EnableSsl = false;
        MailMessage message = new MailMessage();
        message.From = new MailAddress("");
        message.To.Add("");
        message.Subject = "Mesaj";
        message.Body = $"Gönderen: {contact.Name}  {contact.Surname} {contact.Message}";
        message.IsBodyHtml = true;
        await smtpClient.SendMailAsync(message);
        smtpClient.Dispose();
    }
}
