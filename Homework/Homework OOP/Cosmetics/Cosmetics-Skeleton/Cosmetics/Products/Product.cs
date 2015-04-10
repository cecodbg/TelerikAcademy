namespace Cosmetics.Products
{
    using System;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public abstract class Product : IProduct
    {
        private const string ProductName = "Product name";
        private const string ProductBrand = "Product brand";
        private const int MinLenghtName = 3;
        private const int MinLenghtBrand = 2;
        private const int MaxLenght = 10;

        private string name;
        private string brand;
        private decimal price;

        public Product(string name, string brand, decimal price, GenderType gender)
        {
            this.Name = name;
            this.Brand = brand;
            this.Price = price;
            this.Gender = gender;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                //Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductName));
                Validator.CheckIfStringLengthIsValid(value, MaxLenght, MinLenghtName, string.Format(GlobalErrorMessages.InvalidStringLength, ProductName, MinLenghtName, MaxLenght));

                this.name = value;
            }
        }

        public string Brand
        {
            get
            {
                return this.brand;
            }

            private set
            {
                //Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, ProductBrand));
                Validator.CheckIfStringLengthIsValid(value, MaxLenght, MinLenghtBrand, string.Format(GlobalErrorMessages.InvalidStringLength, ProductBrand, MinLenghtBrand, MaxLenght));

                this.brand = value;
            }
        }

        public decimal Price
        {
            get
            {
                return this.price;
            }

            protected set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException("Price cannot by zerro or negative value!");
                }

                this.price = value;
            }
        }

        public GenderType Gender { get; private set; }
        
        public virtual string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(string.Format(" - {0} - {1}:", this.Brand, this.Name));
            result.AppendLine(string.Format(" * Price: ${0}", this.Price));
            result.AppendLine(string.Format(" * For gender: {0}", this.Gender));

            return result.ToString().Trim();
        }
    }
}
