// loginScreen.cs

using System;
using System.Data.SQLite;
using System.Linq;
using System.Windows.Forms;
using Course_Management_System_Final.Control;

namespace Course_Management_System_Final
{
    public partial class loginScreen : Form
    {
        private AuthenticationHelper authenticationHelper;

        public loginScreen()
        {
            InitializeComponent();

            authenticationHelper = new AuthenticationHelper();

            // Attach the event handler to the login button click event
            loginBtn.Click += LoginBtn_Click;
        }



        public void LoginBtn_Click(object sender, EventArgs e)
        {

            if (usernameBox.Text.Length > 0 && passwordBox.Text.Length > 0)
            {
                string username = usernameBox.Text;
                string password = passwordBox.Text;
                
                
                string GetFullName(string usn)
                {
                    string fullName = null;

                    using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
                    {
                        conn.Open();

                        int hash = usn.GetHashCode();
                        string query = "SELECT [name] FROM [ACCOUNT] WHERE [username] = $username;";

                        using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                        {
                            cmd.Parameters.AddWithValue("$username", hash);

                            // Execute the query and retrieve the result
                            object result = cmd.ExecuteScalar();

                            // Check if the result is not null
                            if (result != null)
                            {
                                fullName = result.ToString();
                            }
                        }
                    }

                    return fullName;
                }

                int usnHash = username.GetHashCode();
                int pwdHash = password.GetHashCode();
                DBConnector.SessionManager.Instance.SetLoggedInUser(GetFullName(username));


                string role = authenticationHelper.ValidateUser(usnHash.ToString(), pwdHash.ToString());


                LoginControl loginControl = new LoginControl();
                if (loginControl.Login(username, password) == true)
                {
                    if (role == "student")
                    {
                        this.Hide();
                        studentViewHome studentViewHome = new studentViewHome();
                        studentViewHome.Show();
                    }
                    else if (role == "instructor")
                    {
                        this.Hide();
                        instructorViewHome instructorViewHome = new instructorViewHome();
                        instructorViewHome.Show();
                    }
                    else
                    {
                        MessageBox.Show("Username or password is incorrect. Please try again.", "Login Failed",
                            MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }





            }
        }
    }
}