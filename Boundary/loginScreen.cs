// loginScreen.cs

using System;
using System.Collections.Generic;
using System.Data.Entity.Core.Metadata.Edm;
using System.Data.SQLite;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using Course_Management_System_Final.Control;
using Course_Management_System_Final.Entity;

namespace Course_Management_System_Final
{
    public partial class loginScreen : Form
    {
        private AuthenticationHelper authenticationHelper;
        public List<Course> ClassList { get; set; }

        public loginScreen()
        {
            InitializeComponent();

            authenticationHelper = new AuthenticationHelper();

            // Attach the event handler to the login button click event
            loginBtn.Click += LoginBtn_Click;
            ClassList = new List<Course>();
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
                            if (result != DBNull.Value)
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
                        studentViewHome studentViewHome = new studentViewHome(ClassList);

                        List<Course> courseList = Connect(username);
                        Console.WriteLine($"Number of courses: {courseList.Count}");
                        studentViewHome.UpdateScheduleOfClass(courseList);
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
        public List<Course> Connect(string usn)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();

                int hash = usn.GetHashCode();
                string query = "SELECT [COURSE].[ID], [COURSE].[name], [COURSE].[instructor] " +
                       "FROM [COURSE] " +
                       "JOIN [ACCOUNT] ON [COURSE].[ID] = [ACCOUNT].[accountID] " +
                       "WHERE [ACCOUNT].[username] == $username";


                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("$username", hash);

                    object result = cmd.ExecuteScalar();
                    if (result != null)
                    {
                        List<Course> courses = new List<Course>();

                        if(result is long courseId)
                        {
                            Course course = FetchCourseById(courseId);

                            if (course != null)
                            {
                                courses.Add(course);
                            }
                        }
                        else
                        {
                            foreach (var courseName in (IEnumerable<string>)result)
                            {
                                Course course = new Course(0, courseName, 1);
                                courses.Add(course);
                            }

                        }

                        ClassList = courses;
                    }

                }
            }
            DBConnector classList = new DBConnector();
            List<Course> list = classList.getClass(usn);
            ClassList = list;
            return ClassList;
        }

        private Course FetchCourseById(long courseId)
        {
            using (SQLiteConnection conn = new SQLiteConnection(@"data source =..\..\Data\cManDb.db;Version=3"))
            {
                conn.Open();
                Console.WriteLine("Connection State: " + conn.State);

                string query = "SELECT [ID], [name], [instructor] FROM [COURSE] WHERE [ID] = $courseId;";

                using (SQLiteCommand cmd = new SQLiteCommand(query, conn))
                {
                    cmd.Parameters.AddWithValue("$courseId", courseId);

                    using (SQLiteDataReader rdr = cmd.ExecuteReader())
                    {
                        if (rdr.Read())
                        {
                            // Create and return a new Course object based on the database values
                            return new Course(rdr.GetInt32(0), rdr.GetString(1), rdr.GetInt32(2));
                        }
                    }
                } 
            }

            return null; 
        }

    }
}