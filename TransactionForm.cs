using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace iBank_Student_Bank
{
    public partial class TransactionForm : Form
    {
        Customer customer1 = new Customer();
        public TransactionForm()
        {
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
            customer1.MakeDeposit(int.Parse(txtAmount.Text));
            MessageBox.Show("Deposit Successful!");
        }

        private void withdrawToolStripMenuItem_Click(object sender, EventArgs e)
        {
            customer1.MakeWithdrawal(int.Parse(txtAmount.Text));
            MessageBox.Show("Withdrawal successful!");
        }
    }
}
