//Problem 9. Student groups
//Create a class Student with properties FirstName, LastName, FN, Tel, Email, Marks (a List), GroupNumber.
//Create a List<Student> with sample students. Select only the students that are from group number 2.
//Use LINQ query. Order the students by FirstName.

//Problem 10. Student groups extensions
//Implement the previous using the same query expressed with extension methods.

//Problem 11. Extract students by email
//Extract all students that have email in abv.bg.
//Use string methods and LINQ.

//Problem 12. Extract students by phone
//Extract all students with phones in Sofia.
//Use LINQ.

//Problem 13. Extract students by marks
//Select all students that have at least one mark Excellent (6) into a new anonymous class that has properties – FullName and Marks.
//Use LINQ.

//Problem 14. Extract students with two marks
//Write down a similar program that extracts the students with exactly two marks "2".
//Use extension methods.

//Problem 15. Extract marks
//Extract all Marks of the students that enrolled in 2006. (The students from 2006 have 06 as their 5-th and 6-th digit in the FN).

namespace StudentGroups
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class StudentGroups
    {
        static void Main()
        {
            Student[] studentsArray = new Student[] {
        		new Student("Gosho", "Toshev", "111106", "027734565", "gosho@mail.eu", new List<int> {6,5,3}, 1),
        		new Student("Dimitar", "Vasilev", "22222", "0894445566", "mitko@abv.bg", new List<int> {2,2,4}, 2),
        		new Student("Vasil", "Dimitrov", "333306", "085552221", "vasko@mail.eu", new List<int> {4,6,6}, 1),
        		new Student("Jeliazko", "Momchilov", "44444", "029990033", "jelazko@mail.eu", new List<int> {5,5}, 2),
        		new Student("Damyan", "Petrov", "555506", "0877788665", "damyan@abv.bg", new List<int> {3,4,6}, 1)};

            var SecondGroup =
                studentsArray.Where(student => student.GroupNumber == 2).OrderBy(student => student.FirstName);

            foreach (var student in SecondGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            Console.WriteLine(new string('=', 30));

            var LINQSecondGroup =
                from student in studentsArray
                where student.GroupNumber == 2
                orderby student.FirstName
                select student;

            foreach (var student in LINQSecondGroup)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine(new string('=', 30));

            //var StudentsByEmail =
            //    studentsArray.Where(student => student.Email.Contains("@abv.bg"));

            var StudentsByEmail =
                from student in studentsArray
                where student.Email.Contains("@abv.bg")
                select student;

            foreach (var student in StudentsByEmail)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }
            
            Console.WriteLine(new string('=', 30));

            //var TelsInSofia =
            //    studentsArray.Where(student => student.Tel.StartsWith("02"));
            var TelsInSofia =
                from student in studentsArray
                where student.Tel.StartsWith("02")
                select student;

            foreach (var student in TelsInSofia)
            {
                Console.WriteLine(student.FirstName + " " + student.LastName);
            }

            Console.WriteLine(new string('=', 30));

            var StudentsByMark =
                from student in studentsArray
                where student.Marks.Contains(6)
                select new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                };

            foreach (var student in StudentsByMark)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine(new string('=', 30));

            var StudentsTwoMarks =
                studentsArray.Where(student => student.Marks.FindAll(m => m == 2).Count == 2)
                .Select(student => new
                {
                    FullName = student.FirstName + " " + student.LastName,
                    Marks = student.Marks
                });

            foreach (var student in StudentsTwoMarks)
            {
                Console.WriteLine(student.FullName);
            }

            Console.WriteLine(new string('=', 30));

            var MarksOf2006Students =
                from student in studentsArray
                where student.FN[4] == '0' && student.FN[5] == '6'
                select student;

            List<int> marks = new List<int>();
            foreach (var student in MarksOf2006Students)
            {
                marks.AddRange(student.Marks);
            }

            Console.WriteLine(string.Join(", ", marks));
        }
    }
}
