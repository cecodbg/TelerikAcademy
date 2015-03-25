namespace Point3D
{
    using System;

    public struct Point3D
    {
        private static readonly Point3D StartO;

        static Point3D()
        {
            StartO = new Point3D(0, 0, 0);
        }

        public Point3D(double coordinateX, double coordinateY, double coordinateZ)
            : this()
        {
            this.CoordinateX = coordinateX;
            this.CoordinateY = coordinateY;
            this.CoordinateZ = coordinateZ;
        }

        public static Point3D Start0
        {
            get
            {
                return StartO;
            }
        }

        public double CoordinateX { get; private set; }

        public double CoordinateY { get; private set; }

        public double CoordinateZ { get; private set; }

        public override string ToString()
        {
            return string.Format("Coordinate X: {0}, Coordinate Y: {1}, Coordinate Z: {2}", this.CoordinateX, this.CoordinateY, this.CoordinateZ);
        }
    }
}
