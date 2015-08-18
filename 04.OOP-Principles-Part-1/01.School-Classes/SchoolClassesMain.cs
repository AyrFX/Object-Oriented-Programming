// Problem 1. School classes
// We are given a school. In the school there are classes of students. Each class has a set of teachers. Each teacher teaches, a set of
// disciplines. Students have a name and unique class number. Classes have unique text identifier. Teachers have a name. Disciplines have
// a name, number of lectures and number of exercises. Both teachers and students are people. Students, classes, teachers and disciplines
// could have optional comments (free text block).
// Your task is to identify the classes (in terms of OOP) and their attributes and operations, encapsulate their fields, define the class
// hierarchy and create a class diagram with Visual Studio.

namespace School_Classes
{
    using System;
    using School_Classes.Classes;

    public class SchoolClassesMain
    {
        public SchoolClassesMain()
        {
            throw new System.NotImplementedException();
        }
    
        public static void Main()
        {
            Person p = new Person("Tosho", "Boshev");
            Console.WriteLine(p);

            Student s = new Student("Mitko", "Pitkov", 23);
            Console.WriteLine(s);

            Teacher t = new Teacher("Gosho", "Toshev");
            t.AddDiscipline(new Discipline("Mathematics", 20, 15));
            t.AddDiscipline(new Discipline("Geometry", 20, 25));
            t.AddDiscipline(new Discipline("Trigonometry", 25, 20));
            Console.WriteLine(t);

            Discipline d = new Discipline("Mathematics", 20, 15);
            Console.WriteLine(d);

            Class c = new Class("B");
            Console.WriteLine(c);
        }
    }
}
