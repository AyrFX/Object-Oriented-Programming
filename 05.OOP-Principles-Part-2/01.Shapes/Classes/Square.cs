namespace Shapes.Classes
{
    using System;

    public class Square : Rectangle
    {
        // Constructors
        public Square(double width) : base(width, width)
        {
        }

        // Methods
        public override string ToString()
        {
            return string.Format("The surface of the square with width of {0} is {1}", this.Width, this.CalculateSurface());
        }
    }
}
