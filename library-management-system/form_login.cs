using System;

using System.Windows.Forms;

// This is the code for your desktop app.
// Press Ctrl+F5 (or go to Debug > Start Without Debugging) to run your app.

namespace library_management_system
{
    public partial class FormLogin : Form
    {
        private string username;
        private string password;
        private string connectionString = Properties.Settings.Default.connectionString;
        public FormLogin()
        {
            InitializeComponent();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_btn_Click(object sender, EventArgs e)
        {
            username = input_username.Texts;
            password = input_password.Texts;
             if (String.IsNullOrEmpty(username))
             {
                 MessageBox.Show("Please Input Your Username");
             }
             else if (String.IsNullOrEmpty(password))
             {
                 MessageBox.Show("Please Input Your Password");
             }
             else
             {
                 DbConnection db = new DbConnection();
                 string query = "SELECT * FROM Users WHERE Username=@Username AND Password=@Password";
                 bool isAuthenticated = db.SelectUser(connectionString,query,username,password);
                 if (isAuthenticated)
                 {
                     this.Hide();
                     form_dashboard dashboard = new form_dashboard();
                     dashboard.Show();
                 }
                 else
                 {
                    MessageBox.Show("Invalid username or password.");
                 }
             }
        }
    }
}
