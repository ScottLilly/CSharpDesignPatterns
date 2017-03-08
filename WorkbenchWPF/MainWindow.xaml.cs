using System.Windows;

namespace WorkbenchWPF
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void OnClick_MVVMPattern_NonPatternVersion(object sender, RoutedEventArgs e)
        {
            MVVMPattern.NonPatternVersion.AccountCreationView view =
                new MVVMPattern.NonPatternVersion.AccountCreationView();

            view.ShowDialog();
        }

        private void OnClick_MVVMPattern_PatternVersion(object sender, RoutedEventArgs e)
        {
            MVVMPattern.PatternVersion.AccountCreationView view =
                new MVVMPattern.PatternVersion.AccountCreationView();

            view.ShowDialog();
        }
    }
}