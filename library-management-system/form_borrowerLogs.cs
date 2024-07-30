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
    public partial class form_borrowerLogs : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private Nullable<int> logID;
        private Nullable<int> bookID;
        private Nullable<int> borrowerID;
        private DataTable borrowerLogs;
        public form_borrowerLogs()
        {
            InitializeComponent();
        }

        private void Close(object sender, EventArgs e)
        {
            this.Hide();
            form_dashboard dashboard = new form_dashboard();
            dashboard.Show();
        }

        private void search(object sender, EventArgs e)
        {
            // Assuming DbConnection class handles database operations
            DbConnection db = new DbConnection();

            // Construct the SQL query with parameterized inputs
            string query =
                "SELECT bl.id, bl.fk_borrower, bl.fk_book, b.borrower_name, bo.book_title, bl.status, bl.date_borrowed, bl.date_returned " +
                "FROM borrower_logs bl " +
                "JOIN borrowers b ON bl.fk_borrower = b.borrower_id " +
                "JOIN books bo ON bl.fk_book = bo.book_number " +
                "WHERE " +
                "bl.id LIKE @searchTerm OR " +
                "b.borrower_name LIKE @searchTerm OR " +
                "bo.book_title LIKE @searchTerm OR " +
                "bl.status LIKE @searchTerm OR " +
                "bl.date_borrowed LIKE @searchTerm OR " +
                "bl.date_returned LIKE @searchTerm";

            string searchTerm = "%" + input_search_logs.Text + "%";
            DataTable borrowerLogs = new DataTable();
            borrowerLogs = db.LoadBorrowerLogs(connectionString, query, searchTerm);
            if (gridViewBorrowerLogs.Columns.Contains("fk_borrower"))
                gridViewBorrowerLogs.Columns["fk_borrower"].Visible = false;

            if (gridViewBorrowerLogs.Columns.Contains("fk_book"))
                gridViewBorrowerLogs.Columns["fk_book"].Visible = false;

            if (borrowerLogs != null && borrowerLogs.Rows.Count > 0)
            {
                borrowerLogs.Columns["id"].ColumnName = "Log #";
                borrowerLogs.Columns["borrower_name"].ColumnName = "Borrower";
                borrowerLogs.Columns["book_title"].ColumnName = "Book";
                borrowerLogs.Columns["status"].ColumnName = "Status";
                borrowerLogs.Columns["date_borrowed"].ColumnName = "Borrowed Date";
                borrowerLogs.Columns["date_returned"].ColumnName = "Returned Date";

                gridViewBorrowerLogs.DataSource = borrowerLogs;
                emptyVisual.Visible = false;
            }
            else
            {
                gridViewBorrowerLogs.DataSource = null; 
                emptyVisual.Visible = true; 
            }
        }

        private void LogSelect(object sender, DataGridViewCellEventArgs e)
        {
            if (gridViewBorrowerLogs.Rows[e.RowIndex].Cells[0].Value != null)
            {
                logID = int.Parse(gridViewBorrowerLogs.Rows[e.RowIndex].Cells[0].Value.ToString());
                borrowerID = int.Parse(gridViewBorrowerLogs.Rows[e.RowIndex].Cells[1].Value.ToString());
                bookID = int.Parse(gridViewBorrowerLogs.Rows[e.RowIndex].Cells[2].Value.ToString());

                logIDValue.Text = gridViewBorrowerLogs.Rows[e.RowIndex].Cells[0].Value.ToString();
                input_borrower.Texts = gridViewBorrowerLogs.Rows[e.RowIndex].Cells[3].Value.ToString();
                input_book.Texts = gridViewBorrowerLogs.Rows[e.RowIndex].Cells[4].Value.ToString();
            }
        }

        private void returnBook(object sender, EventArgs e)
        {
            DbConnection db = new DbConnection();
            string query = "Update borrower_logs SET status = 'Returned', date_returned = @date_returned WHERE id = @id";
            bool isReturned = db.returnBook(connectionString,query,logID);

            if (isReturned)
            {
                string query2 = @"
                    UPDATE books 
                    SET book_status = CASE 
                                        WHEN EXISTS (SELECT 1 FROM borrower_logs WHERE fk_book = @book_number AND status = 'Returned') THEN 'On Shelf' 
                                        ELSE book_status 
                                      END
                    WHERE book_number = @book_number";
                bool isStatusUpdate = db.UpdateBookStatus(connectionString, query2, bookID);
                if (isStatusUpdate)
                {
                    string query3 = @"
                        UPDATE books 
                        SET fk_borrower = Null
                        WHERE book_number = @book_number";
                    db.UpdateBookBorrower(connectionString, query3, bookID);
                }
            }
        }
        private void clearFields_Click(object sender, EventArgs e)
        {
            Clear();
        }
        private void Clear()
        {
            logID = null;
            borrowerID = null;
            bookID = null;

            logIDValue.Text = "";
            input_borrower.ClearText();
            input_book.ClearText();
        }

        private void generateReport_Click(object sender, EventArgs e)
        {
            DataSet logs = new DataSet();
            DataTable logsReport = new DataTable();
            logsReport.Columns.Add("ID", typeof(int));
            logsReport.Columns.Add("Borrower", typeof(string));
            logsReport.Columns.Add("Book", typeof(string));
            logsReport.Columns.Add("Status", typeof(string));
            logsReport.Columns.Add("Date Borrowed", typeof(string));
            logsReport.Columns.Add("Date Returned", typeof(string));

            foreach (DataGridViewRow row in gridViewBorrowerLogs.Rows)
            {
                logsReport.Rows.Add(row.Cells[0].Value, row.Cells[3].Value, row.Cells[4].Value, row.Cells[5].Value, row.Cells[6].Value, row.Cells[7].Value);
            }

            logs.Tables.Add(logsReport);
            logs.WriteXmlSchema("Borrower_Logs.xml");

            form_borrowerLogsReport report = new form_borrowerLogsReport();
            BorrowerLogsReport cReport = new BorrowerLogsReport();
            cReport.SetDataSource(logs);
            report.crystalReportViewer1.ReportSource = cReport;
            report.crystalReportViewer1.Refresh();
            report.Show();
        }
    }
}
