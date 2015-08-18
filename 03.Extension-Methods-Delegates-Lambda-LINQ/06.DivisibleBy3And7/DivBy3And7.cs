//Problem 6. Divisible by 7 and 3
//Write a program that prints from given array of integers all numbers that are divisible by 7 and 3. Use the built-in extension methods and lambda expressions.
//Rewrite the same with LINQ.
	
namespace DivisibleBy3And7
{
	using System;
	using System.Linq;
	
	class MainProgram
	{
		public static void Main()
		{
			int[] arrayOfIntegers = new int[] {5, 57, 12, 554, 23, -21, 5423, -2354, 23, 57, 86, 864, 90, -3, 63, 6233, 321, -147 };
			
			var DivisibleLambda =
				from number in arrayOfIntegers
				where (number % 3 == 0 && number % 7 == 0)
				select number;
			
			foreach (var number in DivisibleLambda)
			{
				Console.WriteLine(number);
			}
						
			Console.WriteLine(new String('=', 30));
			
			var DivisibleLinq =
				arrayOfIntegers.Where(number => (number % 3 == 0 && number % 7 == 0));
			
			foreach (var number in DivisibleLinq)
			{
				Console.WriteLine(number);
			}
		}
	}
}