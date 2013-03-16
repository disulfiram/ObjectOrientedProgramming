using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Student : Human
    {
        #region Fields
        
        private float grade;
        
        #endregion
        
        #region Properties
        
        public float Grade
        {
            get
            {
                return this.grade;
            }
            set
            {
                if (value < 1 || value > 6)
                {
                    throw new ArgumentOutOfRangeException("Grade muts be a number between 1 and 6");
                }
                this.grade = value;
            }
        }
        
        public override string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        
        public override string LastName
        {
            get 
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Student(string firstName, string lastName, float grade)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.Grade = grade;
        }
        
        #endregion
        
        #region Methods
        public override string ToString()
        {
            return string.Format("{0} {1} {2} : Grade - {3}", this.GetType(), this.FirstName, this.LastName, this.Grade);
        }
        
        #endregion
    }
}