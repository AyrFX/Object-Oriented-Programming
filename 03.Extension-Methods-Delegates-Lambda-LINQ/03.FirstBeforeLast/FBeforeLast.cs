//Problem 3. First before last
//Write a method that from a given array of students finds all students whose first name is before its last name alphabetically.
//Use LINQ query operators.

namespace FirstBeforeLast
{
    using System;
    using System.Linq;

    class FBeforeLast
    {
        static void Main()
        {
        	Student[] studentsArray = new Student[] {
        		new Student("Gosho", "Toshev"),
        		new Student("Dimitar", "Vasilev"),
        		new Student("Vasil", "Dimitrov"),
        		new Student("Jeliazko", "Momchilov")};
        	
        	var FindStdUnderCondition =
        		from student in studentsArray
        		where student.FirstName.CompareTo(student.LastName) < 0
        		select student;
        	
        	foreach (var student in FindStdUnderCondition)
        	{
        		Console.WriteLine(student.FirstName + " " + student.LastName);
        	}
        }
    }
}
