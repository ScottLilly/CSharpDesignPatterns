using System.Linq;
using System.Windows;

namespace WorkbenchWPF.MVVMPattern.NonPatternVersion
{
    public partial class AccountCreationView : Window
    {
        public AccountCreationView()
        {
            InitializeComponent();
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            if(txtPassword.Text.Trim().Length < 8)
            {
                lblErrorMessage.Text = "Password must be at least eight characters long";
            }
            else if(txtPassword.Text.Trim().Length > 20)
            {
                lblErrorMessage.Text = "Password cannot be more than twenty characters long";
            }
            else if(!txtPassword.Text.Any(char.IsUpper))
            {
                lblErrorMessage.Text = "Password must contain at least one upper-case character";
            }
            else if(!txtPassword.Text.Any(char.IsLower))
            {
                lblErrorMessage.Text = "Password must contain at least one lower-case character";
            }
            else if(!txtPassword.Text.Any(char.IsNumber))
            {
                lblErrorMessage.Text = "Password must contain at least one number";
            }
            else
            {
                lblErrorMessage.Text = "Password is secure";
            }
        }
    }
}