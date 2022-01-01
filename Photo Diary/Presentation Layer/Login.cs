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
    public partial class Login : Form
    {
        public Login()
        {
            InitializeComponent();
        }

        private void Login_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void loginbutton_Click(object sender, EventArgs e)
        {
            LoginService loginService = new LoginService();
            int result = loginService.LoginValidation(usernametextBox.Text, passwordtextBox.Text);

            if (result != -1)
            {
                Dashboard dashboard = new Dashboard(result);
                this.Hide();
                dashboard.Show();
            }
            else
            {
                MessageBox.Show("Invalid username or password");
            }


        }

        private void usernametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void passwordtextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void backbutton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void Login_Load(object sender, EventArgs e)
        {

        }
    }
}
