namespace Shapes.Classes
{
    public class Triangle : Shape
    {
        // Constructors
        public Triangle(double width, double height)
        {
            this.Width = width;
            this.Height = height;
        }

        // Methods
        public override double CalculateSurface()
        {
            return (this.Width * this.Height) / 2;
        }

        public override string ToString()
        {
            return string.Format("The surface of the triangle with width of {0} and height of {1} is {2}", this.Width, this.Height, this.CalculateSurface());
        }
    }
}
