using System.Net;
using System.Net.Mail;

namespace Engine.WrapperFacadePattern.NonPatternVersion_Simple
{
    public class MyClassForFacade
    {
        public void DoSomething()
        {
            // Pretend there is business-logic here

            // Send an e-mail - simple version, with one "to" address
            MailMessage simpleEmail =
                new MailMessage("from@test.com", "to@test.com", "Email subject here", "Email body here");

            // Set up the mail server
            SmtpClient smtpClient = new SmtpClient("mailservername");
            smtpClient.Credentials = CredentialCache.DefaultNetworkCredentials;
            smtpClient.Timeout = 100;

            // Send the email
            smtpClient.Send(simpleEmail);
        }
    }
}