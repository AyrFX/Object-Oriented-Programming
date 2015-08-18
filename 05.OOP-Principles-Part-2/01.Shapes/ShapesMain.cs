namespace Shapes
{
    using System;
    using Shapes.Classes;

    public class ShapesMain
    {
        public static void Main()
        {
            Shape[] arrayOfShapes = new Shape[]
            {
                new Triangle(3, 4),
                new Triangle(12.7, 3.4),
                new Triangle(7.4, 4.7),
                new Rectangle(16.7, 12.3),
                new Rectangle(7.9, 21),
                new Rectangle(12.16, 7.7),
                new Square(7.3),
                new Square(12.19),
                new Square(17.7)
            };
            foreach (var shape in arrayOfShapes)
            {
                Console.WriteLine(shape);
            }
        }
    }
}