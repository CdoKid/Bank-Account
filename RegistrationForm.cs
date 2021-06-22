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
    public partial class RegistrationForm : Form
    {
        Customer customer1 = new Customer ();
        public RegistrationForm()
        {
            InitializeComponent();
        }

        private void completeRegistrationToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if ((txtFullNames.Text != "") && (txtInitialDeposit.Text != "")&&(cmbAccountType.Text!=" "))
            {
                try
                {
                    int Deposit = int.Parse(txtInitialDeposit.Text);
                    customer1.Name = txtFullNames.Text;
                    txtInitialDeposit.Text = customer1.Balance.ToString();

                    txtAccNum.Text = customer1.AccountNumber;

                    MessageBox.Show("Account successfully created for " + customer1.Name + "\n" +
                        "Account number: " + customer1.AccountNumber+ "\n " +
                        "Account Type: "+ cmbAccountType.SelectedItem.ToString() + "\n " +
                        "with initial deposit of "  + customer1.Balance  ,"Summary",
                        MessageBoxButtons.OK,MessageBoxIcon.Information);

                    this.Tag = txtAccNum.Text;
                    this.DialogResult = DialogResult.OK;
                    
                    TransactionForm tsfr = new TransactionForm();                 
                    tsfr.label1.Text = customer1.AccountNumber;
                    tsfr.txtBalance.Text = customer1.Balance.ToString();
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
            customer1.AccountNumber = txtAccNum.Text;
            txtAccNum.Text = customer1.AccountNumber; 

            string[] AccountTypes = { "Current Account", "Savings Account", "Fixed Deposit Account" };
            cmbAccountType.Items.AddRange(AccountTypes);
            
        }
    }
}
