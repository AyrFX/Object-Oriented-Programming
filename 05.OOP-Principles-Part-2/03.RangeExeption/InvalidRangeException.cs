namespace RangeExeption
{
    using System;

    public class InvalidRangeException<T> : ApplicationException
    {
        // Constructors
        public InvalidRangeException(string msg)
            : base(msg)
        {
        }

        public InvalidRangeException(string msg, Exception innerEx)
            : base(msg, innerEx)
        {
        }

        public InvalidRangeException(string msg, T rangeStart, T rangeEnd, Exception innerEx)
            : this(msg, innerEx)
        {
            this.RangeStart = rangeStart;
            this.RangeEnd = rangeEnd;
        }

        // Properties
        public T RangeStart { get; private set; }

        public T RangeEnd { get; private set; }
    }
}
