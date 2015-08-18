namespace BitArray_64
{
    using System;

    public class BitArray64Main
    {
        public static void Main()
        {
            BitArray64 bitArray1 = new BitArray64();
            foreach (var item in bitArray1)
            {
                System.Console.Write(item);
            }

            Console.WriteLine();
            bitArray1[7] = 1;
            bitArray1[12] = 1;
            bitArray1[28] = 1;
            foreach (var item in bitArray1)
            {
                Console.Write(item);
            }

            Console.WriteLine();

            BitArray64 bitArray2 = new BitArray64();
            Console.WriteLine(bitArray1 == bitArray2);
        }
    }
}
