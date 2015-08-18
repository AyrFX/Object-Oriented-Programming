// Problem 1. Student class
// Define a class Student, which contains data about a student – first, middle and last name, SSN, permanent address, mobile phone e-mail,
// course, specialty, university, faculty. Use an enumeration for the specialties, universities and faculties.
// Override the standard methods, inherited by System.Object: Equals(), ToString(), GetHashCode() and operators == and !=.

// Problem 2. IClonable
// Add implementations of the ICloneable interface. The Clone() method should deeply copy all object's fields into a new object of type
// Student.

// Problem 3. IComparable
// Implement the IComparable<Student> interface to compare students by names (as first criteria, in lexicographic order) and by social
// security number (as second criteria, in increasing order).

namespace Student
{
    using System;

    public class Student : ICloneable, IComparable<Student>
    {
        // Fields
        private string fName;
        private string mName;
        private string lName;
        private string ssn;
        private string address;
        private string phone;
        private string email;
        private string course;
        private Specialties speciality;
        private Universities university;
        private Faculties faculty;

        // Constructors
        public Student(string fName, string mName, string lName, string ssn, string address, string phone, string email, string course,
            Specialties speciality, Universities university, Faculties faculty)
        {
            this.FName = fName;
            this.MName = mName;
            this.LName = lName;
            this.SSN = ssn;
            this.Address = address;
            this.Phone = phone;
            this.EMail = email;
            this.Course = course;
            this.Speciality = speciality;
            this.University = university;
            this.Faculty = faculty;
        }

        // Properties
        public string FName
        {
            get
            {
                return this.fName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The first name can't be empty!");
                }

                this.fName = value;
            }
        }

        public string MName
        {
            get
            {
                return this.mName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The middle name can't be empty!");
                }

                this.mName = value;
            }
        }

        public string LName
        {
            get
            {
                return this.lName;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The last name can't be empty!");
                }

                this.lName = value;
            }
        }

        public string SSN
        {
            get
            {
                return this.ssn;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The SSN can't be empty!");
                }

                this.ssn = value;
            }
        }

        public string Address
        {
            get
            {
                return this.address;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The Address can't be empty!");
                }

                this.address = value;
            }
        }

        public string Phone
        {
            get
            {
                return this.phone;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The phone can't be empty!");
                }

                this.phone = value;
            }
        }

        public string EMail
        {
            get
            {
                return this.email;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The e-mail address can't be empty!");
                }

                this.email = value;
            }
        }

        public string Course
        {
            get
            {
                return this.course;
            }

            set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("The course can't be empty!");
                }

                this.course = value;
            }
        }

        public Specialties Speciality
        {
            get
            {
                return this.speciality;
            }

            set
            {
                this.speciality = value;
            }
        }

        public Universities University
        {
            get
            {
                return this.university;
            }

            set
            {
                this.university = value;
            }
        }

        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }

            set
            {
                this.faculty = value;
            }
        }

        // Methods
        public override bool Equals(object obj)
        {
            if ((obj as Student) == null)
            {
                return false;
            }

            if ((obj as Student).SSN == this.SSN)
            {
                return true;
            }

            return false;
        }

        public override string ToString()
        {
            return string.Format("{0} {1}  {2}, SSN: {3}, Address: {4}, Phone: {5}, E-mail address: {6}, Course: {7}, Speciality: {8}, University: {9}, Faculty: {10}",
                this.FName, this.MName, this.LName, this.SSN, this.Address, this.Phone, this.EMail, this.Course, this.Speciality, this.University, this.Faculty);
        }

        public override int GetHashCode()
        {
            return this.SSN.GetHashCode() ^ this.EMail.GetHashCode();
        }

        public object Clone()
        {
            return new Student(this.FName, this.MName, this.LName, this.SSN, this.Address, this.Phone, this.EMail, this.Course,
                this.Speciality, this.University, this.Faculty);
        }

        public int CompareTo(Student other)
        {
            string thisFullName = this.FName + this.MName + this.LName;
            string otherFullName = other.FName + other.MName + other.LName;
            if (thisFullName == otherFullName)
            {
                return this.SSN.CompareTo(other.SSN);
            }
            else
            {
                return thisFullName.CompareTo(otherFullName);
            }
        }

        // Operators
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return firstStudent.SSN == secondStudent.SSN;
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return firstStudent.SSN == secondStudent.SSN;
        }
    }
}
