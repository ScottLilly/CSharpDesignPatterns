namespace Engine.CommandPattern.PatternVersion_WithUndo
{
    public enum CommandState
    {
        Unprocessed,
        ExecuteFailed,
        ExecuteSucceeded,
        UndoFailed,
        UndoSucceeded
    }
}