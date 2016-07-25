namespace Engine.CommandPattern.PatternVersion
{
    public interface ITransaction
    {
        bool IsCompleted { get; set; }
        void Execute();
    }
}