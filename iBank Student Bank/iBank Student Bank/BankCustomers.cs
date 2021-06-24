using System.Collections.Generic;
using iBank_Student_Bank.Models;

namespace iBank_Student_Bank
{
    public static class BankCustomers
    {
        public static List<Customer> Customers = new List<Customer>();

        public static void AddCustomer(Customer customer)
        {
            Customers.Add(customer);
        }
    }
}
