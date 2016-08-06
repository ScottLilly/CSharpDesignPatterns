using System;

namespace Engine.CommandPattern.PatternVersion_WithUndo
{
    public interface ITransaction
    {
        int ID { get; set; }
        DateTime CreatedOn { get; set; }
        CommandState Status { get; set; }
        void Execute();
        void Undo();
    }
}