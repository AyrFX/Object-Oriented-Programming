namespace Animal_Hierarchy.Classes
{
    using System;
    using System.Linq;
    using Animal_Hierarchy.Interfaces;

    public abstract class Animal : ISound
    {
        // Fields
        private string name;
        private Sex sex;
        private int age;

        // Constructors
        public Animal(string name, Sex sex, int age)
        {
            this.Name = name;
            this.Sex = sex;
            this.Age = age;
        }

        // Properties
        public string Name
        {
            get
            {
                return this.name;
            }

            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The animal needs a name!");
                }

                this.name = value;
            }
        }

        public Sex Sex
        {
            get
            {
                return this.sex;
            }

            private set
            {
                this.sex = value;
            }
        }

        public int Age
        {
            get
            {
                return this.age;
            }

            private set
            {
                if (value < 0)
                {
                    throw new ArgumentException("The age can be 0 or positive number!");
                }

                this.age = value;
            }
        }

        // Methods
        public static double AverageAge(Animal[] array)
        {
            return array.Average(x => x.Age);
        }   

        public abstract void MakeSound();
    }
}
