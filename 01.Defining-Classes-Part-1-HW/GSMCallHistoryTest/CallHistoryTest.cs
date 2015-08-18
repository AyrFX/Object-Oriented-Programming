namespace Mobile
{
	using System;
	
	class CallHistoryTest
	{
		public static void Main()
		{
			GSM someGSM = new GSM("Xperia M4 Aqua Dual", "Sony", 520.87m, "Sony owner", new Battery("Xperia Aqua Battery", 488, 13.5f, Battery.BatteryType.LiIon), new Display(5f, 16777216));
			someGSM.AddCall(new Call(new DateTime(2015, 03, 15, 9, 16, 53), "+359874433434", 67));
			someGSM.AddCall(new Call(new DateTime(2015, 02, 16, 18, 3, 7), "+359882223344", 124));
			someGSM.AddCall(new Call(new DateTime(2015, 01, 12, 19, 3, 12), "+359898887766", 23));
			someGSM.AddCall(new Call(new DateTime(2015, 03, 16, 12, 37, 15), "+359884455566", 85));
			someGSM.AddCall(new Call(new DateTime(2015, 03, 17, 16, 43, 0), "+359879933222", 283));
			someGSM.AddCall(new Call(new DateTime(2015, 03, 12, 20, 55, 19), "+359897774433", 149));
			someGSM.AddCall(new Call(new DateTime(2015, 01, 28, 17, 55, 4), "+359884562233", 508));
			Console.WriteLine("Current Calls History:");
			foreach (Call item in someGSM.CallsList)
			{
				Console.WriteLine("Call time: {0}, Number: {1}, Duration: {2} sec.", item.CallDateTime, item.CallNumber, item.CallDuration);
			}
			Console.WriteLine("\nThe total price for the calls is {0}", someGSM.GetCallsPrice(0.37m));
			int longestCall = someGSM.CallsList[0].CallDuration;
			int longestCallIndex = 0;
			for (int i = 0; i < someGSM.CallsList.Count; i++)
			{
				if (someGSM.CallsList[i].CallDuration > longestCall)
				{
					longestCall = someGSM.CallsList[i].CallDuration;
					longestCallIndex = i;
				}
			}
			someGSM.DeleteCall(longestCallIndex);
			Console.WriteLine("\nThe total price for the calls without the longest call is {0}", someGSM.GetCallsPrice(0.37m));
			someGSM.ClearCalls();
			Console.WriteLine("\nCleared Calls History:");
			foreach (Call item in someGSM.CallsList)
			{
				Console.WriteLine("Call time: {0}, Number: {1}, Duration: {2} sec.", item.CallDateTime, item.CallNumber, item.CallDuration);
			}
		}
	}
}