namespace RangeExeption
{
    using System;

    public class RangeExeptionMain
    {
        public static void Main()
        {
            Console.Write("Please enter number: ");
            int number = int.Parse(Console.ReadLine());
            Console.Write("Please enter date: ");
            DateTime date = DateTime.Parse(Console.ReadLine());

            try
            {
                if (number < 1 || number > 100)
                {
                    throw new InvalidRangeException<int>("Out of range!", 1, 100, null);
                }

                if (date < new DateTime(1980, 1, 1) || date > new DateTime(2013, 12, 31))
                {
                    throw new InvalidRangeException<DateTime>("Out of range!", new DateTime(1980, 1, 1), new DateTime(2013, 12, 31), null);
                }
            }
            catch (InvalidRangeException<int> ex)
            {
                Console.WriteLine("Invalid range! The number must be between {0} and {1}.", ex.RangeStart, ex.RangeEnd);
            }
            catch (InvalidRangeException<DateTime> ex)
            {
                Console.WriteLine("Invalid range! The number must be between {0} and {1}.", ex.RangeStart, ex.RangeEnd);
            }
        }
    }
}