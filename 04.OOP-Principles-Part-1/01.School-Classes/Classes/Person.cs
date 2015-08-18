namespace School_Classes.Classes
{
    using System;

    public class Person
    {
        private string fName;
        private string lName;

        ////Constructors
        public Person(string fName, string lName)
        {
            this.FName = fName;
            this.LName = lName;
        }

        ////Properties
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
                    throw new ArgumentNullException("The first name can't be empty!");
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
                    throw new ArgumentNullException("The last name can't be empty!");
                }

                this.lName = value;
            }
        }

        public string Comment { get; set; }

        ////Methods
        public override string ToString()
        {
            return this.fName + " " + this.lName;
        }
    }
}
