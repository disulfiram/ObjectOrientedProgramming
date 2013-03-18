using System;

namespace Animal_Kingdom
{
    class Dog : Animal
    {
        #region Constructors
        
        public Dog(string name, byte age, string gender) : base(name, age, gender)
        {
        }
        
        #endregion
        
        #region Methods
        
        public override void Sound()
        {
            Console.WriteLine("{0}: Arf", this.Name);
        }
    
        #endregion
    }
}