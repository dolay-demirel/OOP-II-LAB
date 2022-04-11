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
    public partial class Register : Form
    {
        public Register()
        {
            InitializeComponent();
        }

        private void btn_register_Click(object sender, EventArgs e)
        {
            SqlCommand commandRegister = new SqlCommand("Insert into User_Table (Username,Password,[Name-Surname],[Phone Number],Address,City,Country,[E-mail]) values (@pusername,@ppassword,@pname,@pphone,@paddress,@pcity,@pcountry,@pemail)",SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            string hashedPassword = Sha256Converter.ComputeSha256Hash(txtbox_password.Text);

            commandRegister.Parameters.AddWithValue("@pusername", txtbox_username.Text);
            commandRegister.Parameters.AddWithValue("@ppassword", hashedPassword);
            commandRegister.Parameters.AddWithValue("@pname", txtbox_name.Text);
            commandRegister.Parameters.AddWithValue("@pphone", txtbox_phnnumber.Text);
            commandRegister.Parameters.AddWithValue("@paddress", txtbox_address.Text);
            commandRegister.Parameters.AddWithValue("@pcity", txtbox_city.Text);
            commandRegister.Parameters.AddWithValue("@pcountry", txtbox_country.Text);
            commandRegister.Parameters.AddWithValue("@pemail", txtbox_email.Text);

            commandRegister.ExecuteNonQuery();

            MessageBox.Show("Successfully registered.");
            this.Close();
        }
    }
}
