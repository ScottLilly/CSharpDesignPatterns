using Engine.CommandPattern.PatternVersion_WithUndo;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.CommandPattern.PatternVersion_WithUndo
{
    [TestClass]
    public class TestCommandPattern
    {
        [TestMethod]
        public void Test_AllTransactionsSuccessful()
        {
            TransactionManager transactionManager = new TransactionManager();

            Account suesAccount = new Account("Sue Smith", 0);

            Deposit deposit = new Deposit(1, suesAccount, 100);
            transactionManager.AddTransaction(deposit);

            // Command has been added to the queue, but not executed.
            Assert.IsTrue(transactionManager.HasPendingTransactions);
            Assert.AreEqual(0, suesAccount.Balance);

            // This executes the commands.
            transactionManager.ProcessPendingTransactions();

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(100, suesAccount.Balance);

            // Add a withdrawal, apply it, and verify the balance changed.
            Withdraw withdrawal = new Withdraw(2, suesAccount, 50);
            transactionManager.AddTransaction(withdrawal);

            transactionManager.ProcessPendingTransactions();

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(50, suesAccount.Balance);

            // Test the undo
            transactionManager.UndoTransactionNumber(2);

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(100, suesAccount.Balance);
        }

        [TestMethod]
        public void Test_OverdraftRemainsInPendingTransactions()
        {
            TransactionManager transactionManager = new TransactionManager();

            // Create an account with a balance of 75
            Account bobsAccount = new Account("Bob Jones", 75);

            // The first command is a withdrawal that is larger than the account's balance.
            // It will not be executed, because of the check in Withdraw.Execute.
            // The deposit will be successful.
            transactionManager.AddTransaction(new Withdraw(1, bobsAccount, 100));
            transactionManager.AddTransaction(new Deposit(2, bobsAccount, 75));

            transactionManager.ProcessPendingTransactions();

            // The withdrawal of 100 was not completed, 
            // because there was not enough money in the account.
            // So, it is still pending.
            Assert.IsTrue(transactionManager.HasPendingTransactions);
            Assert.AreEqual(150, bobsAccount.Balance);

            // The pending transactions (the withdrawal of 100), should execute now.
            transactionManager.ProcessPendingTransactions();

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(50, bobsAccount.Balance);

            // Test the undo
            transactionManager.UndoTransactionNumber(2);

            // The undo failed, because there is not enough money in the account to undo a deposit of 75
            Assert.IsTrue(transactionManager.HasPendingTransactions);
            Assert.AreEqual(50, bobsAccount.Balance);

            transactionManager.UndoTransactionNumber(1);

            // The previous undo (for transaction ID 2) is still pending.
            // But, we successfully undid transaction ID 1.
            Assert.IsTrue(transactionManager.HasPendingTransactions);
            Assert.AreEqual(150, bobsAccount.Balance);

            // This should re-do the failed undo for transaction ID 2
            transactionManager.ProcessPendingTransactions();

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(75, bobsAccount.Balance);
        }

        [TestMethod]
        public void Test_Transfer()
        {
            TransactionManager transactionManager = new TransactionManager();

            Account checking = new Account("Mike Brown", 1000);
            Account savings = new Account("Mike Brown", 100);

            transactionManager.AddTransaction(new Transfer(1, checking, savings, 750));

            transactionManager.ProcessPendingTransactions();

            Assert.AreEqual(250, checking.Balance);
            Assert.AreEqual(850, savings.Balance);

            // Undo the transfer, and check the account balances.
            transactionManager.UndoTransactionNumber(1);

            Assert.IsFalse(transactionManager.HasPendingTransactions);
            Assert.AreEqual(1000, checking.Balance);
            Assert.AreEqual(100, savings.Balance);
        }
    }
}