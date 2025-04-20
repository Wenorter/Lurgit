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
  // The Lurgit Game
  // Written by Kira Khristosova and David Roberts.
  // This is the input box for the dice game called "Lurgit". It takes the player names and puts them on the form.
    public partial class LurgitInputBox : Form
    {
        public LurgitInputBox(string sPrompt, string sTitle)
        {
            InitializeComponent();
            Text = sTitle;
            lblPrompt.Text = sPrompt;
        }// end of additional constructor

        public string sInputValue
        {   // The InputValue property sets or gets the text in the text box
            // Properties will be covered in detail in the lecture on defining classes
            // Briefly, get is executed when an outside method uses sInputValue in an expression,
            get { return txBxInput.Text; }
            // and set is executed when an outside method assigns to sInputValue
            set { txBxInput.Text = value; }
        } // end of sInputValue property
    }//end class
}//end namespace
