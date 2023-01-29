using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TicTacToeGame
{
    public partial class PlayerVsComputer : Form
    {
        public enum Player
        {
            X, O
        }
 
        Player currentPlayerMove;
        List<Button> buttons; 
        Random rand = new Random(); 
        int playerWinsCounter = 0; 
        int computerWinsCounter = 0; 
 
        public PlayerVsComputer()
        {
            InitializeComponent();
            resetGame(); 
        }
 
        private void btn_click(object sender, EventArgs e)
        {
            var button = (Button)sender; 
            currentPlayerMove = Player.X; 
            button.Text = currentPlayerMove.ToString(); 
            button.Enabled = false; 
            button.BackColor = System.Drawing.Color.Cyan; 
            buttons.Remove(button); 
            CheckWinner(); 
            AIturnTimer.Start(); // start the AI timer
        }
 
        private void CpuMoveFunc(object sender, EventArgs e)
        {
           
            if (buttons.Count > 0)
            {
                int index = rand.Next(buttons.Count);
 
                currentPlayerMove = Player.O; 
                buttons[index].Text = currentPlayerMove.ToString();
                buttons[index].BackColor = System.Drawing.Color.MediumPurple; 
                buttons.RemoveAt(index); 
                CheckWinner(); 
                AIturnTimer.Stop();
            }
        }
 
        private void resetGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
            resetGame();
        }
 
        private void loadbuttons()
        {
            
            buttons = new List<Button> { buttonOne, buttonTwo, buttonThree, buttonFour, buttonFive, buttonSix, buttonSeven, buttonNine, buttonEight };
        }
 
        private void resetGame()
        {
            chooseOpponentFunciton.Enabled = true;
            resetMenuFunciton.Enabled = false;
            CleatBtn();
            buttonOne.BackColor = Color.PowderBlue;
            buttonTwo.BackColor = Color.PowderBlue;
            buttonThree.BackColor = Color.PowderBlue;
            buttonFour.BackColor = Color.PowderBlue;
            buttonFive.BackColor = Color.PowderBlue;
            buttonSix.BackColor = Color.PowderBlue;
            buttonSeven.BackColor = Color.PowderBlue;
            buttonEight.BackColor = Color.PowderBlue;
            buttonNine.BackColor = Color.PowderBlue;
            foreach (Control X in this.Controls)
            {
                if (X is Button)
                {
                    ((Button)X).Enabled = true; 
                    ((Button)X).BackColor = Color.PowderBlue; 
                }
            }
            loadbuttons(); 
        }
 
        private void CheckWinner()
        {
            
            if (buttonOne.Text == "X" && buttonTwo.Text == "X" && buttonThree.Text == "X"
               || buttonFour.Text == "X" && buttonFive.Text == "X" && buttonSix.Text == "X"
               || buttonSeven.Text == "X" && buttonNine.Text == "X" && buttonEight.Text == "X"
               || buttonOne.Text == "X" && buttonFour.Text == "X" && buttonSeven.Text == "X"
               || buttonTwo.Text == "X" && buttonFive.Text == "X" && buttonEight.Text == "X"
               || buttonThree.Text == "X" && buttonSix.Text == "X" && buttonNine.Text == "X"
               || buttonOne.Text == "X" && buttonFive.Text == "X" && buttonNine.Text == "X"
               || buttonThree.Text == "X" && buttonFive.Text == "X" && buttonSeven.Text == "X")
            {
               
                AIturnTimer.Stop(); 
                MessageBox.Show("Player Wins"); 
                playerWinsCounter++;  
                label2.Text = "Player Wins - " + playerWinsCounter; 
                resetGame(); 
            }
            
            else if (buttonOne.Text == "O" && buttonTwo.Text == "O" && buttonThree.Text == "O"
            || buttonFour.Text == "O" && buttonFive.Text == "O" && buttonSix.Text == "O"
            || buttonSeven.Text == "O" && buttonNine.Text == "O" && buttonEight.Text == "O"
            || buttonOne.Text == "O" && buttonFour.Text == "O" && buttonSeven.Text == "O"
            || buttonTwo.Text == "O" && buttonFive.Text == "O" && buttonEight.Text == "O"
            || buttonThree.Text == "O" && buttonSix.Text == "O" && buttonNine.Text == "O"
            || buttonOne.Text == "O" && buttonFive.Text == "O" && buttonNine.Text == "O"
            || buttonThree.Text == "O" && buttonFive.Text == "O" && buttonSeven.Text == "O")
            {
                computerWinsCounter++;
                AIturnTimer.Stop(); 
                MessageBox.Show("Computer Wins");
                label3.Text = "Computer Wins - " + computerWinsCounter; 
                resetGame(); 
            }
        }
        private void CleatBtn()
        {
            buttonOne.Text = String.Empty;
            buttonTwo.Text = String.Empty;
            buttonThree.Text = String.Empty;
            buttonFour.Text = String.Empty;
            buttonFive.Text = String.Empty;
            buttonSix.Text = String.Empty;
            buttonSeven.Text = String.Empty;
            buttonEight.Text = String.Empty;
            buttonNine.Text = String.Empty;
        }
        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void chooseOpponentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            mainForm main_formObj = new mainForm();
            main_formObj.Show();
            this.Hide();
        }
    }
}
