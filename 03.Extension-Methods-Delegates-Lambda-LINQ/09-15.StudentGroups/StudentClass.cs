namespace StudentGroups
{
	using System;
    using System.Collections.Generic;

	
	public class Student
	{
		//Constructors
		public Student()
		{
		}
		
		public Student(string fName, string lName, string fn, string tel, string email, List<int> marks, int groupNumber)
		{
			this.FirstName = fName;
			this.LastName = lName;
            this.FN = fn;
            this.Tel = tel;
            this.Email = email;
            this.Marks = marks;
            this.GroupNumber = groupNumber;
		}
		
		//Properties
		public string FirstName { get; set; }
		
		public string LastName { get; set; }

        public string FN { get; set; }

        public string Tel { get; set; }

        public string Email { get; set; }

        public List<int> Marks { get; set; }

        public int GroupNumber { get; set; }

	}
}
