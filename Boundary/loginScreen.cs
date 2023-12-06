// loginScreen.cs

using System;
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