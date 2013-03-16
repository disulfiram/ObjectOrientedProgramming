using System;

namespace School
{
    class Student : Human, ICommentable
    {
        #region Fields
        
        private string fakNumber;
        private string course;
        string comment;
        
        #endregion
        
        #region Properties
        
        public string FakNumber
        {
            get
            {
                return this.fakNumber;
            }
            private set
            {
                this.fakNumber = value;
            }
        }
        
        public string Course
        {
            get
            {
                return this.course;
            }
            private set
            {
                this.course = value;
            }
        }
        
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Student(string firstName, string middleName, string lastName, DateTime birthDate, string fakNumber, string course, string comment) : base(firstName, middleName, lastName, birthDate)
        {
            this.FakNumber = fakNumber;
            this.Course = course;
            this.Comment = comment;
        }
        
        public Student(string firstName, string middleName, string lastName, DateTime birthDate, string fakNumber, string course) : this(firstName, middleName, lastName, birthDate, fakNumber, course, null)
        {
        }
        
        #endregion
        
        #region Methods

        //change course

        #endregion
    }
}