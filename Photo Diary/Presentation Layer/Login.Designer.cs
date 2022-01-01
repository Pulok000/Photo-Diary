namespace PhotoDiary.Presentation_Layer
{
    partial class Login
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
            this.logingroupBox = new System.Windows.Forms.GroupBox();
            this.loginbutton = new System.Windows.Forms.Button();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.passwordlabel = new System.Windows.Forms.Label();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.usernamelabel = new System.Windows.Forms.Label();
            this.backbutton = new System.Windows.Forms.Button();
            this.logingroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // logingroupBox
            // 
            this.logingroupBox.Controls.Add(this.loginbutton);
            this.logingroupBox.Controls.Add(this.passwordtextBox);
            this.logingroupBox.Controls.Add(this.passwordlabel);
            this.logingroupBox.Controls.Add(this.usernametextBox);
            this.logingroupBox.Controls.Add(this.usernamelabel);
            this.logingroupBox.Font = new System.Drawing.Font("Kalpurush", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logingroupBox.Location = new System.Drawing.Point(74, 69);
            this.logingroupBox.Name = "logingroupBox";
            this.logingroupBox.Size = new System.Drawing.Size(407, 270);
            this.logingroupBox.TabIndex = 0;
            this.logingroupBox.TabStop = false;
            this.logingroupBox.Text = "Login";
            this.logingroupBox.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // loginbutton
            // 
            this.loginbutton.Font = new System.Drawing.Font("Kalpurush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginbutton.Location = new System.Drawing.Point(155, 193);
            this.loginbutton.Name = "loginbutton";
            this.loginbutton.Size = new System.Drawing.Size(107, 41);
            this.loginbutton.TabIndex = 5;
            this.loginbutton.Text = "Login";
            this.loginbutton.UseVisualStyleBackColor = true;
            this.loginbutton.Click += new System.EventHandler(this.loginbutton_Click);
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordtextBox.Location = new System.Drawing.Point(168, 140);
            this.passwordtextBox.Multiline = true;
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.PasswordChar = '*';
            this.passwordtextBox.Size = new System.Drawing.Size(187, 27);
            this.passwordtextBox.TabIndex = 3;
            this.passwordtextBox.TextChanged += new System.EventHandler(this.passwordtextBox_TextChanged);
            // 
            // passwordlabel
            // 
            this.passwordlabel.AutoSize = true;
            this.passwordlabel.Font = new System.Drawing.Font("Kalpurush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordlabel.Location = new System.Drawing.Point(47, 140);
            this.passwordlabel.Name = "passwordlabel";
            this.passwordlabel.Size = new System.Drawing.Size(89, 27);
            this.passwordlabel.TabIndex = 2;
            this.passwordlabel.Text = "Password:";
            // 
            // usernametextBox
            // 
            this.usernametextBox.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernametextBox.Location = new System.Drawing.Point(168, 94);
            this.usernametextBox.Multiline = true;
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(187, 27);
            this.usernametextBox.TabIndex = 1;
            this.usernametextBox.TextChanged += new System.EventHandler(this.usernametextBox_TextChanged);
            // 
            // usernamelabel
            // 
            this.usernamelabel.AutoSize = true;
            this.usernamelabel.Font = new System.Drawing.Font("Kalpurush", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernamelabel.Location = new System.Drawing.Point(47, 94);
            this.usernamelabel.Name = "usernamelabel";
            this.usernamelabel.Size = new System.Drawing.Size(104, 27);
            this.usernamelabel.TabIndex = 0;
            this.usernamelabel.Text = "User Name:";
            // 
            // backbutton
            // 
            this.backbutton.Location = new System.Drawing.Point(463, 355);
            this.backbutton.Name = "backbutton";
            this.backbutton.Size = new System.Drawing.Size(90, 29);
            this.backbutton.TabIndex = 4;
            this.backbutton.Text = "Back";
            this.backbutton.UseVisualStyleBackColor = true;
            this.backbutton.Click += new System.EventHandler(this.backbutton_Click);
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(563, 405);
            this.Controls.Add(this.backbutton);
            this.Controls.Add(this.logingroupBox);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Login_FormClosing);
            this.Load += new System.EventHandler(this.Login_Load);
            this.logingroupBox.ResumeLayout(false);
            this.logingroupBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox logingroupBox;
        private System.Windows.Forms.Button loginbutton;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.Label passwordlabel;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.Label usernamelabel;
        private System.Windows.Forms.Button backbutton;
    }
}