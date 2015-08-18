namespace Bank.Classes
{
    using System;

    public class Account : IDepositable
    {
        // Fields
        private string customerName;

        // Constructors
        public Account(string cName, CustomerTypes cType, decimal balance, decimal iRate)
        {
            this.Customer = cName;
            this.CustomerType = cType;
            this.Balance = balance;
            this.Interest = iRate;
        }

        // Properties
        public string Customer
        {
            get
            {
                return this.customerName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can't be empty!");
                }

                this.customerName = value;
            }
        }

        public CustomerTypes CustomerType { get; set; }

        public decimal Balance { get; set; }

        public decimal Interest { get; set; }

        // Methods
        public void Deposit(decimal amount)
        {
            this.Balance += amount;
        }

        public virtual decimal InterestAmount(ushort months)
        {
            return months * this.Interest;
        }
    }
}
