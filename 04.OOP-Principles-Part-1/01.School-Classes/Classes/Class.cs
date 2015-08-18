namespace School_Classes.Classes
{
    using System;
    using System.Collections.Generic;

    public class Class
    {
        // Fields
        private List<Student> students;
        private List<Teacher> teachers;

        // Constructors
        public Class(string id)
        {
            this.Identifier = id;
            this.students = new List<Student>();
            this.teachers = new List<Teacher>();
        }

        public Class(string id, List<Teacher> teachers, List<Student> students)
        {
            this.Identifier = id;
            this.teachers = teachers;
            this.students = students;
        }

        // Properties
        public string Identifier { get; private set; }

        public string Comment { get; set; }

        public List<Student> Teachers { get; private set; }

        public List<Teacher> Students { get; private set; }

        // Methods
        public void AddTeacher(Teacher teacher)
        {
            if (this.teachers.IndexOf(teacher) != -1)
            {
                throw new ArgumentException("The teacher already exists!");
            }

            this.teachers.Add(teacher);
        }

        public void RemoveTeacher(Teacher teacher)
        {
            if (!this.teachers.Remove(teacher))
            {
                throw new ArgumentException("The teacher doesn't teach this class or the teacher can't be removed!");
            }
        }

        public void ClearTeachers()
        {
            this.teachers.Clear();
        }

        public void AddStudent(Student student)
        {
            if (this.students.IndexOf(student) != -1)
            {
                throw new ArgumentException("The student already exists!");
            }

            this.students.Add(student);
        }

        public void RemoveStudent(Student student)
        {
            if (!this.students.Remove(student))
            {
                throw new ArgumentException("The student is not in this class or can't be removed!");
            }
        }

        public void ClearStudents()
        {
            this.students.Clear();
        }

        public override string ToString()
        {
            return "Class " + this.Identifier;
        }
    }
}
