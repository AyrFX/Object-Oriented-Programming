//Problem 5. Order students
//Using the extension methods OrderBy() and ThenBy() with lambda expressions sort the students by first name and last name in
//descending order.
//Rewrite the same with LINQ.

namespace StudentsOrder
{
    using System;
    using System.Linq;

    class StudentsOrder
    {
        static void Main()
        {
        	Student[] studentsArray = new Student[] {
        		new Student("Gosho", "Toshev"),
        		new Student("Dimitar", "Vasilev"),
        		new Student("Vasil", "Dimitrov"),
        		new Student("Jeliazko", "Momchilov"),
        		new Student("Damyan", "Petrov")};
        	
        	var OrderStudents =
        		studentsArray.OrderByDescending(student => student.FirstName).ThenByDescending(student => student.LastName);
        	
        	var LINQOrderStudents =
        		from student in studentsArray
        		orderby student.FirstName descending, student.LastName descending
        		select student;
        	
        	foreach (var student in OrderStudents)
        	{
        		Console.WriteLine(student.FirstName + " " + student.LastName);
        	}
        	
        	Console.WriteLine(new String('=', 30));
        	
        	foreach (var student in LINQOrderStudents)
        	{
        		Console.WriteLine(student.FirstName + " " + student.LastName);
        	}
        }
    }
}
