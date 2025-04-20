namespace LurgitGame
{
    partial class frmLurgitMainForm
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLurgitMainForm));
            this.menStrpLurgit = new System.Windows.Forms.MenuStrip();
            this.strpNewGame = new System.Windows.Forms.ToolStripMenuItem();
            this.settingsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.changeColorInterfaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutTheGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.btnStart = new System.Windows.Forms.Button();
            this.lblLurgit = new System.Windows.Forms.Label();
            this.grpBxUserScores = new System.Windows.Forms.GroupBox();
            this.txtBxUserScores = new System.Windows.Forms.TextBox();
            this.btnRoll = new System.Windows.Forms.Button();
            this.grpBxDice = new System.Windows.Forms.GroupBox();
            this.lblP2Name = new System.Windows.Forms.Label();
            this.lblP1Name = new System.Windows.Forms.Label();
            this.lbP2Score = new System.Windows.Forms.Label();
            this.lbP1Score = new System.Windows.Forms.Label();
            this.chkHoldDiceThree = new System.Windows.Forms.CheckBox();
            this.chkHoldDiceTwo = new System.Windows.Forms.CheckBox();
            this.chkHoldDiceOne = new System.Windows.Forms.CheckBox();
            this.lbRoundCount = new System.Windows.Forms.Label();
            this.lbRollCount = new System.Windows.Forms.Label();
            this.lblDiceThree = new System.Windows.Forms.Label();
            this.lblDiceTwo = new System.Windows.Forms.Label();
            this.lblDiceOne = new System.Windows.Forms.Label();
            this.picBxDiceThree = new System.Windows.Forms.PictureBox();
            this.picBxDiceTwo = new System.Windows.Forms.PictureBox();
            this.picBxDiceOne = new System.Windows.Forms.PictureBox();
            this.btnEndGame = new System.Windows.Forms.Button();
            this.txtBxLurgitStatus = new System.Windows.Forms.TextBox();
            this.btnEndTurn = new System.Windows.Forms.Button();
            this.tmrTurnFlash = new System.Windows.Forms.Timer(this.components);
            this.saveFileDialog = new System.Windows.Forms.SaveFileDialog();
            this.lblBonusStatus = new System.Windows.Forms.Label();
            this.lblP2Turn = new System.Windows.Forms.Label();
            this.lblP1Turn = new System.Windows.Forms.Label();
            this.menStrpLurgit.SuspendLayout();
            this.grpBxUserScores.SuspendLayout();
            this.grpBxDice.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceThree)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceTwo)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceOne)).BeginInit();
            this.SuspendLayout();
            // 
            // menStrpLurgit
            // 
            this.menStrpLurgit.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.strpNewGame,
            this.settingsToolStripMenuItem,
            this.quitToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.menStrpLurgit.Location = new System.Drawing.Point(0, 0);
            this.menStrpLurgit.Name = "menStrpLurgit";
            this.menStrpLurgit.Size = new System.Drawing.Size(762, 24);
            this.menStrpLurgit.TabIndex = 0;
            this.menStrpLurgit.Text = "menuStrip1";
            // 
            // strpNewGame
            // 
            this.strpNewGame.Name = "strpNewGame";
            this.strpNewGame.Size = new System.Drawing.Size(77, 20);
            this.strpNewGame.Text = "New Game";
            this.strpNewGame.Click += new System.EventHandler(this.strpNewGame_Click);
            // 
            // settingsToolStripMenuItem
            // 
            this.settingsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.changeColorInterfaceToolStripMenuItem});
            this.settingsToolStripMenuItem.Name = "settingsToolStripMenuItem";
            this.settingsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
            this.settingsToolStripMenuItem.Text = "Settings";
            // 
            // changeColorInterfaceToolStripMenuItem
            // 
            this.changeColorInterfaceToolStripMenuItem.Name = "changeColorInterfaceToolStripMenuItem";
            this.changeColorInterfaceToolStripMenuItem.Size = new System.Drawing.Size(196, 22);
            this.changeColorInterfaceToolStripMenuItem.Text = "Change Color Interface";
            this.changeColorInterfaceToolStripMenuItem.Click += new System.EventHandler(this.changeColorInterfaceToolStripMenuItem_Click);
            // 
            // quitToolStripMenuItem
            // 
            this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
            this.quitToolStripMenuItem.Size = new System.Drawing.Size(47, 20);
            this.quitToolStripMenuItem.Text = "Rules";
            this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.aboutTheGameToolStripMenuItem});
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(52, 20);
            this.aboutToolStripMenuItem.Text = "About";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.AboutToolStripMenuItem_Click);
            // 
            // aboutTheGameToolStripMenuItem
            // 
            this.aboutTheGameToolStripMenuItem.Name = "aboutTheGameToolStripMenuItem";
            this.aboutTheGameToolStripMenuItem.Size = new System.Drawing.Size(161, 22);
            this.aboutTheGameToolStripMenuItem.Text = "About the Game";
            // 
            // btnStart
            // 
            this.btnStart.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnStart.Location = new System.Drawing.Point(330, 471);
            this.btnStart.Name = "btnStart";
            this.btnStart.Size = new System.Drawing.Size(101, 30);
            this.btnStart.TabIndex = 1;
            this.btnStart.Text = "Start the Game";
            this.btnStart.UseVisualStyleBackColor = true;
            this.btnStart.Click += new System.EventHandler(this.btnStart_Click);
            // 
            // lblLurgit
            // 
            this.lblLurgit.AutoSize = true;
            this.lblLurgit.Font = new System.Drawing.Font("Microsoft Sans Serif", 15F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLurgit.Location = new System.Drawing.Point(292, 36);
            this.lblLurgit.Name = "lblLurgit";
            this.lblLurgit.Size = new System.Drawing.Size(173, 25);
            this.lblLurgit.TabIndex = 2;
            this.lblLurgit.Text = "The Lurgit Game";
            // 
            // grpBxUserScores
            // 
            this.grpBxUserScores.BackColor = System.Drawing.SystemColors.Control;
            this.grpBxUserScores.Controls.Add(this.txtBxUserScores);
            this.grpBxUserScores.Location = new System.Drawing.Point(641, 92);
            this.grpBxUserScores.Name = "grpBxUserScores";
            this.grpBxUserScores.Size = new System.Drawing.Size(109, 353);
            this.grpBxUserScores.TabIndex = 3;
            this.grpBxUserScores.TabStop = false;
            this.grpBxUserScores.Text = "User Scores";
            this.grpBxUserScores.Visible = false;
            // 
            // txtBxUserScores
            // 
            this.txtBxUserScores.BackColor = System.Drawing.Color.White;
            this.txtBxUserScores.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtBxUserScores.Location = new System.Drawing.Point(7, 19);
            this.txtBxUserScores.Multiline = true;
            this.txtBxUserScores.Name = "txtBxUserScores";
            this.txtBxUserScores.ReadOnly = true;
            this.txtBxUserScores.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtBxUserScores.Size = new System.Drawing.Size(100, 328);
            this.txtBxUserScores.TabIndex = 0;
            // 
            // btnRoll
            // 
            this.btnRoll.Enabled = false;
            this.btnRoll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnRoll.Location = new System.Drawing.Point(117, 465);
            this.btnRoll.Name = "btnRoll";
            this.btnRoll.Size = new System.Drawing.Size(106, 43);
            this.btnRoll.TabIndex = 4;
            this.btnRoll.Text = "Roll";
            this.btnRoll.UseVisualStyleBackColor = true;
            this.btnRoll.Visible = false;
            this.btnRoll.Click += new System.EventHandler(this.btnRoll_Click);
            // 
            // grpBxDice
            // 
            this.grpBxDice.BackColor = System.Drawing.SystemColors.Control;
            this.grpBxDice.Controls.Add(this.lblP1Turn);
            this.grpBxDice.Controls.Add(this.lblP2Turn);
            this.grpBxDice.Controls.Add(this.lblBonusStatus);
            this.grpBxDice.Controls.Add(this.lblP2Name);
            this.grpBxDice.Controls.Add(this.lblP1Name);
            this.grpBxDice.Controls.Add(this.lbP2Score);
            this.grpBxDice.Controls.Add(this.lbP1Score);
            this.grpBxDice.Controls.Add(this.chkHoldDiceThree);
            this.grpBxDice.Controls.Add(this.chkHoldDiceTwo);
            this.grpBxDice.Controls.Add(this.chkHoldDiceOne);
            this.grpBxDice.Controls.Add(this.lbRoundCount);
            this.grpBxDice.Controls.Add(this.lbRollCount);
            this.grpBxDice.Controls.Add(this.lblDiceThree);
            this.grpBxDice.Controls.Add(this.lblDiceTwo);
            this.grpBxDice.Controls.Add(this.lblDiceOne);
            this.grpBxDice.Controls.Add(this.picBxDiceThree);
            this.grpBxDice.Controls.Add(this.picBxDiceTwo);
            this.grpBxDice.Controls.Add(this.picBxDiceOne);
            this.grpBxDice.Location = new System.Drawing.Point(28, 92);
            this.grpBxDice.Name = "grpBxDice";
            this.grpBxDice.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.grpBxDice.Size = new System.Drawing.Size(587, 353);
            this.grpBxDice.TabIndex = 5;
            this.grpBxDice.TabStop = false;
            this.grpBxDice.Text = "Dice";
            this.grpBxDice.Visible = false;
            // 
            // lblP2Name
            // 
            this.lblP2Name.AutoSize = true;
            this.lblP2Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP2Name.Location = new System.Drawing.Point(448, 44);
            this.lblP2Name.Name = "lblP2Name";
            this.lblP2Name.Size = new System.Drawing.Size(88, 17);
            this.lblP2Name.TabIndex = 17;
            this.lblP2Name.Text = "Player Two";
            this.lblP2Name.Visible = false;
            // 
            // lblP1Name
            // 
            this.lblP1Name.AutoSize = true;
            this.lblP1Name.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP1Name.Location = new System.Drawing.Point(45, 44);
            this.lblP1Name.Name = "lblP1Name";
            this.lblP1Name.Size = new System.Drawing.Size(89, 17);
            this.lblP1Name.TabIndex = 16;
            this.lblP1Name.Text = "Player One";
            this.lblP1Name.Visible = false;
            // 
            // lbP2Score
            // 
            this.lbP2Score.AutoSize = true;
            this.lbP2Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbP2Score.Location = new System.Drawing.Point(444, 65);
            this.lbP2Score.Name = "lbP2Score";
            this.lbP2Score.Size = new System.Drawing.Size(90, 17);
            this.lbP2Score.TabIndex = 15;
            this.lbP2Score.Text = "P2 Score = 0";
            this.lbP2Score.Visible = false;
            // 
            // lbP1Score
            // 
            this.lbP1Score.AutoSize = true;
            this.lbP1Score.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbP1Score.Location = new System.Drawing.Point(43, 67);
            this.lbP1Score.Name = "lbP1Score";
            this.lbP1Score.Size = new System.Drawing.Size(90, 17);
            this.lbP1Score.TabIndex = 14;
            this.lbP1Score.Text = "P1 Score = 0";
            this.lbP1Score.Visible = false;
            // 
            // chkHoldDiceThree
            // 
            this.chkHoldDiceThree.AutoSize = true;
            this.chkHoldDiceThree.Enabled = false;
            this.chkHoldDiceThree.Location = new System.Drawing.Point(464, 265);
            this.chkHoldDiceThree.Name = "chkHoldDiceThree";
            this.chkHoldDiceThree.Size = new System.Drawing.Size(48, 17);
            this.chkHoldDiceThree.TabIndex = 13;
            this.chkHoldDiceThree.Text = "Hold";
            this.chkHoldDiceThree.UseVisualStyleBackColor = true;
            // 
            // chkHoldDiceTwo
            // 
            this.chkHoldDiceTwo.AutoSize = true;
            this.chkHoldDiceTwo.Enabled = false;
            this.chkHoldDiceTwo.Location = new System.Drawing.Point(255, 265);
            this.chkHoldDiceTwo.Name = "chkHoldDiceTwo";
            this.chkHoldDiceTwo.Size = new System.Drawing.Size(48, 17);
            this.chkHoldDiceTwo.TabIndex = 12;
            this.chkHoldDiceTwo.Text = "Hold";
            this.chkHoldDiceTwo.UseVisualStyleBackColor = true;
            // 
            // chkHoldDiceOne
            // 
            this.chkHoldDiceOne.AutoSize = true;
            this.chkHoldDiceOne.Enabled = false;
            this.chkHoldDiceOne.Location = new System.Drawing.Point(57, 265);
            this.chkHoldDiceOne.Name = "chkHoldDiceOne";
            this.chkHoldDiceOne.Size = new System.Drawing.Size(48, 17);
            this.chkHoldDiceOne.TabIndex = 11;
            this.chkHoldDiceOne.Text = "Hold";
            this.chkHoldDiceOne.UseVisualStyleBackColor = true;
            // 
            // lbRoundCount
            // 
            this.lbRoundCount.AutoSize = true;
            this.lbRoundCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRoundCount.Location = new System.Drawing.Point(252, 46);
            this.lbRoundCount.Name = "lbRoundCount";
            this.lbRoundCount.Size = new System.Drawing.Size(69, 17);
            this.lbRoundCount.TabIndex = 10;
            this.lbRoundCount.Text = "Round 0";
            // 
            // lbRollCount
            // 
            this.lbRollCount.AutoSize = true;
            this.lbRollCount.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lbRollCount.Location = new System.Drawing.Point(261, 67);
            this.lbRollCount.Name = "lbRollCount";
            this.lbRollCount.Size = new System.Drawing.Size(44, 17);
            this.lbRollCount.TabIndex = 9;
            this.lbRollCount.Text = "Roll 0";
            // 
            // lblDiceThree
            // 
            this.lblDiceThree.AutoSize = true;
            this.lblDiceThree.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiceThree.Location = new System.Drawing.Point(423, 233);
            this.lblDiceThree.Name = "lblDiceThree";
            this.lblDiceThree.Size = new System.Drawing.Size(0, 13);
            this.lblDiceThree.TabIndex = 5;
            // 
            // lblDiceTwo
            // 
            this.lblDiceTwo.AutoSize = true;
            this.lblDiceTwo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiceTwo.Location = new System.Drawing.Point(221, 233);
            this.lblDiceTwo.Name = "lblDiceTwo";
            this.lblDiceTwo.Size = new System.Drawing.Size(0, 13);
            this.lblDiceTwo.TabIndex = 4;
            // 
            // lblDiceOne
            // 
            this.lblDiceOne.AutoSize = true;
            this.lblDiceOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDiceOne.Location = new System.Drawing.Point(19, 233);
            this.lblDiceOne.Name = "lblDiceOne";
            this.lblDiceOne.Size = new System.Drawing.Size(0, 13);
            this.lblDiceOne.TabIndex = 3;
            // 
            // picBxDiceThree
            // 
            this.picBxDiceThree.BackColor = System.Drawing.Color.White;
            this.picBxDiceThree.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBxDiceThree.Location = new System.Drawing.Point(426, 99);
            this.picBxDiceThree.Name = "picBxDiceThree";
            this.picBxDiceThree.Size = new System.Drawing.Size(120, 120);
            this.picBxDiceThree.TabIndex = 2;
            this.picBxDiceThree.TabStop = false;
            // 
            // picBxDiceTwo
            // 
            this.picBxDiceTwo.BackColor = System.Drawing.Color.White;
            this.picBxDiceTwo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBxDiceTwo.Location = new System.Drawing.Point(224, 99);
            this.picBxDiceTwo.Name = "picBxDiceTwo";
            this.picBxDiceTwo.Size = new System.Drawing.Size(120, 120);
            this.picBxDiceTwo.TabIndex = 1;
            this.picBxDiceTwo.TabStop = false;
            // 
            // picBxDiceOne
            // 
            this.picBxDiceOne.BackColor = System.Drawing.Color.White;
            this.picBxDiceOne.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.picBxDiceOne.Location = new System.Drawing.Point(22, 99);
            this.picBxDiceOne.Name = "picBxDiceOne";
            this.picBxDiceOne.Size = new System.Drawing.Size(120, 120);
            this.picBxDiceOne.TabIndex = 0;
            this.picBxDiceOne.TabStop = false;
            // 
            // btnEndGame
            // 
            this.btnEndGame.Enabled = false;
            this.btnEndGame.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndGame.Location = new System.Drawing.Point(330, 471);
            this.btnEndGame.Name = "btnEndGame";
            this.btnEndGame.Size = new System.Drawing.Size(101, 30);
            this.btnEndGame.TabIndex = 6;
            this.btnEndGame.Text = "End Game";
            this.btnEndGame.UseVisualStyleBackColor = true;
            this.btnEndGame.Visible = false;
            this.btnEndGame.Click += new System.EventHandler(this.btnEndGame_Click);
            // 
            // txtBxLurgitStatus
            // 
            this.txtBxLurgitStatus.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txtBxLurgitStatus.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBxLurgitStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtBxLurgitStatus.Location = new System.Drawing.Point(215, 64);
            this.txtBxLurgitStatus.Multiline = true;
            this.txtBxLurgitStatus.Name = "txtBxLurgitStatus";
            this.txtBxLurgitStatus.Size = new System.Drawing.Size(339, 20);
            this.txtBxLurgitStatus.TabIndex = 7;
            this.txtBxLurgitStatus.Text = "Please, click the start button to start the game!";
            this.txtBxLurgitStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnEndTurn
            // 
            this.btnEndTurn.Enabled = false;
            this.btnEndTurn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnEndTurn.Location = new System.Drawing.Point(529, 465);
            this.btnEndTurn.Name = "btnEndTurn";
            this.btnEndTurn.Size = new System.Drawing.Size(106, 43);
            this.btnEndTurn.TabIndex = 8;
            this.btnEndTurn.Text = "End Turn";
            this.btnEndTurn.UseVisualStyleBackColor = true;
            this.btnEndTurn.Visible = false;
            // 
            // tmrTurnFlash
            // 
            this.tmrTurnFlash.Tick += new System.EventHandler(this.tmrTurnFlash_Tick);
            // 
            // lblBonusStatus
            // 
            this.lblBonusStatus.AutoSize = true;
            this.lblBonusStatus.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBonusStatus.ForeColor = System.Drawing.Color.Red;
            this.lblBonusStatus.Location = new System.Drawing.Point(218, 25);
            this.lblBonusStatus.Name = "lblBonusStatus";
            this.lblBonusStatus.Size = new System.Drawing.Size(105, 17);
            this.lblBonusStatus.TabIndex = 18;
            this.lblBonusStatus.Text = "Random Bonus";
            this.lblBonusStatus.Visible = false;
            // 
            // lblP2Turn
            // 
            this.lblP2Turn.AutoSize = true;
            this.lblP2Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP2Turn.ForeColor = System.Drawing.Color.Red;
            this.lblP2Turn.Location = new System.Drawing.Point(461, 25);
            this.lblP2Turn.Name = "lblP2Turn";
            this.lblP2Turn.Size = new System.Drawing.Size(59, 17);
            this.lblP2Turn.TabIndex = 19;
            this.lblP2Turn.Text = "P2 Turn";
            this.lblP2Turn.Visible = false;
            // 
            // lblP1Turn
            // 
            this.lblP1Turn.AutoSize = true;
            this.lblP1Turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblP1Turn.ForeColor = System.Drawing.Color.Red;
            this.lblP1Turn.Location = new System.Drawing.Point(54, 25);
            this.lblP1Turn.Name = "lblP1Turn";
            this.lblP1Turn.Size = new System.Drawing.Size(59, 17);
            this.lblP1Turn.TabIndex = 20;
            this.lblP1Turn.Text = "P1 Turn";
            this.lblP1Turn.Visible = false;
            // 
            // frmLurgitMainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.SystemColors.ControlLight;
            this.ClientSize = new System.Drawing.Size(762, 520);
            this.Controls.Add(this.btnEndTurn);
            this.Controls.Add(this.txtBxLurgitStatus);
            this.Controls.Add(this.btnEndGame);
            this.Controls.Add(this.grpBxDice);
            this.Controls.Add(this.btnRoll);
            this.Controls.Add(this.grpBxUserScores);
            this.Controls.Add(this.lblLurgit);
            this.Controls.Add(this.btnStart);
            this.Controls.Add(this.menStrpLurgit);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menStrpLurgit;
            this.Name = "frmLurgitMainForm";
            this.Text = "The Lurgit Game";
            this.menStrpLurgit.ResumeLayout(false);
            this.menStrpLurgit.PerformLayout();
            this.grpBxUserScores.ResumeLayout(false);
            this.grpBxUserScores.PerformLayout();
            this.grpBxDice.ResumeLayout(false);
            this.grpBxDice.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBxDiceOne)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menStrpLurgit;
        private System.Windows.Forms.ToolStripMenuItem strpNewGame;
        private System.Windows.Forms.ToolStripMenuItem settingsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem changeColorInterfaceToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutTheGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem quitToolStripMenuItem;
        private System.Windows.Forms.Button btnStart;
        private System.Windows.Forms.Label lblLurgit;
        private System.Windows.Forms.GroupBox grpBxUserScores;
        private System.Windows.Forms.Button btnRoll;
        private System.Windows.Forms.GroupBox grpBxDice;
        private System.Windows.Forms.PictureBox picBxDiceThree;
        private System.Windows.Forms.PictureBox picBxDiceTwo;
        private System.Windows.Forms.PictureBox picBxDiceOne;
        private System.Windows.Forms.Label lblDiceThree;
        private System.Windows.Forms.Label lblDiceTwo;
        private System.Windows.Forms.Label lblDiceOne;
        private System.Windows.Forms.Button btnEndGame;
        private System.Windows.Forms.TextBox txtBxUserScores;
        private System.Windows.Forms.TextBox txtBxLurgitStatus;
        private System.Windows.Forms.Label lbRollCount;
        private System.Windows.Forms.Label lbRoundCount;
        private System.Windows.Forms.CheckBox chkHoldDiceThree;
        private System.Windows.Forms.CheckBox chkHoldDiceTwo;
        private System.Windows.Forms.CheckBox chkHoldDiceOne;
        private System.Windows.Forms.Label lbP1Score;
        private System.Windows.Forms.Label lbP2Score;
        private System.Windows.Forms.Label lblP2Name;
        private System.Windows.Forms.Label lblP1Name;
        private System.Windows.Forms.Button btnEndTurn;
        private System.Windows.Forms.Timer tmrTurnFlash;
        private System.Windows.Forms.SaveFileDialog saveFileDialog;
        private System.Windows.Forms.Label lblBonusStatus;
        private System.Windows.Forms.Label lblP1Turn;
        private System.Windows.Forms.Label lblP2Turn;
    }
}

