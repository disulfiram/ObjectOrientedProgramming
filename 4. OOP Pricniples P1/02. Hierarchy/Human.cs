using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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
        
        #endregion
    
        public abstract override string ToString();
    }
}