namespace Person
{
    using System;

    public class Person
    {
        // Fields
        private string name;

        // Constructors
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }

        public Person(string name) : this(name, null)
        {
        }

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The name can't be empty!");
                }

                this.name = value;
            }
        }

        public byte? Age { get; set; }

        // Methods
        public override string ToString()
        {
            if (this.Age == null)
            {
                return this.Name + ", age not specified";
            }
            else
            {
                return this.Name + ", age " + this.Age;
            }
        }
    }
}
