namespace Mobile
{
	using System;
	public class Call
	{
		//Fields
		private DateTime callDT;
		private string callNumber;
		private ushort callDuration;
		
		
		//Constructors
		public Call(DateTime callDT, string callNumber, ushort callDuration)
		{
			this.callDT = callDT;
			this.callNumber = callNumber;
			this.callDuration = callDuration;
		}
		
		
		//Properties
		public DateTime CallDateTime
		{
			get
			{
				return callDT;
			}
		}
		
		public string CallNumber
		{
			get
			{
				return callNumber;
			}
		}
		
		public ushort CallDuration
		{
			get
			{
				return callDuration;
			}
		}
	}
}
