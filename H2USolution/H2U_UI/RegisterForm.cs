using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace H2U_UI
{
    public partial class registerForm : Form
    {
        public registerForm()
        {
            InitializeComponent();
        }

        private void registerForm_Load(object sender, EventArgs e)
        {

        }

        private void loginButton_Click(object sender, EventArgs e)
        {
            string username = userNameValue.Text;
            string password = userPasswordValue.Text;

            // we will validate our form here and check if the form matchup the database
            if (IsValid(username, password))
            {
                // Valid username and password
                MessageBox.Show("Login Successful!");
                this.Hide();

                healthGoalForm mainForm = new healthGoalForm();
                mainForm.Show();
               
            }
            else
            {
                
                // Invalid username or password, we will ask the user to create a profile for them
                DialogResult result = MessageBox.Show(
                    "Invalid username or password. Would you like to create a profile?",
                    "Error",
                    MessageBoxButtons.YesNo,
                    MessageBoxIcon.Error
                );

                if (result == DialogResult.Yes)
                {
                    // navigate to create a profile form
                    createProfileForm createProfileForm = new createProfileForm();
                    createProfileForm.Show();
                    this.Hide();
                }
                else
                {
                   
                }
            }
        }

        private bool IsValid(string username, string password)
        {
            // we will use if the login form has any invalid or null value and check with the database
            if (string.IsNullOrWhiteSpace(username) || string.IsNullOrWhiteSpace(password))
            {
                return false;
            }
            //database validation
            return true;
            ///database validation is also needed
        }


    }

}
