using System.ComponentModel;
using System.Linq;

namespace Engine.MVVMPattern.PatternVersion.Models
{
    public class AccountModel : INotifyPropertyChanged
    {
        private string _name;
        private string _password;
        private string _validationMessage;

        public string Name
        {
            get { return _name; }
            set { _name = value; }
        }

        public string Password
        {
            get { return _password; }
            set
            {
                _password = value;

                OnPropertyChanged(nameof(Password));
            }
        }

        public string ValidationMessage
        {
            get { return _validationMessage; }
            set
            {
                _validationMessage = value;

                OnPropertyChanged(nameof(ValidationMessage));
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void ValidatePassword()
        {
            if(Password.Trim().Length < 8)
            {
                ValidationMessage = "Password must be at least eight characters long";
            }
            else if(Password.Trim().Length > 20)
            {
                ValidationMessage = "Password cannot be more than twenty characters long";
            }
            else if(!Password.Any(char.IsUpper))
            {
                ValidationMessage = "Password must contain at least one upper-case character";
            }
            else if(!Password.Any(char.IsLower))
            {
                ValidationMessage = "Password must contain at least one lower-case character";
            }
            else if(!Password.Any(char.IsNumber))
            {
                ValidationMessage = "Password must contain at least one number";
            }
            else
            {
                ValidationMessage = "Password is secure";
            }
        }

        protected virtual void OnPropertyChanged(string propertyName)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }
    }
}