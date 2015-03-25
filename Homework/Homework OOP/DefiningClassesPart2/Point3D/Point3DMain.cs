namespace Point3D
{
    using System;
    using System.Globalization;
    using System.Threading;

    public class Point3DMain
    {
        public static void Main()
        {
            Thread.CurrentThread.CurrentCulture = CultureInfo.InvariantCulture;

            Point3D firstPoint = new Point3D(1, 20, 30);
            Console.WriteLine(firstPoint);
            Point3D secondPoint = new Point3D(5, 10, 35);
            Console.WriteLine(secondPoint);

            Point3D thirdPoint = Point3D.Start0;
            Console.WriteLine(thirdPoint);

            double distance = Distance.CalculateDistance(firstPoint, secondPoint);
            Console.WriteLine(distance);

            Path pathList = new Path();
            pathList.AddPath(firstPoint);
            pathList.AddPath(secondPoint);

            //Console.WriteLine(pathList);

            PathStorage.WritePath(pathList, "..\\..\\test.txt");
            PathStorage.ReadPath("..\\..\\test.txt");
            Console.WriteLine(PathStorage.ReadPath("..\\..\\test.txt"));
        }
    }
}
