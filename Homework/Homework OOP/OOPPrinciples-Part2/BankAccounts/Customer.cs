namespace BankAccounts
{
    using System;

    public abstract class Customer
    {
        private string name;

        public Customer(string name)
        {
            this.Name = name;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.name = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0}", this.Name);
        }
    }
}
