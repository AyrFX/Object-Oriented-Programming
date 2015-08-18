// Problem 5. 64 Bit array
// Define a class BitArray64 to hold 64 bit values inside an ulong value.
// Implement IEnumerable<int> and Equals(…), GetHashCode(), [], == and !=.

namespace BitArray_64
{
    using System;
    using System.Collections;
    using System.Collections.Generic;

    public class BitArray64 : IEnumerable<int>
    {
        private ulong number;

        // Indexers
        public int this[int index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                return (int)((this.number >> index) & 1);
            }

            set
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }

                if (value < 0 || value > 1)
                {
                    throw new ArgumentException();
                }

                if (value == 0)
                {
                    this.number = this.number & (ulong)(~(1 << index));
                }
                else
                {
                    this.number = this.number | (ulong)(1 << index);
                }
            }
        }

        // Operators
        public static bool operator ==(BitArray64 firstArray, BitArray64 secondArray)
        {
            return firstArray.Equals(secondArray);
        }

        public static bool operator !=(BitArray64 firstArray, BitArray64 secondArray)
        {
            return !firstArray.Equals(secondArray);
        }

        // Methods
        public override bool Equals(object obj)
        {
            return this.number == ((BitArray64)obj).number;
        }

        public override int GetHashCode()
        {
            return this.number.GetHashCode() ^ (this.number.GetHashCode() * this.number.GetHashCode());
        }

        public IEnumerator<int> GetEnumerator()
        {
            for (int i = 0; i < 64; i++)
            {
                yield return this[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
    }
}
