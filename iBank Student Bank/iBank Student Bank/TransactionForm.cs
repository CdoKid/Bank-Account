using System;
using System.Windows.Forms;

using iBank_Student_Bank.Models;

namespace iBank_Student_Bank
{
    public partial class TransactionForm : Form
    {
        private readonly Customer customer;

        public TransactionForm(Customer customer)
        {
            this.customer = customer;
            InitializeComponent();
        }

        private void viewBalanceToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void TransactionForm_Load(object sender, EventArgs e)
        {
          
        }

        private void depositToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var balance = customer.Account.Deposit(decimal.Parse(txtAmount.Text));
            MessageBox.Show($"Deposit Successful! R{balance}");
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var balance = customer.Account.Deposit(decimal.Parse(txtAmount.Text));
            MessageBox.Show($"Withdrawal successful! Balance R{balance}");
        }
    }
}
