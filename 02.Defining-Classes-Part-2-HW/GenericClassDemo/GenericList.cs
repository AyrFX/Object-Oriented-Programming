namespace GenericClass
{
    using System;

    public class GenericList<T> where T : System.IComparable<T>
    {
        ////Fields
        private T[] elements;
        private int capacity;
        private int lastFilled;

        ////Constructors
        public GenericList(int elementsCount)
        {
            this.elements = new T[elementsCount];
            this.Capacity = elementsCount;
            this.lastFilled = -1;
        }

        ////Properties
        public int Capacity
        {
            get
            {
                return this.capacity;
            }

            private set
            {
                this.capacity = value;
            }
        }

        ////Methods
        public void Add(T element)
        {
            if (this.lastFilled == this.capacity - 1)
            {
                this.AutoGrow();
            }

            this.lastFilled++;
            this.elements[this.lastFilled] = element;
        }

        public T GetItemAtIndex(int index)
        {
            if (index >= this.capacity || index < 0)
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }

            return this.elements[index];
        }

        public void RemoveElementAtIndex(int index)
        {
            if (index >= this.capacity || index < 0)
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }

            for (int i = index; i < this.lastFilled; i++)
            {
                this.elements[i] = this.elements[i + 1];
            }

            this.lastFilled--;
        }

        public void InsertElementAtIndex(T element, int index)
        {
            if (this.lastFilled == this.capacity - 1)
            {
                this.AutoGrow();
            }

            if (index >= this.capacity || index < 0)
            {
                throw new IndexOutOfRangeException("The index is out of range!");
            }

            for (int i = this.lastFilled + 1; i > index; i--)
            {
                this.elements[i] = this.elements[i - 1];
            }

            this.elements[index] = element;
            this.lastFilled++;
        }

        public void Clear()
        {
            this.lastFilled = -1;
            Array.Clear(this.elements, 0, this.elements.Length);
        }

        public int FindElement(T element)
        {
            return Array.IndexOf(this.elements, element);
        }

        public override string ToString()
        {
            string resultString = string.Empty;
            for (int i = 0; i <= this.lastFilled; i++)
            {
                if (!string.IsNullOrEmpty(resultString))
                {
                    resultString = resultString + ", ";
                }

                resultString = resultString + this.elements[i].ToString();
            }

            return resultString;
        }

        public T Min()
        {
            T minValue = this.elements[0];
            for (int i = 1; i <= this.lastFilled; i++)
            {
                if (this.elements[i].CompareTo(minValue) < 0)
                {
                    minValue = this.elements[i];
                }
            }

            return minValue;
        }

        public T Max()
        {
            T maxValue = this.elements[0];
            for (int i = 1; i <= this.lastFilled; i++)
            {
                if (this.elements[i].CompareTo(maxValue) > 0)
                {
                    maxValue = this.elements[i];
                }
            }

            return maxValue;
        }

        private void AutoGrow()
        {
            this.capacity *= 2;
            T[] newArray = new T[this.capacity];
            Array.Copy(this.elements, newArray, this.elements.Length);
            this.elements = newArray;
        }
    }
}
