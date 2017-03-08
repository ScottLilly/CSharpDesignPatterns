using Engine.MVVMPattern.PatternVersion.ViewModels;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace TestEngine.MVVMPattern
{
    [TestClass]
    public class TestMVVMPattern
    {
        [TestMethod]
        public void Test_PasswordIsTooShort()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must be at least eight characters long",
                            viewModel.NewAccount.ValidationMessage);
        }

        [TestMethod]
        public void Test_PasswordIsTooLong()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asdasdasdasdasdasdasd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password cannot be more than twenty characters long",
                            viewModel.NewAccount.ValidationMessage);
        }

        [TestMethod]
        public void Test_PasswordMustHaveAnUpperCaseCharacter()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asdasdasd";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one upper-case character",
                            viewModel.NewAccount.ValidationMessage);
        }

        [TestMethod]
        public void Test_PasswordMustHaveALowerCaseCharacter()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "ASDASDASD";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one lower-case character",
                            viewModel.NewAccount.ValidationMessage);
        }

        [TestMethod]
        public void Test_PasswordMustHaveANumber()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asdasdasdA";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password must contain at least one number",
                            viewModel.NewAccount.ValidationMessage);
        }

        [TestMethod]
        public void Test_PasswordIsSecure()
        {
            AccountCreationViewModel viewModel = new AccountCreationViewModel();
            viewModel.NewAccount.Password = "asdasdasdA1";
            viewModel.ValidatePassword();

            Assert.AreEqual("Password is secure",
                            viewModel.NewAccount.ValidationMessage);
        }
    }
}