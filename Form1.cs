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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            txtbox_username.Text = Properties.Settings.Default.remember_username;
        }

        private void txtbox_username_TextChanged(object sender, EventArgs e)
        {

        }

        private void lbl_password_Click(object sender, EventArgs e)
        {

        }

        private void btn_cancel_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void txtbox_password_TextChanged(object sender, EventArgs e)
        {
            txtbox_password.PasswordChar = '*';
        }

        private void btn_login_Click(object sender, EventArgs e)
        {

            SqlCommand loginCommand = new SqlCommand("Select * from User_Table where Username=@pusername and Password=@ppassword",SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            string hashedPassword = Sha256Converter.ComputeSha256Hash(txtbox_password.Text);

            loginCommand.Parameters.AddWithValue("@pusername", txtbox_username.Text);
            loginCommand.Parameters.AddWithValue("@ppassword", hashedPassword);

            SqlDataAdapter da = new SqlDataAdapter(loginCommand);

            DataTable dt = new DataTable();

            da.Fill(dt);

            if(dt.Rows.Count > 0)
            {
                Variables.loggedUsername = dt.Rows[0]["Username"].ToString();
                Variables.loggedPassword = dt.Rows[0]["Password"].ToString();
                Variables.loggedName = dt.Rows[0]["Name-Surname"].ToString();
                Variables.loggedPhone = dt.Rows[0]["Phone Number"].ToString();
                Variables.loggedAddress = dt.Rows[0]["Address"].ToString();
                Variables.loggedCity = dt.Rows[0]["City"].ToString();
                Variables.loggedCountry = dt.Rows[0]["Country"].ToString();
                Variables.loggedEmail = dt.Rows[0]["E-mail"].ToString();
                Variables.loggedID = Convert.ToInt32(dt.Rows[0]["UserID"]);


                new Game().Show();
                this.Hide();
            }

            else
            {
                MessageBox.Show("Username or Password is incorrect.");
                txtbox_username.Clear();
                txtbox_password.Clear();
                txtbox_username.Focus();
            }

        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                btn_login.PerformClick();
            }
        }

        private void txtbox_username_KeyPress(object sender, KeyPressEventArgs e)
        {
            if ((!char.IsLetter(e.KeyChar)) && (!char.IsControl(e.KeyChar)))
            {
                e.Handled = true;
            }
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            Properties.Settings.Default.remember_username = txtbox_username.Text;

            Properties.Settings.Default.Save();
        }

        private void checkbox_showpass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkbox_showpass.Checked)
            {
                txtbox_password.PasswordChar = '\0';
            }

            else
            {
                txtbox_password.PasswordChar = '*';
            }
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            new Register().Show();
        }
    }
}
