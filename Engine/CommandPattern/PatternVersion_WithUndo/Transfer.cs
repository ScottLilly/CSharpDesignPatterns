using System;

namespace Engine.CommandPattern.PatternVersion_WithUndo
{
    public class Transfer : ITransaction
    {
        private readonly decimal _amount;
        private readonly Account _fromAccount;
        private readonly Account _toAccount;

        public int ID { get; set; }
        public DateTime CreatedOn { get; set; }
        public CommandState Status { get; set; }

        public Transfer(int id, Account fromAccount, Account toAccount, decimal amount)
        {
            ID = id;
            CreatedOn = DateTime.UtcNow;

            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            Status = CommandState.Unprocessed;
        }

        public void Execute()
        {
            if(_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;

                Status = CommandState.ExecuteSucceeded;
            }
            else
            {
                Status = CommandState.ExecuteFailed;
            }
        }

        public void Undo()
        {
            // Remove the money from the original "to" account, 
            // and add it back to the original "from" account.
            if(_toAccount.Balance >= _amount)
            {
                _toAccount.Balance -= _amount;
                _fromAccount.Balance += _amount;

                Status = CommandState.UndoSucceeded;
            }
            else
            {
                Status = CommandState.UndoFailed;
            }
        }
    }
}