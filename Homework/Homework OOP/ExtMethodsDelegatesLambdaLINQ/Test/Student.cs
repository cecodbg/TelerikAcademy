namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Net.Mail;
    using System.Text.RegularExpressions;

    public class Student : Group
    {
        private string firstName;
        private string lastName;
        private int age;
        private int fNumber;
        private bool fNumberIsSet = false;
        private string tel;
        private bool telIsSet = false;
        private MailAddress email;
        private bool emailIsSet = false;
        private List<int> marks;
        private bool markIsSet = false;

        public Student(string firstName, string lastName, int age)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Age = age;           
        }

        public Student(string firstName, string lastName, int age, int groupNumber, string departmentName, int fNumber, string tel, string email, List<int> marks)
            : this(firstName, lastName, age)
        {
            this.GroupNumber = groupNumber;
            this.groupNumberIsSet = true;
            this.DepartmentName = departmentName;
            this.departmentNameIsSet = true;
            this.FNumber = fNumber;
            this.fNumberIsSet = true;
            this.Tel = tel;
            this.telIsSet = true;
            this.Email = new MailAddress(email);
            this.emailIsSet = true;
            this.Marks = new List<int>(marks);
            this.markIsSet = true;
        }

        public string FirstName
        {
            get
            {
                return this.firstName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("First name cannot be null or empty");
                }

                this.firstName = value;
            }
        }

        public string LastName
        {
            get
            {
                return this.lastName;
            }

            private set
            {
                if (string.IsNullOrWhiteSpace(value) || string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("Last name cannot be null or empty");
                }

                this.lastName = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 18)
                {
                    throw new ArgumentOutOfRangeException();
                }

                this.age = value;
            }
        }

        public int GroupNumber
        {
            get
            {
                return this.groupNumber;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException();
                }

                this.groupNumber = value;
            }
        }

        public string DepartmentName
        {
            get
            {
                return this.departmentName;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Department name cannot be null or empty");
                }

                this.departmentName = value;
            }
        }

        public int FNumber
        {
            get
            {
                return this.fNumber;
            }

            set
            {
                if (value < 0)
                {
                    throw new ArgumentException();
                }

                this.fNumber = value;
            }
        }

        public string Tel
        {
            get
            {
                return this.tel;
            }

            set
            {
                if (string.IsNullOrEmpty(value) || string.IsNullOrWhiteSpace(value))
                {
                    throw new ArgumentException("Tel. cannot be null or empty");
                }

                this.tel = value;
            }
        }

        public MailAddress Email
        {
            get
            {
                return this.email;
            }

            set
            {
                CheckEmail(value.Address);
                this.email = value;
            }
        }

        public List<int> Marks
        {
            get
            {
                return new List<int>(this.marks);
            }

            private set
            {
                this.marks = value;
            }
        }

        private void CheckEmail(string email)
        {
            if (!Regex.IsMatch(email.Trim(),
                @"^(?("")("".+?(?<!\\)""@)|(([0-9a-z]((\.(?!\.))|[-!#\$%&'\*\+/=\?\^`\{\}\|~\w])*)(?<=[0-9a-z])@))" +
                @"(?(\[)(\[(\d{1,3}\.){3}\d{1,3}\])|(([0-9a-z][-\w]*[0-9a-z]*\.)+[a-z0-9][\-a-z0-9]{0,22}[a-z0-9]))$",
                RegexOptions.IgnoreCase, TimeSpan.FromMilliseconds(250)))
            {
                throw new ArgumentException("Invalid email");
            }
        }

        public override string ToString()
        {
            return string.Format("{0} {1}{9}Age: {2}, Group number: {3}, Department: {4}, Faculty number: {5}{9}Pnone number: {6},Email address: {7}M{9}Mark: {8}",
                this.FirstName, this.LastName, this.Age,
                this.groupNumberIsSet ? string.Format("{0}", this.GroupNumber.ToString()) : string.Empty,
                this.departmentNameIsSet ? this.DepartmentName : string.Empty,
                this.fNumberIsSet ? string.Format("{0}", this.FNumber.ToString()) : string.Empty,
                this.telIsSet ? this.Tel : string.Empty,
                this.emailIsSet ? string.Format("{0}", this.Email) : string.Empty,
                this.markIsSet ? string.Join(", ", this.Marks) : string.Empty,
                Environment.NewLine);
        }
    }   
}
