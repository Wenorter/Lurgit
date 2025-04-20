using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; //this one is used to count ckeckboxes.
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO; // for extracting user scores into a textfile.


namespace LurgitGame
{// Assessment for INFT2012
 // Started on 22.08.2018 in process of beeing written.
 // The Lurgit Game
 // Written by Kira Khristosova and David Roberts.
 // This program was written to be able to play the dice game called "Lurgit".

    public partial class frmLurgitMainForm : Form
    {

        #region Initializators and Constructors
        Graphics graPaperDiceOne, graPaperDiceTwo, graPaperDiceThree;
        int iRandDiceOne, iRandDiceTwo, iRandDiceThree, iRoundnum, iRollCount, iScoreP1, iRoundScoreP1, iScoreP2, iRoundScoreP2, iCpuRisk, iRandNum;
        bool bCpuTurn, bP2Turn;
        int[] aryDiceRolls = new int[3];
        Random RollDice = new Random();

        
        public frmLurgitMainForm()
        {
            InitializeComponent();
            graPaperDiceOne = picBxDiceOne.CreateGraphics();
            graPaperDiceTwo = picBxDiceTwo.CreateGraphics();
            graPaperDiceThree = picBxDiceThree.CreateGraphics();

        }
        #endregion

        #region Methods for Dice Patterns
        //--------- MAIN DICE DOT METHOD ---------
        private void DiceDot(Graphics graPaper, int iAcross, int iDown, int iSize)
        {
            graPaper.FillEllipse(new SolidBrush(Color.Black), iAcross, iDown, iSize, iSize);
        }
        //----------------------------------------

        private void OneDot(Graphics graPaper)
        {
            DiceDot(graPaper, 47, 47, 20);
        }

        private void TwoDot(Graphics graPaper)
        {
            DiceDot(graPaper, 15, 80, 20);
            DiceDot(graPaper, 80, 15, 20);
        }

        private void ThreeDot(Graphics graPaper)
        {
            DiceDot(graPaper, 15, 80, 20);
            DiceDot(graPaper, 47, 47, 20);
            DiceDot(graPaper, 80, 15, 20);
        }

        private void FourDot(Graphics graPaper)
        {
            DiceDot(graPaper, 15, 15, 20);
            DiceDot(graPaper, 15, 80, 20);
            DiceDot(graPaper, 80, 15, 20);
            DiceDot(graPaper, 80, 80, 20);
        }

        private void FiveDot(Graphics graPaper)
        {
            DiceDot(graPaper, 15, 15, 20);
            DiceDot(graPaper, 15, 80, 20);
            DiceDot(graPaper, 47, 47, 20);
            DiceDot(graPaper, 80, 15, 20);
            DiceDot(graPaper, 80, 80, 20);
        }

        private void SixDot(Graphics graPaper)
        {
            DiceDot(graPaper, 15, 15, 20);
            DiceDot(graPaper, 15, 47, 20);
            DiceDot(graPaper, 15, 80, 20);
            DiceDot(graPaper, 80, 15, 20);
            DiceDot(graPaper, 80, 47, 20);
            DiceDot(graPaper, 80, 80, 20);
        }

        #endregion // taken from Week4Notes Dice throw exercise.

        #region Methods for Dice Logic
        private void DiceRandPattern(int iRandPattern, Graphics graPaper, Label lblDiceScore) //need possibly come up with another name for this method.
        {

            lblDiceScore.Text = "The Die Score Is " + Convert.ToString(iRandPattern);
            System.Threading.Thread.Sleep(200);

            if (iRandPattern == 1)
            {
                OneDot(graPaper);
            }

            else if (iRandPattern == 2)
            {
                TwoDot(graPaper);
            }

            else if (iRandPattern == 3)
            {
                ThreeDot(graPaper);
            }

            else if (iRandPattern == 4)
            {
                FourDot(graPaper);
            }

            else if (iRandPattern == 5)
            {
                FiveDot(graPaper);
            }

            else if (iRandPattern == 6)
            {
                SixDot(graPaper);
            }

        }

        #endregion

        #region Form Color Picker and Quit Button
        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLurgitRules LurgitRules = new frmLurgitRules();
            LurgitRules.ShowDialog();
        }

