﻿using System;
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

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

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
            if (txtbox_password.Text == "admin" && txtbox_username.Text == "admin" || txtbox_password.Text == "user" && txtbox_username.Text == "user")
            {
                new Game().Show();
                this.Hide();
            }

            else if (txtbox_username.Text == "" && txtbox_password.Text == "")
            {
                MessageBox.Show("Username or Password fields cannot be empty.");
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
    }
}
