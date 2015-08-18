namespace EuclidianSpace
{
    using System.IO;

    public static class PathStorage
    {
        ////Methods
        public static void LoadPath(Path listOfPoints)
        {
            using (StreamReader reader = new StreamReader("..\\..\\input.txt"))
            {
                while (!reader.EndOfStream)
                {
                    string[] line = reader.ReadLine().Split(' ');
                    listOfPoints.AddPoint(new Point3D(double.Parse(line[0]), double.Parse(line[1]), double.Parse(line[2])));
                }
            }
        }

        public static void SavePath(Path listOfPoints)
        {
            using (StreamWriter writer = new StreamWriter("..\\..\\output.txt"))
            {
                for (int i = 0; i < listOfPoints.ListOfPoints.Count; i++)
                {
                    writer.WriteLine(listOfPoints.ListOfPoints[i].X + " " + listOfPoints.ListOfPoints[i].Y + " " + listOfPoints.ListOfPoints[i].Z);
                }
            }
        }
    }
}
