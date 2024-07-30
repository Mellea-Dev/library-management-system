using System;
using System.Windows.Forms;


namespace library_management_system
{
    public partial class form_dashboard : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        public form_dashboard()
        {
            InitializeComponent();
            DbConnection db = new DbConnection();
            int booksCounter = db.WidgetCounter(connectionString, "all books");
            int issuedBooksCounter = db.WidgetCounter(connectionString, "issued books");
            int returnedBooksCounter = db.WidgetCounter(connectionString, "returned books");
            widgetBooks.CountLabelText = booksCounter.ToString();
            widgetIssueds.CountLabelText = issuedBooksCounter.ToString();
            widgetReturns.CountLabelText = returnedBooksCounter.ToString();
        }

        private void minimize_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }
        private void close_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void registerBook_Click(object sender, EventArgs e)
        {
            form_registerBook registerBook = new form_registerBook();
            registerBook.Show();
        }

        private void registerBorrower_Click(object sender, EventArgs e)
        {
            form_registerBorrowers registerBorrower = new form_registerBorrowers();
            registerBorrower.Show();
        }

        private void viewBooks_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_books viewBooks = new form_books();
            viewBooks.Show();
        }
        private void viewBorrowers_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_borrowers viewBorrowers = new form_borrowers();
            viewBorrowers.Show();
        }
        private void viewBorrowerLogs_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_borrowerLogs viewBorrowerLogs = new form_borrowerLogs();
            viewBorrowerLogs.Show();
        }
    }
}
