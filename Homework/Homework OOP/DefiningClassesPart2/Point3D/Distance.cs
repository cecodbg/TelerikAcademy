namespace Point3D
{
    using System;

    public static class Distance
    {
        public static double CalculateDistance(Point3D firstPoint, Point3D secondPoint)
        {
            double result = 0;
            result = Math.Sqrt(((firstPoint.CoordinateX - secondPoint.CoordinateX) * (firstPoint.CoordinateX - secondPoint.CoordinateX)) +
                               ((firstPoint.CoordinateY - secondPoint.CoordinateY) * (firstPoint.CoordinateY - secondPoint.CoordinateY)) +
                               ((firstPoint.CoordinateZ - secondPoint.CoordinateZ) * (firstPoint.CoordinateZ - secondPoint.CoordinateZ)));

            return result;
        }
    }
}
