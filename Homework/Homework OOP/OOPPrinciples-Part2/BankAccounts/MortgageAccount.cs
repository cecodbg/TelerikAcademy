namespace BankAccounts
{
    public class MortgageAccount : Account, IDepositable
    {
        public MortgageAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override void Deposit(decimal money)
        {
            base.Deposit(money);
        }

        public override decimal CalculateInterestRate(int month)
        {
            if (this.Customer is Company)
            {
                if (month <= 12)
                {
                    return ((this.InterestRate / 2) * month) * this.Balance;
                }
                else
                {
                    return (this.InterestRate * month) * this.Balance;
                }
            }
            else
            {
                if (month < 6)
                {
                    return 0;
                }
                else
                {
                    return (this.InterestRate * month) * this.Balance;
                }
            }           
        }
    }
}
