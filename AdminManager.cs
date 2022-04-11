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
    public partial class AdminManager : Form
    {
        public AdminManager()
        {
            InitializeComponent();
        }

        private void AdminManager_Load(object sender, EventArgs e)
        {

            RefreshPage();
        }

        public void RefreshPage()
        {

            SqlCommand commandList = new SqlCommand("Select * from User_Table", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            SqlDataAdapter da = new SqlDataAdapter(commandList);

            DataTable dt = new DataTable();

            da.Fill(dt);

            dataGridView1.DataSource = dt;

        }

        private void btn_adduser_Click(object sender, EventArgs e)
        {
            SqlCommand commandAdd = new SqlCommand("Insert into User_Table (Username,Password,[Name-Surname],[Phone Number],Address,City,Country,[E-mail]) values (@pusername,@ppassword,@pname,@pphone,@paddress,@pcity,@pcountry,@pemail)", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            string hashedPassword = Sha256Converter.ComputeSha256Hash(txtbox_addpass.Text);

            commandAdd.Parameters.AddWithValue("@pusername", txtbox_adduser.Text);
            commandAdd.Parameters.AddWithValue("@ppassword", hashedPassword);
            commandAdd.Parameters.AddWithValue("@pname", txtbox_addname.Text);
            commandAdd.Parameters.AddWithValue("@pphone", txtbox_addphone.Text);
            commandAdd.Parameters.AddWithValue("@paddress", txtbox_addaddress.Text);
            commandAdd.Parameters.AddWithValue("@pcity", txtbox_addcity.Text);
            commandAdd.Parameters.AddWithValue("@pcountry", txtbox_addcountry.Text);
            commandAdd.Parameters.AddWithValue("@pemail", txtbox_addemail.Text);

            commandAdd.ExecuteNonQuery();

            RefreshPage();
        }

        private void btn_deleteuser_Click(object sender, EventArgs e)
        {
            int selectedID = Convert.ToInt32(txtbox_deleteuser.Text);

            SqlCommand commandDelete = new SqlCommand("Delete from User_Table where UserID=@pid", SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            commandDelete.Parameters.AddWithValue("@pid", selectedID);

            commandDelete.ExecuteNonQuery();

            RefreshPage();
        }

        private void btn_edit_Click(object sender, EventArgs e)
        {
            SqlCommand commandEdit = new SqlCommand("Update User_Table set Username=@pusername , Password=@ppassword , [Name-Surname]=@pname , [Phone Number]=@pphone , Address=@paddress , City=@pcity , Country=@pcountry , [E-mail]=@pemail where UserID=@pid",SQLOperations.connection);

            SQLOperations.CheckConnection(SQLOperations.connection);

            string hashedPassword = Sha256Converter.ComputeSha256Hash(txtbox_editpass.Text);

            string selectedID = (dataGridView1.CurrentRow.Cells["UserID"].Value).ToString();

            commandEdit.Parameters.AddWithValue("@pusername", txtbox_edituser.Text);
            commandEdit.Parameters.AddWithValue("@ppassword", hashedPassword);
            commandEdit.Parameters.AddWithValue("@pname", txtbox_editname.Text);
            commandEdit.Parameters.AddWithValue("@pphone", txtbox_editphone.Text);
            commandEdit.Parameters.AddWithValue("@paddress", txtbox_editaddress.Text);
            commandEdit.Parameters.AddWithValue("@pcity", txtbox_editcity.Text);
            commandEdit.Parameters.AddWithValue("@pcountry", txtbox_editcountry.Text);
            commandEdit.Parameters.AddWithValue("@pemail", txtbox_editemail.Text);
            commandEdit.Parameters.AddWithValue("@pid", selectedID);

            commandEdit.ExecuteNonQuery();

            RefreshPage();
        }

        private void dataGridView1_SelectionChanged(object sender, EventArgs e)
        {
            string hashedPassword = Sha256Converter.ComputeSha256Hash((dataGridView1.CurrentRow.Cells["Password"].Value).ToString());


            txtbox_edituser.Text=(dataGridView1.CurrentRow.Cells["Username"].Value).ToString();
            txtbox_editpass.Text = hashedPassword;
            txtbox_editname.Text = (dataGridView1.CurrentRow.Cells["Name-Surname"].Value).ToString();
            txtbox_editphone.Text = (dataGridView1.CurrentRow.Cells["Phone Number"].Value).ToString();
            txtbox_editaddress.Text = (dataGridView1.CurrentRow.Cells["Address"].Value).ToString();
            txtbox_editcity.Text = (dataGridView1.CurrentRow.Cells["City"].Value).ToString();
            txtbox_editcountry.Text = (dataGridView1.CurrentRow.Cells["Country"].Value).ToString();
            txtbox_editemail.Text = (dataGridView1.CurrentRow.Cells["E-mail"].Value).ToString();

        }
    }
}
