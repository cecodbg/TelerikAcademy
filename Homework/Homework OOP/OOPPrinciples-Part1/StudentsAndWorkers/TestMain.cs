namespace StudentsAndWorkers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestMain
    {
        public static void Main()
        {
            List<Student> students = new List<Student>()
            {
                new Student("Ivan", "Ivanov", 4), 
                new Student("Pesho", "Petrov", 5),
                new Student("Joro", "Peev", 6),
                new Student("Sasho", "Totev", 4),
                new Student("Pepi", "Pipev", 3),
                new Student("Moni", "Bonev", 3),
                new Student("Bobi", "Bobev", 5),
                new Student("Toni", "Tonev", 6), 
                new Student("Eli", "Goshova", 6),
                new Student("Meri", "Veleva", 5)
            };

            List<Worker> workers = new List<Worker>()
            {
                new Worker("Valia", "Peshova", 120, 8), 
                new Worker("Ivan", "Goshov", 200, 8), 
                new Worker("Emi", "Pesheva", 350, 5),
                new Worker("Meri", "Bobeva", 200, 6)
            };

            SortedWorkers(workers);

            SortedStudents(students);

            var concat = students.Concat<Human>(workers)
                                 .OrderBy(x => x.FirstName)
                                 .ThenBy(x => x.LastName)
                                 .ToList();

            foreach (var item in concat)
            {
                Console.WriteLine(item);
            }
        }

        public static void SortedWorkers(List<Worker> workers)
        {
            var sorted = workers.OrderByDescending(wor => wor.MoneyPerHour()).ToList();

            foreach (var wor in sorted)
            {
                Console.WriteLine(wor);
            }
        }

        public static void SortedStudents(List<Student> students)
        {
            var sorted = students.OrderBy(st => st.Grade).ToList();

            foreach (var st in sorted)
            {
                Console.WriteLine(st);
            }
        }
    }
}