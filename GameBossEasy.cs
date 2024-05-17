using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NewGame
{
    public partial class GameBossEasy : Form
    {
        bool playerBlock = false;
        bool monsterBlock = false;
        List<string> monsterAttacks = new List<string> { "left", "right", "block" };
        Random random = new Random();
        int monsterSpeed = 5;
        int index = 0;
        bool monsterBlocked;
        int playerHealth = 150;
        int monsterHealth = 100;
        public GameBossEasy()
        {
            InitializeComponent();
            RestartGame();
        }

        private void MonsterAttackTimerEvent(object sender, EventArgs e)
        {
            index = random.Next(0, monsterAttacks.Count);

            switch (monsterAttacks[index].ToString())
            {
                case "left":
                    monster.Image = Properties.Resources.MonsterPunchLeft;
                    monsterBlock = false;
                    if (monster.Bounds.IntersectsWith(player.Bounds) && !playerBlock)
                    {
                        playerHealth -= 5;
                    }
                    break;

                case "right":
                    monster.Image = Properties.Resources.MonsterPunchRight;
                    monsterBlock = false;
                    if (monster.Bounds.IntersectsWith(player.Bounds) && !playerBlock)
                    {

                        playerHealth -= 5;
                    }
                    break;

                case "block":
                    monster.Image = Properties.Resources.MonsterBlock;
                    monsterBlock = true;
                    break;
            }
        }

        private void MonsterMoveTimerEvent(object sender, EventArgs e)
        {
            if (playerHealth > 1)
            {
                playerHealthBar.Value = playerHealth;
            }
            if (monsterHealth > 1)
            {
                monsterHealthBar.Value = monsterHealth;
            }

            monster.Left += monsterSpeed;

            if (monster.Left > 500)
            {
                monsterSpeed = -5;
            }
            if (monster.Left < 220)
            {
                monsterSpeed = 5;
            }
            if (monsterHealth < 1)
            {
                MonsterAttackTimer.Stop();
                MonsterMoveTimer.Stop();

                MessageBox.Show("Победа! Монстры улетели с нашей планеты! Нажмите ОК чтобы сыграть еще раз");
                LoadGameMenu();
            }
            if (playerHealth < 1)
            {
                MonsterAttackTimer.Stop();
                MonsterMoveTimer.Stop();

                MessageBox.Show("Монстр вас одолел! Нажмите ОК чтобы попробовать еще раз");
                LoadGameMenu();
            }
        }

        private void KeyIsDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.S)
            {
                player.Image = Properties.Resources.PlayerBlock;
                playerBlock = true;
            }
            if (e.KeyCode == Keys.A)
            {
                player.Image = Properties.Resources.PlayerLeftPunch;
                playerBlock = false;
                if (player.Bounds.IntersectsWith(monster.Bounds) && !monsterBlocked)
                {
                    monsterHealth -= 5;
                }
            }
            if (e.KeyCode == Keys.D)
            {
                player.Image = Properties.Resources.PlayerRightPunch;
                playerBlock = false;
                if (player.Bounds.IntersectsWith(monster.Bounds) && !monsterBlocked)
                {
                    monsterHealth -= 5;
                }
            }
        }

        private void KeyIsUp(object sender, KeyEventArgs e)
        {
            monster.Image = Properties.Resources.MonsterStand;
            playerBlock = false;
        }

        private void RestartGame()
        {
            MonsterAttackTimer.Start();
            MonsterMoveTimer.Start();
            monster.Left = 463;
            monster.Top = 246;
            monster.Image = Properties.Resources.MonsterStand;
            player.Image = Properties.Resources.PlayerStand;
            playerHealth = 100;
            monsterHealth = 100;
        }

        private void LoadGameMenu()
        {
            this.Close();
        }
    }
}
