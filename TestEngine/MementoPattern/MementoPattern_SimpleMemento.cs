using Engine.MementoPattern.SimpleMemento;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.MementoPattern
{
    [TestClass]
    public class MementoPattern_SimpleMemento
    {
        private const string ORIGINAL_ADDRESS = "1234 Main Street";
        private const string CHANGED_ADDRESS = "4321 Elm Street";

        [TestMethod]
        public void Test_IsDirtyAndRevertWork()
        {
            Customer customer = new Customer(1, "ABC", ORIGINAL_ADDRESS, "Houston", "TX", "77777");

            // Should not be "dirty", because the initial values have not changed.
            Assert.IsFalse(customer.IsDirty);
            Assert.AreEqual(ORIGINAL_ADDRESS, customer.Address);

            customer.Address = CHANGED_ADDRESS;

            // Should be "dirty".
            Assert.IsTrue(customer.IsDirty);
            Assert.AreEqual(CHANGED_ADDRESS, customer.Address);

            customer.RevertToOriginalValues();

            // Should not be "dirty" after reverting values.
            Assert.IsFalse(customer.IsDirty);
            Assert.AreEqual(ORIGINAL_ADDRESS, customer.Address);
        }
    }
}
