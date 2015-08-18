namespace Mobile
{
    using System;
    using System.Collections.Generic;

    public class GSM
    {
        //Fields
    	private string model;
        private string manifacturer;
        private decimal? price;
        private string owner;
        private Battery battery;
        private Display display;
        private static GSM iPhone4S = new GSM("IPhone 4S", "Apple", 489, "IPhone owner", new Battery("616-0581", 200, 8, Battery.BatteryType.LiIon), new Display(3.5f, 16777216));
        private List<Call> callsList = new List<Call>();

        
        //Constructors
        public GSM(string model, string manifacturer) : this(model, manifacturer, null)
        {
        }
        
        public GSM(string model, string manifacturer, decimal? price) : this(model, manifacturer, price, null)
        {
        }
        
        public GSM(string model, string manifacturer, decimal? price, string owner) : this(model, manifacturer, price, owner, null)
        {
        }
        
        public GSM(string model, string manifacturer, decimal? price, string owner, Battery battery) : this(model, manifacturer, price, owner, battery, null)
        {
        }
        
        public GSM(string model, string manifacturer, decimal? price, string owner, Battery battery, Display display)
        {
            this.Model = model;
            this.Manifacturer = manifacturer;
            this.Price = price;
            this.Owner = owner;
            this.Battery = battery;
            this.Display = display;
            this.callsList = new List<Call>();
        }

        
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
        
        public string Manifacturer
        {
            get
            {
                return manifacturer;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The manifacturer can't be null!");
                }
                manifacturer = value;
            }
        }
        
        public decimal? Price
        {
            get
            {
                return price;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The price can't be null!");
                }
                price = value;
            }
        }
        
        public string Owner
        {
            get
            {
                return owner;
            }
            set
            {
                if (value == null || value == "")
                {
                    throw new ArgumentNullException("The owner can't be null!");
                }
                owner = value;
            }
        }
        
        public Battery Battery
        {
            get
            {
                return battery;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The battery can't be null!");
                }
                battery = value;
            }
        }
        
        public Display Display
        {
            get
            {
                return display;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("The display can't be null!");
                }
                display = value;
            }
        }
        
        public static GSM Iphone4S
        {
            get
            {
                return iPhone4S;
            }
        }
        
        public List<Call> CallsList
        {
        	get
        	{
        		return callsList;
        	}
        }
        
        
        //Methods
        public void GSMInfo ()
        {
        	//Console.Clear;
        	Console.WriteLine("Model: {0}", this.Model);
        	Console.WriteLine("Manifacturer: {0}", this.Manifacturer);
        	Console.WriteLine("Price: {0}", this.Price);
        	Console.WriteLine("Owner: {0}", this.Owner);
        	Console.WriteLine("Battery Model: {0}", this.Battery.Model);
        	Console.WriteLine("Battery Type: {0}", this.Battery.Type);
        	Console.WriteLine("Battery Hours Idle: {0}", this.Battery.HoursIdle);
        	Console.WriteLine("Battery Hours Talk: {0}", this.Battery.HoursTalk);
        	Console.WriteLine("Display Size: {0}", this.Display.Size);
        	Console.WriteLine("Display Colors: {0}", this.Display.Colors);
        }
		
        public override string ToString()
		{
			return string.Format("GSM Model={0}, GSM manifacturer={1}, GSM price={2}, GSM owner={3}, GSM battery model={4}, GSM battery type={5}, GSM battery hours idle={6}, GSM battery hours talk={7}, GSM display size={8}, GSM display colors={9}", model, manifacturer, price, owner, battery.Model, battery.Type, battery.HoursIdle, battery.HoursTalk, display.Size, display.Colors);
		}
        
        public void AddCall(Call call)
        {
        	this.callsList.Add(call);
        }
        
        public void DeleteCall(int index)
        {
        	if (index < callsList.Count)
        	{
        		this.callsList.RemoveAt(index);
        	}
        	else
        	{
        		throw new IndexOutOfRangeException("The index of the call to delete is out of the list!");
        	}
        }

        public void ClearCalls()
        {
        	this.callsList.Clear();
        }
        
        public decimal GetCallsPrice(decimal pricePerMinute)
        {
        	int seconds = 0;
        	foreach (Call item in this.callsList)
        	{
        		seconds += item.CallDuration;
        	}
        	seconds /= 60;
        	return pricePerMinute * seconds;
        }
    }
}
