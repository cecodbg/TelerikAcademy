namespace BankAccounts
{
    public class LoanAccount : Account, IDepositable
    {
        public LoanAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override void Deposit(decimal money)
        {
            base.Deposit(money);
        }

        public override decimal CalculateInterestRate(int month)
        {
            return (this.InterestRate * month) * this.Balance;
        }
    }
}
