namespace PhotoDiary.Presentation_Layer
{
    partial class UserProfile
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
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.gendertextBox = new System.Windows.Forms.TextBox();
            this.dateofbirthtextBox = new System.Windows.Forms.TextBox();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.passwordtextBox = new System.Windows.Forms.TextBox();
            this.usernametextBox = new System.Windows.Forms.TextBox();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(38, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 148);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(56, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Password:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 97);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(63, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "User Name:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(41, 325);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(45, 13);
            this.label4.TabIndex = 3;
            this.label4.Text = "Gender:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(41, 203);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(35, 13);
            this.label5.TabIndex = 4;
            this.label5.Text = "Email:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(41, 259);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(69, 13);
            this.label6.TabIndex = 5;
            this.label6.Text = "Date of Birth:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Controls.Add(this.gendertextBox);
            this.groupBox1.Controls.Add(this.dateofbirthtextBox);
            this.groupBox1.Controls.Add(this.emailtextBox);
            this.groupBox1.Controls.Add(this.passwordtextBox);
            this.groupBox1.Controls.Add(this.usernametextBox);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Location = new System.Drawing.Point(32, 24);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(355, 415);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(134, 375);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "Back";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // gendertextBox
            // 
            this.gendertextBox.Enabled = false;
            this.gendertextBox.Location = new System.Drawing.Point(110, 322);
            this.gendertextBox.Name = "gendertextBox";
            this.gendertextBox.Size = new System.Drawing.Size(223, 20);
            this.gendertextBox.TabIndex = 11;
            // 
            // dateofbirthtextBox
            // 
            this.dateofbirthtextBox.Enabled = false;
            this.dateofbirthtextBox.Location = new System.Drawing.Point(110, 252);
            this.dateofbirthtextBox.Name = "dateofbirthtextBox";
            this.dateofbirthtextBox.Size = new System.Drawing.Size(223, 20);
            this.dateofbirthtextBox.TabIndex = 10;
            this.dateofbirthtextBox.TextChanged += new System.EventHandler(this.dateofbirthtextBox_TextChanged);
            // 
            // emailtextBox
            // 
            this.emailtextBox.Enabled = false;
            this.emailtextBox.Location = new System.Drawing.Point(110, 200);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(223, 20);
            this.emailtextBox.TabIndex = 9;
            // 
            // passwordtextBox
            // 
            this.passwordtextBox.Enabled = false;
            this.passwordtextBox.Location = new System.Drawing.Point(110, 148);
            this.passwordtextBox.Name = "passwordtextBox";
            this.passwordtextBox.Size = new System.Drawing.Size(223, 20);
            this.passwordtextBox.TabIndex = 8;
            // 
            // usernametextBox
            // 
            this.usernametextBox.Enabled = false;
            this.usernametextBox.Location = new System.Drawing.Point(110, 94);
            this.usernametextBox.Name = "usernametextBox";
            this.usernametextBox.Size = new System.Drawing.Size(223, 20);
            this.usernametextBox.TabIndex = 7;
            // 
            // nametextBox
            // 
            this.nametextBox.Enabled = false;
            this.nametextBox.Location = new System.Drawing.Point(110, 34);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(223, 20);
            this.nametextBox.TabIndex = 6;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // UserProfile
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(415, 476);
            this.Controls.Add(this.groupBox1);
            this.Name = "UserProfile";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "User Profile";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.UserProfile_FormClosing);
            this.Load += new System.EventHandler(this.UserProfile_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox gendertextBox;
        private System.Windows.Forms.TextBox dateofbirthtextBox;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.TextBox passwordtextBox;
        private System.Windows.Forms.TextBox usernametextBox;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Button button1;
    }
}