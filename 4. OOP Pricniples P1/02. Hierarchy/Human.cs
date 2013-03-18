using System;

namespace Hierarchy
{
    abstract class Human
    {
        #region Fields
        
        protected string firstName;
        protected string lastName;
        
        #endregion
        
        #region Properties
        
        public abstract string FirstName { get; set; }
        
        public abstract string LastName { get; set; }
        
        #endregion
        
        #region Constructors
        
        #endregion
        
        #region Methods
        
        public abstract override string ToString();

        #endregion
    }
}