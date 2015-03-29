﻿namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Student : Human
    {
        private int grade;

        public Student(string firstName, string lastName, int grade)
            : base(firstName, lastName)
        {
            this.Grade = grade;
        }

        public int Grade
        {
            get
            {
                return this.grade;
            }

            set
            {
                if (value < 2 || value > 6)
                {
                    throw new ArgumentException();
                }

                this.grade = value;
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2}", this.FirstName, this.LastName, this.Grade);
        }
    }
}
