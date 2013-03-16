using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    class Animal : ISound
    {
        #region Fields
        
        private bool isFemale;
        private byte age;
        private string name;
        
        #endregion
        
        #region Properties
            
        public string Gender
        {
            get
            {
                if (this.isFemale == true)
                {
                    return "Female";
                }
                if (this.isFemale == false)
                {
                    return "Male";
                }
                else
                {
                    throw new NullReferenceException("No value set!");
                }
            }
            private set
            {
                if (value.ToLower() == "female")
                {
                    this.isFemale = true;
                }
                if (value.ToLower() == "male")
                {
                    this.isFemale = false;   
                }
                else
                {
                    throw new ArgumentOutOfRangeException("Animal can either be male or female!");
                }
            }
        }
            
        public byte Age
        {
            get
            {
                return this.age;
            }
            set
            {
                if (value < 0 || value > 200)
                {
                    throw new ArgumentOutOfRangeException("Invalid age input!");
                }
                this.age = value;
            }
        }
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                this.name = value;
            }
        }
        #endregion
    
        #region Constructors
        public Animal(string name, byte age, string gender)
        {
            this.Name = name;
            this.Age = age;
            this.Gender = gender;
        }

        #endregion

        #region Methods

        public virtual void Sound()
        {
            Console.WriteLine("I am an animal and I don't know how to speak.");
        }

        #endregion
    }
}