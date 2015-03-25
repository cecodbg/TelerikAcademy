namespace Test
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    public static class IEnumerableExtensions
    {
        public static T SumCollection<T>(this IEnumerable<T> collection)
        {
            dynamic sum = 0;

            if (collection.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                sum += item;
            }

            return sum;
        }

        public static T ProductCollection<T>(this IEnumerable<T> collection)
        {
            dynamic product = 1;

            if (collection.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                product *= item;
            }

            return product;
        }

        public static T MinCollection<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            dynamic min = collection.First();

            if (collection.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                if (item.CompareTo(min) < 0)
                {
                    min = item;
                }
            }

            return min;
        }

        public static T MaxCollection<T>(this IEnumerable<T> collection) where T : IComparable<T>
        {
            dynamic max = collection.First();

            if (collection.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            foreach (var item in collection)
            {
                if (item.CompareTo(max) > 0)
                {
                    max = item;
                }
            }

            return max;
        }

        public static double AverageCollection<T>(this IEnumerable<T> collection)
        {
            double average = 0;

            if (collection.Count() == 0)
            {
                throw new ArgumentNullException();
            }

            average = (dynamic)collection.SumCollection() / (double)collection.Count();

            return average;
        }
    }
}
