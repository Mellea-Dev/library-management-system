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
    public partial class form_books : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private DataTable books;
        private Nullable<int> bookNumber = null;
    

        public form_books()
        {
            InitializeComponent();
        }
        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
            form_dashboard dashboard = new form_dashboard();
            dashboard.Show();
        }
        private void search(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string query =
                "select * from books where book_title like '" +
                input_search_books.Texts + "%'";
            books = db.LoadBooks(connectionString, query);
            books.Columns["book_number"].ColumnName = "Book #";
            books.Columns["book_title"].ColumnName = "Book Title";
            books.Columns["book_Author"].ColumnName = "Author";
            books.Columns["book_category"].ColumnName = "Category";
            books.Columns["registered_date"].ColumnName = "Registered Date";
            books.Columns["book_status"].ColumnName = "Status";
            books.Columns["fk_borrower"].ColumnName = "Borrower #";
            if (books != null)
            {
                gridViewBooks.DataSource = books;
                emptyVisual.Visible = false;
            }
        }

        private void cellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewBooks.Rows[e.RowIndex].Cells[0].Value != null)
            {
                bookNumber = int.Parse(gridViewBooks.Rows[e.RowIndex].Cells[0].Value.ToString());
                input_title.Texts = gridViewBooks.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_author.Texts = gridViewBooks.Rows[e.RowIndex].Cells[2].Value.ToString();
                input_category.Texts = gridViewBooks.Rows[e.RowIndex].Cells[3].Value.ToString();
                input_registered_date.Value = Convert.ToDateTime(gridViewBooks.Rows[e.RowIndex].Cells[4].Value.ToString());
            }
        }

        private void updateClick(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_title.Texts) || string.IsNullOrEmpty(input_author.Texts) || string.IsNullOrEmpty(input_category.Texts) || input_registered_date.Value == null)
            {
                MessageBox.Show("You have an empty field please check your inputs");
            }
            else
            {
                DbConnection db = new DbConnection();
                string query =
                    "UPDATE books set book_title = @book_title, book_author = @book_author, book_category = @book_category, registered_date = @registered_date WHERE book_number = @book_number";
                bool isUpdated = db.UpdateBook(connectionString, query, bookNumber, input_title.Texts, input_author.Texts, input_category.Texts, input_registered_date.Value);
                if (isUpdated)
                {
                    ClearInputs();
                }
            }
        }

        private void cancelUpdateClick(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            bookNumber = null;
            input_title.ClearText();
            input_author.ClearText();
            input_category.ClearText();
            input_registered_date.Value = DateTime.Now;
        }
    }
}
