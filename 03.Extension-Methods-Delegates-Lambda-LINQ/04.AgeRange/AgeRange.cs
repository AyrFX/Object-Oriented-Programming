//Problem 4. Age range
//Write a LINQ query that finds the first name and last name of all students with age between 18 and 24.

namespace AgeRange
{
    using System;
    using System.Linq;

    class AgeRange
    {
        static void Main()
        {
        	Student[] studentsArray = new Student[] {
        		new Student("Gosho", "Toshev", 21),
        		new Student("Dimitar", "Vasilev", 17),
        		new Student("Vasil", "Dimitrov", 25),
        		new Student("Jeliazko", "Momchilov", 28)};
        	
        	var StudentsByAge =
        		from student in studentsArray
        		where (student.Age >= 18 && student.Age <= 24)
        		select student;
        	
			foreach (var student in StudentsByAge)
			{
				Console.WriteLine(student.FirstName + " " + student.LastName + ", age " + student.Age);
			}
        }
    }
}
