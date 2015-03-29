namespace SchoolClasses
{
    using System;

    public class Classes
    {
        private string identifier;

        public Classes(string identifier)
        {
            this.Identifier = identifier;
        }

        public string Identifier
        {
            get
            {
                return this.identifier;
            }

            private set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException();
                }

                this.identifier = value;
            }
        }
    }
}
