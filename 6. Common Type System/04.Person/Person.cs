using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Person
{
    class Person
    {
        #region Fields
        
        private string name;
        private byte? age;
        
        #endregion
        
        #region Properties
        
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("Name is obligatory!");
                }
                this.name = value;
            }
        }
        
        public byte? Age
        {
            get
            {
                return this.age;
            }
            private set
            {
                if (value < 0)
                {
                    throw new ArgumentNullException("Age cannot be negative number!");
                }
                this.age = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Person(string name, byte? age)
        {
            this.Name = name;
            this.Age = age;
        }
        
        public Person(string name) : this(name, null)
        {
        }
        
        #endregion

        #region Methods
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.Name);
            toString.AppendFormat(" {0}", this.Age == null ? "unknown" : this.Age.ToString());
            return toString.ToString();
        }
        #endregion
    }
}