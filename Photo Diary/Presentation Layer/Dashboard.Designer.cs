namespace PhotoDiary.Presentation_Layer
{
    partial class Dashboard
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
            this.components = new System.ComponentModel.Container();
            this.addeventbutton = new System.Windows.Forms.Button();
            this.EventDataGridView = new System.Windows.Forms.DataGridView();
            this.button2 = new System.Windows.Forms.Button();
            this.photoDiaryDataSet = new PhotoDiary.PhotoDiaryDataSet();
            this.eventsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.eventsTableAdapter = new PhotoDiary.PhotoDiaryDataSetTableAdapters.eventsTableAdapter();
            this.label1 = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDiaryDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // addeventbutton
            // 
            this.addeventbutton.Location = new System.Drawing.Point(426, 377);
            this.addeventbutton.Name = "addeventbutton";
            this.addeventbutton.Size = new System.Drawing.Size(113, 41);
            this.addeventbutton.TabIndex = 0;
            this.addeventbutton.Text = "Add Event";
            this.addeventbutton.UseVisualStyleBackColor = true;
            this.addeventbutton.Click += new System.EventHandler(this.addeventbutton_Click);
            // 
            // EventDataGridView
            // 
            this.EventDataGridView.AllowUserToAddRows = false;
            this.EventDataGridView.AllowUserToDeleteRows = false;
            this.EventDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.EventDataGridView.Location = new System.Drawing.Point(219, 96);
            this.EventDataGridView.Name = "EventDataGridView";
            this.EventDataGridView.ReadOnly = true;
            this.EventDataGridView.Size = new System.Drawing.Size(539, 275);
            this.EventDataGridView.TabIndex = 1;
            this.EventDataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridView_CellClick);
            this.EventDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.EventDataGridView_CellContentClick);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(12, 184);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(157, 71);
            this.button2.TabIndex = 4;
            this.button2.Text = "Log Out";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // photoDiaryDataSet
            // 
            this.photoDiaryDataSet.DataSetName = "PhotoDiaryDataSet";
            this.photoDiaryDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // eventsBindingSource
            // 
            this.eventsBindingSource.DataMember = "events";
            this.eventsBindingSource.DataSource = this.photoDiaryDataSet;
            // 
            // eventsTableAdapter
            // 
            this.eventsTableAdapter.ClearBeforeFill = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Algerian", 21.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(272, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(207, 32);
            this.label1.TabIndex = 5;
            this.label1.Text = "Photo Diary";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(12, 96);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(157, 71);
            this.button1.TabIndex = 6;
            this.button1.Text = "Profile";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(328, 453);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(467, 13);
            this.label2.TabIndex = 7;
            this.label2.Text = "*For Details,deleting event,make changes in event,select the particular event fro" +
    "m the above box.";
            // 
            // Dashboard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(796, 475);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.EventDataGridView);
            this.Controls.Add(this.addeventbutton);
            this.Name = "Dashboard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Dashboard";
            this.Load += new System.EventHandler(this.Dashboard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.EventDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoDiaryDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.eventsBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addeventbutton;
        private System.Windows.Forms.DataGridView EventDataGridView;
        private System.Windows.Forms.Button button2;
        private PhotoDiaryDataSet photoDiaryDataSet;
        private System.Windows.Forms.BindingSource eventsBindingSource;
        private PhotoDiaryDataSetTableAdapters.eventsTableAdapter eventsTableAdapter;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label2;
    }
}