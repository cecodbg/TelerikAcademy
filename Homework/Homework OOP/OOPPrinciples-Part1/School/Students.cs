namespace SchoolClasses
{
    using System;
    using System.Collections.Generic;


    public class Students : People
    {
        private List<Teachers> teacher;
        private int numberInClass;

        public Students(string name, int numberInClass)
            : base(name)
        {
            this.NumberInClass = numberInClass;
            this.Teacher = new List<Teachers>(teacher);
        }

        public int NumberInClass
        {
            get
            {
                return this.numberInClass;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new IndexOutOfRangeException();
                }

                this.numberInClass = value;
            }
        }

        public List<Teachers> Teacher
        {
            get
            {
                return new List<Teachers>(this.teacher);
            }

            private set
            {
                this.teacher = value;
            }
        }
    }
}
