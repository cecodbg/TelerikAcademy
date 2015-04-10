namespace Cosmetics.Products
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    using Cosmetics.Common;
    using Cosmetics.Contracts;

    public class Toothpaste : Product, IToothpaste, IProduct
    {
        private const int MinLenght = 4;
        private const int MaxLenght = 12;
        private const string EachIngredien = "Each ingredien";

        private IList<string> ingredients;

        public Toothpaste(string name, string brand, decimal price, GenderType gender, IList<string> ingredients)
            : base(name, brand, price, gender)
        {
            this.CreatIngrediens(ingredients);
            this.ingredients = ingredients;
        }

        public string Ingredients
        {
            get { return string.Join(", ", this.ingredients); }
        }

        public void CreatIngrediens(IList<string> ingredients)
        {
            var ingredientsList = new List<string>(ingredients);

            if (ingredientsList.Any(x => x.Length < MinLenght || x.Length > MaxLenght))
            {
                throw new ArgumentOutOfRangeException(string.Format(GlobalErrorMessages.InvalidStringLength, EachIngredien, MinLenght, MaxLenght));
            }
        }

        public override string Print()
        {
            var result = new StringBuilder();
            result.AppendLine(base.Print());
            result.AppendLine(string.Format(" * Ingredients: {0}", this.Ingredients));

            return result.ToString().Trim();
        }
    }
}
