namespace Shapes.Classes
{
    public class Rectangle : Shape
    {
        // Constructors
        public Rectangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Methods
        public override double CalculateSurface()
        {
            return this.Width * this.Height;
        }

        public override string ToString()
        {
            return string.Format("The surface of the rectangle with width of {0} and height of {1} is {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
