using System;

namespace Animal_Kingdom
{
    class Kitten : Cat
    {
        #region Constructors
        
        public Kitten(string name, byte age) : base(name, age, "female")
        { 
        }
    
        #endregion
    }
}