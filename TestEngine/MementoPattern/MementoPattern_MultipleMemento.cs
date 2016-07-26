using Engine.MementoPattern.MultipleMemento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.MementoPattern
{
    [TestClass]
    public class MementoPattern_MultipleMemento
    {
        private const string ORIGINAL_ADDRESS = "1234 Main Street";
        private const string CHANGED_ADDRESS_1 = "4321 Elm Street";
        private const string CHANGED_ADDRESS_2 = "1111 Pine Road";
        private const string CHANGED_ADDRESS_3 = "5555 5th Avenue";

        [TestMethod]
        public void Test_IsDirtyAndRevertWork()
        {
            Customer customer = new Customer(1, "ABC", ORIGINAL_ADDRESS, "Houston", "TX", "77777");

            // Should not be "dirty", because the initial values have not changed.
            Assert.IsFalse(customer.IsDirty);
            Assert.AreEqual(ORIGINAL_ADDRESS, customer.Address);

            customer.Address = CHANGED_ADDRESS_1;
            customer.SaveMemento();

            // Should be "dirty".
            Assert.IsTrue(customer.IsDirty);
            Assert.AreEqual(CHANGED_ADDRESS_1, customer.Address);

            customer.Address = CHANGED_ADDRESS_2;
            customer.SaveMemento();

            // Should be "dirty".
            Assert.IsTrue(customer.IsDirty);
            Assert.AreEqual(CHANGED_ADDRESS_2, customer.Address);

            customer.Address = CHANGED_ADDRESS_3;

            // Should be "dirty".
            Assert.IsTrue(customer.IsDirty);
            Assert.AreEqual(CHANGED_ADDRESS_3, customer.Address);

            // Revert the current change, to latest saved memento.
            customer.RevertToLastValues();

            // Should be "dirty".
            Assert.IsTrue(customer.IsDirty);
            Assert.AreEqual(CHANGED_ADDRESS_2, customer.Address);

            // Go back to original values.
            customer.RevertToOriginalValues();

            // Should not be "dirty" after reverting values.
            Assert.IsFalse(customer.IsDirty);
            Assert.AreEqual(ORIGINAL_ADDRESS, customer.Address);
        }
    }
}
