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
    public partial class IntroductionEasyLevel : Form
    {
        public IntroductionEasyLevel()
        {
            InitializeComponent();
        }

        private void LoadEasyLevel(object sender, EventArgs e)
        {
            this.Close();
            EasyLevel gameWindow = new EasyLevel();
            gameWindow.Show();
        }
    }
}
