namespace NewGame
{
    partial class GameMenu
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
            this.buttonStartEasyLevel = new System.Windows.Forms.Button();
            this.buttonHelp = new System.Windows.Forms.Button();
            this.buttonStartHardLevel = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // buttonStartEasyLevel
            // 
            this.buttonStartEasyLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartEasyLevel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStartEasyLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartEasyLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartEasyLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartEasyLevel.Location = new System.Drawing.Point(242, 176);
            this.buttonStartEasyLevel.Name = "buttonStartEasyLevel";
            this.buttonStartEasyLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStartEasyLevel.Size = new System.Drawing.Size(368, 58);
            this.buttonStartEasyLevel.TabIndex = 0;
            this.buttonStartEasyLevel.Text = "Начать легкий уровень";
            this.buttonStartEasyLevel.UseVisualStyleBackColor = false;
            this.buttonStartEasyLevel.Click += new System.EventHandler(this.LoadEasyLevel);
            // 
            // buttonHelp
            // 
            this.buttonHelp.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonHelp.BackColor = System.Drawing.Color.DarkGray;
            this.buttonHelp.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonHelp.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonHelp.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonHelp.Location = new System.Drawing.Point(242, 329);
            this.buttonHelp.Name = "buttonHelp";
            this.buttonHelp.Size = new System.Drawing.Size(368, 58);
            this.buttonHelp.TabIndex = 1;
            this.buttonHelp.Text = "Справка";
            this.buttonHelp.UseVisualStyleBackColor = false;
            this.buttonHelp.Click += new System.EventHandler(this.LoadHelp);
            // 
            // buttonStartHardLevel
            // 
            this.buttonStartHardLevel.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonStartHardLevel.BackColor = System.Drawing.Color.DarkGray;
            this.buttonStartHardLevel.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.buttonStartHardLevel.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonStartHardLevel.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonStartHardLevel.Location = new System.Drawing.Point(242, 253);
            this.buttonStartHardLevel.Name = "buttonStartHardLevel";
            this.buttonStartHardLevel.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.buttonStartHardLevel.Size = new System.Drawing.Size(368, 58);
            this.buttonStartHardLevel.TabIndex = 2;
            this.buttonStartHardLevel.Text = "Начать тяжелый уровень";
            this.buttonStartHardLevel.UseVisualStyleBackColor = false;
            this.buttonStartHardLevel.Click += new System.EventHandler(this.LoadHardLevel);
            // 
            // GameMenu
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::NewGame.Properties.Resources.FonMenu;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(856, 561);
            this.Controls.Add(this.buttonHelp);
            this.Controls.Add(this.buttonStartHardLevel);
            this.Controls.Add(this.buttonStartEasyLevel);
            this.DoubleBuffered = true;
            this.Name = "GameMenu";
            this.Text = "GameMenu";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button buttonStartEasyLevel;
        private System.Windows.Forms.Button buttonHelp;
        private System.Windows.Forms.Button buttonStartHardLevel;
    }
}