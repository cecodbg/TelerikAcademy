namespace BankAccounts
{
    public class DepositAccount : Account
    {
        public DepositAccount(Customer customer, decimal balance, decimal interestRate)
            : base(customer, balance, interestRate)
        {

        }

        public override void Withdraw(decimal money)
        {
            base.Withdraw(money);
        }

        public override void Deposit(decimal money)
        {
            base.Deposit(money);
        }

        public override decimal CalculateInterestRate(int month)
        {
            if (this.Balance <= 1000)
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
