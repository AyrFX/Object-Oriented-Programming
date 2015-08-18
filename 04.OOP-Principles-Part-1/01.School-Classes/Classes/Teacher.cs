namespace School_Classes.Classes
{
    using System;
    using System.Collections.Generic;

    public class Teacher : Person
    {
        // Fields
        private List<Discipline> disciplines;
        
        // Constructors
        public Teacher(string fName, string lName) : base(fName, lName)
        {
            this.disciplines = new List<Discipline>();
        }

        // Properties
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }            
        }

        // Methods
        public void AddDiscipline(Discipline discipline)
        {
            if (this.disciplines.IndexOf(discipline) != -1)
            {
                throw new ArgumentException("The discipline already exists!");
            }

            this.disciplines.Add(discipline);
        }

        public void RemoveDiscipline(Discipline discipline)
        {
            if (!this.disciplines.Remove(discipline))
            {
                throw new ArgumentException("The teacher doesn't teach this discipline or the discipline can't be removed!");
            }
        }

        public void ClearDisciplines()
        {
            this.disciplines.Clear();
        }

        public override string ToString()
        {
            return base.ToString() + ", disciplines: " + string.Join(", ", this.disciplines);
        }
    }
}
