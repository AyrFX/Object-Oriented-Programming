namespace StudentsOrder
{
	using System;
	
	public class Student
	{
		//Constructors
		public Student()
		{
		}
		
		public Student(string fName, string lName)
		{
			this.FirstName = fName;
			this.LastName = lName;
		}
		
		//Properties
		public string FirstName { get; set; }
		
		public string LastName { get; set; }
	}
}
