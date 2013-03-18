using System;

namespace Animal_Kingdom
{
    class Frog : Animal
    {
        #region Constructors
        
        public Frog(string name, byte age, string gender) : base(name, age, gender)
        { 
        }
        
        #endregion
            
        #region Methods
        
        public override void Sound()
        {
            Console.WriteLine("{0}: Ribbit!", this.Name);
        }
        
        #endregion
    }
}