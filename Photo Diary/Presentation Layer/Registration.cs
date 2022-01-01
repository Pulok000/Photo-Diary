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
    public partial class Registration : Form
    {
        public Registration()
        {
            InitializeComponent();
        }

        private void Registration_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void submitbutton_Click(object sender, EventArgs e)
        {
            if (nametextBox.Text == "")
            {
                MessageBox.Show("Name cant be empty.");

            }
            else if (unametextBox.Text == "")
            {
                MessageBox.Show("UserName cant be empty.");

            }
            else if (passtextBox.Text == "")
            {
                MessageBox.Show("Password cant be empty.");

            }
            else if (cpasstextBox.Text == "")
            {
                MessageBox.Show("Confirm Password cant be empty.");

            }
            else if (emailtextBox.Text == "")
            {
                MessageBox.Show("Email cant be empty.");

            }
            else if (dateTimePicker.Text == "")
            {
                MessageBox.Show("Date Of Birth cant be empty.");

            }
            else if (maleradioButton.Checked == false && femaleradioButton.Checked == false)
            {
                MessageBox.Show("gender cant be empty.");

            }
            else
            {
                if (passtextBox.Text != cpasstextBox.Text)
                {
                    MessageBox.Show("Password and confirm password does not match.");

                }
                else
                {
                    string gender;

                    if(maleradioButton.Checked)
                    {
                        gender="male";
                    }
                    else
                    {
                        gender="Female";
                    }


                    RegistrationService registrationService = new RegistrationService();
                    int result = registrationService.AddNewUser(nametextBox.Text, unametextBox.Text, passtextBox.Text, emailtextBox.Text, dateTimePicker.Text, gender);
                    if (result > 0)
                    {
                        MessageBox.Show("User added successfully !!");
                        Home home = new Home();
                        this.Hide();
                        home.Show();

                        //UpdateListOfProducts();
                    }
                    else
                    {
                        MessageBox.Show("Error in Registration.");
                    }


                }

            }

        }

        private void termscheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (termscheckBox.Checked)
            {

                submitbutton.Enabled = true;
            }
            else
            {
                submitbutton.Enabled = false;

            }
        }

        private void nametextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void registrationbackbutton_Click(object sender, EventArgs e)
        {
            Home home = new Home();
            this.Hide();
            home.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
