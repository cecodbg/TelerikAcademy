namespace BankAccounts
{
    using System;
    using System.Collections.Generic;

    class BankTest
    {
        static void Main()
        {
            List<Account> accaunt = new List<Account>()
              {
                  new MortgageAccount(new Individual("Gosho"), 1200, 5),
                  new MortgageAccount(new Company("CEZ"), 1500, 10), 
                  new LoanAccount(new Individual("Gosho"), 10000, 5), 
                  new LoanAccount(new Company("CEZ"), 12000, 12), 
                  new DepositAccount(new Individual("Gosho"), 20000, 2), 
                  new DepositAccount(new Company("CEZ"), 4000, 5),
              };

            foreach (var item in accaunt)
            {
                Console.WriteLine(item);
            }

            var acc = new MortgageAccount(new Individual("Gosho"), 1200, 5);
            Console.WriteLine(acc.CalculateInterestRate(18)); 
        }
    }
}
