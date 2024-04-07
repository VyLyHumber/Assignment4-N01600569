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
    public partial class FormAddTransaction : Form
    {
        private int userId;
        public FormAddTransaction(int userId)
        {
            InitializeComponent();
            this.userId = userId;
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            // Validate amount
            if (string.IsNullOrWhiteSpace(textBoxAddAmount.Text))
            {
                MessageBox.Show("Please enter an amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // Parse the amount
            if (!decimal.TryParse(textBoxAddAmount.Text, out decimal amount))
            {
                MessageBox.Show("Please enter a valid amount.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            // Check if the entered amount is greater than the current balance
            using (var context = new MMABooksContext())
            {
                var account = context.Accounts.FirstOrDefault(a => a.UserId == userId);
                if (account != null && Convert.ToDecimal(account.CurrentBalance ?? 0) < amount)
                {
                    MessageBox.Show("Entered amount exceeds the current balance.", "Validation Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    return;
                }
            }

            // Validate description
            string description = textBoxAddDes.Text.Trim();
            if (string.IsNullOrWhiteSpace(description))
            {
                MessageBox.Show("Please enter a description.");
                return;
            }

           

            // Create a new transaction object
            Assignment4_N01600569.Models.Entities.TransactionHistory transaction = new Assignment4_N01600569.Models.Entities.TransactionHistory
            {
                AccountId = userId,
                Amount = amount, // Debiting the amount
                Description = description
            };

            // Save the transaction to the database
            using (var context = new MMABooksContext())
            {
                context.TransactionHistories.Add(transaction);

                // Update the current balance in the Accounts table
                var account = context.Accounts.FirstOrDefault(a => a.UserId == userId);
                if (account != null)
                {
                    // Convert nullable double to decimal
                    decimal currentBalance = Convert.ToDecimal(account.CurrentBalance ?? 0);

                    // Subtract the amount from the current balance
                    currentBalance -= amount;

                    // Assign the updated current balance back to the account
                    account.CurrentBalance = Convert.ToDouble(currentBalance);
                }

                context.SaveChanges();
            }
            // Display success message
            MessageBox.Show("Transaction added successfully!", "Success", MessageBoxButtons.OK, MessageBoxIcon.Information);
            // Close the form and return DialogResult.OK
            this.DialogResult = DialogResult.OK;
            this.Close();
        }
    }
}