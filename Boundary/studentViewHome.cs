using System;
using System.Data.SqlClient;
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

        private string connectionString = "YourConnectionString";



        

        private void PopulateClassesListBox(string username)
        {
            // Clear existing items in the ListBox
            scheduleOfClasses.Items.Clear();

            try
            {
                using (SqlConnection connection = new SqlConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
                {
                    connection.Open();
                    string usn = DBConnector.SessionManager.Instance.LoggedInUsername;
                    usn = usn.GetHashCode().ToString();

                    // SQL query to retrieve classes for a given username
                    string query =
                        @"SELECT c.name FROM ACCOUNT a JOIN ENROLLMENT e ON a.accountID = e.studenttID JOIN COURSE c ON e.courseID = c.name WHERE a.username = usn ";

                    using (SqlCommand command = new SqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);

                        using (SqlDataReader reader = command.ExecuteReader())
                        {
                            // Iterate through the results and add them to the ListBox
                            while (reader.Read())
                            {
                                string className = reader["class_name"].ToString();
                                scheduleOfClasses.Items.Add(className);
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
    }
        
    }
