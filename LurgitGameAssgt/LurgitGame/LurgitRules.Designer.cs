namespace LurgitGame
{
    partial class frmLurgitRules
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLurgitRules));
            this.lblLurgit = new System.Windows.Forms.Label();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.lblLurgitRules = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblLurgit
            // 
            this.lblLurgit.AutoSize = true;
            this.lblLurgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLurgit.Location = new System.Drawing.Point(375, 9);
            this.lblLurgit.Name = "lblLurgit";
            this.lblLurgit.Size = new System.Drawing.Size(66, 25);
            this.lblLurgit.TabIndex = 5;
            this.lblLurgit.Text = "Rules";
            // 
            // btnEndGame
            // 
            this.btnEndGame.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndGame.Location = new System.Drawing.Point(365, 568);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(106, 43);
            this.btnEndGame.TabIndex = 7;
            this.btnEndGame.Text = "Got It";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // lblLurgitRules
            // 
            this.lblLurgitRules.AutoSize = true;
            this.lblLurgitRules.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLurgitRules.Location = new System.Drawing.Point(17, 57);
            this.lblLurgitRules.Name = "lblLurgitRules";
            this.lblLurgitRules.Size = new System.Drawing.Size(806, 493);
            this.lblLurgitRules.TabIndex = 8;
            this.lblLurgitRules.Text = resources.GetString("lblLurgitRules.Text");
            // 
            // frmLurgitRules
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(824, 639);
            this.Controls.Add(this.lblLurgitRules);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.lblLurgit);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmLurgitRules";
            this.Text = "Lurgit Rules";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblLurgit;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.Label lblLurgitRules;
    }
}