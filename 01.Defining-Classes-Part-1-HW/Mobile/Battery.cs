using System;
namespace Mobile
{
    public class Battery
    {
        //Fields
    	private string model;
        private float? hoursIdle;
        private float? hoursTalk;
        private BatteryType type;

        
        //Constructors
        public Battery() : this(null)
        {
        }
        
        public Battery(string model) : this(model, null)
        {
        }
        
        public Battery(string model, float? hoursIdle) : this(model, hoursIdle, null)
        {
        }
        
        public Battery(string model, float? hoursIdle, float? hoursTalk) : this(model, hoursIdle, hoursTalk, 0)
        {
        }
        
        public Battery(string model, float? hoursIdle, float? hoursTalk, BatteryType type)
        {
            this.Model = model;
            this.HoursIdle = hoursIdle;
            this.HoursTalk = hoursTalk;
            this.Type = type;
        }
        
        
        //Enumerators
        public enum BatteryType : byte {LiIon, NiMH, NiCd};

        
        //Properties
        public string Model
        {
            get
            {
                return model;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The model can't be null!");
                }
                model = value;
            }
        }
        
        public float? HoursIdle
        {
            get
            {
                return hoursIdle;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The hours idle value can't be null!");
                }
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The hours idle value must be positive value!");
                }
                hoursIdle = value;
            }
        }
        
        public float? HoursTalk
        {
            get
            {
                return hoursTalk;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The hours talk value can't be null!");
                }
                if (value < 1)
                {
                    throw new ArgumentOutOfRangeException("The hours talk value must be positive value!");
                }
                hoursTalk = value;
            }
        }
        
        public BatteryType Type
        {
            get
            {
                return type;
            }
            set
            {
                type = value;
            }
        }
    }
}
