using System;
using System.Windows.Forms;
using Engine.PublishSubscribePattern.PatternVersion.Models;

namespace Workbench
{
    public partial class Form1 : Form
    {
        private readonly Player _currentPlayer = new Player {HitPoints = 10};

        public Form1()
        {
            InitializeComponent();

            _currentPlayer.PlayerKilled += PlayerKilled;
        }

        private void PlayerKilled(object sender, EventArgs eventArgs)
        {
            MessageBox.Show("Got here!");
        }

        private void btnTest_Click(object sender, EventArgs e)
        {
            _currentPlayer.HitPoints -= 3;
        }
    }
}