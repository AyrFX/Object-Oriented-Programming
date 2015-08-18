namespace Bank.Classes
{
    public class MortgageAccount : Account
    {
        // Fields
        private AccountTypes accType;

        // Constructors
        public MortgageAccount(string cName, CustomerTypes cType, decimal balance, decimal iRate)
            : base(cName, cType, balance, iRate)
        {
            this.accType = AccountTypes.mortgage;
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
            decimal currentInterest = this.Interest;
            if (this.CustomerType == CustomerTypes.company)
            {
                if (months <= 12)
                {
                    currentInterest /= 2;
                }
                else
                {
                    months -= 6;
                }
            }
            else if (this.CustomerType == CustomerTypes.individual)
            {
                if (months <= 6)
                {
                    return 0;
                }
                else
                {
                    months -= 6;
                }
            }

            return months * currentInterest;
        }
    }
}
