using System;
using System.Windows.Forms;

namespace iBank_Student_Bank
{
    public partial class MainForm : Form
    {
        // intitializing an account base to generate accounts from
        int accountNumberBase = 100000000;

        public MainForm()
        {
            InitializeComponent();
        }

        private void openToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void helpToolStripMenuItem_Click(object sender, EventArgs e)
        {
            AboutForm abtfr = new AboutForm();
            abtfr.Show();
        }

        private void openRegistrationFormToolStripMenuItem_Click(object sender, EventArgs e)
        {
            if (radCustomer.Checked)
            {
                // creating new account
                var accountNumber = accountNumberBase + 1;

                RegistrationForm rgfr = new RegistrationForm(accountNumber: accountNumber.ToString());
                rgfr.Show();

            }
            else if (radEmployee.Checked)
            {
                ManagementForm mnfr = new ManagementForm();
                mnfr.Show();
            }
        }

        private void exitToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
