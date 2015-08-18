namespace Student
{
    using System;

    public class StudentMain
    {
        public static void Main()
        {
            Student firstStudent = new Student("Pesho", "Goshev", "Toshev", "33344477712", "First Student's Address", "First Students Phone", "First Student's Phone",
                "fift", Specialties.Economics, Universities.UNSS, Faculties.Economics_Sciences);
            Student secondStudent = new Student("Gosho", "Toshev", "Peshov", "44477712333", "Second Student's Address", "Second Students Phone", "First Student's Phone",
                "third", Specialties.Mathematics, Universities.SU, Faculties.Mathematics_Sciences);

            Console.WriteLine(firstStudent);
            secondStudent = firstStudent.Clone() as Student;
            Console.WriteLine(firstStudent == secondStudent);
        }
    }
}
