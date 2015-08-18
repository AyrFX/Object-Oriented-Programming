namespace Bank
{
    using System;
    using Bank.Classes;

    public class BankMain
    {
        public static void Main()
        {
            LoanAccount lAccount = new LoanAccount("Gosho Goshev", CustomerTypes.individual, 23423, 3);
            DepositAccount dAccount = new DepositAccount("Company", CustomerTypes.company, 44321, 1.75m);
            MortgageAccount mAccount = new MortgageAccount("Any individual", CustomerTypes.individual, -234, 2.99m);

            Console.WriteLine("Loan account interest amont for 5 months: {0}", lAccount.InterestAmount(5));
            Console.WriteLine("Deposit account interest amont for 3 months: {0}", dAccount.InterestAmount(3));
            Console.WriteLine("Mortgage account interest amont for 7 months: {0}", mAccount.InterestAmount(7));
        }
    }
}
