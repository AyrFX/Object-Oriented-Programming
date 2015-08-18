//Problem 2. IEnumerable extensions
//Implement a set of extension methods for IEnumerable<T> that implement the following group functions: sum, product, min, max,
//average.

namespace IEnumerableExtension
{
    using System;
    using System.Collections.Generic;

    class IEnumExt
    {
        static void Main()
        {
        	List<int> collection = new List<int>() { 3, 4, 7, 12, 16, 19, 21, 28};
        	Console.WriteLine("Sum = " + collection.Sum());
        	Console.WriteLine(new String('=', 30));
        	Console.WriteLine("Product = " + collection.Product());
        	Console.WriteLine(new String('=', 30));
        	Console.WriteLine("Min = " + collection.Min());
        	Console.WriteLine(new String('=', 30));
        	Console.WriteLine("Max = " + collection.Max());
        	Console.WriteLine(new String('=', 30));
        	Console.WriteLine("Average = " + collection.Average());
        }
    }
}
