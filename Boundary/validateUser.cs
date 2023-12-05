// AuthenticationHelper.cs

using System;
using System.Data.SQLite;
using System.Windows.Forms;

namespace Course_Management_System_Final
{
    public class AuthenticationHelper
    {
        private SQLiteConnection sqlConnection;

        public AuthenticationHelper()
        {
            // SQLite connection string
            string connectionString = "Data Source=..\\..\\Data\\cManDb.db;Version=3;";
            sqlConnection = new SQLiteConnection(connectionString);
        }

        public string ValidateUser(string username, string password)
        {
            try
            {
                sqlConnection.Open();

                // SQL query to check username, password, and role in the database
                string query = "SELECT role FROM ACCOUNT WHERE Username=@username AND Password=@password";

                using (SQLiteCommand cmd = new SQLiteCommand(query, sqlConnection))
                {
                    cmd.Parameters.AddWithValue("@username", username);
                    cmd.Parameters.AddWithValue("@password", password);

                    object roleObj = cmd.ExecuteScalar();

                    // Check if the user with the given username and password exists
                    if (roleObj != null)
                    {
                        return roleObj.ToString();
                    }

                    return null; // Return null if no matching user is found
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return null;
            }
            finally
            {
                sqlConnection.Close();
            }
        }
    }
}