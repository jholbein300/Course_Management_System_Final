using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Course_Management_System_Final.Control;


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
            addClassView addCourseView = new addClassView();
            addCourseView.Show();
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