using PhotoDiary.Business_Logic_Layer;
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
    public partial class DeleteEvent : Form
    {

        public int userId;
        public DeleteEvent()
        {
            InitializeComponent();
        }

        public DeleteEvent(int userId )
        {
            InitializeComponent();
            this.userId=userId;
        }

        private void DeleteEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void deleteeventButton_Click(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            int result = eventService.DeleteEvent(Convert.ToInt32(deleteeventidTextBox.Text));
            if (result > 0)
            {
                MessageBox.Show("Event deleted successfully !!");
                //Dashboard dashboard = new Dashboard(userId);
                //this.Hide();
                //dashboard.Show();
                //UpdateListofCategories();
            }
            else
            {
                MessageBox.Show("Error in deleting.");
            }
        }

        private void deletebackbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();
        }

        private void DeleteEvent_Load(object sender, EventArgs e)
        {
            EventService eventService = new EventService();
            EventDataGridView.DataSource = eventService.GetAllEvents(userId);
        }
    }
}
