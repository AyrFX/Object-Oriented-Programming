namespace EuclidianSpace
{
    using System;

    public class EuclidianSpaceDemo
    {
        public static void Main()
        {
            Point3D firstPoint = new Point3D(12.3, 4.7, 7.12);
            Console.WriteLine(firstPoint.ToString());
            Console.WriteLine(new string('=', 30));
            Point3D secondPoint = new Point3D(7.12, 12.3, 4.7);
            Console.WriteLine(secondPoint.ToString());
            Console.WriteLine(new string('=', 30));
            Console.WriteLine(DistanceCalc.Distance(firstPoint, secondPoint));
            Console.WriteLine(new string('=', 30));

            Path anyPath = new Path();
            anyPath.AddPoint(firstPoint);
            anyPath.AddPoint(secondPoint);

            PathStorage.SavePath(anyPath);

            Path loadedPath = new Path();
            PathStorage.LoadPath(loadedPath);
            for (int i = 0; i < loadedPath.ListOfPoints.Count; i++)
            {
                Console.WriteLine(loadedPath.ListOfPoints[i].ToString());
            }
        }
    }
}