
namespace TicTacToeGame
{
    partial class PlayerVPlayerForm
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameMenuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.resetMenuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.exitMenuFunction = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.buttonOne = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.lblcountdownTimer = new System.Windows.Forms.Label();
            this.startBtn = new System.Windows.Forms.Button();
            this.GroupBoxGameSettings = new System.Windows.Forms.GroupBox();
            this.GroupBoxForStartingPlayer = new System.Windows.Forms.GroupBox();
            this.StartingPlayerTwoRadioBtn = new System.Windows.Forms.RadioButton();
            this.StartingPlayerOneRadioBtn = new System.Windows.Forms.RadioButton();
            this.groupBoxForXPlayer = new System.Windows.Forms.GroupBox();
            this.PlayerOneRadioBtnX = new System.Windows.Forms.RadioButton();
            this.PlayerTwoRadioBtnX = new System.Windows.Forms.RadioButton();
            this.GroupBoxPlayerInfo = new System.Windows.Forms.GroupBox();
            this.playerTwoNameTextBox = new System.Windows.Forms.TextBox();
            this.playerOneNameTextBox = new System.Windows.Forms.TextBox();
            this.PlayerTwoLabel = new System.Windows.Forms.Label();
            this.playerOneLabel = new System.Windows.Forms.Label();
            this.CountDownTimer = new System.Windows.Forms.Timer(this.components);
            this.lblPlayerOneWins = new System.Windows.Forms.Label();
            this.lblPlayerTwoWins = new System.Windows.Forms.Label();
            this.menuStrip1.SuspendLayout();
            this.GroupBoxGameSettings.SuspendLayout();
            this.GroupBoxForStartingPlayer.SuspendLayout();
            this.groupBoxForXPlayer.SuspendLayout();
            this.GroupBoxPlayerInfo.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.helpToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(749, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameMenuFunction,
            this.resetMenuFunction,
            this.exitMenuFunction});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "&File";
            // 
            // newGameMenuFunction
            // 
            this.newGameMenuFunction.Name = "newGameMenuFunction";
            this.newGameMenuFunction.Size = new System.Drawing.Size(171, 22);
            this.newGameMenuFunction.Text = "&Choose Opponent";
            this.newGameMenuFunction.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // resetMenuFunction
            // 
            this.resetMenuFunction.Name = "resetMenuFunction";
            this.resetMenuFunction.Size = new System.Drawing.Size(171, 22);
            this.resetMenuFunction.Text = "&Reset Game";
            this.resetMenuFunction.Click += new System.EventHandler(this.resetMenuFunction_Click);
            // 
            // exitMenuFunction
            // 
            this.exitMenuFunction.Name = "exitMenuFunction";
            this.exitMenuFunction.Size = new System.Drawing.Size(171, 22);
            this.exitMenuFunction.Text = "&Exit";
            this.exitMenuFunction.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutGameToolStripMenuItem});
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
            this.helpToolStripMenuItem.Text = "&Help";
            // 
            // aboutGameToolStripMenuItem
            // 
            this.aboutGameToolStripMenuItem.Name = "aboutGameToolStripMenuItem";
            this.aboutGameToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.aboutGameToolStripMenuItem.Text = "&About Game";
            this.aboutGameToolStripMenuItem.Click += new System.EventHandler(this.aboutGameToolStripMenuItem_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonOne.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.buttonOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOne.Location = new System.Drawing.Point(163, 77);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(82, 73);
            this.buttonOne.TabIndex = 1;
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonTwo.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTwo.Location = new System.Drawing.Point(236, 77);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(82, 73);
            this.buttonTwo.TabIndex = 1;
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonThree.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThree.Location = new System.Drawing.Point(311, 76);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(82, 73);
            this.buttonThree.TabIndex = 1;
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonFour.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFour.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFour.Location = new System.Drawing.Point(163, 149);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(82, 73);
            this.buttonFour.TabIndex = 1;
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonFive.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonFive.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFive.Location = new System.Drawing.Point(236, 149);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(82, 73);
            this.buttonFive.TabIndex = 1;
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonSix.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSix.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSix.Location = new System.Drawing.Point(311, 149);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(82, 73);
            this.buttonSix.TabIndex = 1;
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonSeven.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonSeven.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSeven.Location = new System.Drawing.Point(163, 222);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(82, 73);
            this.buttonSeven.TabIndex = 1;
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonEight.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonEight.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEight.Location = new System.Drawing.Point(236, 222);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(82, 73);
            this.buttonEight.TabIndex = 1;
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.Btn_click);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.PowderBlue;
            this.buttonNine.Font = new System.Drawing.Font("Forte", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.buttonNine.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNine.Location = new System.Drawing.Point(311, 222);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(82, 73);
            this.buttonNine.TabIndex = 1;
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.Btn_click);
            // 
            // lblcountdownTimer
            // 
            this.lblcountdownTimer.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblcountdownTimer.Location = new System.Drawing.Point(236, 24);
            this.lblcountdownTimer.Name = "lblcountdownTimer";
            this.lblcountdownTimer.Size = new System.Drawing.Size(73, 35);
            this.lblcountdownTimer.TabIndex = 4;
            this.lblcountdownTimer.Text = "00";
            this.lblcountdownTimer.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // startBtn
            // 
            this.startBtn.BackColor = System.Drawing.Color.LightGreen;
            this.startBtn.Location = new System.Drawing.Point(12, 126);
            this.startBtn.Name = "startBtn";
            this.startBtn.Size = new System.Drawing.Size(92, 42);
            this.startBtn.TabIndex = 8;
            this.startBtn.Text = "Start Game";
            this.startBtn.UseVisualStyleBackColor = false;
            this.startBtn.Click += new System.EventHandler(this.startBtn_Click);
            // 
            // GroupBoxGameSettings
            // 
            this.GroupBoxGameSettings.Controls.Add(this.GroupBoxForStartingPlayer);
            this.GroupBoxGameSettings.Controls.Add(this.groupBoxForXPlayer);
            this.GroupBoxGameSettings.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxGameSettings.Location = new System.Drawing.Point(399, 154);
            this.GroupBoxGameSettings.Name = "GroupBoxGameSettings";
            this.GroupBoxGameSettings.Size = new System.Drawing.Size(316, 142);
            this.GroupBoxGameSettings.TabIndex = 7;
            this.GroupBoxGameSettings.TabStop = false;
            this.GroupBoxGameSettings.Text = "Game Settings";
            // 
            // GroupBoxForStartingPlayer
            // 
            this.GroupBoxForStartingPlayer.Controls.Add(this.StartingPlayerTwoRadioBtn);
            this.GroupBoxForStartingPlayer.Controls.Add(this.StartingPlayerOneRadioBtn);
            this.GroupBoxForStartingPlayer.Location = new System.Drawing.Point(22, 75);
            this.GroupBoxForStartingPlayer.Name = "GroupBoxForStartingPlayer";
            this.GroupBoxForStartingPlayer.Size = new System.Drawing.Size(241, 58);
            this.GroupBoxForStartingPlayer.TabIndex = 2;
            this.GroupBoxForStartingPlayer.TabStop = false;
            this.GroupBoxForStartingPlayer.Text = "Starting Player";
            // 
            // StartingPlayerTwoRadioBtn
            // 
            this.StartingPlayerTwoRadioBtn.AutoSize = true;
            this.StartingPlayerTwoRadioBtn.Location = new System.Drawing.Point(117, 32);
            this.StartingPlayerTwoRadioBtn.Name = "StartingPlayerTwoRadioBtn";
            this.StartingPlayerTwoRadioBtn.Size = new System.Drawing.Size(82, 19);
            this.StartingPlayerTwoRadioBtn.TabIndex = 4;
            this.StartingPlayerTwoRadioBtn.Text = "Player Two";
            this.StartingPlayerTwoRadioBtn.UseVisualStyleBackColor = true;
            // 
            // StartingPlayerOneRadioBtn
            // 
            this.StartingPlayerOneRadioBtn.AutoSize = true;
            this.StartingPlayerOneRadioBtn.Checked = true;
            this.StartingPlayerOneRadioBtn.Location = new System.Drawing.Point(16, 33);
            this.StartingPlayerOneRadioBtn.Name = "StartingPlayerOneRadioBtn";
            this.StartingPlayerOneRadioBtn.Size = new System.Drawing.Size(82, 19);
            this.StartingPlayerOneRadioBtn.TabIndex = 3;
            this.StartingPlayerOneRadioBtn.TabStop = true;
            this.StartingPlayerOneRadioBtn.Text = "Player One";
            this.StartingPlayerOneRadioBtn.UseVisualStyleBackColor = true;
            // 
            // groupBoxForXPlayer
            // 
            this.groupBoxForXPlayer.Controls.Add(this.PlayerOneRadioBtnX);
            this.groupBoxForXPlayer.Controls.Add(this.PlayerTwoRadioBtnX);
            this.groupBoxForXPlayer.Location = new System.Drawing.Point(21, 22);
            this.groupBoxForXPlayer.Name = "groupBoxForXPlayer";
            this.groupBoxForXPlayer.Size = new System.Drawing.Size(240, 47);
            this.groupBoxForXPlayer.TabIndex = 5;
            this.groupBoxForXPlayer.TabStop = false;
            this.groupBoxForXPlayer.Text = "X for ";
            // 
            // PlayerOneRadioBtnX
            // 
            this.PlayerOneRadioBtnX.AutoSize = true;
            this.PlayerOneRadioBtnX.Checked = true;
            this.PlayerOneRadioBtnX.Location = new System.Drawing.Point(17, 22);
            this.PlayerOneRadioBtnX.Name = "PlayerOneRadioBtnX";
            this.PlayerOneRadioBtnX.Size = new System.Drawing.Size(82, 19);
            this.PlayerOneRadioBtnX.TabIndex = 0;
            this.PlayerOneRadioBtnX.TabStop = true;
            this.PlayerOneRadioBtnX.Text = "Player One";
            this.PlayerOneRadioBtnX.UseVisualStyleBackColor = true;
            // 
            // PlayerTwoRadioBtnX
            // 
            this.PlayerTwoRadioBtnX.AutoSize = true;
            this.PlayerTwoRadioBtnX.Location = new System.Drawing.Point(118, 22);
            this.PlayerTwoRadioBtnX.Name = "PlayerTwoRadioBtnX";
            this.PlayerTwoRadioBtnX.Size = new System.Drawing.Size(82, 19);
            this.PlayerTwoRadioBtnX.TabIndex = 1;
            this.PlayerTwoRadioBtnX.TabStop = true;
            this.PlayerTwoRadioBtnX.Text = "Player Two";
            this.PlayerTwoRadioBtnX.UseVisualStyleBackColor = true;
            // 
            // GroupBoxPlayerInfo
            // 
            this.GroupBoxPlayerInfo.Controls.Add(this.playerTwoNameTextBox);
            this.GroupBoxPlayerInfo.Controls.Add(this.playerOneNameTextBox);
            this.GroupBoxPlayerInfo.Controls.Add(this.PlayerTwoLabel);
            this.GroupBoxPlayerInfo.Controls.Add(this.playerOneLabel);
            this.GroupBoxPlayerInfo.Font = new System.Drawing.Font("Segoe UI Semibold", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.GroupBoxPlayerInfo.Location = new System.Drawing.Point(399, 48);
            this.GroupBoxPlayerInfo.Name = "GroupBoxPlayerInfo";
            this.GroupBoxPlayerInfo.Size = new System.Drawing.Size(316, 100);
            this.GroupBoxPlayerInfo.TabIndex = 6;
            this.GroupBoxPlayerInfo.TabStop = false;
            this.GroupBoxPlayerInfo.Text = "Players Information";
            // 
            // playerTwoNameTextBox
            // 
            this.playerTwoNameTextBox.Location = new System.Drawing.Point(126, 58);
            this.playerTwoNameTextBox.Name = "playerTwoNameTextBox";
            this.playerTwoNameTextBox.Size = new System.Drawing.Size(135, 23);
            this.playerTwoNameTextBox.TabIndex = 1;
            // 
            // playerOneNameTextBox
            // 
            this.playerOneNameTextBox.Location = new System.Drawing.Point(126, 29);
            this.playerOneNameTextBox.Name = "playerOneNameTextBox";
            this.playerOneNameTextBox.Size = new System.Drawing.Size(135, 23);
            this.playerOneNameTextBox.TabIndex = 1;
            // 
            // PlayerTwoLabel
            // 
            this.PlayerTwoLabel.AutoSize = true;
            this.PlayerTwoLabel.Location = new System.Drawing.Point(21, 61);
            this.PlayerTwoLabel.Name = "PlayerTwoLabel";
            this.PlayerTwoLabel.Size = new System.Drawing.Size(99, 15);
            this.PlayerTwoLabel.TabIndex = 0;
            this.PlayerTwoLabel.Text = "Player Two Name";
            // 
            // playerOneLabel
            // 
            this.playerOneLabel.AutoSize = true;
            this.playerOneLabel.Location = new System.Drawing.Point(21, 31);
            this.playerOneLabel.Name = "playerOneLabel";
            this.playerOneLabel.Size = new System.Drawing.Size(99, 15);
            this.playerOneLabel.TabIndex = 0;
            this.playerOneLabel.Text = "Player One Name";
            // 
            // CountDownTimer
            // 
            this.CountDownTimer.Interval = 1000;
            this.CountDownTimer.Tick += new System.EventHandler(this.CountdownTimer_Func);
            // 
            // lblPlayerOneWins
            // 
            this.lblPlayerOneWins.AutoSize = true;
            this.lblPlayerOneWins.Location = new System.Drawing.Point(20, 194);
            this.lblPlayerOneWins.Name = "lblPlayerOneWins";
            this.lblPlayerOneWins.Size = new System.Drawing.Size(93, 15);
            this.lblPlayerOneWins.TabIndex = 9;
            this.lblPlayerOneWins.Text = "Player One Wins";
            // 
            // lblPlayerTwoWins
            // 
            this.lblPlayerTwoWins.AutoSize = true;
            this.lblPlayerTwoWins.Location = new System.Drawing.Point(16, 254);
            this.lblPlayerTwoWins.Name = "lblPlayerTwoWins";
            this.lblPlayerTwoWins.Size = new System.Drawing.Size(92, 15);
            this.lblPlayerTwoWins.TabIndex = 10;
            this.lblPlayerTwoWins.Text = "Player Two Wins";
            // 
            // PlayerVPlayerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.ClientSize = new System.Drawing.Size(749, 322);
            this.Controls.Add(this.lblPlayerTwoWins);
            this.Controls.Add(this.lblPlayerOneWins);
            this.Controls.Add(this.startBtn);
            this.Controls.Add(this.GroupBoxGameSettings);
            this.Controls.Add(this.GroupBoxPlayerInfo);
            this.Controls.Add(this.lblcountdownTimer);
            this.Controls.Add(this.buttonNine);
            this.Controls.Add(this.buttonSix);
            this.Controls.Add(this.buttonThree);
            this.Controls.Add(this.buttonEight);
            this.Controls.Add(this.buttonFive);
            this.Controls.Add(this.buttonTwo);
            this.Controls.Add(this.buttonSeven);
            this.Controls.Add(this.buttonFour);
            this.Controls.Add(this.buttonOne);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "PlayerVPlayerForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Tic Tac Toe";
            this.Load += new System.EventHandler(this.TicTacToe_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.GroupBoxGameSettings.ResumeLayout(false);
            this.GroupBoxForStartingPlayer.ResumeLayout(false);
            this.GroupBoxForStartingPlayer.PerformLayout();
            this.groupBoxForXPlayer.ResumeLayout(false);
            this.groupBoxForXPlayer.PerformLayout();
            this.GroupBoxPlayerInfo.ResumeLayout(false);
            this.GroupBoxPlayerInfo.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameMenuFunction;
        private System.Windows.Forms.ToolStripMenuItem resetMenuFunction;
        private System.Windows.Forms.ToolStripMenuItem exitMenuFunction;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutGameToolStripMenuItem;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Label lblcountdownTimer;
        private System.Windows.Forms.Button startBtn;
        private System.Windows.Forms.GroupBox GroupBoxGameSettings;
        private System.Windows.Forms.GroupBox GroupBoxForStartingPlayer;
        private System.Windows.Forms.RadioButton StartingPlayerTwoRadioBtn;
        private System.Windows.Forms.RadioButton StartingPlayerOneRadioBtn;
        private System.Windows.Forms.GroupBox groupBoxForXPlayer;
        private System.Windows.Forms.RadioButton PlayerOneRadioBtnX;
        private System.Windows.Forms.RadioButton PlayerTwoRadioBtnX;
        private System.Windows.Forms.GroupBox GroupBoxPlayerInfo;
        private System.Windows.Forms.TextBox playerTwoNameTextBox;
        private System.Windows.Forms.TextBox playerOneNameTextBox;
        private System.Windows.Forms.Label PlayerTwoLabel;
        private System.Windows.Forms.Label playerOneLabel;
        private System.Windows.Forms.Timer CountDownTimer;
        private System.Windows.Forms.Label lblPlayerOneWins;
        private System.Windows.Forms.Label lblPlayerTwoWins;
    }
}

