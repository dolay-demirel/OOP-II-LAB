namespace Prelab_1
{
    partial class Gameplay
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
            this.btn_normal = new System.Windows.Forms.Button();
            this.btn_easy = new System.Windows.Forms.Button();
            this.btn_hard = new System.Windows.Forms.Button();
            this.btn_custom = new System.Windows.Forms.Button();
            this.txtbox_custom1 = new System.Windows.Forms.TextBox();
            this.txtbox_custom2 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // btn_normal
            // 
            this.btn_normal.Location = new System.Drawing.Point(123, 12);
            this.btn_normal.Name = "btn_normal";
            this.btn_normal.Size = new System.Drawing.Size(105, 23);
            this.btn_normal.TabIndex = 0;
            this.btn_normal.Text = "Intermediate";
            this.btn_normal.UseVisualStyleBackColor = true;
            this.btn_normal.Click += new System.EventHandler(this.btn_normal_Click);
            // 
            // btn_easy
            // 
            this.btn_easy.Location = new System.Drawing.Point(12, 11);
            this.btn_easy.Name = "btn_easy";
            this.btn_easy.Size = new System.Drawing.Size(105, 23);
            this.btn_easy.TabIndex = 2;
            this.btn_easy.Text = "Easy";
            this.btn_easy.UseVisualStyleBackColor = true;
            this.btn_easy.Click += new System.EventHandler(this.btn_easy_Click);
            // 
            // btn_hard
            // 
            this.btn_hard.Location = new System.Drawing.Point(234, 13);
            this.btn_hard.Name = "btn_hard";
            this.btn_hard.Size = new System.Drawing.Size(105, 23);
            this.btn_hard.TabIndex = 3;
            this.btn_hard.Text = "Hard";
            this.btn_hard.UseVisualStyleBackColor = true;
            this.btn_hard.Click += new System.EventHandler(this.btn_hard_Click);
            // 
            // btn_custom
            // 
            this.btn_custom.Location = new System.Drawing.Point(346, 13);
            this.btn_custom.Name = "btn_custom";
            this.btn_custom.Size = new System.Drawing.Size(105, 23);
            this.btn_custom.TabIndex = 4;
            this.btn_custom.Text = "Custom";
            this.btn_custom.UseVisualStyleBackColor = true;
            this.btn_custom.Click += new System.EventHandler(this.btn_custom_Click);
            // 
            // txtbox_custom1
            // 
            this.txtbox_custom1.Location = new System.Drawing.Point(458, 13);
            this.txtbox_custom1.Name = "txtbox_custom1";
            this.txtbox_custom1.Size = new System.Drawing.Size(100, 22);
            this.txtbox_custom1.TabIndex = 5;
            // 
            // txtbox_custom2
            // 
            this.txtbox_custom2.Location = new System.Drawing.Point(565, 13);
            this.txtbox_custom2.Name = "txtbox_custom2";
            this.txtbox_custom2.Size = new System.Drawing.Size(100, 22);
            this.txtbox_custom2.TabIndex = 6;
            // 
            // Gameplay
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1072, 788);
            this.Controls.Add(this.txtbox_custom2);
            this.Controls.Add(this.txtbox_custom1);
            this.Controls.Add(this.btn_custom);
            this.Controls.Add(this.btn_hard);
            this.Controls.Add(this.btn_easy);
            this.Controls.Add(this.btn_normal);
            this.Name = "Gameplay";
            this.Text = "Gameplay";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btn_normal;
        private System.Windows.Forms.Button btn_easy;
        private System.Windows.Forms.Button btn_hard;
        private System.Windows.Forms.Button btn_custom;
        private System.Windows.Forms.TextBox txtbox_custom1;
        private System.Windows.Forms.TextBox txtbox_custom2;
    }
}