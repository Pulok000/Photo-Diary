namespace PhotoDiary.Presentation_Layer
{
    partial class Registration
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.submitbutton = new System.Windows.Forms.Button();
            this.termscheckBox = new System.Windows.Forms.CheckBox();
            this.femaleradioButton = new System.Windows.Forms.RadioButton();
            this.maleradioButton = new System.Windows.Forms.RadioButton();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.passtextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.cpasstextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.emailtextBox = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.unametextBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.nametextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.registrationbackbutton = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.submitbutton);
            this.groupBox1.Controls.Add(this.termscheckBox);
            this.groupBox1.Controls.Add(this.femaleradioButton);
            this.groupBox1.Controls.Add(this.maleradioButton);
            this.groupBox1.Controls.Add(this.dateTimePicker);
            this.groupBox1.Controls.Add(this.label7);
            this.groupBox1.Controls.Add(this.label6);
            this.groupBox1.Controls.Add(this.passtextBox);
            this.groupBox1.Controls.Add(this.label5);
            this.groupBox1.Controls.Add(this.cpasstextBox);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.emailtextBox);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.unametextBox);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.nametextBox);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Font = new System.Drawing.Font("Arial Narrow", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(74, 42);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(454, 373);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "User Registration";
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // submitbutton
            // 
            this.submitbutton.Enabled = false;
            this.submitbutton.Location = new System.Drawing.Point(188, 323);
            this.submitbutton.Name = "submitbutton";
            this.submitbutton.Size = new System.Drawing.Size(90, 26);
            this.submitbutton.TabIndex = 19;
            this.submitbutton.Text = "Submit";
            this.submitbutton.UseVisualStyleBackColor = true;
            this.submitbutton.Click += new System.EventHandler(this.submitbutton_Click);
            // 
            // termscheckBox
            // 
            this.termscheckBox.AutoSize = true;
            this.termscheckBox.Location = new System.Drawing.Point(28, 283);
            this.termscheckBox.Name = "termscheckBox";
            this.termscheckBox.Size = new System.Drawing.Size(287, 24);
            this.termscheckBox.TabIndex = 18;
            this.termscheckBox.Text = "I have checked all the terms and conditions";
            this.termscheckBox.UseVisualStyleBackColor = true;
            this.termscheckBox.CheckedChanged += new System.EventHandler(this.termscheckBox_CheckedChanged);
            // 
            // femaleradioButton
            // 
            this.femaleradioButton.AutoSize = true;
            this.femaleradioButton.Location = new System.Drawing.Point(298, 232);
            this.femaleradioButton.Name = "femaleradioButton";
            this.femaleradioButton.Size = new System.Drawing.Size(72, 24);
            this.femaleradioButton.TabIndex = 15;
            this.femaleradioButton.TabStop = true;
            this.femaleradioButton.Text = "Female";
            this.femaleradioButton.UseVisualStyleBackColor = true;
            // 
            // maleradioButton
            // 
            this.maleradioButton.AutoSize = true;
            this.maleradioButton.Location = new System.Drawing.Point(191, 232);
            this.maleradioButton.Name = "maleradioButton";
            this.maleradioButton.Size = new System.Drawing.Size(56, 24);
            this.maleradioButton.TabIndex = 14;
            this.maleradioButton.TabStop = true;
            this.maleradioButton.Text = "Male";
            this.maleradioButton.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(191, 200);
            this.dateTimePicker.MaxDate = new System.DateTime(2015, 12, 31, 0, 0, 0, 0);
            this.dateTimePicker.MinDate = new System.DateTime(1890, 1, 1, 0, 0, 0, 0);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(200, 26);
            this.dateTimePicker.TabIndex = 13;
            this.dateTimePicker.Value = new System.DateTime(2005, 12, 31, 0, 0, 0, 0);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(24, 231);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(58, 20);
            this.label7.TabIndex = 12;
            this.label7.Text = "Gender:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(24, 205);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Date Of Birth:";
            // 
            // passtextBox
            // 
            this.passtextBox.Location = new System.Drawing.Point(191, 97);
            this.passtextBox.Name = "passtextBox";
            this.passtextBox.PasswordChar = '*';
            this.passtextBox.Size = new System.Drawing.Size(229, 26);
            this.passtextBox.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(24, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(72, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Password:";
            // 
            // cpasstextBox
            // 
            this.cpasstextBox.Location = new System.Drawing.Point(191, 129);
            this.cpasstextBox.Name = "cpasstextBox";
            this.cpasstextBox.PasswordChar = '*';
            this.cpasstextBox.Size = new System.Drawing.Size(229, 26);
            this.cpasstextBox.TabIndex = 7;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(24, 135);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(121, 20);
            this.label4.TabIndex = 6;
            this.label4.Text = "Confirm Password:";
            // 
            // emailtextBox
            // 
            this.emailtextBox.Location = new System.Drawing.Point(191, 161);
            this.emailtextBox.Name = "emailtextBox";
            this.emailtextBox.Size = new System.Drawing.Size(229, 26);
            this.emailtextBox.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 167);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 20);
            this.label3.TabIndex = 4;
            this.label3.Text = "Email:";
            // 
            // unametextBox
            // 
            this.unametextBox.Location = new System.Drawing.Point(191, 65);
            this.unametextBox.Name = "unametextBox";
            this.unametextBox.Size = new System.Drawing.Size(229, 26);
            this.unametextBox.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(24, 71);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 20);
            this.label2.TabIndex = 2;
            this.label2.Text = "User Name:";
            // 
            // nametextBox
            // 
            this.nametextBox.Location = new System.Drawing.Point(191, 35);
            this.nametextBox.Name = "nametextBox";
            this.nametextBox.Size = new System.Drawing.Size(229, 26);
            this.nametextBox.TabIndex = 1;
            this.nametextBox.TextChanged += new System.EventHandler(this.nametextBox_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Name:";
            // 
            // registrationbackbutton
            // 
            this.registrationbackbutton.Location = new System.Drawing.Point(478, 416);
            this.registrationbackbutton.Name = "registrationbackbutton";
            this.registrationbackbutton.Size = new System.Drawing.Size(90, 29);
            this.registrationbackbutton.TabIndex = 20;
            this.registrationbackbutton.Text = "Back";
            this.registrationbackbutton.UseVisualStyleBackColor = true;
            this.registrationbackbutton.Click += new System.EventHandler(this.registrationbackbutton_Click);
            // 
            // Registration
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(598, 457);
            this.Controls.Add(this.registrationbackbutton);
            this.Controls.Add(this.groupBox1);
            this.Name = "Registration";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registration";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Registration_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button submitbutton;
        private System.Windows.Forms.CheckBox termscheckBox;
        private System.Windows.Forms.RadioButton femaleradioButton;
        private System.Windows.Forms.RadioButton maleradioButton;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox passtextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox cpasstextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox emailtextBox;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox unametextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox nametextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button registrationbackbutton;
    }
}