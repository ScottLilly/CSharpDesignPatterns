namespace Engine.CommandPattern.PatternVersion
{
    public class Transfer : ITransaction
    {
        private readonly decimal _amount;
        private readonly Account _fromAccount;
        private readonly Account _toAccount;

        public bool IsCompleted { get; set; }

        public Transfer(Account fromAccount, Account toAccount, decimal amount)
        {
            _fromAccount = fromAccount;
            _toAccount = toAccount;
            _amount = amount;

            IsCompleted = false;
        }

        public void Execute()
        {
            if(_fromAccount.Balance >= _amount)
            {
                _fromAccount.Balance -= _amount;
                _toAccount.Balance += _amount;

                IsCompleted = true;
            }
        }
    }
}