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
    public partial class form_registerBook : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private string bookTitle;
        private string bookAuthor;
        private string bookCategory;
        private int bookNumber;
   
        public form_registerBook()
        {
            InitializeComponent();

            input_book_number.Enter += new EventHandler(this.InputBookNumber_Enter);
            input_book_number.Leave += new EventHandler(this.InputBookNumber_Leave);
        }
        private void InputBookNumber_Enter(object sender, EventArgs e)
        {
            inputReminder.Visible = true;
        }
        private void InputBookNumber_Leave(object sender, EventArgs e)
        {
            inputReminder.Visible = false;
        }
        private void InputBookNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            // Allow control keys such as backspace
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBookButton_Click(object sender, EventArgs e)
        {
            bookTitle = input_book_title.Texts;
            bookAuthor = input_book_author.Texts;
            bookCategory = input_book_category.Texts;

            if (!int.TryParse(input_book_number.Texts, out bookNumber))
            {
                MessageBox.Show("Book Number must be a valid integer.");
                return;
            }

            if (bookNumber == null)
            {
                MessageBox.Show("Book Number is Required.");
            }
            else if (String.IsNullOrEmpty(bookTitle))
            {
                MessageBox.Show("Book Title is required.");
            }
            else if (String.IsNullOrEmpty(bookAuthor))
            {
                MessageBox.Show("Book Author is required.");
            }
            else if (string.IsNullOrEmpty(bookCategory))
            {
                MessageBox.Show("Book Category is required.");
            }
            else
            {
                DbConnection db = new DbConnection();
                if (db.BookNumberExists(connectionString, bookNumber))
                {
                    MessageBox.Show("Book Number already exists.");
                }
                else
                {
                    string query = "INSERT INTO books (book_number, book_title, book_author, book_category, registered_date, book_status) " +
                                   "VALUES (@book_number, @book_title, @book_author, @book_category, @registered_date, @book_status)";
                    bool isAdded = db.AddBook(connectionString, query, bookNumber, bookTitle, bookAuthor, bookCategory);
                    if (isAdded)
                    {
                        input_book_title.Texts = "";
                        input_book_author.Texts = "";
                        input_book_category.Texts = "";
                        input_book_number.Texts = "";
                    }
                }
            }
        }
    }
}
