namespace PhotoDiary.Presentation_Layer
{
    partial class DeleteEvent
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
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.deleteeventButton = new System.Windows.Forms.Button();
            this.deleteeventidTextBox = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.deletebackbutton = new System.Windows.Forms.Button();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.groupBox4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.deleteeventButton);
            this.groupBox4.Controls.Add(this.deleteeventidTextBox);
            this.groupBox4.Controls.Add(this.label4);
            this.groupBox4.Font = new System.Drawing.Font("Mongolian Baiti", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox4.Location = new System.Drawing.Point(35, 121);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(278, 109);
            this.groupBox4.TabIndex = 4;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Delete Event";
            // 
            // deleteeventButton
            // 
            this.deleteeventButton.Location = new System.Drawing.Point(117, 65);
            this.deleteeventButton.Name = "deleteeventButton";
            this.deleteeventButton.Size = new System.Drawing.Size(146, 31);
            this.deleteeventButton.TabIndex = 2;
            this.deleteeventButton.Text = "Delete";
            this.deleteeventButton.UseVisualStyleBackColor = true;
            this.deleteeventButton.Click += new System.EventHandler(this.deleteeventButton_Click);
            // 
            // deleteeventidTextBox
            // 
            this.deleteeventidTextBox.Location = new System.Drawing.Point(117, 25);
            this.deleteeventidTextBox.Name = "deleteeventidTextBox";
            this.deleteeventidTextBox.Size = new System.Drawing.Size(146, 21);
            this.deleteeventidTextBox.TabIndex = 1;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(20, 28);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 14);
            this.label4.TabIndex = 0;
            this.label4.Text = "Event Id";
            // 
            // deletebackbutton
            // 
            this.deletebackbutton.Location = new System.Drawing.Point(687, 315);
            this.deletebackbutton.Name = "deletebackbutton";
            this.deletebackbutton.Size = new System.Drawing.Size(75, 23);
            this.deletebackbutton.TabIndex = 5;
            this.deletebackbutton.Text = "Back";
            this.deletebackbutton.UseVisualStyleBackColor = true;
            this.deletebackbutton.Click += new System.EventHandler(this.deletebackbutton_Click);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(321, 17);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.Size = new System.Drawing.Size(441, 292);
            this.EventDataGridView.TabIndex = 6;
            // 
            // DeleteEvent
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(774, 350);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.deletebackbutton);
            this.Controls.Add(this.groupBox4);
            this.Name = "DeleteEvent";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "DeleteEvent";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.DeleteEvent_FormClosing);
            this.Load += new System.EventHandler(this.DeleteEvent_Load);
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button deleteeventButton;
        private System.Windows.Forms.TextBox deleteeventidTextBox;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button deletebackbutton;
        private System.Windows.Forms.DataGridView EventDataGridView;
    }
}