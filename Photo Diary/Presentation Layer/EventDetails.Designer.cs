namespace PhotoDiary.Presentation_Layer
{
    partial class EventDetails
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
            this.detailspictureBox = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.eventidtextBox = new System.Windows.Forms.TextBox();
            this.lastedittextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.titletextBox = new System.Windows.Forms.TextBox();
            this.desciptiontextBox = new System.Windows.Forms.TextBox();
            this.detailsbackbutton = new System.Windows.Forms.Button();
            this.editbutton = new System.Windows.Forms.Button();
            this.deletebutton = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.datetextBox = new System.Windows.Forms.TextBox();
            this.importancetextBox = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.detailspictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(35, 144);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(50, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Event Id:";
            // 
            // detailspictureBox
            // 
            this.detailspictureBox.Location = new System.Drawing.Point(38, 22);
            this.detailspictureBox.Name = "detailspictureBox";
            this.detailspictureBox.Size = new System.Drawing.Size(155, 104);
            this.detailspictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.detailspictureBox.TabIndex = 1;
            this.detailspictureBox.TabStop = false;
            this.detailspictureBox.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(214, 141);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(63, 13);
            this.label2.TabIndex = 2;
            this.label2.Text = "Last Edited:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(35, 179);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 3;
            this.label3.Text = "Title:";
            // 
            // eventidtextBox
            // 
            this.eventidtextBox.Enabled = false;
            this.eventidtextBox.Location = new System.Drawing.Point(91, 141);
            this.eventidtextBox.Name = "eventidtextBox";
            this.eventidtextBox.Size = new System.Drawing.Size(100, 20);
            this.eventidtextBox.TabIndex = 4;
            this.eventidtextBox.TextChanged += new System.EventHandler(this.eventidtextBox_TextChanged);
            // 
            // lastedittextBox
            // 
            this.lastedittextBox.Enabled = false;
            this.lastedittextBox.Location = new System.Drawing.Point(283, 141);
            this.lastedittextBox.Name = "lastedittextBox";
            this.lastedittextBox.Size = new System.Drawing.Size(123, 20);
            this.lastedittextBox.TabIndex = 5;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(35, 217);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 13);
            this.label4.TabIndex = 6;
            this.label4.Text = "Description:";
            // 
            // titletextBox
            // 
            this.titletextBox.Enabled = false;
            this.titletextBox.Location = new System.Drawing.Point(91, 176);
            this.titletextBox.Name = "titletextBox";
            this.titletextBox.Size = new System.Drawing.Size(315, 20);
            this.titletextBox.TabIndex = 7;
            // 
            // desciptiontextBox
            // 
            this.desciptiontextBox.Enabled = false;
            this.desciptiontextBox.Location = new System.Drawing.Point(38, 250);
            this.desciptiontextBox.Multiline = true;
            this.desciptiontextBox.Name = "desciptiontextBox";
            this.desciptiontextBox.Size = new System.Drawing.Size(368, 140);
            this.desciptiontextBox.TabIndex = 8;
            this.desciptiontextBox.TextChanged += new System.EventHandler(this.desciptiontextBox_TextChanged);
            // 
            // detailsbackbutton
            // 
            this.detailsbackbutton.Location = new System.Drawing.Point(174, 468);
            this.detailsbackbutton.Name = "detailsbackbutton";
            this.detailsbackbutton.Size = new System.Drawing.Size(75, 23);
            this.detailsbackbutton.TabIndex = 9;
            this.detailsbackbutton.Text = "Back";
            this.detailsbackbutton.UseVisualStyleBackColor = true;
            this.detailsbackbutton.Click += new System.EventHandler(this.detailsbackbutton_Click);
            // 
            // editbutton
            // 
            this.editbutton.Location = new System.Drawing.Point(58, 409);
            this.editbutton.Name = "editbutton";
            this.editbutton.Size = new System.Drawing.Size(133, 36);
            this.editbutton.TabIndex = 10;
            this.editbutton.Text = "Edit";
            this.editbutton.UseVisualStyleBackColor = true;
            this.editbutton.Click += new System.EventHandler(this.editbutton_Click);
            // 
            // deletebutton
            // 
            this.deletebutton.Location = new System.Drawing.Point(235, 409);
            this.deletebutton.Name = "deletebutton";
            this.deletebutton.Size = new System.Drawing.Size(137, 36);
            this.deletebutton.TabIndex = 11;
            this.deletebutton.Text = "Delete";
            this.deletebutton.UseVisualStyleBackColor = true;
            this.deletebutton.Click += new System.EventHandler(this.deletebutton_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(214, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Date:";
            // 
            // datetextBox
            // 
            this.datetextBox.Enabled = false;
            this.datetextBox.Location = new System.Drawing.Point(283, 100);
            this.datetextBox.Name = "datetextBox";
            this.datetextBox.Size = new System.Drawing.Size(123, 20);
            this.datetextBox.TabIndex = 13;
            // 
            // importancetextBox
            // 
            this.importancetextBox.Enabled = false;
            this.importancetextBox.Location = new System.Drawing.Point(283, 57);
            this.importancetextBox.Name = "importancetextBox";
            this.importancetextBox.Size = new System.Drawing.Size(123, 20);
            this.importancetextBox.TabIndex = 14;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(214, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 15;
            this.label6.Text = "Importance";
            // 
            // EventDetails
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Window;
            this.ClientSize = new System.Drawing.Size(443, 520);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.importancetextBox);
            this.Controls.Add(this.datetextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.deletebutton);
            this.Controls.Add(this.editbutton);
            this.Controls.Add(this.detailsbackbutton);
            this.Controls.Add(this.desciptiontextBox);
            this.Controls.Add(this.titletextBox);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.lastedittextBox);
            this.Controls.Add(this.eventidtextBox);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.detailspictureBox);
            this.Controls.Add(this.label1);
            this.Name = "EventDetails";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Details";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.EventDetails_FormClosing);
            this.Load += new System.EventHandler(this.EventDetails_Load);
            this.Click += new System.EventHandler(this.EventDetails_Click);
            ((System.ComponentModel.ISupportInitialize)(this.detailspictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.PictureBox detailspictureBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox eventidtextBox;
        private System.Windows.Forms.TextBox lastedittextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox titletextBox;
        private System.Windows.Forms.TextBox desciptiontextBox;
        private System.Windows.Forms.Button detailsbackbutton;
        private System.Windows.Forms.Button editbutton;
        private System.Windows.Forms.Button deletebutton;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox datetextBox;
        private System.Windows.Forms.TextBox importancetextBox;
        private System.Windows.Forms.Label label6;
    }
}