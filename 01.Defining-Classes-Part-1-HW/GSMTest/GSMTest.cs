namespace Mobile
{
	using System;
	
    class GSMTest
    {
    	static void Main()
    	{
    		GSM[] GSMArray = new GSM[4];
    		GSMArray[0] = new GSM("Galaxy E7", "Samsung", 648, "Samsung owner", new Battery("E7 Battery", 800, 18, Battery.BatteryType.LiIon), new Display(5.5f, 16777216));
    		GSMArray[1] = new GSM("Lumia 640 XL LTE", "Microsoft", 394.24m, "MS owner", new Battery("Lumia 640 Battery", 888, 24, Battery.BatteryType.LiIon), new Display(5.7f, 16777216));
    		GSMArray[2] = new GSM("Xperia M4 Aqua Dual", "Sony", 520.87m, "Sony owner", new Battery("Xperia Aqua Battery", 488, 13.5f, Battery.BatteryType.LiIon), new Display(5f, 16777216));
    		GSMArray[3] = new GSM("G3 Screen", "LG", 899, "LG owner", new Battery("LG G3 Battery", 640, 13f, Battery.BatteryType.LiIon), new Display(5.9f, 16777216));
    		for (int i = 0; i < GSMArray.Length; i++)
    		{
    			Console.WriteLine(GSMArray[i].ToString());
    			Console.WriteLine(new String('=', 30));
    		}
    		Console.WriteLine(GSM.Iphone4S);
    	}
    }
}
