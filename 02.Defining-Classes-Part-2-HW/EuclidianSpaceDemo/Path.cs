namespace EuclidianSpace
{
    using System.Collections.Generic;

    public class Path
    {
        ////Fields
        private List<Point3D> list;

        ////Constructors
        public Path()
        {
            this.list = new List<Point3D>();
        }

        ////Properties
        public List<Point3D> ListOfPoints
        {
            get
            {
                return this.list;
            }
        }

        ////Methods
        public void AddPoint(Point3D point)
        {
            this.list.Add(point);
        }

        public void RemovePoint(Point3D point)
        {
            this.list.Remove(point);
        }
    }
}
