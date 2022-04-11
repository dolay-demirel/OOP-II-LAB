namespace Prelab_1
{
    partial class AdminManager
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtbox_adduser = new System.Windows.Forms.TextBox();
            this.txtbox_addpass = new System.Windows.Forms.TextBox();
            this.txtbox_addname = new System.Windows.Forms.TextBox();
            this.txtbox_addphone = new System.Windows.Forms.TextBox();
            this.txtbox_addaddress = new System.Windows.Forms.TextBox();
            this.txtbox_addcity = new System.Windows.Forms.TextBox();
            this.txtbox_addcountry = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtbox_deleteuser = new System.Windows.Forms.TextBox();
            this.btn_deleteuser = new System.Windows.Forms.Button();
            this.btn_adduser = new System.Windows.Forms.Button();
            this.txtbox_addemail = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtbox_edituser = new System.Windows.Forms.TextBox();
            this.txtbox_editpass = new System.Windows.Forms.TextBox();
            this.txtbox_editname = new System.Windows.Forms.TextBox();
            this.txtbox_editphone = new System.Windows.Forms.TextBox();
            this.txtbox_editaddress = new System.Windows.Forms.TextBox();
            this.txtbox_editcity = new System.Windows.Forms.TextBox();
            this.txtbox_editcountry = new System.Windows.Forms.TextBox();
            this.txtbox_editemail = new System.Windows.Forms.TextBox();
            this.btn_edit = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(13, 13);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(1162, 279);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.SelectionChanged += new System.EventHandler(this.dataGridView1_SelectionChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 310);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 16);
            this.label1.TabIndex = 1;
            this.label1.Text = "Add New User";
            // 
            // txtbox_adduser
            // 
            this.txtbox_adduser.Location = new System.Drawing.Point(13, 330);
            this.txtbox_adduser.Name = "txtbox_adduser";
            this.txtbox_adduser.Size = new System.Drawing.Size(334, 22);
            this.txtbox_adduser.TabIndex = 2;
            // 
            // txtbox_addpass
            // 
            this.txtbox_addpass.Location = new System.Drawing.Point(13, 359);
            this.txtbox_addpass.Name = "txtbox_addpass";
            this.txtbox_addpass.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addpass.TabIndex = 3;
            // 
            // txtbox_addname
            // 
            this.txtbox_addname.Location = new System.Drawing.Point(13, 388);
            this.txtbox_addname.Name = "txtbox_addname";
            this.txtbox_addname.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addname.TabIndex = 4;
            // 
            // txtbox_addphone
            // 
            this.txtbox_addphone.Location = new System.Drawing.Point(13, 417);
            this.txtbox_addphone.Name = "txtbox_addphone";
            this.txtbox_addphone.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addphone.TabIndex = 5;
            // 
            // txtbox_addaddress
            // 
            this.txtbox_addaddress.Location = new System.Drawing.Point(13, 446);
            this.txtbox_addaddress.Name = "txtbox_addaddress";
            this.txtbox_addaddress.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addaddress.TabIndex = 6;
            // 
            // txtbox_addcity
            // 
            this.txtbox_addcity.Location = new System.Drawing.Point(13, 475);
            this.txtbox_addcity.Name = "txtbox_addcity";
            this.txtbox_addcity.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addcity.TabIndex = 7;
            // 
            // txtbox_addcountry
            // 
            this.txtbox_addcountry.Location = new System.Drawing.Point(13, 504);
            this.txtbox_addcountry.Name = "txtbox_addcountry";
            this.txtbox_addcountry.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addcountry.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(397, 310);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(79, 16);
            this.label2.TabIndex = 9;
            this.label2.Text = "Delete User";
            // 
            // txtbox_deleteuser
            // 
            this.txtbox_deleteuser.Location = new System.Drawing.Point(400, 330);
            this.txtbox_deleteuser.Name = "txtbox_deleteuser";
            this.txtbox_deleteuser.Size = new System.Drawing.Size(334, 22);
            this.txtbox_deleteuser.TabIndex = 10;
            // 
            // btn_deleteuser
            // 
            this.btn_deleteuser.Location = new System.Drawing.Point(400, 357);
            this.btn_deleteuser.Name = "btn_deleteuser";
            this.btn_deleteuser.Size = new System.Drawing.Size(75, 23);
            this.btn_deleteuser.TabIndex = 11;
            this.btn_deleteuser.Text = "Delete";
            this.btn_deleteuser.UseVisualStyleBackColor = true;
            this.btn_deleteuser.Click += new System.EventHandler(this.btn_deleteuser_Click);
            // 
            // btn_adduser
            // 
            this.btn_adduser.Location = new System.Drawing.Point(12, 561);
            this.btn_adduser.Name = "btn_adduser";
            this.btn_adduser.Size = new System.Drawing.Size(75, 23);
            this.btn_adduser.TabIndex = 12;
            this.btn_adduser.Text = "Add";
            this.btn_adduser.UseVisualStyleBackColor = true;
            this.btn_adduser.Click += new System.EventHandler(this.btn_adduser_Click);
            // 
            // txtbox_addemail
            // 
            this.txtbox_addemail.Location = new System.Drawing.Point(13, 533);
            this.txtbox_addemail.Name = "txtbox_addemail";
            this.txtbox_addemail.Size = new System.Drawing.Size(334, 22);
            this.txtbox_addemail.TabIndex = 13;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 310);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(62, 16);
            this.label3.TabIndex = 1;
            this.label3.Text = "Edit User";
            // 
            // txtbox_edituser
            // 
            this.txtbox_edituser.Location = new System.Drawing.Point(770, 330);
            this.txtbox_edituser.Name = "txtbox_edituser";
            this.txtbox_edituser.Size = new System.Drawing.Size(334, 22);
            this.txtbox_edituser.TabIndex = 2;
            // 
            // txtbox_editpass
            // 
            this.txtbox_editpass.Location = new System.Drawing.Point(770, 359);
            this.txtbox_editpass.Name = "txtbox_editpass";
            this.txtbox_editpass.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editpass.TabIndex = 3;
            // 
            // txtbox_editname
            // 
            this.txtbox_editname.Location = new System.Drawing.Point(770, 388);
            this.txtbox_editname.Name = "txtbox_editname";
            this.txtbox_editname.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editname.TabIndex = 4;
            // 
            // txtbox_editphone
            // 
            this.txtbox_editphone.Location = new System.Drawing.Point(770, 417);
            this.txtbox_editphone.Name = "txtbox_editphone";
            this.txtbox_editphone.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editphone.TabIndex = 5;
            // 
            // txtbox_editaddress
            // 
            this.txtbox_editaddress.Location = new System.Drawing.Point(770, 446);
            this.txtbox_editaddress.Name = "txtbox_editaddress";
            this.txtbox_editaddress.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editaddress.TabIndex = 6;
            // 
            // txtbox_editcity
            // 
            this.txtbox_editcity.Location = new System.Drawing.Point(770, 475);
            this.txtbox_editcity.Name = "txtbox_editcity";
            this.txtbox_editcity.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editcity.TabIndex = 7;
            // 
            // txtbox_editcountry
            // 
            this.txtbox_editcountry.Location = new System.Drawing.Point(770, 504);
            this.txtbox_editcountry.Name = "txtbox_editcountry";
            this.txtbox_editcountry.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editcountry.TabIndex = 8;
            // 
            // txtbox_editemail
            // 
            this.txtbox_editemail.Location = new System.Drawing.Point(770, 533);
            this.txtbox_editemail.Name = "txtbox_editemail";
            this.txtbox_editemail.Size = new System.Drawing.Size(334, 22);
            this.txtbox_editemail.TabIndex = 13;
            // 
            // btn_edit
            // 
            this.btn_edit.Location = new System.Drawing.Point(770, 561);
            this.btn_edit.Name = "btn_edit";
            this.btn_edit.Size = new System.Drawing.Size(75, 23);
            this.btn_edit.TabIndex = 14;
            this.btn_edit.Text = "Edit";
            this.btn_edit.UseVisualStyleBackColor = true;
            this.btn_edit.Click += new System.EventHandler(this.btn_edit_Click);
            // 
            // AdminManager
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1187, 593);
            this.Controls.Add(this.btn_edit);
            this.Controls.Add(this.txtbox_editemail);
            this.Controls.Add(this.txtbox_addemail);
            this.Controls.Add(this.btn_adduser);
            this.Controls.Add(this.btn_deleteuser);
            this.Controls.Add(this.txtbox_deleteuser);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtbox_editcountry);
            this.Controls.Add(this.txtbox_editcity);
            this.Controls.Add(this.txtbox_addcountry);
            this.Controls.Add(this.txtbox_editaddress);
            this.Controls.Add(this.txtbox_addcity);
            this.Controls.Add(this.txtbox_editphone);
            this.Controls.Add(this.txtbox_addaddress);
            this.Controls.Add(this.txtbox_editname);
            this.Controls.Add(this.txtbox_addphone);
            this.Controls.Add(this.txtbox_editpass);
            this.Controls.Add(this.txtbox_addname);
            this.Controls.Add(this.txtbox_edituser);
            this.Controls.Add(this.txtbox_addpass);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtbox_adduser);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dataGridView1);
            this.Name = "AdminManager";
            this.Text = "AdminManager";
            this.Load += new System.EventHandler(this.AdminManager_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtbox_adduser;
        private System.Windows.Forms.TextBox txtbox_addpass;
        private System.Windows.Forms.TextBox txtbox_addname;
        private System.Windows.Forms.TextBox txtbox_addphone;
        private System.Windows.Forms.TextBox txtbox_addaddress;
        private System.Windows.Forms.TextBox txtbox_addcity;
        private System.Windows.Forms.TextBox txtbox_addcountry;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtbox_deleteuser;
        private System.Windows.Forms.Button btn_deleteuser;
        private System.Windows.Forms.Button btn_adduser;
        private System.Windows.Forms.TextBox txtbox_addemail;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtbox_edituser;
        private System.Windows.Forms.TextBox txtbox_editpass;
        private System.Windows.Forms.TextBox txtbox_editname;
        private System.Windows.Forms.TextBox txtbox_editphone;
        private System.Windows.Forms.TextBox txtbox_editaddress;
        private System.Windows.Forms.TextBox txtbox_editcity;
        private System.Windows.Forms.TextBox txtbox_editcountry;
        private System.Windows.Forms.TextBox txtbox_editemail;
        private System.Windows.Forms.Button btn_edit;
    }
}