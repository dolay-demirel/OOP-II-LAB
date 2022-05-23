using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Prelab_1;

namespace Prelab_1
{
    public partial class Gameplay : Form
    {

        public int X = 0;
        public int Y = 0;
        public int Xpos = 0;
        public int Ypos = 0;
        public int Xname = 1;
        public int Yname = 1;

        Settings stngs = new Settings();
        public int difficulty;
        public Gameplay()
        {
            InitializeComponent();
        }

        private void Gameplay_Load(object sender, EventArgs e)
        {

            int X = 9;
            int Y = 9;
            

            for(int row=0; row<X; row++)
            {
                for(int col=0; col<Y; col++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.Name = Xname.ToString() + "." + Yname.ToString();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(55*(Xpos+1),55*(Ypos+1));
                    Ypos++;
                    Yname++;
                    Controls.Add(btn);
                }
                Xpos++;
                Xname++;
                Ypos = 0;
            }


        }
    }
}
