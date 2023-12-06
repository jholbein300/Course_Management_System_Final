using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Course_Management_System_Final
{
    public partial class addClassView : Form
    {
        public static bool addedClass { get; private set; } // Declare as a class-level variable

        public addClassView()
        {
            InitializeComponent();
            addClassButton.Click += addClassButton_Click;
            addedClass = false; // Initialize the variable
        }

        public void addClassButton_Click(object sender, EventArgs e)
        {
            
            if (classList.SelectedItem != null)
            {
                string selectedValue = classList.SelectedItem.ToString();
                using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
                {
                    conn.Open(); // Open the connection

                    using (SQLiteCommand cmnd = new SQLiteCommand(@"BEGIN TRANSACTION; 
                                                     INSERT INTO ENROLLMENT (courseID, studentID) VALUES (2, 1);
                                                     COMMIT", conn))
                    {
                        cmnd.ExecuteNonQuery(); // Execute the SQL statement
                    }
                }

                
                
                

                

                
                this.Hide();
                addedClass = true;
                studentViewHome studentViewHome = new studentViewHome();
                studentViewHome.Show();
                

            }
        }
    }
}