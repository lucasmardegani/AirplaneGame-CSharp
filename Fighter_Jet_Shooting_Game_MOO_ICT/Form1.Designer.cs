namespace Fighter_Jet_Shooting_Game_MOO_ICT
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            enemyOne = new PictureBox();
            enemyTwo = new PictureBox();
            enemyThree = new PictureBox();
            bullet = new PictureBox();
            bulletLeft = new PictureBox();
            bulletRight = new PictureBox();
            player = new PictureBox();
            txtScore = new Label();
            lblLives = new Label();
            heartPowerUp = new Label();
            bombPowerUp = new Label();
            tripleShotPowerUp = new Label();
            pnlMenu = new Panel();
            btnJogar = new Button();
            lblMenuTitle = new Label();
            pnlGameOver = new Panel();
            btnSair = new Button();
            btnJogarNovamente = new Button();
            lblGameOverMessage = new Label();
            gameTimer = new System.Windows.Forms.Timer(components);
            ((System.ComponentModel.ISupportInitialize)enemyOne).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyTwo).BeginInit();
            ((System.ComponentModel.ISupportInitialize)enemyThree).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bullet).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulletLeft).BeginInit();
            ((System.ComponentModel.ISupportInitialize)bulletRight).BeginInit();
            ((System.ComponentModel.ISupportInitialize)player).BeginInit();
            pnlMenu.SuspendLayout();
            pnlGameOver.SuspendLayout();
            SuspendLayout();
            // 
            // enemyOne
            // 
            this.enemyOne.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyOne.Location = new System.Drawing.Point(30, 62);
            this.enemyOne.Name = "enemyOne";
            this.enemyOne.Size = new System.Drawing.Size(100, 85);
            this.enemyOne.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyOne.TabIndex = 0;
            this.enemyOne.TabStop = false;
            // 
            // enemyTwo
            // 
            this.enemyTwo.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyTwo.Location = new System.Drawing.Point(400, 62);
            this.enemyTwo.Name = "enemyTwo";
            this.enemyTwo.Size = new System.Drawing.Size(100, 85);
            this.enemyTwo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyTwo.TabIndex = 0;
            this.enemyTwo.TabStop = false;
            // 
            // enemyThree
            // 
            this.enemyThree.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.enemy;
            this.enemyThree.Location = new System.Drawing.Point(760, 62);
            this.enemyThree.Name = "enemyThree";
            this.enemyThree.Size = new System.Drawing.Size(100, 85);
            this.enemyThree.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.enemyThree.TabIndex = 0;
            this.enemyThree.TabStop = false;
            // 
            // bullet
            // 
            this.bullet.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.bullet;
            this.bullet.Location = new System.Drawing.Point(473, 304);
            this.bullet.Name = "bullet";
            this.bullet.Size = new System.Drawing.Size(7, 27);
            this.bullet.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bullet.TabIndex = 0;
            this.bullet.TabStop = false;
            // 
            // bulletLeft
            // 
            this.bulletLeft.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.bullet;
            this.bulletLeft.Location = new System.Drawing.Point(-300, 304);
            this.bulletLeft.Name = "bulletLeft";
            this.bulletLeft.Size = new System.Drawing.Size(7, 27);
            this.bulletLeft.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bulletLeft.TabIndex = 0;
            this.bulletLeft.TabStop = false;
            // 
            // bulletRight
            // 
            this.bulletRight.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.bullet;
            this.bulletRight.Location = new System.Drawing.Point(-300, 304);
            this.bulletRight.Name = "bulletRight";
            this.bulletRight.Size = new System.Drawing.Size(7, 27);
            this.bulletRight.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.bulletRight.TabIndex = 0;
            this.bulletRight.TabStop = false;
            // 
            // player
            // 
            this.player.Image = global::Fighter_Jet_Shooting_Game_MOO_ICT.Properties.Resources.player;
            this.player.Location = new System.Drawing.Point(395, 632);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(110, 98);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 0;
            this.player.TabStop = false;
            // 
            // txtScore
            // 
            this.txtScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtScore.Location = new System.Drawing.Point(670, 9);
            this.txtScore.Name = "txtScore";
            this.txtScore.Size = new System.Drawing.Size(220, 32);
            this.txtScore.TabIndex = 1;
            this.txtScore.Text = "Pontos: 0";
            this.txtScore.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            // 
            // lblLives
            // 
            this.lblLives.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.lblLives.ForeColor = System.Drawing.Color.DarkRed;
            this.lblLives.Location = new System.Drawing.Point(12, 9);
            this.lblLives.Name = "lblLives";
            this.lblLives.Size = new System.Drawing.Size(220, 32);
            this.lblLives.TabIndex = 2;
            this.lblLives.Text = "Vidas: 3";
            // 
            // heartPowerUp
            // 
            this.heartPowerUp.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.heartPowerUp.Location = new System.Drawing.Point(-300, -1000);
            this.heartPowerUp.Name = "heartPowerUp";
            this.heartPowerUp.Size = new System.Drawing.Size(40, 40);
            this.heartPowerUp.TabIndex = 3;
            this.heartPowerUp.Text = "❤️";
            this.heartPowerUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // bombPowerUp
            // 
            this.bombPowerUp.Font = new System.Drawing.Font("Segoe UI Emoji", 18F);
            this.bombPowerUp.Location = new System.Drawing.Point(-300, -1000);
            this.bombPowerUp.Name = "bombPowerUp";
            this.bombPowerUp.Size = new System.Drawing.Size(40, 40);
            this.bombPowerUp.TabIndex = 4;
            this.bombPowerUp.Text = "💣";
            this.bombPowerUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tripleShotPowerUp
            // 
            this.tripleShotPowerUp.BackColor = System.Drawing.Color.Gold;
            this.tripleShotPowerUp.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold);
            this.tripleShotPowerUp.Location = new System.Drawing.Point(-300, -1000);
            this.tripleShotPowerUp.Name = "tripleShotPowerUp";
            this.tripleShotPowerUp.Size = new System.Drawing.Size(40, 40);
            this.tripleShotPowerUp.TabIndex = 5;
            this.tripleShotPowerUp.Text = "3X";
            this.tripleShotPowerUp.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlMenu
            // 
            this.pnlMenu.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(30)))), ((int)(((byte)(30)))), ((int)(((byte)(60)))));
            this.pnlMenu.Controls.Add(this.btnJogar);
            this.pnlMenu.Controls.Add(this.lblMenuTitle);
            this.pnlMenu.Location = new System.Drawing.Point(0, 0);
            this.pnlMenu.Name = "pnlMenu";
            this.pnlMenu.Size = new System.Drawing.Size(900, 750);
            this.pnlMenu.TabIndex = 6;
            // 
            // btnJogar
            // 
            this.btnJogar.Font = new System.Drawing.Font("Microsoft Sans Serif", 16F, System.Drawing.FontStyle.Bold);
            this.btnJogar.Location = new System.Drawing.Point(350, 380);
            this.btnJogar.Name = "btnJogar";
            this.btnJogar.Size = new System.Drawing.Size(200, 60);
            this.btnJogar.TabIndex = 1;
            this.btnJogar.Text = "Jogar";
            this.btnJogar.UseVisualStyleBackColor = true;
            this.btnJogar.Click += new System.EventHandler(this.btnJogar_Click);
            // 
            // lblMenuTitle
            // 
            this.lblMenuTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 26F, System.Drawing.FontStyle.Bold);
            this.lblMenuTitle.ForeColor = System.Drawing.Color.White;
            this.lblMenuTitle.Location = new System.Drawing.Point(0, 260);
            this.lblMenuTitle.Name = "lblMenuTitle";
            this.lblMenuTitle.Size = new System.Drawing.Size(900, 60);
            this.lblMenuTitle.TabIndex = 0;
            this.lblMenuTitle.Text = "Fighter Jet Shooting Game";
            this.lblMenuTitle.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // pnlGameOver
            // 
            this.pnlGameOver.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(60)))), ((int)(((byte)(20)))), ((int)(((byte)(20)))));
            this.pnlGameOver.Controls.Add(this.btnSair);
            this.pnlGameOver.Controls.Add(this.btnJogarNovamente);
            this.pnlGameOver.Controls.Add(this.lblGameOverMessage);
            this.pnlGameOver.Location = new System.Drawing.Point(0, 0);
            this.pnlGameOver.Name = "pnlGameOver";
            this.pnlGameOver.Size = new System.Drawing.Size(900, 750);
            this.pnlGameOver.TabIndex = 7;
            this.pnlGameOver.Visible = false;
            // 
            // btnSair
            // 
            this.btnSair.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnSair.Location = new System.Drawing.Point(290, 430);
            this.btnSair.Name = "btnSair";
            this.btnSair.Size = new System.Drawing.Size(320, 55);
            this.btnSair.TabIndex = 2;
            this.btnSair.Text = "Sair";
            this.btnSair.UseVisualStyleBackColor = true;
            this.btnSair.Click += new System.EventHandler(this.btnSair_Click);
            // 
            // btnJogarNovamente
            // 
            this.btnJogarNovamente.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold);
            this.btnJogarNovamente.Location = new System.Drawing.Point(290, 360);
            this.btnJogarNovamente.Name = "btnJogarNovamente";
            this.btnJogarNovamente.Size = new System.Drawing.Size(320, 55);
            this.btnJogarNovamente.TabIndex = 1;
            this.btnJogarNovamente.Text = "Jogar novamente";
            this.btnJogarNovamente.UseVisualStyleBackColor = true;
            this.btnJogarNovamente.Click += new System.EventHandler(this.btnJogarNovamente_Click);
            // 
            // lblGameOverMessage
            // 
            this.lblGameOverMessage.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold);
            this.lblGameOverMessage.ForeColor = System.Drawing.Color.White;
            this.lblGameOverMessage.Location = new System.Drawing.Point(0, 260);
            this.lblGameOverMessage.Name = "lblGameOverMessage";
            this.lblGameOverMessage.Size = new System.Drawing.Size(900, 60);
            this.lblGameOverMessage.TabIndex = 0;
            this.lblGameOverMessage.Text = "Seu avião explodiu";
            this.lblGameOverMessage.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // gameTimer
            // 
            this.gameTimer.Interval = 20;
            this.gameTimer.Tick += new System.EventHandler(this.mainGameTimerEvent);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(900, 750);
            this.Controls.Add(this.player);
            this.Controls.Add(this.bulletRight);
            this.Controls.Add(this.bulletLeft);
            this.Controls.Add(this.bullet);
            this.Controls.Add(this.enemyThree);
            this.Controls.Add(this.enemyTwo);
            this.Controls.Add(this.enemyOne);
            this.Controls.Add(this.tripleShotPowerUp);
            this.Controls.Add(this.bombPowerUp);
            this.Controls.Add(this.heartPowerUp);
            this.Controls.Add(this.lblLives);
            this.Controls.Add(this.txtScore);
            this.Controls.Add(this.pnlGameOver);
            this.Controls.Add(this.pnlMenu);
            this.Name = "Form1";
            this.Text = "Fighet Jet Shooting Game MOOI CT";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.keyisdown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.keyisup);
            ((System.ComponentModel.ISupportInitialize)(this.enemyOne)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyTwo)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.enemyThree)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bullet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletLeft)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bulletRight)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            pnlMenu.ResumeLayout(false);
            pnlGameOver.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();


        }

        #endregion

        private System.Windows.Forms.PictureBox enemyOne;
        private System.Windows.Forms.PictureBox enemyTwo;
        private System.Windows.Forms.PictureBox enemyThree;
        private System.Windows.Forms.PictureBox bullet;
        private System.Windows.Forms.PictureBox bulletLeft;
        private System.Windows.Forms.PictureBox bulletRight;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.Label txtScore;
        private System.Windows.Forms.Label lblLives;
        private System.Windows.Forms.Label heartPowerUp;
        private System.Windows.Forms.Label bombPowerUp;
        private System.Windows.Forms.Label tripleShotPowerUp;
        private System.Windows.Forms.Panel pnlMenu;
        private System.Windows.Forms.Button btnJogar;
        private System.Windows.Forms.Label lblMenuTitle;
        private System.Windows.Forms.Panel pnlGameOver;
        private System.Windows.Forms.Button btnSair;
        private System.Windows.Forms.Button btnJogarNovamente;
        private System.Windows.Forms.Label lblGameOverMessage;
        private System.Windows.Forms.Timer gameTimer;

    }
}
