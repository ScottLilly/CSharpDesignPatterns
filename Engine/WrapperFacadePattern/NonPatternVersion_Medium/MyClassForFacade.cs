using System.Net;
using System.Net.Mail;

namespace Engine.WrapperFacadePattern.NonPatternVersion_Medium
{
    public class MyClassForFacade
    {
        public void DoSomething()
        {
            // Pretend there is business-logic here

            // Send an e-mail - complex version, with multiple "to", "cc", and "bcc" addresses.
            MailMessage email = new MailMessage();

            email.From = new MailAddress("from@test.com");

            email.To.Add(new MailAddress("to1@test.com"));
            email.To.Add(new MailAddress("to2@test.com"));
            email.To.Add(new MailAddress("to3@test.com"));

            email.CC.Add(new MailAddress("cc1@test.com"));
            email.To.Add(new MailAddress("cc2@test.com"));

            email.Bcc.Add(new MailAddress("bcc1@test.com"));
            email.Bcc.Add(new MailAddress("bcc2@test.com"));
            email.Bcc.Add(new MailAddress("bcc3@test.com"));
            email.Bcc.Add(new MailAddress("bcc4@test.com"));

            email.Subject = "Email subject here";
            email.Body = "Email body here";

            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            // Send the email
            smtpClient.Send(email);
        }
    }
}