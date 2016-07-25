namespace Engine.WrapperFacadePattern.PatternVersion
{
    public interface IEmailFluentInterface
    {
        IEmailFluentInterface From(string fromAddress);
        IEmailFluentInterface To(params string[] toAddresses);
        IEmailFluentInterface CC(params string[] ccAddresses);
        IEmailFluentInterface BCC(params string[] bccAddresses);
        IEmailFluentInterface WithSubject(string subject);
        IEmailFluentInterface WithBody(string body);
        void Send();
    }
}