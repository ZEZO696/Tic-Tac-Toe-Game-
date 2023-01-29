using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class mainForm : Form
    {
        public mainForm()
        {
            InitializeComponent();
          
        }
        
        private void button1_Click(object sender, EventArgs e)
        {
            PlayerVPlayerForm playerVplayerObj = new PlayerVPlayerForm();
            playerVplayerObj.Show();
            this.Hide();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            PlayerVsComputer playerVComputerObj = new PlayerVsComputer();
            playerVComputerObj.Show();
            this.Hide();
        }
    }
}
