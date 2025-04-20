using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace LurgitGame
{// Assessment for INFT2012
 // Started on 22.08.2018 in process of beeing written.
 // The Lurgit Game Mode
 // Written by Kira Khristosova and David Roberts.
 // This is the form which allows to select the game mode of the Lurgit Game.
    public partial class frmLurgitGameMode : Form
    {
        public static int iSinglePlayerEnabled;
        public static int iMultiplayerEnabled;
        public static int iCPUEnabled;

        public frmLurgitGameMode()
        {
            InitializeComponent();
        }

        private void btnSinglePlayer_Click(object sender, EventArgs e)
        {
            // here should be an assigned value to set game to Single Player
            iSinglePlayerEnabled = 1;
            this.Dispose();
        }

        private void btnMultiPlayer_Click(object sender, EventArgs e)
        {
            // here should be a value to set game mode to Multiplayer
            iMultiplayerEnabled = 1;
            this.Dispose();
        }

        private void btnAgainstAI_Click(object sender, EventArgs e)
        {
            // here should be a value set to game mode to Against AI
            iCPUEnabled = 1;
            this.Dispose();
        }
    }
}
