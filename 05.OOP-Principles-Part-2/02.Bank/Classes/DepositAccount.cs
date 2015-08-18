namespace Bank.Classes
{
    public class DepositAccount : Account, IWithdrawable
    {
        // Fields
        private AccountTypes accType;

        // Constructors
        public DepositAccount(string cName, CustomerTypes cType, decimal balance, decimal iRate)
            : base(cName, cType, balance, iRate)
        {
            this.accType = AccountTypes.deposit;
        }

        // Properties
        public AccountTypes AcountType
        {
            get
            {
                return this.accType;
            }

            private set
            {
                this.accType = value;
            }
        }

        // Methods
        public override decimal InterestAmount(ushort months)
        {
            if (this.Balance > 0 && this.Balance < 1000)
            {
                return 0;
            }

            return months * this.Interest;
        }

        public void Withdraw(decimal amount)
        {
            this.Balance -= amount;
        }
    }
}
