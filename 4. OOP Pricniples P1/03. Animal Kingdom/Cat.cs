using System;

namespace Animal_Kingdom
{
    class Cat : Animal
    {
        #region Constructors
        
        public Cat(string name, byte age, string gender) : base(name, age, gender)
        {
        }
        
        #endregion
        
        #region Methods
        
        public override void Sound()
        {
            Console.WriteLine("{0}: Mew!", this.Name);
        }
    
        #endregion
    }
}