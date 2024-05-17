namespace NewGame
{
    partial class GameBossEasy
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.monsterHealthBar = new System.Windows.Forms.ProgressBar();
            this.playerHealthBar = new System.Windows.Forms.ProgressBar();
            this.player = new System.Windows.Forms.PictureBox();
            this.monster = new System.Windows.Forms.PictureBox();
            this.MonsterAttackTimer = new System.Windows.Forms.Timer(this.components);
            this.MonsterMoveTimer = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.player)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(64, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(106, 29);
            this.label1.TabIndex = 0;
            this.label1.Text = "Монстр";
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(693, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(87, 29);
            this.label2.TabIndex = 1;
            this.label2.Text = "Игрок";
            // 
            // monsterHealthBar
            // 
            this.monsterHealthBar.Location = new System.Drawing.Point(12, 41);
            this.monsterHealthBar.Name = "monsterHealthBar";
            this.monsterHealthBar.Size = new System.Drawing.Size(214, 34);
            this.monsterHealthBar.TabIndex = 2;
            // 
            // playerHealthBar
            // 
            this.playerHealthBar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.playerHealthBar.Location = new System.Drawing.Point(630, 41);
            this.playerHealthBar.Name = "playerHealthBar";
            this.playerHealthBar.Size = new System.Drawing.Size(214, 34);
            this.playerHealthBar.TabIndex = 3;
            // 
            // player
            // 
            this.player.BackColor = System.Drawing.Color.Transparent;
            this.player.Image = global::NewGame.Properties.Resources.PlayerStand;
            this.player.Location = new System.Drawing.Point(367, 338);
            this.player.Name = "player";
            this.player.Size = new System.Drawing.Size(100, 180);
            this.player.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.player.TabIndex = 4;
            this.player.TabStop = false;
            // 
            // monster
            // 
            this.monster.BackColor = System.Drawing.Color.Transparent;
            this.monster.Image = global::NewGame.Properties.Resources.MonsterStand;
            this.monster.Location = new System.Drawing.Point(463, 246);
            this.monster.Name = "monster";
            this.monster.Size = new System.Drawing.Size(110, 190);
            this.monster.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.monster.TabIndex = 5;
            this.monster.TabStop = false;
            // 
            // MonsterAttackTimer
            // 
            this.MonsterAttackTimer.Interval = 500;
            this.MonsterAttackTimer.Tick += new System.EventHandler(this.MonsterAttackTimerEvent);
            // 
            // MonsterMoveTimer
            // 
            this.MonsterMoveTimer.Interval = 20;
            this.MonsterMoveTimer.Tick += new System.EventHandler(this.MonsterMoveTimerEvent);
            // 
            // GameBossEasy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewGame.Properties.Resources.FonBoss;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.player);
            this.Controls.Add(this.playerHealthBar);
            this.Controls.Add(this.monsterHealthBar);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.monster);
            this.DoubleBuffered = true;
            this.Name = "GameBossEasy";
            this.Text = "GameBoss";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.KeyIsDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.KeyIsUp);
            ((System.ComponentModel.ISupportInitialize)(this.player)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.monster)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ProgressBar monsterHealthBar;
        private System.Windows.Forms.ProgressBar playerHealthBar;
        private System.Windows.Forms.PictureBox player;
        private System.Windows.Forms.PictureBox monster;
        private System.Windows.Forms.Timer MonsterAttackTimer;
        private System.Windows.Forms.Timer MonsterMoveTimer;
    }
}