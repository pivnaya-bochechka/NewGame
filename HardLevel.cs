using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class HardLevel : Form
    {
        bool goLeft, goRight, goUp, goDown, gameOver;
        string facing = "up";
        int playerHealth = 100;
        int speed = 12;
        int ammo = 10;
        int monsterSpeed = 2;
        int monsterStrongSpeed = 3;
        int score;
        Random randNum = new Random();

        List<PictureBox> monstersList = new List<PictureBox>();
        List<PictureBox> monstersListStrong = new List<PictureBox>();
        public HardLevel()
        {
            InitializeComponent();
            RestartGame();

            hpTimer.Tick += new EventHandler(hpTimer_Tick); 
        }

        private void hpTimer_Tick(object sender, EventArgs e)
        {
            if (playerHealth < 80)
            {
                DropHealth();
            }
        }

        private void MainTimerEvent(object sender, EventArgs e)
        {
            if (score == 40)
            {
                this.Close();
                ContinuationHardLevel gameBossWindow = new ContinuationHardLevel();
                gameBossWindow.Show();
            }

            if (playerHealth > 1)
            {
                healthBar.Value = playerHealth;
            }
            else
            {
                gameOver = true;
                player.Image = Properties.Resources.playerDead;
                GameTimer.Stop();
            }

            txtAmmo.Text = "Патроны: " + ammo;
            txtScore.Text = "Убийства: " + score;

            if (goLeft == true && player.Left > 0)
            {
                player.Left -= speed;
            }

            if (goRight == true && player.Left + player.Width < this.ClientSize.Width)
            {
                player.Left += speed;
            }

            if (goUp == true && player.Top > 0)
            {
                player.Top -= speed;
            }

            if (goDown == true && player.Top + player.Height < this.ClientSize.Height)
            {
                player.Top += speed;
            }

            foreach (Control x in this.Controls)
            {
                if (x is PictureBox && (string)x.Tag == "ammo")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        ammo += 5;
                    }
                }

                if (x is PictureBox && (string)x.Tag == "health")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        this.Controls.Remove(x);
                        ((PictureBox)x).Dispose();
                        if (playerHealth < 80)
                        {
                            playerHealth += 20;
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "monster")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 1;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterLeft;
                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterRight;
                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterUp;
                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += monsterSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterDown;
                    }
                }

                foreach (Control j in this.Controls)
                {
                    if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "monster")
                    {
                        if (x.Bounds.IntersectsWith(j.Bounds))
                        {
                            score++;

                            this.Controls.Remove(j);
                            ((PictureBox)j).Dispose();
                            this.Controls.Remove(x);
                            ((PictureBox)x).Dispose();
                            monstersList.Remove((PictureBox)x);
                            MakeMonsters();
                        }
                    }
                }

                if (x is PictureBox && (string)x.Tag == "monsterStrong")
                {
                    if (player.Bounds.IntersectsWith(x.Bounds))
                    {
                        playerHealth -= 2;
                    }

                    if (x.Left > player.Left)
                    {
                        x.Left -= monsterStrongSpeed;
                        ((PictureBox)x).Image = Properties.Resources.MonsterStrongLeftt;

                    }

                    if (x.Left < player.Left)
                    {
                        x.Left += monsterStrongSpeed;
                        ((PictureBox)x).Image = Properties.Resources.MonsterStrongRightt;

                    }

                    if (x.Top > player.Top)
                    {
                        x.Top -= monsterStrongSpeed;
                        ((PictureBox)x).Image = Properties.Resources.monsterStrongUpp;

                    }

                    if (x.Top < player.Top)
                    {
                        x.Top += monsterStrongSpeed;
                        ((PictureBox)x).Image = Properties.Resources.MonsterStrongDownn;

                    }

                    foreach (Control j in this.Controls)
                    {
                        if (j is PictureBox && (string)j.Tag == "bullet" && x is PictureBox && (string)x.Tag == "monsterStrong")
                        {
                            if (x.Bounds.IntersectsWith(j.Bounds))
                            {
                                score++;

                                this.Controls.Remove(j);
                                ((PictureBox)j).Dispose();
                                this.Controls.Remove(x);
                                ((PictureBox)x).Dispose();
                                monstersListStrong.Remove((PictureBox)x);
                                MakeMonstersStrong();
                            }

                        }
                    }
                }
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (gameOver == true)
            {
                return;
            }

            if (e.KeyCode == Keys.A)
            {
                goLeft = true;
                facing = "left";
                player.Image = Properties.Resources.playerLeft;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = true;
                facing = "right";
                player.Image = Properties.Resources.PlayerRight;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = true;
                facing = "up";
                player.Image = Properties.Resources.playerUp;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = true;
                facing = "down";
                player.Image = Properties.Resources.playerDown;
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.A)
            {
                goLeft = false;
            }

            if (e.KeyCode == Keys.D)
            {
                goRight = false;
            }

            if (e.KeyCode == Keys.W)
            {
                goUp = false;
            }

            if (e.KeyCode == Keys.S)
            {
                goDown = false;
            }

            if (e.KeyCode == Keys.Space && ammo > 0 && gameOver == false)
            {
                ammo--;
                ShootBullet(facing);

                if (ammo < 1)
                {
                    DropAmmo();
                }
            }

            if (e.KeyCode == Keys.Enter && gameOver == true)
            {
                RestartGame();
            }
        }

        private void ShootBullet(string direction)
        {
            Bullet shootBullet = new Bullet();

            shootBullet.direction = direction;
            shootBullet.bulletLeft = player.Left + (player.Width / 2);
            shootBullet.bulletTop = player.Top + (player.Height / 2);
            shootBullet.MakeBullet(this);
        }
        private void MakeMonsters()
        {
            PictureBox monster = new PictureBox();
            monster.Tag = "monster";
            monster.Image = Properties.Resources.monsterDown;
            monster.Left = randNum.Next(0, 872);
            monster.Top = randNum.Next(0, 600);
            monster.SizeMode = PictureBoxSizeMode.AutoSize;
            monster.BackColor = Color.Transparent;
            monstersList.Add(monster);
            this.Controls.Add(monster);
            player.BringToFront();

        }
        private void MakeMonstersStrong()
        {
            PictureBox monsterStrong = new PictureBox();
            monsterStrong.Tag = "monsterStrong";
            monsterStrong.Image = Properties.Resources.MonsterStrongDownn;
            monsterStrong.Left = randNum.Next(0, 872);
            monsterStrong.Top = randNum.Next(0, 600);
            monsterStrong.SizeMode = PictureBoxSizeMode.AutoSize;
            monsterStrong.BackColor = Color.Transparent;
            monstersListStrong.Add(monsterStrong);
            this.Controls.Add(monsterStrong);
            player.BringToFront();

        }
        private void DropAmmo()
        {
            PictureBox ammo = new PictureBox();
            ammo.Image = Properties.Resources.Ammo;
            ammo.SizeMode = PictureBoxSizeMode.AutoSize;
            ammo.Left = randNum.Next(10, this.ClientSize.Width - ammo.Width);
            ammo.Top = randNum.Next(60, this.ClientSize.Height - ammo.Height);
            ammo.Tag = "ammo";
            this.Controls.Add(ammo);

            ammo.BringToFront();
            player.BringToFront();
        }
        private void DropHealth()
        {
            PictureBox health = new PictureBox();
            health.Image = Properties.Resources.Hp;
            health.SizeMode = PictureBoxSizeMode.AutoSize;
            health.Left = randNum.Next(10, this.ClientSize.Width - health.Width);
            health.Top = randNum.Next(60, this.ClientSize.Height - health.Height);
            health.Tag = "health";
            this.Controls.Add(health);

            health.BringToFront();
            player.BringToFront();
        }
        private void RestartGame()
        {
            player.Image = Properties.Resources.playerUp;

            foreach (PictureBox i in monstersList)
            {
                this.Controls.Remove(i);
            }

            foreach (PictureBox i in monstersListStrong)
            {
                this.Controls.Remove(i);
            }

            monstersList.Clear();
            monstersListStrong.Clear();

            for (int i = 0; i < 3; i++)
            {
                MakeMonsters();
            }

            for (int i = 0; i < 1; i++)
            {
                MakeMonstersStrong();
            }

            goUp = false;
            goDown = false;
            goLeft = false;
            goRight = false;
            gameOver = false;

            playerHealth = 100;
            score = 0;
            ammo = 10;

            GameTimer.Start();
        }
    }
}
