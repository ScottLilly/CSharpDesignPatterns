using System.Net;
using System.Net.Mail;

namespace Engine.WrapperFacadePattern.NonPatternVersion_Complex
{
    public class MyClassForFacade
    {
        public void DoSomething()
        {
            // Pretend there is business-logic here

            // Send an e-mail - complex version, with multiple "to", "cc", and "bcc" addresses.
            MailMessage email = new MailMessage();

            MailAddress fromAddress = new MailAddress("from@test.com");
            email.From = fromAddress;

            MailAddress toAddress1 = new MailAddress("to1@test.com");
            email.To.Add(toAddress1);
            MailAddress toAddress2 = new MailAddress("to2@test.com");
            email.To.Add(toAddress2);
            MailAddress toAddress3 = new MailAddress("to3@test.com");
            email.To.Add(toAddress3);

            MailAddress ccAddress1 = new MailAddress("cc1@test.com");
            email.CC.Add(ccAddress1);
            MailAddress ccAddress2 = new MailAddress("cc2@test.com");
            email.CC.Add(ccAddress2);

            MailAddress bccAddress1 = new MailAddress("bcc1@test.com");
            email.Bcc.Add(bccAddress1);
            MailAddress bccAddress2 = new MailAddress("bcc2@test.com");
            email.Bcc.Add(bccAddress2);
            MailAddress bccAddress3 = new MailAddress("bcc3@test.com");
            email.Bcc.Add(bccAddress3);
            MailAddress bccAddress4 = new MailAddress("bcc4@test.com");
            email.Bcc.Add(bccAddress4);

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