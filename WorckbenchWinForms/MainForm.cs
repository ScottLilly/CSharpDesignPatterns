using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WorckbenchWinForms
{
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void OnClick_MVVMPattern_PatternVersion(object sender, EventArgs e)
        {
            MVVMPattern.PatternVersion.AccountCreationView view =
                new MVVMPattern.PatternVersion.AccountCreationView();

            view.ShowDialog();
        }
    }
}
