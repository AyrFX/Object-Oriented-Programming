namespace LongestString
{
    using System;
    using System.Linq;

    class LStringStart
    {
        static void Main()
        {
            string[] arrayOfStrings = new string[] { "asd", "jgffg", "d", "", "sdaef4r2", "dqq", "cl" };
            var LongestStr =
                from strings in arrayOfStrings
                orderby strings.Length descending
                select strings;
            Console.WriteLine(LongestStr.ToArray()[0]);
        }
    }
}
