// Problem 2. Students and workers
// Define abstract class Human with a first name and a last name. Define a new class Student which is derived from Human and has a new
// field – grade. Define class Worker derived from Human with a new property WeekSalary and WorkHoursPerDay and a method MoneyPerHour()
// that returns money earned per hour by the worker. Define the proper constructors and properties for this hierarchy.
// Initialize a list of 10 students and sort them by grade in ascending order (use LINQ or OrderBy() extension method).
// Initialize a list of 10 workers and sort them by money per hour in descending order.
// Merge the lists and sort them by first name and last name.

namespace Students_and_Workers
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using Students_and_Workers.Classes;

    public class StudentsAndWorkersMain
    {
        public static void Main()
        {
            List<Student> listOfStudents = new List<Student>();
            listOfStudents.Add(new Student("Pesho", "Goshev", 3));
            listOfStudents.Add(new Student("Dimo", "Petrv", 7));
            listOfStudents.Add(new Student("Pavel", "Georgiev", 4));
            listOfStudents.Add(new Student("Tosho", "Metodiev", 1));
            listOfStudents.Add(new Student("Zlatin", "Kacarov", 9));
            listOfStudents.Add(new Student("Dobromir", "Yanev", 6));
            listOfStudents.Add(new Student("Nikolay", "Velkov", 2));
            listOfStudents.Add(new Student("Bojidar", "Borisov", 5));
            listOfStudents.Add(new Student("Vasil", "Slavov", 8));
            listOfStudents.Add(new Student("Dimitar", "Branimirov", 7));

            var studentsByGrade =
                from s in listOfStudents
                orderby s.Grade
                select s;

            Console.WriteLine("Students soted by grade:");            
            foreach (var student in studentsByGrade)
            {
                Console.WriteLine(student);
            }

            Console.WriteLine(new string('=', 30));

            List<Worker> listOfWorkers = new List<Worker>();
            listOfWorkers.Add(new Worker("Pesho", "Branimirov", 450, 4));
            listOfWorkers.Add(new Worker("Dimo", "Goshev", 630, 4.5f));
            listOfWorkers.Add(new Worker("Pavel", "Petrov", 915, 6));
            listOfWorkers.Add(new Worker("Tosho", "Georgiev", 420, 3.3f));
            listOfWorkers.Add(new Worker("Zlatin", "Metodiev", 945, 6.7f));
            listOfWorkers.Add(new Worker("Dobromir", "Kacarov", 1560, 8));
            listOfWorkers.Add(new Worker("Nikolay", "Yanev", 790, 4));
            listOfWorkers.Add(new Worker("Bojidar", "Velkov", 1500, 8));
            listOfWorkers.Add(new Worker("Vasil", "Borisov", 1830, 9));
            listOfWorkers.Add(new Worker("Dimitar", "Slavov", 1260, 7.5f));

            var workersByMPerHour = 
                from worker in listOfWorkers
                orderby worker.MoneyPerHour() descending
                select worker;

            Console.WriteLine("Workers sorted descending by hourly salary:");
            foreach (var worker in workersByMPerHour)
            {
                Console.WriteLine("{0}, {1:0.00}", worker, worker.MoneyPerHour());
            }

            Console.WriteLine(new string('=', 30));

            List<Human> mergedList = new List<Human>();
            mergedList.AddRange(listOfStudents);
            mergedList.AddRange(listOfWorkers);

            var sortedList =
                from human in mergedList
                orderby human.FName, human.LName
                select human;

            foreach (var human in sortedList)
            {
                Console.WriteLine("{0} {1}", human.FName, human.LName);
            }
        }
    }
}
