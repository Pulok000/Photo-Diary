﻿namespace PhotoDiary.Presentation_Layer
{
    partial class Home
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
            this.label1 = new System.Windows.Forms.Label();
            this.loginbutton = new System.Windows.Forms.Button();
            this.registrationbutton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(170, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 0;
            this.label1.Text = "Photo Diary";
            // 
            // loginbutton
            // 
            this.loginbutton.Location = new System.Drawing.Point(156, 120);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(240, 56);
            this.loginbutton.TabIndex = 1;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // registrationbutton
            // 
            this.registrationbutton.Location = new System.Drawing.Point(156, 195);
            this.registrationbutton.Name = "registrationbutton";
            this.registrationbutton.Size = new System.Drawing.Size(240, 54);
            this.registrationbutton.TabIndex = 2;
            this.registrationbutton.Text = "Registration";
            this.registrationbutton.UseVisualStyleBackColor = true;
            this.registrationbutton.Click += new System.EventHandler(this.registrationbutton_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(573, 364);
            this.Controls.Add(this.registrationbutton);
            this.Controls.Add(this.loginbutton);
            this.Controls.Add(this.label1);
            this.Name = "Home";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Home";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Home_FormClosing);
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.Button registrationbutton;
    }
}