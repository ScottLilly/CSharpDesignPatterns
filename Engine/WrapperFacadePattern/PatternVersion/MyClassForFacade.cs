using Engine.WrapperFacadePattern.PatternVersion;

namespace DesignPatternDemos.Facade
{
    public class MyClassForFacade
    {
        public void DoSomething()
        {
            // Pretend there is business-logic here

            // Send an e-mail - version behind wrapper/facade, with multiple "to", "cc", and "bcc" addresses.
            EmailCreator.CreateEmailFrom("from@test.com")
                .To("to1@test.com", "to2@test.com", "to2@test.com")
                .CC("cc1@test.com", "cc2@test.com")
                .BCC("bcc1@test.com", "bcc2@test.com", "bcc3@test.com", "bcc4@test.com")
                .WithSubject("Email subject here")
                .WithBody("Email body here")
                .Send();
        }
    }
}