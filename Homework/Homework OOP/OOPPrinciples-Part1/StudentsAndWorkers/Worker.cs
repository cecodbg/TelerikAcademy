namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Worker : Human
    {
        private decimal weekSalary;
        private decimal workHoursPerDay;

        public Worker(string firstName,string lastName,  decimal weekSalary, decimal workHoursPerDay)
            : base (firstName, lastName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.weekSalary = value;
            }
        }

        public decimal WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value <= 0 || value > 8)
                {
                    throw new ArgumentException();
                }

                this.workHoursPerDay = value;
            }
        }

        public decimal MoneyPerHour()
        {
            decimal hourSalary = (this.WeekSalary / 40);

            return hourSalary;
        }

        public override string ToString()
        {
            return string.Format("{0} {1} {2} {3}", this.FirstName, this.LastName, this.WeekSalary, this.WorkHoursPerDay);
        }
    }
}
