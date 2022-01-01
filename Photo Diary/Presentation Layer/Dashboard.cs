using PhotoDiary.Business_Logic_Layer;
using PhotoDiary.Data_Access_Layer.Entities;
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
    public partial class Dashboard : Form
    {
        public  int userId;
        public Dashboard()
        {
            InitializeComponent();
        }



        public Dashboard(int result)
        {
            InitializeComponent();
            userId=result;

        }

        private void addeventbutton_Click(object sender, EventArgs e)
        {
            AddEvent createEvent = new AddEvent(userId);
            this.Hide();
            createEvent.Show();
        }

        private void Dashboard_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'photoDiaryDataSet.events' table. You can move, or remove it, as needed.
            this.eventsTableAdapter.Fill(this.photoDiaryDataSet.events);
            EventService eventService = new EventService();
            List<Event> eventt=eventService.GetAllEvents(userId);
            //EventDataGridView.DataSource = eventService.GetAllEvents(userId);
            //EventDataGridView.ColumnCount = 2;
            //EventDataGridView.Columns[0].Name = "Title";
            //EventDataGridView.Columns[1].Name = "Description";
            

            //EventDataGridView.Rows.Add(new object[] {eventt[0].Title, eventt[0].Description});
            //EventDataGridView.Rows.Add(new object[] {eventt[1].Title, eventt[1].Description});


            DataTable dt = new DataTable();

            dt.Columns.Add("Event Id");
            dt.Columns.Add("Title");
            dt.Columns.Add("Description");
            dt.Columns.Add("Image Path");

            foreach (var item in eventt)
            {
                var row = dt.NewRow();

                row["Event Id"] = item.EventId;
                row["Title"] = item.Title;
                row["Description"] = item.Description;
                row["Image Path"] = item.Image;

                dt.Rows.Add(row);
            }
            EventDataGridView.AutoSizeColumnsMode =
        DataGridViewAutoSizeColumnsMode.Fill;

            EventDataGridView.RowTemplate.Height = 120;
           

            dt.Columns.Add("Image",Type.GetType("System.Byte[]"));

            foreach (DataRow drow in dt.Rows)
            {

                drow["Image"] = File.ReadAllBytes(drow["Image Path"].ToString());
            }
           EventDataGridView.DataSource = dt;




            //DataGridViewImageColumn imageColumn = new DataGridViewImageColumn();
            //imageColumn = (DataGridViewImageColumn)EventDataGridView.Columns[1];
            //imageColumn.ImageLayout = DataGridViewImageCellLayout.Stretch;


            //foreach (DataGridViewRow row1 in dt.Rows)
            //{
            //    string imgPath;
            //    imgPath = Path.Combine(Application.StartupPath, row1.Cells[0].Value.ToString());
            //    Image imageFile = Image.FromFile(imgPath);
            //    if (imgPath != null)
            //    {
            //        //img.Image=imgPath;
            //        row1.Cells[0].Value = imageFile;
            //    }
            //    else
            //    {
            //        MessageBox.Show("Invalid Path");
            //    }
            //}
           
        }

        private void deleteeventbutton_Click(object sender, EventArgs e)
        {
            DeleteEvent deleteEvent = new DeleteEvent(userId);
            this.Hide();
            deleteEvent.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void EventDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void Editbutton_Click(object sender, EventArgs e)
        {
            UpdateEvent editEvent = new UpdateEvent(userId);
            this.Hide();
            editEvent.Show();
        }

        private void EventDataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            string eventIdString = EventDataGridView.Rows[e.RowIndex].Cells[0].Value.ToString();
            int eventId = Convert.ToInt32(eventIdString);
            EventDetails eventDetails = new EventDetails(userId,eventId);

            this.Hide();
            eventDetails.Show();
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            UserProfile userProfile = new UserProfile(userId);
            this.Hide();
            userProfile.Show();
        }
    }
}
