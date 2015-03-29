namespace AnimalHierarchy
{
    using System;

    public class Tomcat : Cat
    {
        public Tomcat(string name, int age, Gender gender)
            : base (name, age, gender)
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
                if (Gender.Female == value)
                {
                    throw new ArgumentException("Tomcat cannot be female");
                }

                base.Gender = value;
            }
        }

        public override string MakeSound()
        {
            return "Mew mew";
        }
    }
}
