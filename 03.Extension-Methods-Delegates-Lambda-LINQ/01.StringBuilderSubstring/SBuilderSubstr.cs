//Problem 1. StringBuilder.Substring
//Implement an extension method Substring(int index, int length) for the class StringBuilder that returns new StringBuilder and has the same functionality as Substring in the
//class String.

namespace SBuilderExtension
{
    using System;
    using System.Text;

    class SBuilderSubstr
    {
        static void Main()
        {
        	StringBuilder someSB = new StringBuilder("StringBuilder class represents a mutable string of characters. This class cannot be inherited.");
        	Console.WriteLine(someSB.Substring(0, 19));
        }
    }
}
