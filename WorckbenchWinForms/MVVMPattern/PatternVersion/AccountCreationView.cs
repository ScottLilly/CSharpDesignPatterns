using System;
using System.Windows.Forms;
using Engine.MVVMPattern.PatternVersion.ViewModels;

namespace WorckbenchWinForms.MVVMPattern.PatternVersion
{
    public partial class AccountCreationView : Form
    {
        private readonly AccountCreationViewModel _viewModel = new AccountCreationViewModel();

        public AccountCreationView()
        {
            InitializeComponent();

            label_ValidationMessage.DataBindings.Add(new Binding("Text", _viewModel, "NewAccount.ValidationMessage",true));
            textBox_Password.DataBindings.Add(new Binding("Text", _viewModel, "NewAccount.Password", true));
        }

        private void OnClick_ValidatePassword(object sender, EventArgs e)
        {
            _viewModel.ValidatePassword();
        }
    }
}
