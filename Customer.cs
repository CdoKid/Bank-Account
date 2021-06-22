using System;
using System.Collections.Generic;

namespace iBank_Student_Bank
{
    class Customer
    {
        //Customer fields
        private string fullname;
        private string accountnumber;
        private static int accountnumberseed = 1468772930;
        private double balance = 0;




        private List<Customer> allTransactions = new List<Customer>();

        //transactions fields
        public double Amount { get; }
       // public DateTime Date { get; }
       // public string Notes { get; }




        //constructors
        public Customer() { }


        public Customer(string name, double initialbalance)
        {
            fullname = name;
            balance = initialbalance;

            fullname = name;
            balance = initialbalance;
            MakeDeposit(initialbalance);
        }
        public Customer(double amount)
        {
            Amount = amount;
         //   Date = date;
           // Notes = notes;

        }

        //customer properties
        public string Name
        {
            get
            { return fullname; }
            set
            { fullname = value; }
        }

        public string AccountNumber
        {
            get
            { return accountnumber; }
            set
            {
                accountnumber = accountnumberseed.ToString();
                accountnumberseed++;


            }

        }


        public double Balance
        {
            get
            {
                double balance = 0;
                foreach (var item in allTransactions)
                {
                    balance += item.Amount;
                }

                return balance;
            }
            set
            {
                balance = value;
            }

        }





        public void MakeDeposit(double amount)
        {

            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var deposit = new Customer(amount);
            allTransactions.Add(deposit);

        }
        public void MakeWithdrawal(double amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of withdrawal must be positive");
            }
            if (Balance - amount < 0)
            {
                throw new InvalidOperationException("Not sufficient funds for this withdrawal");
            }
            var withdrawal = new Customer(-amount);
            allTransactions.Add(withdrawal);

        }
    }

}
