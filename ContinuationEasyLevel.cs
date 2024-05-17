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
    public partial class ContinuationEasyLevel : Form
    {
        public ContinuationEasyLevel()
        {
            InitializeComponent();
        }

        private void LoadBossEasyLevel(object sender, EventArgs e)
        {
            this.Close();
            GameBossEasy gameBossWindow = new GameBossEasy();
            gameBossWindow.Show();
        }
    }
}
