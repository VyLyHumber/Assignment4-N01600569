using Assignment4_N01600569.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client.NativeInterop;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;


namespace Assignment4_N01600569
{
    public partial class FormMainApplication : Form
    {
        private Assignment4_N01600569.Models.Entities.User currentUser;
        public FormMainApplication(Assignment4_N01600569.Models.Entities.User user)
        {
            InitializeComponent();
            currentUser = user;
        }

        private void FormMainApplication_Load(object sender, EventArgs e)
        {
            // Fetch and display account details for the current user
            DisplayAccountDetails();

            // Fetch and display transaction history for the current user
            DisplayTransactionHistory();
        }

        private void DisplayAccountDetails()
        {
            using (var context = new MMABooksContext())
            {
                var account = context.Accounts.FirstOrDefault(a => a.UserId == currentUser.Id);

                if (account != null)
                {
                    // Display account details in UI controls
                    textBoxAccountID.Text = account.AccountId.ToString();
                    textBoxAccountType.Text = account.AccountType;
                    textBoxCurrentBalance.Text = account.CurrentBalance.ToString();
                    textBoxAccountDate.Text = account.DateCreated?.ToShortDateString();
                }
            }
        }

        private void DisplayTransactionHistory()
        {
            using (var context = new MMABooksContext())
            {
                var transactions = context.TransactionHistories
                    .Where(t => t.AccountId == currentUser.Id)
                    .ToList();

                dataGridViewTransaction.DataSource = transactions;
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Show a form to add a new transaction
            FormAddTransaction formAddTransaction = new FormAddTransaction(currentUser.Id);
            DialogResult result = formAddTransaction.ShowDialog();

            if (result == DialogResult.OK)
            {                
                // Refresh transaction history and account details
                DisplayTransactionHistory();
                DisplayAccountDetails();
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Get the selected transaction from the DataGridView
            if (dataGridViewTransaction.SelectedRows.Count > 0)
            {
                int transactionId = Convert.ToInt32(dataGridViewTransaction.SelectedRows[0].Cells["TransactionId"].Value);

                // Show a form to update the selected transaction
                FormUpdateTransaction formUpdateTransaction = new FormUpdateTransaction(transactionId);
                DialogResult result = formUpdateTransaction.ShowDialog();

                if (result == DialogResult.OK)
                {
                    // Refresh transaction history and account details
                    DisplayTransactionHistory();
                    DisplayAccountDetails();
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to update.");
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            // Get the selected transaction from the DataGridView
            if (dataGridViewTransaction.SelectedRows.Count > 0)
            {
                int transactionId = Convert.ToInt32(dataGridViewTransaction.SelectedRows[0].Cells["TransactionId"].Value);
                decimal amount = Convert.ToDecimal(dataGridViewTransaction.SelectedRows[0].Cells["Amount"].Value);

                DialogResult result = MessageBox.Show("Are you sure you want to delete this transaction?", "Confirm Delete", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    // Call the method to delete transaction history
                    DeleteTransactionHistory(transactionId, amount);
                }
            }
            else
            {
                MessageBox.Show("Please select a transaction to delete.");
            }
        }

        private void DeleteTransactionHistory(int transactionId, decimal amount)
        {
            using (var context = new MMABooksContext())
            {
                var transaction = context.TransactionHistories.FirstOrDefault(t => t.TransactionId == transactionId);
                if (transaction != null)
                {
                    // Delete the transaction
                    context.TransactionHistories.Remove(transaction);
                    context.SaveChanges();

                    // Update the current balance
                    var account = context.Accounts.FirstOrDefault(a => a.UserId == currentUser.Id);
                    if (account != null)
                    {
                        // Convert decimal amount to double before adding
                        double amountToAdd = Convert.ToDouble(amount);
                        account.CurrentBalance += amountToAdd; // Credit the amount back to the current balance
                        context.SaveChanges();
                    }

                    // Refresh transaction history and account details
                    DisplayTransactionHistory();
                    DisplayAccountDetails();
                }
            }
        }
    }
}
