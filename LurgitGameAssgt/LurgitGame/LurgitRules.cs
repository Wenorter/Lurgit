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
{ // Assessment for INFT2012
  // Started on 22.08.2018 in process of beeing written.
  // The Lurgit Game Rules
  // Written by Kira Khristosova and David Roberts.
  // This form is a set of rules to the game called "Lurgit".
    public partial class frmLurgitRules : Form
    {
        public frmLurgitRules()
        {
            InitializeComponent();
        }

        private void btnEndGame_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }
    }//end class
}//end namespace
