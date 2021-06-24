using System;
using System.Windows.Forms;
using System.Collections.Generic;

using iBank_Student_Bank.Enums;
using iBank_Student_Bank.Models;

namespace iBank_Student_Bank
{
    public partial class RegistrationForm : Form
    {
        private readonly string accountNumber;

        public RegistrationForm(string accountNumber)
        {
            this.accountNumber = accountNumber;
            InitializeComponent();
        }

        private void completeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtFullNames.Text != "") && (txtInitialDeposit.Text != "")&&(cmbAccountType.Text!=" "))
            {
                try
                {
                    // Parsing AccountType string to enum
                    Enum.TryParse(cmbAccountType.Text, out AccountType accountType);

                    // Creating new account with account number and account type from form input
                    var account = new Account(accountNumber: accountNumber, accountType: accountType);

                    // Creating initial deposit
                    account.Deposit(amount: decimal.Parse(txtInitialDeposit.Text));

                    // Creating new customer
                    var customer = new Customer(firstName: txtFullNames.Text, lastName: txtFullNames.Text, account);

                    // Adding customer to static list available across all classes
                    BankCustomers.AddCustomer(customer);

                    MessageBox.Show("Account successfully created for "+ Environment.NewLine + customer.ToString() +
                                    "with initial deposit of "  + txtInitialDeposit.Text, "Summary",
                                     MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.Tag = txtAccNum.Text;
                    this.DialogResult = DialogResult.OK;

                    //Passing customer instance to performing transactions on customer account
                    TransactionForm tsfr = new TransactionForm(customer: customer);                 
                    tsfr.Show();
                    this.Hide();
                    

                }
                catch (FormatException ex)
                {
                    MessageBox.Show("Please enter a numeric value for the initial deposit" + Environment.NewLine +
                                    ex.Message, "Data entry error",
                                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);
                                    
                }
                catch (Exception exx)
                {
                    MessageBox.Show("Please enter a string for the full names" + Environment.NewLine +
                                    exx.Message, "Data entry error",
                                    MessageBoxButtons.RetryCancel, MessageBoxIcon.Error);

                }
            }
            else
            {
                MessageBox.Show("is a required field", "Entry Error", MessageBoxButtons.OK);
            }
            
        }

        private void RegistrationForm_Load(object sender, EventArgs e)
        {
            string[] AccountTypes = Enum.GetNames(typeof(AccountType));
            cmbAccountType.Items.AddRange(AccountTypes);
            
        }
    }
}
