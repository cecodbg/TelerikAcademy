namespace Generic
{
    using System;

    public class ProgramMain
    {
        public static void Main()
        {
            GenericList<int> newList = new GenericList<int>();
            Console.WriteLine(newList.Capacity);

            newList.AddElement(5);
            newList.AddElement(2);
            newList.AddElement(8);
            newList.AddElement(9);
            newList.AddElement(10);
            Console.WriteLine(newList.Capacity);
            Console.WriteLine(newList[4]);

            Console.WriteLine(newList);

            Console.WriteLine(newList.Max());
            Console.WriteLine(newList.Min());

            newList.Clear();
            Console.WriteLine(newList.Capacity);
        }
    }
}
