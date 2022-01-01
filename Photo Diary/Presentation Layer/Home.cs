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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void Home_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            Login login = new Login();
            this.Hide();
            login.Show();
        }

        private void registrationbutton_Click(object sender, EventArgs e)
        {
            Registration registration = new Registration();
            this.Hide();
            registration.Show();
        }

        private void Home_Load(object sender, EventArgs e)
        {

        }
    }
}
