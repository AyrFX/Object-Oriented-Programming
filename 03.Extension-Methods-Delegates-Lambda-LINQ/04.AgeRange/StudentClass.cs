namespace AgeRange
{
	using System;
	
	public class Student
	{
		//Constructors
		public Student()
		{
		}
		
		public Student(string fName, string lName, int age)
		{
			this.FirstName = fName;
			this.LastName = lName;
			this.Age = age;
		}
		
		//Properties
		public string FirstName { get; set; }
		
		public string LastName { get; set; }
		
		public int Age { get; set; }
	}
}
