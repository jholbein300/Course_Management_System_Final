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
            nextButton.Click += nextButton_Click;
        }


        
        public void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //DBConnector.SaveLogout(loggedInUsn);
            MessageBox.Show("You have successfully logged out!", "Logout Successful", MessageBoxButtons.OK);
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            
        }

        public void nextButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            removeStudentView removeStudentView = new removeStudentView();
            removeStudentView.Show();
        }
    }
}