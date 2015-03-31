namespace RangeExceptions
{
    using System;
    using System.Text;

    public class TestExceptions
    {
        public static void Main()
        {
            Console.OutputEncoding = Encoding.Unicode;
            try
            {
                Console.WriteLine("Enter number in range from 1 to 100");
                int test = int.Parse(Console.ReadLine());

                if (test < 1 || test > 100)
                {
                    throw new InvalidRangeException<int>("Congratulations, you are an idiot", 1, 100);
                }
            }
            catch (InvalidRangeException<int> e)
            {
                Console.WriteLine(e.Message);
            }

            DateTime start = new DateTime(1980, 1, 1);
            DateTime end = new DateTime(2013, 12, 31);
            try
            {
                Console.WriteLine("Enter date in range from {0} to {1}", start, end);
                DateTime test = DateTime.Parse(Console.ReadLine());
                if (test < start || test > end)
                {
                    throw new InvalidRangeException<DateTime>("Congratulations, you are an idiot", start, end);
                }
            }
            catch (InvalidRangeException<DateTime> e)
            {
                Console.WriteLine(e.Message);
            }
        }
    }
}
