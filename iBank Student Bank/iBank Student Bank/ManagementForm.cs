using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using iBank_Student_Bank.Models;

namespace iBank_Student_Bank
{
    public partial class ManagementForm : Form
    {
        private List<Customer> customers;
        public ManagementForm()
        {
            customers = BankCustomers.Customers;

            InitializeComponent();
        }
    }
}
