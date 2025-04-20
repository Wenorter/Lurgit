namespace LurgitGame
{
    partial class frmLurgitGameMode
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLurgitGameMode));
            this.lblGameMode = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblMultiPlayer = new System.Windows.Forms.Label();
            this.btnMultiPlayer = new System.Windows.Forms.Button();
            this.btnAgainstAI = new System.Windows.Forms.Button();
            this.btnSinglePlayer = new System.Windows.Forms.Button();
            this.lblHint = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblGameMode
            // 
            this.lblGameMode.AutoSize = true;
            this.lblGameMode.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblGameMode.Location = new System.Drawing.Point(209, 34);
            this.lblGameMode.Name = "lblGameMode";
            this.lblGameMode.Size = new System.Drawing.Size(302, 17);
            this.lblGameMode.TabIndex = 16;
            this.lblGameMode.Text = "Please, select the preffered game mode!";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(75, 182);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(146, 15);
            this.label2.TabIndex = 15;
            this.label2.Text = "Simple One Player Game";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(508, 182);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(184, 15);
            this.label1.TabIndex = 14;
            this.label1.Text = "Test your skills against computer";
            // 
            // lblMultiPlayer
            // 
            this.lblMultiPlayer.AutoSize = true;
            this.lblMultiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblMultiPlayer.Location = new System.Drawing.Point(312, 182);
            this.lblMultiPlayer.Name = "lblMultiPlayer";
            this.lblMultiPlayer.Size = new System.Drawing.Size(104, 15);
            this.lblMultiPlayer.TabIndex = 13;
            this.lblMultiPlayer.Text = "Two Player Game";
            // 
            // btnMultiPlayer
            // 
            this.btnMultiPlayer.BackColor = System.Drawing.SystemColors.Control;
            this.btnMultiPlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnMultiPlayer.Location = new System.Drawing.Point(310, 103);
            this.btnMultiPlayer.Name = "btnMultiPlayer";
            this.btnMultiPlayer.Size = new System.Drawing.Size(106, 43);
            this.btnMultiPlayer.TabIndex = 17;
            this.btnMultiPlayer.Text = "Multiplayer";
            this.btnMultiPlayer.UseVisualStyleBackColor = false;
            this.btnMultiPlayer.Click += new System.EventHandler(this.btnMultiPlayer_Click);
            // 
            // btnAgainstAI
            // 
            this.btnAgainstAI.BackColor = System.Drawing.SystemColors.Control;
            this.btnAgainstAI.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnAgainstAI.Location = new System.Drawing.Point(544, 103);
            this.btnAgainstAI.Name = "btnAgainstAI";
            this.btnAgainstAI.Size = new System.Drawing.Size(106, 43);
            this.btnAgainstAI.TabIndex = 18;
            this.btnAgainstAI.Text = "Against AI";
            this.btnAgainstAI.UseVisualStyleBackColor = false;
            this.btnAgainstAI.Click += new System.EventHandler(this.btnAgainstAI_Click);
            // 
            // btnSinglePlayer
            // 
            this.btnSinglePlayer.BackColor = System.Drawing.SystemColors.Control;
            this.btnSinglePlayer.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnSinglePlayer.Location = new System.Drawing.Point(100, 103);
            this.btnSinglePlayer.Name = "btnSinglePlayer";
            this.btnSinglePlayer.Size = new System.Drawing.Size(106, 43);
            this.btnSinglePlayer.TabIndex = 19;
            this.btnSinglePlayer.Text = "Single Player";
            this.btnSinglePlayer.UseVisualStyleBackColor = false;
            this.btnSinglePlayer.Click += new System.EventHandler(this.btnSinglePlayer_Click);
            // 
            // lblHint
            // 
            this.lblHint.AutoSize = true;
            this.lblHint.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblHint.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lblHint.Location = new System.Drawing.Point(75, 246);
            this.lblHint.Name = "lblHint";
            this.lblHint.Size = new System.Drawing.Size(597, 13);
            this.lblHint.TabIndex = 20;
            this.lblHint.Text = "Hint: If this form is closed and ignored, without selecting the game mode will au" +
    "tomatically set the game mode to Single Player.";
            // 
            // frmLurgitGameMode
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(733, 269);
            this.Controls.Add(this.lblHint);
            this.Controls.Add(this.btnSinglePlayer);
            this.Controls.Add(this.btnAgainstAI);
            this.Controls.Add(this.btnMultiPlayer);
            this.Controls.Add(this.lblGameMode);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lblMultiPlayer);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLurgitGameMode";
            this.Text = "The Lurgit Game";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblGameMode;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lblMultiPlayer;
        private System.Windows.Forms.Button btnMultiPlayer;
        private System.Windows.Forms.Button btnAgainstAI;
        private System.Windows.Forms.Button btnSinglePlayer;
        private System.Windows.Forms.Label lblHint;
    }
}