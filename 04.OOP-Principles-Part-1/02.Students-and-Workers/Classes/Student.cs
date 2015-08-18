namespace Students_and_Workers.Classes
{
    public class Student : Human
    {
        // Fields
        private int grade;

        // Constructors
        public Student(string fName, string lName, int grade) : base(fName, lName)
        {
            this.grade = grade;
        }

        // Properties
        public int Grade
        {
            get
            {
                return this.grade;
            }

            private set
            {
                this.grade = value;
            }
        }

        // Methods
        public override string ToString()
        {
            return base.ToString() + ", grade " + this.Grade;
        }
    }
}
