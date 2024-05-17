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
    public partial class IntroductionHardLevel : Form
    {
        public IntroductionHardLevel()
        {
            InitializeComponent();
        }

        private void LoadHardLevel(object sender, EventArgs e)
        {
            this.Close();
            HardLevel gameWindow = new HardLevel();
            gameWindow.Show();
        }
    }
}
