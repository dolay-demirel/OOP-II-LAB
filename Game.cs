using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Prelab_1
{
    public partial class Game : Form
    {
        public Game()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btn_settings_Click(object sender, EventArgs e)
        {
            new Settings().Show();

            
        }

        private void btn_about_Click(object sender, EventArgs e)
        {
            new About().ShowDialog();
          
        }

        private void btn_play_Click(object sender, EventArgs e)
        {
            new Gameplay().Show();
        }
    }
}
