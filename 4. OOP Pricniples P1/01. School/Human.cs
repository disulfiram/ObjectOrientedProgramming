using System;

namespace School
{
    class Human
    {
        #region Fields
        
        private string firstName;
        private string middleName;
        private string lastName;
        private DateTime birthDate;
        
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
            
        public DateTime BirthDate
        {
            get
            {
                return this.birthDate;
            }
            private set
            {
                if (value < new DateTime(1913, 01, 01))
                {
                    throw new ArgumentOutOfRangeException("Too old for school!");
                }
                this.birthDate = value;
            }
        }
        
        #endregion
            
        #region Constructors
            
        public Human(string firstName, string middleName, string lastName, DateTime birthDate)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.BirthDate = birthDate;
        }
        
        public Human(string firstName, string lastName, DateTime birthDate) : this(firstName, null, lastName, birthDate)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}