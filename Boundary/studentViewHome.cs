using System;
using System.Windows.Forms;
using System.Data.SQLite;
using Course_Management_System_Final.Control;
using Course_Management_System_Final.Entity;
using System.Collections.Generic;

namespace Course_Management_System_Final
{
    
    public partial class studentViewHome : Form
    {
        private List<Course> classList;
        
        public studentViewHome(List<Course> classList)
        {
            InitializeComponent();
            this.classList = classList;
            addClassButton.Click += addClassButton_Click;
            logoutButton.Click += logoutButton_Click;

            if(classList != null && scheduleOfClasses is ListBox listBox)
            {
                foreach (Course course in classList)
                {
                    listBox.Items.Add(course.Name.ToString());
                }
            }
            
        }

        private void addClassButton_Click(object sender, EventArgs e)
        {
            this.Hide();
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