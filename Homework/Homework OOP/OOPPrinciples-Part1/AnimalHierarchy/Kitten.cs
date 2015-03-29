namespace AnimalHierarchy
{
    using System;

    public class Kitten : Cat
    {
        public Kitten(string name, int age, Gender gender)
            : base(name, age, gender)
        {

        }

        public override Gender Gender
        {
            get
            {
                return base.Gender;
            }

            protected set
            {
                if (Gender.Male == value)
                {
                    throw new ArgumentException("Kitten cannot be male");
                }

                base.Gender = value;
            }
        }

        public override string MakeSound()
        {
            return "Mrrr mrrr";
        }
    }
}
