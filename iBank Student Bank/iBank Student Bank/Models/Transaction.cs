namespace iBank_Student_Bank.Models
{
    public class Transaction
    {
        #region Properties

        public string AccountNumber { get; }

        public decimal Amount { get; }

        #endregion Properties

        #region Constructor

        public Transaction(string accountNumber, decimal amount)
        {
            Amount = amount;
            AccountNumber = accountNumber;
        }

        #endregion Constructor
    }
}
