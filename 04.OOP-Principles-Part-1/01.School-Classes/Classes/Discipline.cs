namespace School_Classes.Classes
{
    using System;

    public class Discipline
    {
        // Constructors
        public Discipline(string name, int lecturesNumber, int exercisesNumber)
        {
            this.Name = name;
            this.Lectures = lecturesNumber;
            this.Exercises = exercisesNumber;
        }

        // Properties
        public string Name { get; set; }

        public int Lectures { get; set; }

        public int Exercises { get; set; }

        public string Comment { get; set; }

        // Methods
        public override string ToString()
        {
            return this.Name + " - lectures: " + this.Lectures + "; exercises: " + this.Exercises;
        }
    }
}
