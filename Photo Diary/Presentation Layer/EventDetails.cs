using PhotoDiary.Business_Logic_Layer;
using PhotoDiary.Data_Access_Layer.Entities;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PhotoDiary.Presentation_Layer
{
    public partial class EventDetails : Form
    {
        private EventService es;
        private Event details;

        private int eventId;
        private int userId;
        public EventDetails()
        {
            InitializeComponent();
        }
        public EventDetails(int userId,int eventId)
        {
            InitializeComponent();
            this.userId = userId;
            this.eventId = eventId;
            es = new EventService();
            details = es.GetEvent(eventId);

            eventidtextBox.Text = details.EventId.ToString();
            detailspictureBox.Image = new Bitmap(details.Image);
            titletextBox.Text = details.Title;
            desciptiontextBox.Text = details.Description;
            importancetextBox.Text = details.Importance;

            datetextBox.Text = details.UploadTime;
            lastedittextBox.Text = details.EditTime;
            
            
        }

        private void EventDetails_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void EventDetails_Load(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

            
        }
        private void EventDetails_Click(object sender, EventArgs e)
        {

        }

        private void detailsbackbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();
        }

        private void eventidtextBox_TextChanged(object sender, EventArgs e)
        {
            
        }

        private void editbutton_Click(object sender, EventArgs e)
        {
            UpdateEvent editEvent = new UpdateEvent(userId,eventId);
            this.Hide();
            editEvent.Show();
        }

        private void deletebutton_Click(object sender, EventArgs e)
        {

            EventService eventService = new EventService();
            int result = eventService.DeleteEvent(eventId);
            if (result > 0)
            {
                MessageBox.Show("Event deleted successfully !!");

            }
            else
            {
                MessageBox.Show("Error in deleting.");
            }

            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();

        }

        private void desciptiontextBox_TextChanged(object sender, EventArgs e)
        {
        }
    }
}