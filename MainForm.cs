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
    public partial class MainForm : Form
    {
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
                RegistrationForm rgfr = new RegistrationForm();
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
