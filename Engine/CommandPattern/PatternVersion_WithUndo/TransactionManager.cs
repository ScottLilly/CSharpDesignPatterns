using System;
using System.Collections.Generic;
using System.Linq;

namespace Engine.CommandPattern.PatternVersion_WithUndo
{
    public class TransactionManager
    {
        private readonly List<ITransaction> _transactions = new List<ITransaction>();

        public bool HasPendingTransactions
        {
            get
            {
                return _transactions.Any(x =>
                    x.Status == CommandState.Unprocessed ||
                    x.Status == CommandState.ExecuteFailed ||
                    x.Status == CommandState.UndoFailed);
            }
        }

        public void AddTransaction(ITransaction transaction)
        {
            _transactions.Add(transaction);
        }

        public void ProcessPendingTransactions()
        {
            // Execute transactions that are unprocessed, or had a previous Execute fail.
            foreach(ITransaction transaction in _transactions.Where(x =>
                x.Status == CommandState.Unprocessed ||
                x.Status == CommandState.ExecuteFailed))
            {
                transaction.Execute();
            }

            // Retry the Undo, for transactions that had a previous Undo fail.
            foreach(ITransaction transaction in _transactions.Where(x =>
                x.Status == CommandState.UndoFailed))
            {
                transaction.Undo();
            }
        }

        public void UndoTransactionNumber(int id)
        {
            // Get the Command object that has the passed ID.
            // If it does not exist in _transactions, the result will be null (default, for this object type).
            ITransaction transaction = _transactions.FirstOrDefault(x => x.ID == id);

            if(transaction == null)
            {
                throw new ArgumentException(string.Format("There is no transaction number: {0}", id));
            }

            if(transaction.Status != CommandState.ExecuteSucceeded)
            {
                throw new ArgumentException("Can only undo transactions that have been successfully executed.");
            }

            // We have a valid transaction, so perform the "undo".
            transaction.Undo();

            // Remove the transaction, if it was successfully completed.
            if(transaction.Status == CommandState.UndoSucceeded)
            {
                _transactions.Remove(transaction);
            }
        }

        public void RemoveOldTransactions()
        {
            // Remove transaction that have been Executed, and are more than 15 days old.
            _transactions.RemoveAll(x =>
                x.Status == CommandState.ExecuteSucceeded &&
                (DateTime.UtcNow - x.CreatedOn).Days > 15);
        }
    }
}