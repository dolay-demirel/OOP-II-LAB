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
        public List<Button> buttons = new List<Button>();


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


        }

        private void create()
        {

            for (int row = 0; row < X; row++)
            {
                for (int col = 0; col < Y; col++)
                {
                    Button btn = new Button();
                    btn.Text = "";
                    btn.Tag = Xname.ToString() + "." + Yname.ToString();
                    btn.Size = new Size(50, 50);
                    btn.Location = new Point(55 * (Xpos + 1), 55 * (Ypos + 1));
                    Ypos++;
                    Yname++;
                    Controls.Add(btn);
                    buttons.Add(btn);
                }
                Xpos++;
                Xname++;
                Ypos = 0;

            }

            Xpos = 0;
            Ypos = 0;
            Xname = 1;
            Yname = 1;

            for(int j = 0; j < 3; j++)
            {
                for(int k = 0; k < buttons.Count; k++)
                {
                    if (k == randomizer())
                    {
                        buttons[k].BackColor = Color.Red;
                    }
                }
            }


        }

        private int randomizer()
        {
            Random rnd = new Random();
            return rnd.Next(1, X * Y);
        }

        private void btn_normal_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            X = 9;
            Y = 9;

            create();

        }

        private void btn_easy_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            X = 15;
            Y = 15;

            create();
        }

        private void btn_hard_Click(object sender, EventArgs e)
        {
            this.Controls.Clear();
            this.InitializeComponent();

            X = 5;
            Y = 5;

            create();
        }

        private void btn_custom_Click(object sender, EventArgs e)
        {

            if (txtbox_custom1.Text != "" && txtbox_custom2.Text != "")
            {
                X = Int32.Parse(txtbox_custom1.Text);
                Y = Int32.Parse(txtbox_custom2.Text);
            }
            else
                MessageBox.Show("Custom Values are Empty!");

            this.Controls.Clear();
            this.InitializeComponent();


            create();
        }
    }
}