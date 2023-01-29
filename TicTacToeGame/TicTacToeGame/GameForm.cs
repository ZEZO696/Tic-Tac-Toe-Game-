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
    public partial class PlayerVPlayerForm : Form
    {
        private bool isWinner = false;
        private bool playerOneTurn;
        private int buttonsCountOnClick;
        private int seconds = 20;
        int playerOneWins = 0;
        int playerTwoWins = 0;
        public PlayerVPlayerForm()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void aboutGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Hello Darkness, my old friend. Am here to talk to you again.", "About Game",
                MessageBoxButtons.OK,MessageBoxIcon.Information);
        }

        private void TicTacToe_Load(object sender, EventArgs e)
        {
            enableDisableMethodForButtons(false);
            
            newGameMenuFunction.Enabled = true;
            resetMenuFunction.Enabled = false;
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            mainForm mainFormObj = new mainForm();
            mainFormObj.Show();
            this.Hide();
        }

        private void enableDisableMethodForButtons(bool enable)
        {
            buttonOne.Enabled = enable;
            buttonTwo.Enabled = enable;
            buttonThree.Enabled = enable;
            buttonFour.Enabled = enable;
            buttonFive.Enabled = enable;
            buttonSix.Enabled = enable;
            buttonSeven.Enabled = enable;
            buttonEight.Enabled = enable;
            buttonNine.Enabled = enable;      
        }
        
        private void enableDisableGroupBox(bool value)
        {
            GroupBoxGameSettings.Enabled = value;
            GroupBoxPlayerInfo.Enabled = value;
        }

        private void resetMenuFunction_Click(object sender, EventArgs e)
        {
            resetGame();
        }

        private void resetGame()
        {
            lblcountdownTimer.Text = "20";
            seconds = 20;
            enableDisableMethodForButtons(false);
            enableDisableGroupBox(true);
            newGameMenuFunction.Enabled = true;
            resetMenuFunction.Enabled = false;
            CleatBtn();
            buttonsCountOnClick = 0;
            isWinner = false;
            buttonOne.BackColor = Color.PowderBlue;
            buttonTwo.BackColor = Color.PowderBlue;
            buttonThree.BackColor = Color.PowderBlue;
            buttonFour.BackColor = Color.PowderBlue;
            buttonFive.BackColor = Color.PowderBlue;
            buttonSix.BackColor = Color.PowderBlue;
            buttonSeven.BackColor = Color.PowderBlue;
            buttonEight.BackColor = Color.PowderBlue;
            buttonNine.BackColor = Color.PowderBlue;
        }

        private void Btn_click(object sender, EventArgs e)
        {
            Button btn = (Button)sender;
            if (StartingPlayerOneRadioBtn.Checked)
            {
                if (PlayerOneRadioBtnX.Checked)
                    btn.Text = "X";
                else
                    btn.Text = "O";
                StartingPlayerTwoRadioBtn.Checked = true;
                btn.BackColor = Color.Cyan;
            }
            else
            {
                if (PlayerTwoRadioBtnX.Checked)
                    btn.Text = "X";
                else
                    btn.Text = "O";
                StartingPlayerOneRadioBtn.Checked = true;
                btn.BackColor = Color.MediumPurple;
            }
            btn.Enabled = false;
            buttonsCountOnClick++;
            CheckingWinner();
        }
        private void CleatBtn()
        {
            buttonOne.Text =   String.Empty;
            buttonTwo.Text =   String.Empty;
            buttonThree.Text = String.Empty;
            buttonFour.Text =  String.Empty;
            buttonFive.Text =  String.Empty;
            buttonSix.Text =   String.Empty;
            buttonSeven.Text = String.Empty;
            buttonEight.Text = String.Empty;
            buttonNine.Text =  String.Empty;
        }
        private void CheckingWinner()
        {
            if (buttonsCountOnClick == 9)
            {
                MessageBox.Show("Game Drawn!","Game Over!",MessageBoxButtons.OK,MessageBoxIcon.Information );
                resetGame();
            }
            else
            {
                if ((buttonOne.Text == buttonTwo.Text && buttonTwo.Text == buttonThree.Text) && (!buttonOne.Enabled == true))
                    isWinner = true;

                else if ((buttonFour.Text == buttonFive.Text && buttonFive.Text == buttonSix.Text) && (!buttonFour.Enabled == true))
                    isWinner = true;

                else if ((buttonSeven.Text == buttonEight.Text && buttonEight.Text == buttonNine.Text) && (!buttonSeven.Enabled == true))
                    isWinner = true;

                else if ((buttonOne.Text == buttonFour.Text && buttonFour.Text == buttonSeven.Text) && (!buttonOne.Enabled == true))
                    isWinner = true;

                else if ((buttonTwo.Text == buttonFive.Text && buttonFive.Text == buttonEight.Text) && (!buttonTwo.Enabled == true))
                    isWinner = true;

                else if ((buttonThree.Text == buttonSix.Text && buttonSix.Text == buttonNine.Text) && (!buttonThree.Enabled == true))
                    isWinner = true;

                else if ((buttonOne.Text == buttonFive.Text && buttonFive.Text == buttonNine.Text) && (!buttonOne.Enabled == true))
                    isWinner = true;

                else if ((buttonThree.Text == buttonFive.Text && buttonFive.Text == buttonSeven.Text) && (!buttonThree.Enabled == true))
                    isWinner = true;
                
                if (isWinner == true) 
                {
                    CountDownTimer.Stop();
                    if (playerOneTurn == false)
                    {
                        MessageBox.Show($"{playerTwoNameTextBox.Text} is the winner", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        playerTwoWins++;
                        lblPlayerTwoWins.Text =  playerTwoNameTextBox.Text + " Wins - "  + playerTwoWins;
                    }
                    else
                    {
                        MessageBox.Show($"{playerOneNameTextBox.Text} is the winner", "Game Over", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        playerOneWins++;
                        lblPlayerOneWins.Text = playerOneNameTextBox.Text + " Wins - " + playerOneWins;
                    }
                    resetGame();
                }
            }
            
        }

        private void startBtn_Click(object sender, EventArgs e)
        {
            enableDisableMethodForButtons(true);
            newGameMenuFunction.Enabled = false;
            resetMenuFunction.Enabled = true;
            playerOneTurn = true;
            enableDisableGroupBox(false);
            CountDownTimer.Start();
        }

        private void CountdownTimer_Func(object sender, EventArgs e)
        {
            lblcountdownTimer.Text = seconds--.ToString();
            if(seconds < 0)
            {
                CountDownTimer.Stop();
                MessageBox.Show("Game Drawn!!", "Time Over!!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                resetGame();
            }
        }
    }
}
