using System.Media;
using System.Numerics;

namespace Fighter_Jet_Shooting_Game_MOO_ICT
{
    public partial class Form1 : Form
    {

        bool goLeft, goRight, goUp, goDown, shooting, isGameOver;
        int score;
        int lives;
        const int startingLives = 3;
        int playerSpeed = 12;
        int enemySpeed = 6;
        int bulletSpeed;
        Random rnd = new Random();

        int gameTicks;
        const int ticksPerSecond = 50; // gameTimer.Interval = 20ms

        const int bombDelaySeconds = 35;
        const int heartIntervalSeconds = 8;
        const int tripleShotIntervalSeconds = 12;
        const int tripleShotDurationSeconds = 20;

        bool tripleShotActive;
        bool tripleShotFired;
        int tripleShotTicksRemaining;

        public Form1()
        {
            InitializeComponent();
            showGameControls(false);
        }

        private void btnJogar_Click(object sender, EventArgs e)
        {
            pnlMenu.Visible = false;
            showGameControls(true);
            this.ActiveControl = null;
            resetGame();
        }

        private void btnJogarNovamente_Click(object sender, EventArgs e)
        {
            pnlGameOver.Visible = false;
            showGameControls(true);
            this.ActiveControl = null;
            resetGame();
        }

        private void btnSair_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void showGameControls(bool visible)
        {
            enemyOne.Visible = visible;
            enemyTwo.Visible = visible;
            enemyThree.Visible = visible;
            bullet.Visible = visible;
            bulletLeft.Visible = visible;
            bulletRight.Visible = visible;
            player.Visible = visible;
            txtScore.Visible = visible;
            lblLives.Visible = visible;
            heartPowerUp.Visible = visible;
            bombPowerUp.Visible = visible;
            tripleShotPowerUp.Visible = visible;
        }

        private void mainGameTimerEvent(object sender, EventArgs e)
        {

            gameTicks++;
            txtScore.Text = "Pontos: " + score;

            enemyOne.Top += enemySpeed;
            enemyTwo.Top += enemySpeed;
            enemyThree.Top += enemySpeed;

            if (enemyOne.Top > 790)
            {
                enemyOne.Top = rnd.Next(0, 200) * -1;
                enemyOne.Left = rnd.Next(20, 760);
                loseLife(false);
            }
            if (enemyTwo.Top > 790)
            {
                enemyTwo.Top = rnd.Next(0, 500) * -1;
                enemyTwo.Left = rnd.Next(20, 760);
                loseLife(false);
            }
            if (enemyThree.Top > 790)
            {
                enemyThree.Top = rnd.Next(0, 900) * -1;
                enemyThree.Left = rnd.Next(20, 760);
                loseLife(false);
            }

            if (isGameOver == true)
            {
                return;
            }

            // player movement logic starts

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= playerSpeed;
            }
            if (goRight == true && player.Left < 790)
            {
                player.Left += playerSpeed;
            }
            if (goUp == true && player.Top > 0)
            {
                player.Top -= playerSpeed;
            }
            if (goDown == true && player.Top < 652)
            {
                player.Top += playerSpeed;
            }
            // player movement logic ends

            moveBullets();
            movePowerUps();
            checkBulletCollisions();
            checkPlayerCollisions();

            if (tripleShotActive == true)
            {
                tripleShotTicksRemaining -= 1;
                if (tripleShotTicksRemaining <= 0)
                {
                    tripleShotActive = false;
                }
            }

            lblLives.Text = "Vidas: " + lives;

        }

        private void moveBullets()
        {
            if (shooting == true)
            {
                bulletSpeed = 20;
                bullet.Top -= bulletSpeed;

                if (tripleShotFired == true)
                {
                    bulletLeft.Top -= bulletSpeed;
                    bulletRight.Top -= bulletSpeed;
                }
            }
            else
            {
                bullet.Left = -300;
                bulletLeft.Left = -300;
                bulletRight.Left = -300;
                bulletSpeed = 0;
            }

            if (bullet.Top < -30)
            {
                shooting = false;
                tripleShotFired = false;
            }
        }

        private void movePowerUps()
        {
            // bomba: só aparece depois de 35 segundos de jogo
            if (gameTicks >= bombDelaySeconds * ticksPerSecond)
            {
                if (bombPowerUp.Top > -100)
                {
                    bombPowerUp.Top += enemySpeed;
                    if (bombPowerUp.Top > 790)
                    {
                        bombPowerUp.Top = -1000;
                    }
                }
                else if (rnd.Next(0, bombDelaySeconds * ticksPerSecond) == 0)
                {
                    bombPowerUp.Left = rnd.Next(20, 840);
                    bombPowerUp.Top = -40;
                }
            }

            // power-up de vida extra
            if (heartPowerUp.Top > -100)
            {
                heartPowerUp.Top += enemySpeed;
                if (heartPowerUp.Top > 790)
                {
                    heartPowerUp.Top = -1000;
                }
            }
            else if (rnd.Next(0, heartIntervalSeconds * ticksPerSecond) == 0)
            {
                heartPowerUp.Left = rnd.Next(20, 840);
                heartPowerUp.Top = -40;
            }

            // power-up de tiro triplo
            if (tripleShotPowerUp.Top > -100)
            {
                tripleShotPowerUp.Top += enemySpeed;
                if (tripleShotPowerUp.Top > 790)
                {
                    tripleShotPowerUp.Top = -1000;
                }
            }
            else if (rnd.Next(0, tripleShotIntervalSeconds * ticksPerSecond) == 0)
            {
                tripleShotPowerUp.Left = rnd.Next(20, 840);
                tripleShotPowerUp.Top = -40;
            }
        }

