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
    public partial class GameMenu : Form
    {
        public GameMenu()
        {
            InitializeComponent();

            buttonStartEasyLevel.FlatAppearance.BorderSize = 0;
            buttonStartEasyLevel.FlatStyle = FlatStyle.Flat;
            buttonStartHardLevel.FlatAppearance.BorderSize = 0;
            buttonStartHardLevel.FlatStyle = FlatStyle.Flat;
            buttonHelp.FlatAppearance.BorderSize = 0;
            buttonHelp.FlatStyle = FlatStyle.Flat;
        }

        private void LoadHelp(object sender, EventArgs e)
        {
            Help helpWindow = new Help();
            helpWindow.Show();
        }

        private void LoadEasyLevel(object sender, EventArgs e)
        {
            IntroductionEasyLevel gameWindow = new IntroductionEasyLevel();
            gameWindow.Show();
        }

        private void LoadHardLevel(object sender, EventArgs e)
        {
            IntroductionHardLevel gameWindow = new IntroductionHardLevel();
            gameWindow.Show();
        }
    }
}
