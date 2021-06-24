using System;
using System.Collections.Generic;
using iBank_Student_Bank.Enums;
namespace iBank_Student_Bank.Models
{
    public class Account
    {
        #region Properties

        public string AccountNumber { get; }

        public AccountType AccountType { get; }

        public decimal Balance { get; private set; }

        public List<Transaction> Transactions { get; private set; }

        #endregion Properties

        #region Constructor

        public Account(string accountNumber, AccountType accountType)
        {
            Balance = 0L;
            AccountType = accountType;
            AccountNumber = accountNumber;
            Transactions = new List<Transaction>();
        }

        #endregion Constructor

        #region Methods

        public decimal Deposit(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }
            var transaction = new Transaction(accountNumber: AccountNumber, amount: amount);


            Transactions.Add(transaction);

            Balance += amount;

            return Balance;

        }

        public decimal Withdraw(decimal amount)
        {
            if (amount <= 0)
            {
                throw new ArgumentOutOfRangeException(nameof(amount), "Amount of deposit must be positive");
            }

            var transaction = new Transaction(accountNumber: AccountNumber, amount: -amount);


            Transactions.Add(transaction);

            Balance -= amount;

            return Balance;
        }

        #endregion Methods
    }
}
