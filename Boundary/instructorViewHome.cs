using System;
using System.Windows.Forms;

namespace Course_Management_System_Final
{
    public partial class instructorViewHome : Form
    {
        public instructorViewHome()
        {
            InitializeComponent();
            logoutButton.Click += logoutButton_Click;

        }


        
        public void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //DBConnector.SaveLogout(loggedInUsn);
            MessageBox.Show("You have successfully logged out!", "Logout Successful", MessageBoxButtons.OK);
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            
        }
    }
}