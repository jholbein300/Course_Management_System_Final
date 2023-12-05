// loginScreen.cs

using System;
using System.Windows.Forms;

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
                

                string password = passwordBox.Text;

                string role = authenticationHelper.ValidateUser(username, password);

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