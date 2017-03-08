using System.Windows;
using Engine.MVVMPattern.PatternVersion.ViewModels;

namespace WorkbenchWPF.MVVMPattern.PatternVersion
{
    public partial class AccountCreationView : Window
    {
        private readonly AccountCreationViewModel _viewModel = new AccountCreationViewModel();

        public AccountCreationView()
        {
            InitializeComponent();

            DataContext = _viewModel;
        }

        private void OnClick_ValidatePassword(object sender, RoutedEventArgs e)
        {
            _viewModel.ValidatePassword();
        }
    }
}