        private void changeColorInterfaceToolStripMenuItem_Click(object sender, EventArgs e)
        {

            ColorDialog colorPicker = new ColorDialog();
            if (colorPicker.ShowDialog() == DialogResult.OK)
            {
                this.BackColor = colorPicker.Color;
                txtBxLurgitStatus.BackColor = colorPicker.Color;
                grpBxDice.BackColor = colorPicker.Color;
                grpBxUserScores.BackColor = colorPicker.Color;
            }
        }
        #endregion //changed name, David

        #region Start Button
        private void btnStart_Click(object sender, EventArgs e)
        {
            lblP1Name.Visible = true;
            lbP1Score.Visible = true;

            //-------GAME MODE FORM APPEARS------------
            frmLurgitGameMode LurgitGameMode = new frmLurgitGameMode();
            LurgitGameMode.ShowDialog();
            //-----------------------------------------

            //-------INPUT BOX FORM APPEARS------------
            LurgitInputBox frmCollectorPlayerOne = new LurgitInputBox("Enter Player One Name", "First Player");
            frmCollectorPlayerOne.ShowDialog();
            string sP1Name = frmCollectorPlayerOne.sInputValue;
            lblP1Name.Text = string.Format(sP1Name);
            if (sP1Name == "") //if the name haven't been chosen or user clicked 'Cancel' button on the Input Box, because I don't want the label to be blank
            {
                sP1Name = "Player One"; //the reason I put string here is to be able to display it in the messagebox where it would ask you to pick colour of your team.
                lblP1Name.Text = sP1Name;
            }

            MessageBox.Show(sP1Name + ", pick the colour of your team (if you wish). If you decide not to choose any colour your team colour would be automatically set to colour of this form.", "Player " + sP1Name + ", Choose Your Team Colour!");
            //-----------------------------------------

            //-------TEAM COLOUR PICKER APPEARS--------
            ColorDialog teamColorPickerPlayerOne = new ColorDialog();
            if (teamColorPickerPlayerOne.ShowDialog() == DialogResult.OK)
            {
                lblP1Name.BackColor = teamColorPickerPlayerOne.Color;
            }
            //-----------------------------------------

            //-----IF MULTIPLAYER MODE WAS ENABLED-----
            if (frmLurgitGameMode.iMultiplayerEnabled == 1) //This happens only when Multiplayer Mode is Enabled.
            {   
                //MAKES LABELS FOR PLAYER TWO VISIBLE

                lblP2Name.Visible = true;
                lbP2Score.Visible = true;

                //INPUT BOX FOR SECOND PLAYER

                LurgitInputBox frmCollectorPlayerTwo = new LurgitInputBox("Enter Player Two Name", "Second Player");
                frmCollectorPlayerTwo.ShowDialog();

                string sP2Name = frmCollectorPlayerTwo.sInputValue;
                lblP2Name.Text = string.Format(sP2Name);

                if (sP2Name == "") //if second player didn't choose the name
                {
                    sP2Name = "Player Two";
                    lblP2Name.Text = sP2Name;
                }

                MessageBox.Show(sP2Name + ", pick the colour of your team. Same as for " + sP1Name + " if you decide not to choose the colour - it would be colour of this form :)", "Player " + sP2Name + ", Choose Your Team Colour!");

                ColorDialog teamColorPickerPlayerTwo = new ColorDialog();
                if (teamColorPickerPlayerTwo.ShowDialog() == DialogResult.OK)
                {
                    lblP2Name.BackColor = teamColorPickerPlayerTwo.Color;
                }
            }

            //-----------------------------------------
            //-----IF AGAINST AI MODE WAS ENABLED------

            if (frmLurgitGameMode.iCPUEnabled == 1)
            {
                lblP2Name.Visible = true;
                lbP2Score.Visible = true;
                lblP2Name.Text = "Computer";
            }

            txtBxLurgitStatus.Text = "The Game Starts!";

            btnEndGame.Visible = true;
            btnEndGame.Enabled = true;
            strpNewGame.Enabled = false;
            grpBxDice.Visible = true;
            btnRoll.Visible = true;
            btnRoll.Enabled = true; //i'm not sure of invisible button is un-enabled or enabled, so I would rather make sure that invisible buttons are not enabled, untill they are visible.
            btnStart.Visible = true;
            grpBxUserScores.Visible = true;
            btnEndTurn.Visible = true;
            btnEndTurn.Enabled = true;
            btnStart.Visible = false;
            btnStart.Enabled = false;
        }
        #endregion

