namespace Engine.CommandPattern
{
    public abstract class BaseTransaction
    {
        public bool IsCompleted { get; set; }

        public abstract void Execute();
    }
}
