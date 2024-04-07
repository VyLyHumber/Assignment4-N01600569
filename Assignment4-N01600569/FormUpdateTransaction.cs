using Assignment4_N01600569.Models.Entities;
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
    public partial class FormUpdateTransaction : Form
    {
        private int transactionId;
        public FormUpdateTransaction(int transactionId)
        {
            InitializeComponent();
            this.transactionId = transactionId;
        }

        private void FormUpdateTransaction_Load(object sender, EventArgs e)
        {
            // Load transaction details
            LoadTransactionDetails();
        }

        private void LoadTransactionDetails()
        {
            using (var context = new MMABooksContext())
            {
                var transaction = context.TransactionHistories.Find(transactionId);

                if (transaction != null)
                {
                    // Populate UI controls with transaction details
                    textBoxUDID.Text = transaction.TransactionId.ToString();
                    textBoxUDAccountID.Text = transaction.AccountId.ToString();
                    textBoxUDAmount.Text = transaction.Amount.ToString();
                    textBoxUDDate.Text = transaction.TransactionDate.ToString();
                    textBoxUDDes.Text = transaction.Description;
                }
            }
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            // Update transaction details
            using (var context = new MMABooksContext())
            {
                var transaction = context.TransactionHistories.Find(transactionId);

                if (transaction != null)
                {
                    // Validate amount input
                    if (string.IsNullOrWhiteSpace(textBoxUDAmount.Text))
                    {
                        MessageBox.Show("Please enter the amount.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    if (!decimal.TryParse(textBoxUDAmount.Text, out decimal newAmount))
                    {
                        MessageBox.Show("Invalid amount format. Please enter a valid number.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Validate description input
                    if (string.IsNullOrWhiteSpace(textBoxUDDes.Text))
                    {
                        MessageBox.Show("Please enter the description.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Check if the new amount is greater than the current balance
                    var currentBalance = GetAccountBalance(transaction.AccountId);
                    if (newAmount > currentBalance)
                    {
                        MessageBox.Show("Amount cannot be greater than the current balance.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        return;
                    }

                    // Calculate the difference between the new amount and the old amount
                    decimal amountDifference = newAmount - (decimal)(transaction.Amount ?? 0);

                    // Update transaction properties
                    transaction.Amount = decimal.Parse(textBoxUDAmount.Text);
                    transaction.Description = textBoxUDDes.Text;

                    // Automatically set transaction date to current date and time
                    transaction.TransactionDate = DateTime.Now;

                    // Update the current balance of the associated account
                    var account = context.Accounts.Find(transaction.AccountId);
                    
                    if (account != null)
                    {
                        if (amountDifference > 0)
                        {                            
                            account.CurrentBalance = (double)((decimal)(account.CurrentBalance ?? 0) - amountDifference);
                        }
                        else if (amountDifference < 0)
                        {
                            account.CurrentBalance = (double)((decimal)(account.CurrentBalance ?? 0) + Math.Abs(amountDifference));
                        }
                        //account.CurrentBalance = (double)((decimal)(account.CurrentBalance ?? 0) + amountDifference);
                    }
                    
                    
                    // Save changes to database
                    context.SaveChanges();

                    MessageBox.Show("Transaction updated successfully.", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                else
                {
                    MessageBox.Show("Transaction not found.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private decimal GetAccountBalance(int accountId)
        {
            using (var context = new MMABooksContext())
            {
                var account = context.Accounts.Find(accountId);
                if (account != null)
                {
                    return Convert.ToDecimal(account.CurrentBalance ?? 0);
                }
                return 0; // If account not found, return 0 balance
            }
        }


    }
}
