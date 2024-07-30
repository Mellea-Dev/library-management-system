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
    public partial class form_borrowers : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private DataTable borrowers;
        private Nullable<int> borrowerID = null;
        public form_borrowers()
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
                "select * from borrowers where borrower_name like '" +
                input_search_borrowers.Texts + "%'";
            borrowers = db.LoadBorrowers(connectionString, query);
            borrowers.Columns["borrower_id"].ColumnName = "Borrower #";
            borrowers.Columns["borrower_name"].ColumnName = "Fullname";
            borrowers.Columns["borrower_contact"].ColumnName = "Contact";
            borrowers.Columns["issued_books"].ColumnName = "Issued Books";
           
            if (borrowers != null)
            {
                gridViewBorrowers.DataSource = borrowers;
                emptyVisual.Visible = false;
            }
        }

        private void borrowerSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewBorrowers.Rows[e.RowIndex].Cells[0].Value != null)
            {
                borrowerID = int.Parse(gridViewBorrowers.Rows[e.RowIndex].Cells[0].Value.ToString());
                input_borrower.Texts = gridViewBorrowers.Rows[e.RowIndex].Cells[1].Value.ToString();
                input_contact.Texts = gridViewBorrowers.Rows[e.RowIndex].Cells[2].Value.ToString();
            }
        }

        private void updateBorrower(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(input_contact.Texts) || string.IsNullOrEmpty(input_borrower.Texts))
            {
                MessageBox.Show("All Fields are Required Please Check your Inputs.", " Warning" + MessageBoxButtons.OK + MessageBoxIcon.Warning);
            }
            else
            {
                DbConnection db = new DbConnection();
                string query =
                    "UPDATE borrowers set borrower_name = @borrower_name, borrower_contact = @borrower_contact WHERE borrower_id = @borrower_id";
                bool isUpdated =  db.UpdateBorrower(connectionString, query, borrowerID, input_borrower.Texts, input_contact.Texts);
                if (isUpdated)
                {
                    ClearInputs();
                }
            }
        }

        private void cancelUpdate(object sender, EventArgs e)
        {
            ClearInputs();
        }

        private void ClearInputs()
        {
            borrowerID = null;
            input_borrower.ClearText();
            input_contact.ClearText();
        }

        private void issueBookButton_Click(object sender, EventArgs e)
        {
            form_issueBook issueBook = new form_issueBook(borrowerID,input_borrower.Texts);
            issueBook.Show();
        }
    }
}
