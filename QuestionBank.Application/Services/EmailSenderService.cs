using Microsoft.Extensions.Options;
using System.Net.Mail;
using System.Net;
using QuestionBank.Application.Helpers.Common;

namespace QuestionBank.Application.Services;

public interface IEmailSender
{
    Task SendEmailAsync(string message, string subject, string[] toAddress, string[] ccAddress, string[] attachements);
    Task Execute(string message, string subject, string[] toAddress, string[] ccAddress, string[] attachements);
}
public class EmailSenderService :IEmailSender
{
    private readonly Settings _emailSettings;
    public EmailSenderService(IOptions<Settings> emailSettings)
    {
        _emailSettings = emailSettings.Value;
    }
    public Task SendEmailAsync(string message, string subject, string[] toAddress, string[] ccAddress, string[] attachements)
    {
        Execute(message, subject, toAddress, ccAddress, attachements).Wait();
        return Task.FromResult(0);
    }

    public async Task Execute(string message, string subject, string[] toAddress, string[] ccAddress, string[] attachements)
    {
        try
        {
            if (toAddress == null && ccAddress == null)
                return;

            MailMessage mail = new MailMessage()
            {
                From = new MailAddress(_emailSettings.EmailSettings.Sender, "Identity Services")
            };


            if (toAddress != null)
            {
                foreach (var to in toAddress)
                    mail.To.Add(new MailAddress(to));
            }

            if (ccAddress != null)
            {
                foreach (var cc in ccAddress)
                    mail.CC.Add(new MailAddress(cc));
            }

            if (attachements != null)
            {
                foreach (var fileName in attachements)
                    mail.Attachments.Add(new Attachment(fileName));
            }

            mail.Subject = subject;
            mail.Body = message;
            mail.IsBodyHtml = true;
            mail.Priority = MailPriority.High;

            using (SmtpClient smtp = new SmtpClient(_emailSettings.EmailSettings.MailServer, _emailSettings.EmailSettings.MailPort))
            {
                smtp.UseDefaultCredentials = false;
                smtp.Credentials = new NetworkCredential(_emailSettings.EmailSettings.Sender, _emailSettings.EmailSettings.Password);
                smtp.EnableSsl = true;
                smtp.Timeout = 20000;
                await smtp.SendMailAsync(mail);
            }
        }
        catch (Exception ex)
        {

        }

    }
}

