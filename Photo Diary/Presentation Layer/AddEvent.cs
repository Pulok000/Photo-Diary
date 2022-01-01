using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using PhotoDiary.Business_Logic_Layer;
using PhotoDiary.Data_Access_Layer;

namespace PhotoDiary.Presentation_Layer
{
    public partial class AddEvent : Form
    {
        public  int userId;
        public AddEvent(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void CreateEvent_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }
        public static string imgAddr;

        private void button1_Click(object sender, EventArgs e)
        {
            OpenFileDialog open = new OpenFileDialog();
            open.Filter = "Image Files(*.jpeg;*.jpg;*.gif;*bmp;)|*.jpeg;*.jpg;*.gif;*bmp;";
            if (open.ShowDialog() == DialogResult.OK)
            {

                uploadimagetextBox.Text = open.FileName;
                pictureBox.Image = new Bitmap(open.FileName);
                //label2.Text = open.SafeFileName;


            }
        }

        private void submitbutton_Click(object sender, EventArgs e)
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



            File.Copy(uploadimagetextBox.Text, Path.Combine(@"C:\Users\admin\Desktop\OOP2 Final Assignment\OOP2\Final Assignment\Photo Diary\PhotoDiary\PhotoDiary\Uploads\", Path.GetFileName(uploadimagetextBox.Text)), true);

            imgAddr = Path.Combine(@"C:\Users\admin\Desktop\OOP2 Final Assignment\OOP2\Final Assignment\Photo Diary\PhotoDiary\PhotoDiary\Uploads\", Path.GetFileName(uploadimagetextBox.Text));

            EventService eventService = new EventService();
            int result = eventService.AddEvent(imgAddr, titletextBox.Text, descriptiontextBox.Text, importance, userId,uploadtimedateTimePicker.Text);

            if (result > 0)
            {
                MessageBox.Show("New Event added successfully !!");
                Dashboard dashboard = new Dashboard(userId);
                this.Hide();
                dashboard.Show();
                //UpdateListOfProducts();
            }
            else
            {
                MessageBox.Show("Error in adding.");
            }




        }

        private void addeventgroupBox_Enter(object sender, EventArgs e)
        {

        }

        private void addeventbackbutton_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();
        }

        private void AddEvent_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox_Click(object sender, EventArgs e)
        {

        }
    }
}