        private void checkBulletCollisions()
        {
            checkBulletHit(bullet);
            if (tripleShotFired == true)
            {
                checkBulletHit(bulletLeft);
                checkBulletHit(bulletRight);
            }
        }

        private void checkBulletHit(PictureBox activeBullet)
        {
            if (activeBullet.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                score += 1;
                enemyOne.Top = -450;
                enemyOne.Left = rnd.Next(20, 760);
                shooting = false;
                tripleShotFired = false;
            }
            if (activeBullet.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                score += 1;
                enemyTwo.Top = -650;
                enemyTwo.Left = rnd.Next(20, 760);
                shooting = false;
                tripleShotFired = false;
            }
            if (activeBullet.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                score += 1;
                enemyThree.Top = -750;
                enemyThree.Left = rnd.Next(20, 760);
                shooting = false;
                tripleShotFired = false;
            }

            if (bombPowerUp.Top > -100 && activeBullet.Bounds.IntersectsWith(bombPowerUp.Bounds))
            {
                bombPowerUp.Top = -1000;
                shooting = false;
                tripleShotFired = false;
            }
        }

        private void checkPlayerCollisions()
        {
            if (player.Bounds.IntersectsWith(enemyOne.Bounds))
            {
                enemyOne.Top = rnd.Next(0, 200) * -1;
                enemyOne.Left = rnd.Next(20, 760);
                loseLife(true);
            }
            if (player.Bounds.IntersectsWith(enemyTwo.Bounds))
            {
                enemyTwo.Top = rnd.Next(0, 500) * -1;
                enemyTwo.Left = rnd.Next(20, 760);
                loseLife(true);
            }
            if (player.Bounds.IntersectsWith(enemyThree.Bounds))
            {
                enemyThree.Top = rnd.Next(0, 900) * -1;
                enemyThree.Left = rnd.Next(20, 760);
                loseLife(true);
            }

            if (bombPowerUp.Top > -100 && player.Bounds.IntersectsWith(bombPowerUp.Bounds))
            {
                bombPowerUp.Top = -1000;
                loseLife(true);
            }

            if (heartPowerUp.Top > -100 && player.Bounds.IntersectsWith(heartPowerUp.Bounds))
            {
                heartPowerUp.Top = -1000;
                lives += 1;
                lblLives.Text = "Vidas: " + lives;
            }

            if (tripleShotPowerUp.Top > -100 && player.Bounds.IntersectsWith(tripleShotPowerUp.Bounds))
            {
                tripleShotPowerUp.Top = -1000;
                tripleShotActive = true;
                tripleShotTicksRemaining = tripleShotDurationSeconds * ticksPerSecond;
            }
        }

        private void loseLife(bool explosion)
        {
            if (isGameOver == true)
            {
                return;
            }

            if (explosion == true)
            {
                SystemSounds.Hand.Play();
            }

            lives -= 1;
            lblLives.Text = "Vidas: " + lives;

            if (lives <= 0)
            {
                gameOver();
            }
        }

        private void keyisdown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = true;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = true;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = true;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = true;
            }
        }

        private void keyisup(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Left)
            {
                goLeft = false;
            }
            if (e.KeyCode == Keys.Right)
            {
                goRight = false;
            }
            if (e.KeyCode == Keys.Up)
            {
                goUp = false;
            }
            if (e.KeyCode == Keys.Down)
            {
                goDown = false;
            }
            if (e.KeyCode == Keys.Space && shooting == false && isGameOver == false)
            {
                shooting = true;

                bullet.Top = player.Top - 30;
                bullet.Left = player.Left + (player.Width / 2);

                if (tripleShotActive == true)
                {
                    tripleShotFired = true;
                    bulletLeft.Top = player.Top - 30;
                    bulletLeft.Left = player.Left + 10;
                    bulletRight.Top = player.Top - 30;
                    bulletRight.Left = player.Left + player.Width - 17;
                }

            }
        }

        private void resetGame()
        {
            isGameOver = false;
            gameTicks = 0;
            score = 0;
            lives = startingLives;
            enemySpeed = 6;

            tripleShotActive = false;
            tripleShotFired = false;
            tripleShotTicksRemaining = 0;

            enemyOne.Left = rnd.Next(20, 760);
            enemyTwo.Left = rnd.Next(20, 760);
            enemyThree.Left = rnd.Next(20, 760);

            enemyOne.Top = rnd.Next(0, 200) * -1;
            enemyTwo.Top = rnd.Next(0, 500) * -1;
            enemyThree.Top = rnd.Next(0, 900) * -1;

            bulletSpeed = 0;
            bullet.Left = -300;
            bulletLeft.Left = -300;
            bulletRight.Left = -300;
            shooting = false;

            heartPowerUp.Top = -1000;
            bombPowerUp.Top = -1000;
            tripleShotPowerUp.Top = -1000;

            player.Left = 395;
            player.Top = 632;

            txtScore.Text = "Pontos: " + score;
            lblLives.Text = "Vidas: " + lives;

            pnlGameOver.Visible = false;

            gameTimer.Start();

        }

        private void gameOver()
        {
            isGameOver = true;
            gameTimer.Stop();
            showGameControls(false);

            lblGameOverMessage.Text = "Seu avião explodiu";
            pnlGameOver.Visible = true;
            pnlGameOver.BringToFront();
        }
    }
}
