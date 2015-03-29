namespace AnimalHierarchy
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public abstract class Animal : ISound
    {
        private int age;
        private string name;

        public Animal(string name, int age, Gender gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.age = value;
            }
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

        public virtual Gender Gender { get; protected set; }

        public static double Average(List<Animal> animals)
        {
            var average = animals.Average(x => x.Age);

            return average;
        }

        public abstract string MakeSound();

        public override string ToString()
        {
            return string.Format("{0}, {1}, {2}", this.Name, this.Age, this.Gender);
        }
    }
}
