using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Student.Enum;

namespace Student
{
    class Student : ICloneable, IComparable<Student>
    {
        #region Fields
        
        private string firstName;
        private string middleName;
        private string lastName;
        private Univeristies university;
        private Specialities specialty;
        private Faculties faculty;
        private uint ssn;
        private Address address;
        
        #endregion
        
        #region Properties
        
        public string FirstName
        {
            get
            {
                return this.firstName;
            }
            private set
            {
                this.firstName = value;
            }
        }
        
        public string MiddleName
        {
            get
            {
                return this.middleName;
            }
            private set
            {
                this.middleName = value;
            }
        }
        
        public string LastName
        {
            get
            {
                return this.lastName;
            }
            private set
            {
                this.lastName = value;
            }
        }
        
        public Univeristies University
        {
            get
            {
                return this.university;
            }
            private set
            {
                this.university = value;
            }
        }
        
        public Specialities Specialty
        {
            get
            {
                return this.specialty;
            }
            private set
            {
                this.specialty = value;
            }
        }
        
        public Faculties Faculty
        {
            get
            {
                return this.faculty;
            }
            private set
            {
                this.faculty = value;
            }
        }
        
        public uint SSN
        {
            get
            {
                return this.ssn;
            }
            private set
            {
                this.ssn = value;
            }
        }
        
        public Address Address
        {
            get
            {
                return this.address;
            }
            set
            {
                this.address = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Student(string firstName, string middleName, string lastName, byte university, byte specialty, byte faculty, uint ssn, Address address)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.University = (Univeristies)university;
            this.Specialty = (Specialities)specialty;
            this.Faculty = (Faculties)faculty;
            this.SSN = ssn;
            this.Address = address;
        }
        
        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("{0} {1} {2}", this.firstName, this.middleName, this.lastName);
            toString.AppendLine();
            toString.AppendFormat("{0}, {1}, {2}", this.university.ToString(), this.specialty.ToString(), this.faculty.ToString());
            toString.AppendLine();
            toString.AppendFormat("{0}", this.ssn);
            toString.AppendLine();
            toString.AppendFormat("Address:");
            toString.AppendLine();
            toString.AppendFormat("{0}", this.address.ToString());
            return toString.ToString();
        }
        
        public override bool Equals(object param)
        {
            Student student = param as Student;
            if (student == null)
            {
                return false;
            }
            if (!Object.Equals(this.FirstName, student.FirstName) ||
                !Object.Equals(this.MiddleName, student.MiddleName) ||
                !Object.Equals(this.LastName, student.LastName) ||
                !Object.Equals(this.Address, student.Address))
            {
                return false;
            }
            if (this.University != student.University ||
                this.Faculty != student.Faculty ||
                this.Specialty != student.Specialty ||
                this.SSN != student.SSN)
            {
                return false;
            }
            return true;
        }
        
        public static bool operator ==(Student firstStudent, Student secondStudent)
        {
            return Student.Equals(firstStudent, secondStudent);
        }
        
        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(Student.Equals(firstStudent, secondStudent));
        }
        
        public override int GetHashCode()
        {
            return FirstName.GetHashCode() ^ LastName.GetHashCode();
        }
        
        #region IClonable Methods
        
        public Student Clone()
        {
            return new Student(
                this.firstName,
                this.middleName,
                this.lastName,
                (byte)this.university,
                (byte)this.specialty,
                (byte)this.faculty,
                this.ssn,
                this.address);
        }
        
        object ICloneable.Clone()  // Implicit implementation
        {
            return this.Clone();
        }
        
        public Student ChangeFirstName(string newName)
        {
            this.FirstName = newName;
            return this;
        }
        
        #endregion
        
        public int CompareTo(Student otherStudent)
        {
            if (this.firstName == otherStudent.firstName)
            {
                if (this.middleName == otherStudent.middleName)
                {
                    if (this.lastName == otherStudent.lastName)
                    {
                        return this.ssn.CompareTo(otherStudent.ssn);
                    }
                    return this.lastName.CompareTo(otherStudent.lastName);
                }
                return this.middleName.CompareTo(otherStudent.middleName);
            }
            return this.firstName.CompareTo(otherStudent.firstName);
        }
    
        #endregion
    }
}