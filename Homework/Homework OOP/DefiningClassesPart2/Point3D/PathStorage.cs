namespace Point3D
{
    using System;
    using System.IO;
    using System.Linq;

    public static class PathStorage
    {
        public static void WritePath(Path pathList, string filePath)
        {
            StreamWriter writer = new StreamWriter(filePath);
            using (writer)
            {
                foreach (Point3D item in pathList.PathList)
                {
                    writer.WriteLine(item);
                }
            }
        }

        public static Path ReadPath(string filePath)
        {
            Path pathList = new Path();
            StreamReader reader = new StreamReader(filePath);
            using (reader)
            {
                while (reader.EndOfStream == false)
                {
                    string line = reader.ReadLine();
                    string[] coord = line.Split(new char[] { ' ', ',', '\t' }, StringSplitOptions.RemoveEmptyEntries).ToArray();
                    Point3D point = new Point3D(int.Parse(coord[2]), int.Parse(coord[5]), int.Parse(coord[8]));
                    pathList.AddPath(point);
                }
            }

            return pathList;
        }
    }
}
