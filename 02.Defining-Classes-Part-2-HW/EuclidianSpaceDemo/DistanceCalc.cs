namespace EuclidianSpace
{
    using System;

    public static class DistanceCalc
    {
        public static double Distance(Point3D firstPoint, Point3D secondPoint)
        {
            return Math.Sqrt(Math.Pow(firstPoint.X - secondPoint.X, 2) + Math.Pow(firstPoint.Y - secondPoint.Y, 2) + Math.Pow(firstPoint.Z - secondPoint.Z, 2));
        }
    }
}
