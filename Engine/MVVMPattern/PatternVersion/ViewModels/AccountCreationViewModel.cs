using Engine.MVVMPattern.PatternVersion.Models;

namespace Engine.MVVMPattern.PatternVersion.ViewModels
{
    public class AccountCreationViewModel
    {
        public AccountModel NewAccount { get; set; }

        public AccountCreationViewModel()
        {
            NewAccount = new AccountModel();
        }

        public void ValidatePassword()
        {
            NewAccount.ValidatePassword();
        }
    }
}