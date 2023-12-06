// loginScreen.cs

using System;
using System.Collections.Generic;
using System.Data.SQLite;
using System.Linq;
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
        }



        private void LoginBtn_Click(object sender, EventArgs e)
        {

            if (usernameBox.Text.Length > 0 && passwordBox.Text.Length > 0)
            {
                string username = usernameBox.Text;
                string password = passwordBox.Text;

                int usnHash = username.GetHashCode();
                int pwdHash = password.GetHashCode();


                string role = authenticationHelper.ValidateUser(usnHash.ToString(), pwdHash.ToString());


                LoginControl loginControl = new LoginControl();
                if (loginControl.Login(username, password) == true)
                {
                    if (role == "student")
                    {
                        this.Hide();
                        studentViewHome studentViewHome = new studentViewHome(ClassList);
                        studentViewHome.Show();
                    }
                    else if (role == "instructor")
                    {
                        this.Hide();
                        instructorViewHome instructorViewHome = new instructorViewHome();
                        instructorViewHome.Show();
                        Connect(username);
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
            DBConnector dB = new DBConnector();
            List<Course> classList = dB.getClass(usn);
            ClassList = classList;
            return classList;
        }
    }
}