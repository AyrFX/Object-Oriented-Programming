namespace Students_and_Workers.Classes
{
    using System;

    public class Worker : Human
    {
        // Fields
        private decimal weekSalary;
        private float workHoursPerDay;
        
        // Constructors
        public Worker(string fName, string lName, decimal weekSalary, float workHoursPerDay) : base(fName, lName)
        {
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }

        // Properties
        public decimal WeekSalary
        {
            get
            {
                return this.weekSalary;
            }

            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Nobody will work for this money!!!");
                }

                this.weekSalary = value;
            }
        }

        public float WorkHoursPerDay
        {
            get
            {
                return this.workHoursPerDay;
            }

            private set
            {
                if (value > 24)
                {
                    throw new ArgumentException("The worker can't work more of 24 hours per day!");
                }

                this.workHoursPerDay = value;
            }
        }

        // Methods
        public decimal MoneyPerHour()
        {
            return this.weekSalary / (decimal)(this.workHoursPerDay * 5);
        }

        public override string ToString()
        {
            return base.ToString() + ", week salary: " + this.weekSalary + "; work hours per day: " + this.workHoursPerDay;
        }
    }
}
