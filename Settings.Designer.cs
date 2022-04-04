
namespace Prelab_1
{
    partial class Settings
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
            this.btn_exit = new System.Windows.Forms.Button();
            this.lbl_easy = new System.Windows.Forms.Label();
            this.lbl_normal = new System.Windows.Forms.Label();
            this.lbl_hard = new System.Windows.Forms.Label();
            this.checkbox_easy = new System.Windows.Forms.CheckBox();
            this.checkbox_normal = new System.Windows.Forms.CheckBox();
            this.checkbox_hard = new System.Windows.Forms.CheckBox();
            this.lbl_difficulty = new System.Windows.Forms.Label();
            this.lbl_shapes = new System.Windows.Forms.Label();
            this.lbl_square = new System.Windows.Forms.Label();
            this.lbl_triangle = new System.Windows.Forms.Label();
            this.lbl_round = new System.Windows.Forms.Label();
            this.checkbox_square = new System.Windows.Forms.CheckBox();
            this.checkbox_triangle = new System.Windows.Forms.CheckBox();
            this.checkbox_round = new System.Windows.Forms.CheckBox();
            this.lbl_custom = new System.Windows.Forms.Label();
            this.textbox_custom1 = new System.Windows.Forms.TextBox();
            this.textbox_custom2 = new System.Windows.Forms.TextBox();
            this.checkbox_custom = new System.Windows.Forms.CheckBox();
            this.SuspendLayout();
            // 
            // btn_exit
            // 
            this.btn_exit.Location = new System.Drawing.Point(306, 175);
            this.btn_exit.Name = "btn_exit";
            this.btn_exit.Size = new System.Drawing.Size(86, 30);
            this.btn_exit.TabIndex = 0;
            this.btn_exit.Text = "Save and Exit";
            this.btn_exit.UseVisualStyleBackColor = true;
            this.btn_exit.Click += new System.EventHandler(this.btn_exit_Click);
            // 
            // lbl_easy
            // 
            this.lbl_easy.AutoSize = true;
            this.lbl_easy.Location = new System.Drawing.Point(12, 45);
            this.lbl_easy.Name = "lbl_easy";
            this.lbl_easy.Size = new System.Drawing.Size(30, 13);
            this.lbl_easy.TabIndex = 1;
            this.lbl_easy.Text = "Easy";
            // 
            // lbl_normal
            // 
            this.lbl_normal.AutoSize = true;
            this.lbl_normal.Location = new System.Drawing.Point(92, 45);
            this.lbl_normal.Name = "lbl_normal";
            this.lbl_normal.Size = new System.Drawing.Size(40, 13);
            this.lbl_normal.TabIndex = 1;
            this.lbl_normal.Text = "Normal";
            // 
            // lbl_hard
            // 
            this.lbl_hard.AutoSize = true;
            this.lbl_hard.Location = new System.Drawing.Point(182, 45);
            this.lbl_hard.Name = "lbl_hard";
            this.lbl_hard.Size = new System.Drawing.Size(30, 13);
            this.lbl_hard.TabIndex = 1;
            this.lbl_hard.Text = "Hard";
            // 
            // checkbox_easy
            // 
            this.checkbox_easy.AutoSize = true;
            this.checkbox_easy.Location = new System.Drawing.Point(15, 61);
            this.checkbox_easy.Name = "checkbox_easy";
            this.checkbox_easy.Size = new System.Drawing.Size(15, 14);
            this.checkbox_easy.TabIndex = 2;
            this.checkbox_easy.UseVisualStyleBackColor = true;
            this.checkbox_easy.CheckedChanged += new System.EventHandler(this.checkbox_easy_CheckedChanged);
            // 
            // checkbox_normal
            // 
            this.checkbox_normal.AutoSize = true;
            this.checkbox_normal.Location = new System.Drawing.Point(95, 61);
            this.checkbox_normal.Name = "checkbox_normal";
            this.checkbox_normal.Size = new System.Drawing.Size(15, 14);
            this.checkbox_normal.TabIndex = 2;
            this.checkbox_normal.UseVisualStyleBackColor = true;
            this.checkbox_normal.CheckedChanged += new System.EventHandler(this.checkbox_normal_CheckedChanged);
            // 
            // checkbox_hard
            // 
            this.checkbox_hard.AutoSize = true;
            this.checkbox_hard.Location = new System.Drawing.Point(185, 61);
            this.checkbox_hard.Name = "checkbox_hard";
            this.checkbox_hard.Size = new System.Drawing.Size(15, 14);
            this.checkbox_hard.TabIndex = 2;
            this.checkbox_hard.UseVisualStyleBackColor = true;
            this.checkbox_hard.CheckedChanged += new System.EventHandler(this.checkbox_hard_CheckedChanged);
            // 
            // lbl_difficulty
            // 
            this.lbl_difficulty.AutoSize = true;
            this.lbl_difficulty.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_difficulty.Location = new System.Drawing.Point(12, 19);
            this.lbl_difficulty.Name = "lbl_difficulty";
            this.lbl_difficulty.Size = new System.Drawing.Size(67, 16);
            this.lbl_difficulty.TabIndex = 4;
            this.lbl_difficulty.Text = "Difficulty";
            // 
            // lbl_shapes
            // 
            this.lbl_shapes.AutoSize = true;
            this.lbl_shapes.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_shapes.Location = new System.Drawing.Point(12, 96);
            this.lbl_shapes.Name = "lbl_shapes";
            this.lbl_shapes.Size = new System.Drawing.Size(61, 16);
            this.lbl_shapes.TabIndex = 4;
            this.lbl_shapes.Text = "Shapes";
            // 
            // lbl_square
            // 
            this.lbl_square.AutoSize = true;
            this.lbl_square.Location = new System.Drawing.Point(12, 121);
            this.lbl_square.Name = "lbl_square";
            this.lbl_square.Size = new System.Drawing.Size(41, 13);
            this.lbl_square.TabIndex = 1;
            this.lbl_square.Text = "Square";
            // 
            // lbl_triangle
            // 
            this.lbl_triangle.AutoSize = true;
            this.lbl_triangle.Location = new System.Drawing.Point(92, 121);
            this.lbl_triangle.Name = "lbl_triangle";
            this.lbl_triangle.Size = new System.Drawing.Size(45, 13);
            this.lbl_triangle.TabIndex = 1;
            this.lbl_triangle.Text = "Triangle";
            // 
            // lbl_round
            // 
            this.lbl_round.AutoSize = true;
            this.lbl_round.Location = new System.Drawing.Point(182, 121);
            this.lbl_round.Name = "lbl_round";
            this.lbl_round.Size = new System.Drawing.Size(39, 13);
            this.lbl_round.TabIndex = 1;
            this.lbl_round.Text = "Round";
            // 
            // checkbox_square
            // 
            this.checkbox_square.AutoSize = true;
            this.checkbox_square.Location = new System.Drawing.Point(15, 137);
            this.checkbox_square.Name = "checkbox_square";
            this.checkbox_square.Size = new System.Drawing.Size(15, 14);
            this.checkbox_square.TabIndex = 2;
            this.checkbox_square.UseVisualStyleBackColor = true;
            // 
            // checkbox_triangle
            // 
            this.checkbox_triangle.AutoSize = true;
            this.checkbox_triangle.Location = new System.Drawing.Point(95, 137);
            this.checkbox_triangle.Name = "checkbox_triangle";
            this.checkbox_triangle.Size = new System.Drawing.Size(15, 14);
            this.checkbox_triangle.TabIndex = 2;
            this.checkbox_triangle.UseVisualStyleBackColor = true;
            // 
            // checkbox_round
            // 
            this.checkbox_round.AutoSize = true;
            this.checkbox_round.Location = new System.Drawing.Point(185, 137);
            this.checkbox_round.Name = "checkbox_round";
            this.checkbox_round.Size = new System.Drawing.Size(15, 14);
            this.checkbox_round.TabIndex = 2;
            this.checkbox_round.UseVisualStyleBackColor = true;
            // 
            // lbl_custom
            // 
            this.lbl_custom.AutoSize = true;
            this.lbl_custom.Location = new System.Drawing.Point(303, 45);
            this.lbl_custom.Name = "lbl_custom";
            this.lbl_custom.Size = new System.Drawing.Size(42, 13);
            this.lbl_custom.TabIndex = 1;
            this.lbl_custom.Text = "Custom";
            // 
            // textbox_custom1
            // 
            this.textbox_custom1.Location = new System.Drawing.Point(306, 81);
            this.textbox_custom1.Name = "textbox_custom1";
            this.textbox_custom1.Size = new System.Drawing.Size(39, 20);
            this.textbox_custom1.TabIndex = 5;
            this.textbox_custom1.Visible = false;
            this.textbox_custom1.TextChanged += new System.EventHandler(this.textbox_custom1_TextChanged);
            this.textbox_custom1.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_custom1_KeyPress);
            // 
            // textbox_custom2
            // 
            this.textbox_custom2.Location = new System.Drawing.Point(351, 81);
            this.textbox_custom2.Name = "textbox_custom2";
            this.textbox_custom2.Size = new System.Drawing.Size(39, 20);
            this.textbox_custom2.TabIndex = 5;
            this.textbox_custom2.Visible = false;
            this.textbox_custom2.TextChanged += new System.EventHandler(this.textbox_custom2_TextChanged);
            this.textbox_custom2.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textbox_custom2_KeyPress);
            // 
            // checkbox_custom
            // 
            this.checkbox_custom.AutoSize = true;
            this.checkbox_custom.Location = new System.Drawing.Point(306, 61);
            this.checkbox_custom.Name = "checkbox_custom";
            this.checkbox_custom.Size = new System.Drawing.Size(15, 14);
            this.checkbox_custom.TabIndex = 6;
            this.checkbox_custom.UseVisualStyleBackColor = true;
            this.checkbox_custom.CheckedChanged += new System.EventHandler(this.checkbox_custom_CheckedChanged);
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(404, 217);
            this.Controls.Add(this.checkbox_custom);
            this.Controls.Add(this.textbox_custom2);
            this.Controls.Add(this.textbox_custom1);
            this.Controls.Add(this.lbl_shapes);
            this.Controls.Add(this.lbl_difficulty);
            this.Controls.Add(this.checkbox_hard);
            this.Controls.Add(this.checkbox_normal);
            this.Controls.Add(this.checkbox_round);
            this.Controls.Add(this.checkbox_triangle);
            this.Controls.Add(this.checkbox_square);
            this.Controls.Add(this.checkbox_easy);
            this.Controls.Add(this.lbl_custom);
            this.Controls.Add(this.lbl_hard);
            this.Controls.Add(this.lbl_normal);
            this.Controls.Add(this.lbl_round);
            this.Controls.Add(this.lbl_triangle);
            this.Controls.Add(this.lbl_square);
            this.Controls.Add(this.lbl_easy);
            this.Controls.Add(this.btn_exit);
            this.Name = "Settings";
            this.Text = "Settings";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Settings_FormClosing);
            this.Load += new System.EventHandler(this.Settings_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_exit;
        private System.Windows.Forms.Label lbl_easy;
        private System.Windows.Forms.Label lbl_normal;
        private System.Windows.Forms.Label lbl_hard;
        private System.Windows.Forms.CheckBox checkbox_easy;
        private System.Windows.Forms.CheckBox checkbox_normal;
        private System.Windows.Forms.CheckBox checkbox_hard;
        private System.Windows.Forms.Label lbl_difficulty;
        private System.Windows.Forms.Label lbl_shapes;
        private System.Windows.Forms.Label lbl_square;
        private System.Windows.Forms.Label lbl_triangle;
        private System.Windows.Forms.Label lbl_round;
        private System.Windows.Forms.CheckBox checkbox_square;
        private System.Windows.Forms.CheckBox checkbox_triangle;
        private System.Windows.Forms.CheckBox checkbox_round;
        private System.Windows.Forms.Label lbl_custom;
        private System.Windows.Forms.TextBox textbox_custom1;
        private System.Windows.Forms.TextBox textbox_custom2;
        private System.Windows.Forms.CheckBox checkbox_custom;
    }
}