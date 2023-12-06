using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Course_Management_System_Final
{
    public partial class addClassView : Form
    {
        public addClassView()
        {
            InitializeComponent();
            addClassButton.Click += addClassButton_Click;
        }
        public void addClassButton_Click(object sender, EventArgs e)
        {
            if (classList.SelectedItem != null)
            {
                string selectedValue = classList.SelectedItem.ToString();
                using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
                {
                    using (SQLiteCommand cmnd = new SQLiteCommand(@"data source =..\..\Data\cManDb.db;Version=3"))
                    {
                        @"BEGIN TRANSACTION; 
                        INSERT INTO ENROLLMENT (courseID, studentID) VALUES (1, 1);
                        COMMIT";
                    }
                }

            }
        }
    }
}