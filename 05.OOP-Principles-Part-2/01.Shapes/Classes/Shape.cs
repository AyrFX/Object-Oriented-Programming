namespace Shapes.Classes
{
    using System;

    public abstract class Shape
    {
        // Fields
        private double width;
        private double height;

        // Properties
        public double Width
        {
            get
            {
                return this.width;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The width can be possitive number!");
                }

                this.width = value;
            }
        }

        public double Height
        {
            get
            {
                return this.height;
            }

            set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("The height can be possitive number!");
                }

                this.height = value;
            }
        }

        // Methods
        public abstract double CalculateSurface();
    }
}
