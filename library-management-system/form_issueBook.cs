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
    public partial class form_issueBook : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private Nullable<int> _borrowerID;
        private string _borrowerName;
        private Nullable<int> _bookID;
        private DataTable books;
        public form_issueBook(Nullable<int> borrowerID, string borrowerName)
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

        private void form_issueBook_Load(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string query = "SELECT * FROM books WHERE book_status = 'On Shelf'";

            books = db.LoadBooks(connectionString, query);
            selectBook.DisplayMember = "book_title";
            selectBook.DataSource = books;
        }
        private void selectBookChange(object sender, EventArgs e)
        {
            _bookID = int.Parse(((DataRowView)selectBook.SelectedItem)["book_number"].ToString());
        }

        private void issueBook(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string query = "INSERT INTO borrower_logs (fk_borrower, fk_book, status, date_borrowed) VALUES (@fk_borrower, @fk_book, 'Issued', @date_borrowed)";
            bool isIssued = db.IssueBook(connectionString, query, _borrowerID, _bookID);

            if (isIssued)
            {   
                // Update book status
                string query2 = @"
                    UPDATE books 
                    SET book_status = CASE 
                                        WHEN EXISTS (SELECT 1 FROM borrower_logs WHERE fk_book = @book_number AND status = 'Issued') THEN 'Borrowed' 
                                        ELSE book_status 
                                      END 
                    WHERE book_number = @book_number";
                
                bool isStatusUpdate = db.UpdateBookStatus(connectionString, query2, _bookID);

                if (isStatusUpdate)
                {
                    // Update fk_borrower
                    string query3 = @"
                        UPDATE books 
                        SET fk_borrower = (SELECT fk_borrower FROM borrower_logs WHERE fk_book = @book_number ORDER BY date_borrowed DESC LIMIT 1) 
                        WHERE book_number = @book_number";

                    db.UpdateBookBorrower(connectionString, query3, _bookID);
                }
            }
        }
        private void returnBook(object sender, EventArgs e)
        {
            //
        }
    }
}
