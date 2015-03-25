namespace Point3D
{
    using System.Collections.Generic;

    public class Path
    {
        private List<Point3D> pathList;

        public Path()
        {
            this.pathList = new List<Point3D>();
        }

        public List<Point3D> PathList
        {
            get
            {
                return new List<Point3D>(this.pathList);
            }

            private set
            {
                this.pathList = value;
            }
        }

        public void AddPath(Point3D point)
        {
            this.pathList.Add(point);
        }

        public override string ToString()
        {
            return string.Join("\n", this.pathList);
        }
    }
}
