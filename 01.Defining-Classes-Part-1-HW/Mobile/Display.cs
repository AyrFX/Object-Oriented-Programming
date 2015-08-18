using System;
namespace Mobile
{
    public class Display
    {
        //Fields
    	private float? size;
        private int? colors;
        
		
        //Constructors
        public Display() : this(null)
        {
        }
        
        public Display(float? size) : this(size, null)
        {
        }
        
        public Display(float? size, int? colors)
        {
            this.Size = size;
            this.Colors = colors;
        }
		
        
        //Properties
        public float? Size
        {
            get
            {
                return size;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The size of the display can't be null!");
                }
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The size of the display must be positive value!");
                }
                size = value;
            }
        }
        
        public int? Colors
        {
            get
            {
                return colors;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The number of colors of the display can't be null!");
                }
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The number of colors of the display must be positive value!");
                }
                colors = value;
            }
        }
    }
}
