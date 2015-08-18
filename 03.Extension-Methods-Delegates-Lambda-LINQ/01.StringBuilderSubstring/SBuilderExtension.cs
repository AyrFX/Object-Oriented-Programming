namespace SBuilderExtension
{
	using System;
	using System.Text;

	public static class SBuilderExt
	{
		public static string Substring(this StringBuilder sBld, int index, int length)
		{
			if (index < 0 || index > sBld.ToString().Length - 1)
			{
				throw new IndexOutOfRangeException("The index must be between 0 and the length of the string!");
			}
			string resultString = "";
			for (int i = index; i <= index + length && i < sBld.ToString().Length; i++)
			{
				resultString = resultString + sBld.ToString()[i];
			}
			return resultString;
		}
	}
}
