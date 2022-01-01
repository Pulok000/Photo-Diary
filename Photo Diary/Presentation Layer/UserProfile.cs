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
    public partial class UserProfile : Form
    {

        private int userId;
        private RegistrationService registrationService;
        private Registrations registration;
        public UserProfile()
        {
            InitializeComponent();
        }

        public UserProfile(int userId)
        {
            InitializeComponent();
            this. userId= userId;
            registrationService=new RegistrationService();
            registration=registrationService.GetUser(userId);

            nametextBox.Text = registration.Name;
            usernametextBox.Text = registration.Username;
            passwordtextBox.Text = registration.Password;
            emailtextBox.Text = registration.Email;
            dateofbirthtextBox.Text = registration.Dob;
            gendertextBox.Text = registration.Gender;


        }

        


        private void UserProfile_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void UserProfile_Load(object sender, EventArgs e)
        {

        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void dateofbirthtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Dashboard dashboard = new Dashboard(userId);
            this.Hide();
            dashboard.Show();
        }
    }
}