        #region Dice Roll Logic and Score Logic

        private void AboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            frmLurgitAboutBox LurgitAboutBox = new frmLurgitAboutBox();
            LurgitAboutBox.ShowDialog();
        }

        private void btnRoll_Click(object sender, EventArgs e)
        {
            lblBonusStatus.Visible = false; //makes label with Bonus Status Invisible if there was any bonus;
            RollandRound();
            DiceNoHoldClear();

            //basic singleplayer structure determined by rollcount.
            if (iRollCount == 1)
            {
                bCpuTurn = false;
                bP2Turn = false;
                FirstRoll();
                EnableHoldDie();
                
            }

            if (iRollCount == 2)
            {
                DiceHoldnRoll();
                EnableHoldDie();
               
            }

            if (iRollCount == 3)
            {
                DiceHoldnRoll();
                EnableHoldDie();
                
            }

            tmrTurnFlash.Start(); //this is a timer to make red 'player turn' labels to flash.
            //CheckBoxCkeck(); //checks the amount of "Hold" checkboxes. If there is more then 2 checked displays error message.
            ScoreCalculate();
            ScoreCard();
            Multiplayer();
            ComputersTurn();
            LurgitBonus(); // checks if there was a 'Lurgit' Bonus and adds + 20 points to the player's score.
            SequenceBonus(); // checks if there was a Sequence Bonus and adds + 10 points to the player's score.
            

        }
        
        public void RollandRound()     //responsible for starting new rounds, managing roll count and starting the game off.
        {
            if (iRoundnum == 0)         //kicks off the game by assigning a round number and roll count
            {
                iRoundnum = 1;
                iRollCount = 0;
            }

            if (iRollCount == 3)        //starts new round
            {
                iRoundnum = iRoundnum + 1;
                iRollCount = 0;

                if (iRoundnum == 7)
                {
                    MessageBox.Show("Congratulations, " + lblP1Name.Text + " you have scored " + Convert.ToString(iScoreP1) + " altogether in all rounds. Finishing the game.", "The End of Game! " + lblP1Name.Text + " you have scored: " + Convert.ToString(iScoreP1));
                    
                    if (MessageBox.Show("Do you want to save your scores as a text document?","Saving the game scores", MessageBoxButtons.YesNo) == DialogResult.Yes)
                    {
                        if (saveFileDialog.ShowDialog() == DialogResult.OK)
                        {
                            string sFileName = saveFileDialog.FileName;

                            try
                            {
                                StreamWriter swOutStream = new StreamWriter(sFileName);
                                swOutStream.Write(txtBxUserScores.Text);  // writes textfile as a string
                                swOutStream.Flush(); // this is a writing buffer, if the buffer crushes in process it would be able to transfer part that was in the buffer.
                                swOutStream.Close(); // closes file when it finished 
                                MessageBox.Show(sFileName + " saved.", "The Lurgit Game: User Scores Saved");
                            }

                            catch (IOException ioe)  // For exceptions errors
                            {       
                                MessageBox.Show(ioe.Message, "File error");
                            }
                        }
                    }

                    Application.Exit();
                }
            
            }

            //handles the labels, and ensures they update when changed.
            iRollCount = iRollCount + 1;
            lbRoundCount.Text = "Round " + Convert.ToString(iRoundnum);
            lbRollCount.Text = "Roll " + Convert.ToString(iRollCount);
            lbRollCount.Refresh();
            lbRoundCount.Refresh();
        }
        public void FirstRoll()         //for the first round to ensure values are assigned to die.
        {
            lblDiceOne.Enabled = false;
            lblDiceTwo.Enabled = false;
            lblDiceThree.Enabled = false;

            iRandDiceOne = RollDice.Next(1, 7);
            DiceRandPattern(iRandDiceOne, graPaperDiceOne, lblDiceOne);
            lblDiceOne.Enabled = true;

            iRandDiceTwo = RollDice.Next(1, 7);
            DiceRandPattern(iRandDiceTwo, graPaperDiceTwo, lblDiceTwo);
            lblDiceTwo.Enabled = true;

            iRandDiceThree = RollDice.Next(1, 7);
            DiceRandPattern(iRandDiceThree, graPaperDiceThree, lblDiceThree);
            lblDiceThree.Enabled = true;

            aryDiceRolls[0] = iRandDiceOne;
            aryDiceRolls[1] = iRandDiceTwo;
            aryDiceRolls[2] = iRandDiceThree;
        }
        public void DiceHoldnRoll()     //holding dice functionality.
        {
            //These if statments add functionality to the hold dice buttons and ensure dice being held are not updated.

            lblDiceOne.Enabled = false;
            lblDiceTwo.Enabled = false;
            lblDiceThree.Enabled = false;

            if (chkHoldDiceOne.Checked == false)
            {                                   
                iRandDiceOne = RollDice.Next(1, 7);                             //assigns the random value to the die
                DiceRandPattern(iRandDiceOne, graPaperDiceOne, lblDiceOne);     //draws the die value onto the picturebox
                lblDiceOne.Enabled = true;                                      //reenables the label with the updated value.
            }

            if (chkHoldDiceTwo.Checked == false)
            {
                iRandDiceTwo = RollDice.Next(1, 7);
                DiceRandPattern(iRandDiceTwo, graPaperDiceTwo, lblDiceTwo);
                lblDiceTwo.Enabled = true;
            }

            if (chkHoldDiceThree.Checked == false)
            {
                iRandDiceThree = RollDice.Next(1, 7);
                DiceRandPattern(iRandDiceThree, graPaperDiceThree, lblDiceThree);
                lblDiceThree.Enabled = true;
            }

            aryDiceRolls[0] = iRandDiceOne;
            aryDiceRolls[1] = iRandDiceTwo;
            aryDiceRolls[2] = iRandDiceThree;
        }

        private void tmrTurnFlash_Tick(object sender, EventArgs e) //timer for flashing red "player turn" labels. I thought it would attract player's attention to it.
        {
            

            if (bP2Turn && iRollCount == 3) //this is meant to work for multiplayer only.
            {
                lblP2Turn.Visible = !lblP2Turn.Visible;
                lblP1Turn.Visible = false;       
            }         
            
            else if(bCpuTurn == false ||bP2Turn == false)
            {
                lblP2Turn.Visible = false;
                lblP1Turn.Visible = !lblP1Turn.Visible;
            }
        }

        public void EnableHoldDie()     //re-enables the dice hold buttons after roll, and stops holding the dice on the third roll.
        {
            // It is important that buttons are re-enabled with each roll, since the player wouln't be able to hold them otherwise.
            chkHoldDiceOne.Enabled = true;
            chkHoldDiceTwo.Enabled = true;
            chkHoldDiceThree.Enabled = true;

            chkHoldDiceOne.Checked = false;
            chkHoldDiceTwo.Checked = false;
            chkHoldDiceThree.Checked = false;

            // Stops the player from holding die on the third roll since score is added
            if (iRollCount == 3)
            {
                chkHoldDiceOne.Enabled = false;
                chkHoldDiceTwo.Enabled = false;
                chkHoldDiceThree.Enabled = false;
            }
        }
        public void DiceNoHoldClear()   //clears all die that are not being held and disables checkboxes during roll.
        {
            chkHoldDiceOne.Enabled = false;
            chkHoldDiceTwo.Enabled = false;
            chkHoldDiceThree.Enabled = false;

            if (chkHoldDiceOne.Checked == false)
            {
                graPaperDiceOne.Clear(Color.White);
            }

            if (chkHoldDiceTwo.Checked == false)
            {
                graPaperDiceTwo.Clear(Color.White);
            }

            if (chkHoldDiceThree.Checked == false)
            {
                graPaperDiceThree.Clear(Color.White);
            }
        }


        public void ScoreCard()         //responsible for managing the score card
        {
            //Week 5 Two Integer textboxes exercise. Shows previous rolls in text box
            if (bCpuTurn || bP2Turn)
            {
                txtBxUserScores.AppendText(String.Format("\t{0:d}, {1:d}, {2:d} \r\n", iRandDiceOne, iRandDiceTwo, iRandDiceThree)); // \t puts the scores on the other side of the user scores.
            }
            else
            {
                txtBxUserScores.AppendText(String.Format("{0:d}, {1:d}, {2:d} \r\n", iRandDiceOne, iRandDiceTwo, iRandDiceThree));
            }

        }
        public void ScoreCalculate()    //checks for Lurgit and Sequence Bonuses, along with adding score.
        {
            //uses an array to store die rolls and check if they match iRoundnum

            if (iRollCount == 3 && bCpuTurn == false || iRollCount == 3 && bP2Turn == false)
            {
                foreach (int iDie in aryDiceRolls)
                {
                    if (iDie == iRoundnum)
                    {
                        iRoundScoreP1 = iRoundScoreP1 + iRoundnum;
                    }
                }

                iScoreP1 = iScoreP1 + iRoundScoreP1;
                lbP1Score.Text = "P1 Score = " + iScoreP1;
                lbP1Score.Refresh();
                iRoundScoreP1 = 0;
            }

            if (iRollCount == 3 && bCpuTurn || iRollCount == 3 && bP2Turn)
            {
                foreach (int iDie in aryDiceRolls)
                {
                    if (iDie == iRoundnum)
                    {
                        iRoundScoreP2 = iRoundScoreP2 + iRoundnum;
                    }
                }

                iScoreP2 = iScoreP2 + iRoundScoreP2;
                lbP2Score.Text = "P2 Score = " + iScoreP2;
                lbP2Score.Refresh();
                iRoundScoreP2 = 0;
            }
        }
        #endregion

        #region Bonuses
        private void LurgitBonus()
        {
            if (iRandDiceOne == iRandDiceTwo && iRandDiceTwo == iRandDiceThree) //there is no reason to add && iRandDiceThree == iRandDiceOne, because this expression already tells that all three values should be equal.
            {
               lblBonusStatus.Visible = true;
               lblBonusStatus.Text = "Lurgit Bonus! + 20 Points!";

                ScoreCalculate();
                iScoreP1 = iScoreP1 + 20;
            }
        }

        private void SequenceBonus()
        {
            if (iRandDiceOne == 1 && iRandDiceTwo == 2 && iRandDiceThree == 3)
            {
                lblBonusStatus.Visible = true;
                lblBonusStatus.Text = "Sequence Bonus! + 10 Points!";

                ScoreCalculate();
                iScoreP1 = iScoreP1 + 10;
            }

            else if (iRandDiceOne == 2 && iRandDiceTwo == 3 && iRandDiceThree == 4)
            {
                lblBonusStatus.Visible = true;
                lblBonusStatus.Text = "Sequence Bonus! + 10 Points!";

                ScoreCalculate();
                iScoreP1 = iScoreP1 + 10;
            }


            else if (iRandDiceOne == 3 && iRandDiceTwo == 4 && iRandDiceThree == 5)
            {
                lblBonusStatus.Visible = true;
                lblBonusStatus.Text = "Sequence Bonus! + 10 Points!";

                ScoreCalculate();
                iScoreP1 = iScoreP1 + 10;
            }

            else if (iRandDiceOne == 4 && iRandDiceTwo == 5 && iRandDiceThree == 6)
            {
                lblBonusStatus.Visible = true;
                lblBonusStatus.Text = "Sequence Bonus! + 10 Points!";

                ScoreCalculate();
                iScoreP1 = iScoreP1 + 10;
            }
        }
        #endregion

        public void CheckBoxCkeck()
        {
            int counter = 0;
            foreach (Control chckBx in this.Controls)
            { 

            if (chckBx is CheckBox)
                { 
                    if (((CheckBox)chckBx).Checked)
                    {
                        counter++;
                    }
                }

            MessageBox.Show(counter.ToString());
            }
            if (counter >= 3)
                {
                    MessageBox.Show("You can't hold more than two dice","Error");
                }
            }

        #region Multiplayer
        public void Multiplayer() //basic structure of player two's turn.
        {
            if (frmLurgitGameMode.iMultiplayerEnabled == 1 && iRollCount == 3)
            {
                //iRollCount = 0;
                //lbRollCount.Text = "Roll " + Convert.ToString(iRollCount);
                bP2Turn = true;
            }
        }
        #endregion

        #region Computer Player
        public void ComputersTurn()     //the basic structure for the computers turn.
        {
            if (frmLurgitGameMode.iCPUEnabled == 1 && iRollCount == 3)
            {
                bCpuTurn = true;
                btnRoll.Enabled = false;
                lblP2Turn.Visible = true;

                
                System.Threading.Thread.Sleep(1200); //delay between turns should be changed
                iRollCount = 0;
                lbRollCount.Text = "Roll " + Convert.ToString(iRollCount);
                lbRollCount.Refresh();

                //Disables the hold dice checkboxes to make it feel like even ground.
                chkHoldDiceOne.Enabled = false;
                chkHoldDiceTwo.Enabled = false;
                chkHoldDiceThree.Enabled = false;

                //Cpu first turn
                RollandRound();
                DiceNoHoldClear();
                FirstRoll();
                EnableHoldDie();
                ScoreCard();
                System.Threading.Thread.Sleep(900);

                //Cpu second turn
                ComputerRNG();
                RollandRound();
                DiceNoHoldClear();
                DiceHoldnRoll();
                EnableHoldDie();
                ScoreCard();
                System.Threading.Thread.Sleep(900);

                //Cpu third turn
                ComputerRNG();
                RollandRound();
                DiceNoHoldClear();
                DiceHoldnRoll();
                EnableHoldDie();
                ScoreCard();
                ScoreCalculate();
                System.Threading.Thread.Sleep(900);

                //Comuter Player End
                bCpuTurn = false;
                btnRoll.Enabled = true;
                lblP2Turn.Visible = false;
            }
        }
        public void ComputerRNG()       //adds some unpredicatability and the ability to hold dice to the computer.
        {
            iRandNum = RollDice.Next(1, 4);

            if (iRandDiceOne == iRoundnum)
            {
                chkHoldDiceOne.Checked = true;
                iCpuRisk = iCpuRisk + 1;

            }

            if (iRandDiceTwo == iRoundnum)
            {
                chkHoldDiceTwo.Checked = true;
                iCpuRisk = iCpuRisk + 1;
            }

            if (iRandDiceThree == iRoundnum)
            {
                chkHoldDiceThree.Checked = true;
                iCpuRisk = iCpuRisk + 1;
            }

            if (iCpuRisk < 2 && iRandNum == 1 && iRoundnum <= 4)
            {
                chkHoldDiceThree.Checked = false;
                chkHoldDiceThree.Checked = false;
                chkHoldDiceThree.Checked = false;
            }
        }
        #endregion

        #region New game, End game, Single Player
        private void singlePlayerToolStripMenuItem_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void strpNewGame_Click(object sender, EventArgs e)
        {
            btnStart_Click(sender, e);
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            //this clears all the controls and returns the form to it's original state.
            this.Controls.Clear();
            this.InitializeComponent();


            //they need to be there because the dice visuals won't work if you reset the game.
            graPaperDiceOne = picBxDiceOne.CreateGraphics();
            graPaperDiceTwo = picBxDiceTwo.CreateGraphics();
            graPaperDiceThree = picBxDiceThree.CreateGraphics();

            //this clears all the data from the previous gameplay: results from the user score textbox, number of rounds, number of rolls, player points per round, player names and dice scores.

            txtBxUserScores.Text = "";
            lblBonusStatus.Text = "";
            lblP1Turn.Text = "";
            lblP2Turn.Text = "";
            lblP1Name.Text = "";
            lblP2Name.Text = "";
            iRandDiceOne = 0;
            iRandDiceTwo = 0;
            iRandDiceThree = 0;
            iRoundnum = 0;
            iRollCount = 0;
            iRoundScoreP1 = 0;
            iRoundScoreP2 = 0;
            iScoreP1 = 0;
            iScoreP2 = 0;
            

        }
        #endregion

    }// end class
}//end namespace
