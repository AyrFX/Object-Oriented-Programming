namespace IEnumerableExtension
{
	using System;
	using System.Collections.Generic;
	using System.Linq;
	
	public static class IEnumExtensions
	{
		public static T Sum<T>(this IEnumerable<T> IEnum) where T : IComparable, IConvertible
		{
			dynamic result = 0;
			foreach (var element in IEnum)
			{
				result += element;
			}
			return result;
		}
		
		public static T Product<T>(this IEnumerable<T> IEnum) where T : IComparable, IConvertible
		{
			dynamic result = 1;
			int count = 0;
			foreach (var element in IEnum)
			{
				result *= element;
				count++;
			}
			return result;
		}
		
		public static T Min<T>(this IEnumerable<T> IEnum) where T : IComparable, IConvertible
		{
			T result = IEnum.First();
			foreach (var element in IEnum)
			{
				if (element.CompareTo(result) < 0)
				{
					result = element;
				}
			}
			return result;
		}
		
		public static T Max<T>(this IEnumerable<T> IEnum) where T : IComparable, IConvertible
		{
			T result = IEnum.First();
			foreach (var element in IEnum)
			{
				if (element.CompareTo(result) > 0)
				{
					result = element;
				}
			}
			return result;
		}
		
		public static T Average<T>(this IEnumerable<T> IEnum) where T : IComparable, IConvertible
		{
			dynamic result = 0;
			foreach (var element in IEnum)
			{
				result += element;
			}
			return result / IEnum.Count();
		}
	}
}
