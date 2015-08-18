namespace EuclidianSpace
{
    public struct Point3D
    {
        ////Fields
        private static readonly Point3D PointO = new Point3D(0, 0, 0);

        ////Constructors
        public Point3D(double x, double y, double z) : this()
        {
            this.X = x;
            this.Y = y;
            this.Z = z;
        }

        ////Properties
        public static Point3D GetOPoint
        {
            get
            {
                return PointO;
            }
        }

        public double X { get; set; }

        public double Y { get; set; }

        public double Z { get; set; }

        ////Methods
        public override string ToString()
        {
            return string.Format("[Point3D X={0}, Y={1}, Z={2}]", this.X, this.Y, this.Z);
        }
    }
}
