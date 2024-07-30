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
    public partial class form_registerBorrowers : Form
    {
        private string connectionString = Properties.Settings.Default.connectionString;
        private string fullname;
        private string contact;
        public form_registerBorrowers()
        {
            InitializeComponent();
        }

        private void close_Click(object sender, EventArgs e)
        {
            this.Hide();
        }

        private void addBorrower_Click(object sender, EventArgs e)
        {
            fullname = input_fullname.Texts;
            contact = input_contact.Texts;

            if (string.IsNullOrEmpty(fullname) || string.IsNullOrEmpty(contact))
            {
                MessageBox.Show("All fields are required!");
            }
            else
            {
                DbConnection db = new DbConnection();
                string query = "INSERT INTO borrowers (borrower_name, borrower_contact) " +
                               "VALUES (@fullname, @contact)";
                bool isAdded = db.AddBorrower(connectionString, query, fullname, contact);
                if (isAdded)
                {
                    input_fullname.ClearText();
                    input_contact.ClearText();
                }
            }
        }
    }
}
