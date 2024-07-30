using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace library_management_system
{
    public partial class form_returnBook : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private Nullable<int> _borrowerID;
        private string _borrowerName;
        private Nullable<int> _bookID;
        private DataTable books;
        public form_returnBook(Nullable<int> borrowerID, string borrowerName)
        {
            InitializeComponent();
            _borrowerID = borrowerID;
            _borrowerName = borrowerName;
            borrowerIDValue.Text = _borrowerID.ToString();
            borrowerNameValue.Text = _borrowerName;
        }
        private void Close(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void form_returnBook_Load(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string query = "SELECT * FROM books WHERE book_status = 'Borrowed'";

            books = db.LoadBooks(connectionString, query);
            selectBook.DisplayMember = "book_title";
            selectBook.DataSource = books;
        }
        private void selectBookChange(object sender, EventArgs e)
        {
            _bookID = int.Parse(((DataRowView)selectBook.SelectedItem)["book_number"].ToString());
        }

        private void returnBook(object sender, EventArgs e)
        {
            
        }
    }
}
