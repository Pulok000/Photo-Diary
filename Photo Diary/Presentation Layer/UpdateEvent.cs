using PhotoDiary.Business_Logic_Layer;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary.Presentation_Layer
{
    public partial class UpdateEvent : Form
    {
        private int userId;
        private int eventId;
        public static string imgAddr;
        public UpdateEvent()
        {
            InitializeComponent();
        }

        public UpdateEvent(int userId, int eventId)
        {
            InitializeComponent();
            this.userId = userId;
            this.eventId = eventId;
        }

        public UpdateEvent(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        
        }

        private void UpdateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }


        private void updatebutton_Click(object sender, EventArgs e)
        {

            string importance;
            if (highadioButton.Checked)
            {
                importance = "High";
            }
            else if (maleradioButton.Checked)
            {
                importance = "Moderate";
            }
            else
            {
                importance = "Less Important";
            }

            DateTime aDate = DateTime.Now; 
            string editTime=aDate.ToString("MM/dd/yyyy hh:mm tt");

            File.Copy(updateimagetextBox.Text, Path.Combine(@"C:\Users\admin\Desktop\OOP2 Final Assignment\OOP2\Final Assignment\Photo Diary\PhotoDiary\PhotoDiary\Uploads\", Path.GetFileName(updateimagetextBox.Text)), true);

            imgAddr = Path.Combine(@"C:\Users\admin\Desktop\OOP2 Final Assignment\OOP2\Final Assignment\Photo Diary\PhotoDiary\PhotoDiary\Uploads\", Path.GetFileName(updateimagetextBox.Text));

            EventService eventService = new EventService();
            int result = eventService.UpdateEvent(imgAddr, titletextBox.Text, descriptiontextBox.Text, importance, userId, uploadtimedateTimePicker.Text,editTime, eventId);

            if (result > 0)
            {
                MessageBox.Show("New Event added successfully !!");
                Dashboard dashboard = new Dashboard(userId);
                this.Hide();
                dashboard.Show();
               // UpdateListOfEvents();
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.jpg;*.gif;*bmp;)|*.jpeg;*.jpg;*.gif;*bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                updateimagetextBox.Text = open.FileName;
                pictureBox.Image = new Bitmap(open.FileName);
                //label2.Text = open.SafeFileName;


            }
        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void addeventbackbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();
        }

        private void UpdateEvent_Load(object sender, EventArgs e)
        {

        }
    }
}
