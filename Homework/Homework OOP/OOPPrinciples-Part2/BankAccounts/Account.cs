namespace BankAccounts
{
    using System;

    public abstract class Account : IDepositable, IWithdraw
    {
        private Customer customer;
        private decimal balance;
        private decimal interestRate;

        public Account(Customer customer, decimal balance, decimal interestRate)
        {
            this.Customer = customer;
            this.Balance = balance;
            this.InterestRate = interestRate;
        }

        public Customer Customer
        {
            get
            {
                return this.customer;
            }

            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }

                this.customer = value;
            }
        }

        public decimal Balance
        {
            get
            {
                return this.balance;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.balance = value;
            }
        }

        public decimal InterestRate
        {
            get
            {
                return this.interestRate;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.interestRate = value;
            }
        }

        public abstract decimal CalculateInterestRate(int month);

        public virtual void Deposit(decimal money)
        {
            if (money > 0)
            {
                this.Balance += money;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public virtual void Withdraw(decimal money)
        {
            if (this.Balance > money && this.Balance - money < 0)
            {
                this.Balance -= money;
            }
            else
            {
                throw new ArgumentOutOfRangeException();
            }
        }

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Customer, this.Balance, this.InterestRate);
        }
    }
}
