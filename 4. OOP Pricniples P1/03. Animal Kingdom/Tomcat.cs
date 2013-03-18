using System;
using System.Linq;

namespace Animal_Kingdom
{
    class Tomcat : Cat
    {
        #region Constructors
        
        public Tomcat(string name, byte age) : base(name, age, "male")
        {
        }
        
        #endregion
    }
}