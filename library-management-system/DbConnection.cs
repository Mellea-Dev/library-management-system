
using System;
using System.Data;
using System.Diagnostics;
using System.Drawing.Text;
using System.Security.Cryptography.X509Certificates;
using System.Windows.Forms;
using MySql.Data.MySqlClient;



namespace library_management_system
{
    class DbConnection
    {
        //login
        public bool SelectUser(string connectionString, string query, string username, string password)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@Username", username);
                        command.Parameters.AddWithValue("@Password", password);
                        connection.Open();

                        using (MySqlDataReader reader = command.ExecuteReader())
                        {
                            return reader.HasRows;
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Login Failed" + ex.Message);
                return false;
            }
        }
        //Widget Counter
        public int WidgetCounter(string connectionString, string widget)
        {
            string query = "";
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    switch (widget)
                    {
                        case "all books":
                            query = "SELECT COUNT(*) FROM books";
                            break;
                        case "issued books":
                            query = "SELECT COUNT(*) FROM borrower_logs WHERE status = 'Issued'";
                            break;
                        case "returned books":
                            query = "SELECT COUNT(*) FROM borrower_logs WHERE status = 'Returned'";
                            break;
                        default:
                            MessageBox.Show("Invalid widget type specified.");
                            return 0; // or throw an exception, based on your needs
                    }

                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error: " + ex.Message);
                return 0; // Return a default value in case of an exception
            }
        }
        //LoadBooks
        public DataTable LoadBooks(string connectionString, string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataSet books = new DataSet();
                        dataAdapter.Fill(books);
                        return books.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Data: " + ex.Message);
                return null;
            }
        }
        //Check Book If Exist
        public bool BookNumberExists(string connectionString, int bookNumber)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    string query = "SELECT COUNT(*) FROM books WHERE book_number = @book_number";
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@book_number", bookNumber);
                        connection.Open();
                        int count = Convert.ToInt32(command.ExecuteScalar());
                        return count > 0;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error checking book number in the database: " + ex.Message);
                return false;
            }
        }
        //Add book
        public bool AddBook(string connectionString, string query, int bookNumber, string bookTitle, string bookAuthor, string bookCategory)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.AddWithValue("@book_number", bookNumber);
                        command.Parameters.AddWithValue("@book_title", bookTitle);
                        command.Parameters.AddWithValue("@book_author", bookAuthor);
                        command.Parameters.AddWithValue("@book_category", bookCategory);
                        command.Parameters.AddWithValue("@registered_date", DateTime.Now);
                        command.Parameters.AddWithValue("@book_status", "On Shelf");
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book: " + bookTitle + "Successfuly added to the Shelf.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error in adding to the database: " + ex.Message);
                return false;
            }
        }
        // Update Book
        public bool UpdateBook(string connectionString, string query, Nullable<int> bookNumber, string bookTitle, string bookAuthor, string bookCategory, DateTime registeredDate)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    if (MessageBox.Show("Data will be Updated. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@book_number", bookNumber);
                            command.Parameters.AddWithValue("@book_title", bookTitle);
                            command.Parameters.AddWithValue("@book_author", bookAuthor);
                            command.Parameters.AddWithValue("@book_category", bookCategory);
                            command.Parameters.AddWithValue("@registered_date", registeredDate);
                            connection.Open();
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                            DataSet books = new DataSet();
                            dataAdapter.Fill(books);
                        }
                    }
                }
                MessageBox.Show("Book which has ID =  " + bookNumber + "  is Updated.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Editing: " + ex.Message);
                return false;
            }
        }

        //LoadBorrowers
        public DataTable LoadBorrowers(string connectionString, string query)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        connection.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataSet borrowers = new DataSet();
                        dataAdapter.Fill(borrowers);
                        return borrowers.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Fetching Data: " + ex.Message);
                return null;
            }
        }
        // Add Borrowers
        public bool AddBorrower(string connectionString, string query, string fullname, string contact)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query,connection))
                    {
                        command.Parameters.AddWithValue("@fullname", fullname);
                        command.Parameters.AddWithValue("@contact", contact);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Borrower Successfuly Added.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Register Error: " + ex.Message);
                return false;
            }
        }
        //Update Borrower
        public bool UpdateBorrower(string connectionString, string query, Nullable<int> borrowerID, string fullname, string contact)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    if (MessageBox.Show("Data will be Updated. Do you Want to Confirm", "Confirmation", MessageBoxButtons.OKCancel, MessageBoxIcon.Question) == DialogResult.OK)
                    {
                        using (MySqlCommand command = new MySqlCommand(query, connection))
                        {
                            command.Parameters.AddWithValue("@borrower_id", borrowerID);
                            command.Parameters.AddWithValue("@borrower_name", fullname);
                            command.Parameters.AddWithValue("@borrower_contact", contact);
                            connection.Open();
                            MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                            DataSet borrowers = new DataSet();
                            dataAdapter.Fill(borrowers);
                        }
                    }
                }
                MessageBox.Show("Borrower which has ID =  " + borrowerID + "  is Updated.", " Success" + MessageBoxButtons.OK + MessageBoxIcon.Information);
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error Editing: " + ex.Message);
                return false;
            }
        }
        //Issue Book
        public bool IssueBook(string connectionString, string query, Nullable<int> borrowerID, Nullable<int> bookID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@fk_borrower", borrowerID);
                        command.Parameters.Add("@fk_book", bookID);
                        command.Parameters.Add("@status", "Issued");
                        command.Parameters.Add("@date_borrowed", DateTime.Now);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Borrower Successfuly Added.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logging Error: " + ex.Message);
                return false;
            }
        }
        public bool UpdateBookStatus(string connectionString, string query, Nullable<int>bookID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@book_number", bookID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book Table Successfuly Updated.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logging Error: " + ex.Message);
                return false;
            }
        }
        public bool UpdateBookBorrower(string connectionString, string query, Nullable<int> bookID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@book_number", bookID);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                MessageBox.Show("Book Borrower Successfuly Updated.");
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Logging Error: " + ex.Message);
                return false;
            }
        }

        public DataTable LoadBorrowerLogs(string connectionString, string query, string searchTerm)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query,connection))
                    {
                        command.Parameters.Add("@searchTerm", searchTerm);
                        connection.Open();
                        MySqlDataAdapter dataAdapter = new MySqlDataAdapter(command);
                        DataSet borrowerLogs = new DataSet();
                        dataAdapter.Fill(borrowerLogs);
                        return borrowerLogs.Tables[0];
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Fetching Data Error: " + ex.Message);
                return null;
            }
        }

        public bool returnBook(string connectionString, string query, Nullable<int> logID)
        {
            try
            {
                using (MySqlConnection connection = new MySqlConnection(connectionString))
                {
                    using (MySqlCommand command = new MySqlCommand(query, connection))
                    {
                        command.Parameters.Add("@id", logID);
                        command.Parameters.Add("@date_returned", DateTime.Now);
                        connection.Open();
                        command.ExecuteNonQuery();
                    }
                }
                return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Updating Borrowers Log Error: " + ex.Message);
                return false;
            }
        }
    }
}
