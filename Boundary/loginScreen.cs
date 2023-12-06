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
            
            if (usernameBox.Text.Length > 0)
            {
                string username = usernameBox.Text;

                int usnHash = username.GetHashCode();

                

                string password = passwordBox.Text;

                int pwdHash = password.GetHashCode();

                string role = authenticationHelper.ValidateUser(usnHash.ToString(), pwdHash.ToString());
                


                if (role != null)
                {

                    // Navigate to the next form based on the role (replace StudentForm and InstructorForm)
                    if (role == "student")
                    {
                        studentViewHome studentViewHome = new studentViewHome();
                        studentViewHome.Show();
                    }
                    else if (role == "instructor")
                    {
                        instructorViewHome instructorViewHome = new instructorViewHome();
                        instructorViewHome.Show();
                    }

                    // Hide the current form
                    this.Hide();
                }
                
            }
            else
            {
                MessageBox.Show("Invalid username or password. Please try again.");
            }
        }
    }
}