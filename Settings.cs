using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace Prelab_1
{
    public partial class Settings : Form
    {

        public Settings()
        {
            InitializeComponent();
        }

        private void btn_exit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btn_save_Click(object sender, EventArgs e)
        {

        }

        private void checkbox_easy_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_easy.Checked)
            {
                checkbox_normal.Checked = false;
                checkbox_hard.Checked = false;
                checkbox_custom.Checked = false;
                textbox_custom1.Clear();
                textbox_custom2.Clear();
            }
        }

        private void checkbox_normal_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_normal.Checked)
            {
                checkbox_easy.Checked = false;
                checkbox_hard.Checked = false;
                checkbox_custom.Checked = false;
                textbox_custom1.Clear();
                textbox_custom2.Clear();
            }
        }

        private void checkbox_hard_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_hard.Checked)
            {
                checkbox_easy.Checked = false;
                checkbox_normal.Checked = false;
                checkbox_custom.Checked = false;
                textbox_custom1.Clear();
                textbox_custom2.Clear();
            }
        }

        private void textbox_custom1_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void textbox_custom2_TextChanged(object sender, EventArgs e)
        {
           
        }

        private void Settings_Load(object sender, EventArgs e)
        {
            checkbox_square.Checked = Properties.Settings.Default.checkbox_square;
            checkbox_triangle.Checked = Properties.Settings.Default.checkbox_triangle;
            checkbox_round.Checked = Properties.Settings.Default.checkbox_round;
            checkbox_easy.Checked = Properties.Settings.Default.checkbox_easy;
            checkbox_normal.Checked = Properties.Settings.Default.checkbox_normal;
            checkbox_hard.Checked = Properties.Settings.Default.checkbox_hard;
            checkbox_custom.Checked = Properties.Settings.Default.checkbox_custom;
            textbox_custom1.Text = Properties.Settings.Default.custom_textbox1;
            textbox_custom2.Text = Properties.Settings.Default.custom_textbox2;
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.checkbox_square = checkbox_square.Checked;
            Properties.Settings.Default.checkbox_triangle = checkbox_triangle.Checked;
            Properties.Settings.Default.checkbox_round = checkbox_round.Checked;
            Properties.Settings.Default.checkbox_easy = checkbox_easy.Checked;
            Properties.Settings.Default.checkbox_normal = checkbox_normal.Checked;
            Properties.Settings.Default.checkbox_hard = checkbox_hard.Checked;
            Properties.Settings.Default.checkbox_custom = checkbox_custom.Checked;
            Properties.Settings.Default.custom_textbox1 = textbox_custom1.Text;
            Properties.Settings.Default.custom_textbox2 = textbox_custom2.Text;

            Properties.Settings.Default.Save();
        }

        private void textbox_custom1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
            
        }

        private void textbox_custom2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsNumber(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }

        }

        private void checkbox_custom_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_custom.Checked)
            {
                checkbox_easy.Checked = false;
                checkbox_normal.Checked = false;
                checkbox_hard.Checked = false;
                textbox_custom1.Visible = true;
                textbox_custom2.Visible = true;
            }

            else
            {
                textbox_custom1.Visible = false;
                textbox_custom2.Visible = false;
            }
        }
    }
}
