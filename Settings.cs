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
using Prelab_1.SQLVariables;
using Prelab_1;

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
            SqlCommand commandEdit = new SqlCommand("Update User_Table set [Name-Surname]=@pname , [Phone Number]=@pphone , Address=@paddress , City=@pcity , Country=@pcountry , [E-mail]=@pemail where Username=@pusername", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            commandEdit.Parameters.AddWithValue("@pname", txtbox_name.Text);
            commandEdit.Parameters.AddWithValue("@pphone", txtbox_phnnumber.Text);
            commandEdit.Parameters.AddWithValue("@paddress", txtbox_address.Text);
            commandEdit.Parameters.AddWithValue("@pcity", txtbox_city.Text);
            commandEdit.Parameters.AddWithValue("@pcountry", txtbox_country.Text);
            commandEdit.Parameters.AddWithValue("@pemail", txtbox_email.Text);
            commandEdit.Parameters.AddWithValue("@pusername", Variables.loggedUsername);

            commandEdit.ExecuteNonQuery();

            refreshPage();

            this.Close();
        }

        public void refreshPage()
        {
            SqlCommand commandList = new SqlCommand("Select * from User_Table", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);

            commandList.ExecuteNonQuery();
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
            refreshPage();

            lbl_username.Text = $"Logged With: {Variables.loggedUsername}";
            txtbox_name.Text = Variables.loggedName;
            txtbox_phnnumber.Text = Variables.loggedPhone;
            txtbox_address.Text = Variables.loggedAddress;
            txtbox_city.Text = Variables.loggedCity;
            txtbox_country.Text = Variables.loggedCountry;
            txtbox_email.Text = Variables.loggedEmail;

            if(Variables.loggedUsername=="admin")
            {
                new AdminManager().Show();
            }

            checkbox_square.Checked = Properties.Settings.Default.checkbox_square;
            checkbox_triangle.Checked = Properties.Settings.Default.checkbox_triangle;
            checkbox_round.Checked = Properties.Settings.Default.checkbox_round;
            checkbox_easy.Checked = Properties.Settings.Default.checkbox_easy;
            checkbox_normal.Checked = Properties.Settings.Default.checkbox_normal;
            checkbox_hard.Checked = Properties.Settings.Default.checkbox_hard;
            checkbox_custom.Checked = Properties.Settings.Default.checkbox_custom;
            textbox_custom1.Text = Properties.Settings.Default.custom_textbox1;
            textbox_custom2.Text = Properties.Settings.Default.custom_textbox2;

            refreshPage();
        }

        private void Settings_FormClosing(object sender, FormClosingEventArgs e)
        {
            
            SqlCommand commandList = new SqlCommand("Select * from User_Table", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);


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

            refreshPage();
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

        private void btn_changepass_Click(object sender, EventArgs e)
        {

            string hashedPassword = Sha256Converter.ComputeSha256Hash(txtbox_oldpass.Text);
            
            if(hashedPassword == Variables.loggedPassword)
            {
                SqlCommand commandEdit = new SqlCommand("Update User_Table set Password=@ppassword where Username=@pusername", SQLOperations.connection);

                SQLOperations.CheckConnection(SQLOperations.connection);

                string hashPassword = Sha256Converter.ComputeSha256Hash(txtbox_newpass.Text);

                commandEdit.Parameters.AddWithValue("@ppassword", hashPassword);
                commandEdit.Parameters.AddWithValue("@pusername", Variables.loggedUsername);

                commandEdit.ExecuteNonQuery();

                MessageBox.Show("Password changed.");

                refreshPage();
            }

            else
            {
                MessageBox.Show("Password is incorrect.");
            }
        }
    }
}
