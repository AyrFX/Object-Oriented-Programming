namespace Bank.Classes
{
    public class LoanAccount : Account
    {
        // Fields
        private AccountTypes accType;

        // Constructors
        public LoanAccount(string cName, CustomerTypes cType, decimal balance, decimal iRate)
            : base(cName, cType, balance, iRate)
        {
            this.accType = AccountTypes.loan;
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
            if (this.CustomerType == CustomerTypes.individual)
            {
                if (months > 3)
                {
                    months -= 3;
                }
                else
                {
                    return 0;
                }
            }
            else if (this.CustomerType == CustomerTypes.company)
            {
                if (months > 2)
                {
                    months -= 2;
                }
                else
                {
                    return 0;
                }
            }

            return months * this.Interest;
        }
    }
}
