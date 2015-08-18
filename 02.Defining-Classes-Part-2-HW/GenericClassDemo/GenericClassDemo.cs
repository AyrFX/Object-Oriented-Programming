namespace GenericClass
{
    using System;

    public class GenericClassDemo
    {
        public static void Main()
        {
            GenericList<int> exampleGeneric = new GenericList<int>(3);
            Console.WriteLine("GenericList capacity = " + exampleGeneric.Capacity);
            Console.WriteLine("ToString method result = " + exampleGeneric.ToString());
            Console.WriteLine(new string('=', 30));

            exampleGeneric.Add(3);
            exampleGeneric.Add(4);
            exampleGeneric.Add(7);
            exampleGeneric.Add(12);
            Console.WriteLine("ToString method result after adding elements = " + exampleGeneric.ToString());
            Console.WriteLine(new string('=', 30));

            Console.WriteLine("The element at index 0 is " + exampleGeneric.GetItemAtIndex(0));
            Console.WriteLine("The element at index 1 is " + exampleGeneric.GetItemAtIndex(1));
            Console.WriteLine("The element at index 2 is " + exampleGeneric.GetItemAtIndex(2));
            Console.WriteLine("The element at index 3 is " + exampleGeneric.GetItemAtIndex(3));
            Console.WriteLine(new string('=', 30));

            exampleGeneric.RemoveElementAtIndex(0);
            Console.WriteLine("ToString method result after removing element at index 0 = " + exampleGeneric.ToString());
            exampleGeneric.RemoveElementAtIndex(2);
            Console.WriteLine("ToString method result after removing element at index 2 = " + exampleGeneric.ToString());
            Console.WriteLine(new string('=', 30));

            exampleGeneric.InsertElementAtIndex(3, 0);
            Console.WriteLine("ToString method result after inserting value of 3 at index 0 = " + exampleGeneric.ToString());
            exampleGeneric.InsertElementAtIndex(12, 2);
            Console.WriteLine("ToString method result after inserting value of 12 at index 1 = " + exampleGeneric.ToString());
            Console.WriteLine(new string('=', 30));

            Console.WriteLine("The index of 12 is " + exampleGeneric.FindElement(12));
            Console.WriteLine("The index of 3 is " + exampleGeneric.FindElement(3));
            Console.WriteLine("The index of 4 is " + exampleGeneric.FindElement(4));
            Console.WriteLine(new string('=', 30));

            Console.WriteLine("The min value is " + exampleGeneric.Min());
            Console.WriteLine("The max value is " + exampleGeneric.Max());
            Console.WriteLine(new string('=', 30));

            exampleGeneric.Clear();
            Console.WriteLine("ToString method result after clearing = " + exampleGeneric.ToString());
            Console.WriteLine(new string('=', 30));
        }
    }
}