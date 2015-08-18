// Problem 4. Person class
// Create a class Person with two fields – name and age. Age can be left unspecified (may contain null value. Override ToString() to
// display the information of a person and if age is not specified – to say so.
// Write a program to test this functionality.

namespace Person
{
    using System;

    public class Program
    {
        public static void Main()
        {
            Person anyPerson = new Person("Pesho Goshev Toshev");
            Console.WriteLine(anyPerson);
            anyPerson.Age = 27;
            Console.WriteLine(anyPerson);
        }
    }
}
