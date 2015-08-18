namespace School_Classes.Classes
{
    using System;

    public class Student : Person
    {
        // Fields
        private int classNumber;
        
        // Constructors
        public Student(string fName, string lName, int classNumber) : base(fName, lName)
        {
            this.ClassNumber = classNumber;
        }

        // Properties
        public int ClassNumber
        {
            get
            {
                return this.classNumber;
            }

            private set
            {
                if (value == 0)
                {
                    throw new ArgumentNullException("The student must have class number!");
                }

                this.classNumber = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + ", class number " + this.classNumber;
        }
    }
}
