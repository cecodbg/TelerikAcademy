namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Category : ICategory
    {
        private const int MinLenght = 2;
        private const int MaxLenght = 15;
        private const string CategoryName = "Category name";
        private readonly IList<IProduct> products;

        private string name;

        public Category(string name)
        {
            this.Name = name;
            this.products = new List<IProduct>();
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                Validator.CheckIfStringIsNullOrEmpty(value, string.Format(GlobalErrorMessages.StringCannotBeNullOrEmpty, CategoryName));
                Validator.CheckIfStringLengthIsValid(value, MaxLenght, MinLenght, string.Format(GlobalErrorMessages.InvalidStringLength, CategoryName, MinLenght, MaxLenght));

                this.name = value;
            }
        }

        public void AddCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to add to category"));

            this.products.Add(cosmetics);
        }

        public void RemoveCosmetics(IProduct cosmetics)
        {
            Validator.CheckIfNull(cosmetics, string.Format(GlobalErrorMessages.ObjectCannotBeNull, "Cosmetics to remove to category"));

            if (!this.products.Contains(cosmetics))
            {
                throw new ArgumentException(string.Format("Product {0} does not exist in category {1}!", cosmetics.Name, this.Name));
            }

            this.products.Remove(cosmetics);
        }

        public string Print()
        {
            var categoryPrint = string.Format("{0} category - {1} {2} in total", this.Name, this.products.Count, this.products.Count == 1 ? "product" : "products");

            var resultPrint = new StringBuilder();
            resultPrint.AppendLine(categoryPrint);

            var sortProducts = this.products.OrderBy(pr => pr.Brand)
                                            .ThenByDescending(pr => pr.Price);

            foreach (var item in sortProducts)
            {
                resultPrint.AppendLine(item.Print());
            }

            return resultPrint.ToString().Trim();
        }
    }
}
