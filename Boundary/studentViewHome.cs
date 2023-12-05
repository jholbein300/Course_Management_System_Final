using System;
using System.Windows.Forms;
using System.Data.SQLite;


namespace Course_Management_System_Final
{
    
    public partial class studentViewHome : Form
    {
        public studentViewHome()
        {
            InitializeComponent();
            addClassButton.Click += addClassButton_Click;
            logoutButton.Click += logoutButton_Click;
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            addCourseView addCourseView = new addCourseView();
            addCourseView.Show();
        }
        
        public void logoutButton_Click(object sender, EventArgs e)
        {
            this.Hide();
            //DBConnector.SaveLogin(loggedInUsn); when it is added to LoginController, it
            //will save the time of the logout event in the DB
            MessageBox.Show("You have successfully logged out!", "Logout Successful", MessageBoxButtons.OK);
            loginScreen loginScreen = new loginScreen();
            loginScreen.Show();
            
        }
    }
}