namespace Students_and_Workers.Classes
{
    using System;

    public class Human
    {
        // Fields
        private string fName, lName;

        // Constructors
        public Human(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }

        // Properties
        public string FName
        {
            get
            {
                return this.fName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The humen must have first name!");
                }

                this.fName = value;
            }
        }

        public string LName
        {
            get
            {
                return this.lName;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentException("The hunen must have last name!");
                }

                this.lName = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return this.fName + " " + this.lName;
        }
    }
}
