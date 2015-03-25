namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public class Test
    {
        public static void Main()
        {
            // Test StringBuilder
            Console.WriteLine("1. StringBuilder.Substring");
            //string str = "Implement an extension method";
            //StringBuilder strihgBuilder = new StringBuilder(str);
            //Console.WriteLine(strihgBuilder.Substring(4, 6));
            //Console.WriteLine(strihgBuilder.Substring(4));

            // Test IEnumerable
            Console.WriteLine("2. IEnumerable extensions");
            IEnumerable<int> list = new List<int>() { 1, 2, 3, 4, 5, 6, 7, 8, 9, 21 };
            //Console.WriteLine(list.SumCollection());
            //Console.WriteLine(list.ProductCollection());
            //Console.WriteLine(list.MinCollection());
            //Console.WriteLine(list.MaxCollection());
            //Console.WriteLine(list.AverageCollection());

            // Test Student
            var students = StudentList();

            Console.WriteLine("3. First before last");
            //SortFirstBeforLast(students);
            Console.WriteLine("4. Age range 18 to 24");
            //SortByAge(students);

            Console.WriteLine("5. Order students LINQ");
            //SortLinq(students);
            Console.WriteLine("5. Order students lambda");
            //SortLambda(students);  

            Console.WriteLine("6. Divisible by 7 and 3 LINQ");
            //DivisibleBy7And3Linq(list);
            Console.WriteLine("6. Divisible by 7 and 3 lambda");
            //DivisibleBy7And3Lambda(list);

            Console.WriteLine("9. Student groups 2 LINQ");
            //ExtractStudentByGroup(students);
            Console.WriteLine("10. Student groups 2 lambda");
            //ExtractStudentByGroupLambda(students);

            Console.WriteLine("11. Extract students by email");
            //ExtractStudentsByEmail(students);

            Console.WriteLine("12. Extract students by phone");
            //ExtractStudentsByPhone(students);

            Console.WriteLine("13. Extract students by marks");
            //ExtractStudentsByMarks(students);

            Console.WriteLine("14. Extract students with two marks");
            //ExtractStudentsWithTwoMarks(students);

            Console.WriteLine("15. Extract marks");
            //ExtractMarks(students);

            Console.WriteLine("18. Grouped by GroupNumber");
            //GroupedByGroupNumber(students);

            Console.WriteLine("19. Grouped by Department name extensions");
            //GroupedByDepartmentNameExtensions(students);
        }

        private static void GroupedByDepartmentNameExtensions(List<Student> students)
        {
            var result = students.GroupBy(st => st.DepartmentName)
                                 .ToList();

            foreach (var st in result)
            {
                Console.WriteLine(string.Join("\n", st));
                Console.WriteLine();
            }
        }

        private static void GroupedByGroupNumber(List<Student> students)
        {
            var result = from st in students
                         group st by st.GroupNumber;

            foreach (var st in result)
            {
                Console.WriteLine(string.Join("\n", st));
                Console.WriteLine();
            }  
        }

        private static void ExtractMarks(List<Student> students)
        {
            var result = students.Where(st => st.FNumber % 100 == 06)
                                 .Select(st => st.Marks)
                                 .ToList();

            foreach (var st in result)
            {
                Console.WriteLine(string.Join(", ", st));
            }

            Console.WriteLine();

            //var result = from st in students
            //             where st.FNumber % 100 == 06
            //             select st.Marks;

            //foreach (var st in result)
            //{
            //    Console.WriteLine(string.Join(", ", st));
            //}
        }

        private static void ExtractStudentsWithTwoMarks(List<Student> students)
        {
            var result = students.Where(st => st.Marks.Contains(2))
                                 .ToList();

            foreach (var sr in result)
            {
                Console.WriteLine(sr);
            }

            Console.WriteLine();

            //var result = from st in students
            //             where st.Marks.Contains(2)
            //             select st;

            //foreach (var sr in result)
            //{
            //    Console.WriteLine(sr);
            //}

            //Console.WriteLine();
        }

        private static void ExtractStudentsByMarks(List<Student> students)
        {
            var result = from st in students
                         where st.Marks.Contains(6)
                         select new { FullName = st.FirstName + " " + st.LastName, Mark = st.Marks };

            foreach (var st in result)
            {
                Console.WriteLine("{0} {1}", st.FullName, string.Join(", ", st.Mark));
            }

            Console.WriteLine();
        }

        private static void ExtractStudentsByPhone(List<Student> students)
        {
            var sort = from st in students
                       where st.Tel.StartsWith("089")
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
        }

        private static void ExtractStudentsByEmail(List<Student> students)
        {
            var sort = from st in students
                       where st.Email.Host == "abv.bg"
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
        }

        private static void ExtractStudentByGroupLambda(List<Student> students)
        {
            var sort = students.Where(x => x.GroupNumber == 2)
                               .OrderBy(x => x.FirstName)
                               .ToList();

            foreach (Student st in sort)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
        }

        private static void ExtractStudentByGroup(List<Student> students)
        {
            var sort = from st in students
                       where st.GroupNumber == 2
                       orderby st.FirstName
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st);
            }

            Console.WriteLine();
        }

        private static void DivisibleBy7And3Linq(IEnumerable<int> list)
        {
            var sort = from number in list
                       where number % 7 == 0 && number % 3 == 0
                       select number;

            foreach (var number in sort)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }

        private static void DivisibleBy7And3Lambda(IEnumerable<int> list)
        {
            var sort = list.Where(x => x % 3 == 0 && x % 7 == 0)
                           .ToList();

            foreach (var number in sort)
            {
                Console.WriteLine(number);
            }

            Console.WriteLine();
        }

        private static void SortLinq(List<Student> students)
        {
            var sort = from st in students
                       orderby st.FirstName descending, st.LastName descending
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine();
        }

        private static void SortLambda(List<Student> students)
        {
            var sort = students.OrderByDescending(st => st.FirstName)
                               .ThenByDescending(st => st.LastName)
                               .ToList();

            foreach (Student st in sort)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine();
        }

        private static void SortByAge(List<Student> students)
        {
            var sort = from st in students
                       where st.Age > 18 && st.Age < 24
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName + " " + st.Age);
            }

            Console.WriteLine();
        }

        private static void SortFirstBeforLast(List<Student> students)
        {
            var sort = from st in students
                       where st.FirstName.CompareTo(st.LastName) < 0
                       select st;

            foreach (Student st in sort)
            {
                Console.WriteLine(st.FirstName + " " + st.LastName);
            }

            Console.WriteLine();
        }

        private static List<Student> StudentList()
        {
            var students = new List<Student>()
            {
                new Student("Ivan", "Peshev", 20, 2, "Mathematics", 100005, "0898500600", "ivan@gmail.com", new List<int>() {2, 2, 2}),
                new Student("Pesho", "Ivanov", 22, 2, "Mathematics", 100206, "0878505606", "pesho@gmail.com", new List<int>() {5, 3, 4}),
                new Student("Sasho", "Stamatov", 19, 1, "Literature", 100305, "0988526626", "sasho@gmail.com", new List<int>() {5, 6, 6}), 
                new Student("Gosho", "Atanasov", 25, 1, "Literature", 100406, "0898555666", "gosho@abv.bg", new List<int>() {5, 6, 6}), 
                new Student("Moni", "Bonev", 21, 2, "Biology", 100106, "0888545656", "moni@abv.bg", new List<int>() {5, 2, 3}),
                new Student("Pepi", "Pipev", 26, 1, "Biology", 100505, "0888454556", "pepi@abv.bg", new List<int>() {5, 2, 4})
            };
            return students;
        }
    }
}
