using System;

namespace iBank_Student_Bank.Models
{
    public class Customer
    {
        #region Properties

        public string LastName { get; }

        public string FirstName { get; }

        public Account Account { get; }

        #endregion Properties

        #region Constructor

        public Customer(string firstName, string lastName, Account account)
        {
            Account = account;
            LastName = lastName;
            FirstName = firstName;
        }

        #endregion Constructor

        #region Methods

        public override string ToString()
        {
            return $"Full name: {FirstName} {LastName} {Environment.NewLine} " +
                $"Account number: {Account.AccountNumber} {Environment.NewLine} " +
                $"Account type: {Account.AccountType}" +
                $"Balance R{Account.Balance}";
        }

        #endregion Methods
    }
}
