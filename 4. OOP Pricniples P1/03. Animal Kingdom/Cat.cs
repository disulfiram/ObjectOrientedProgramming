using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Animal_Kingdom
{
    class Cat:Animal
    {
        public Cat(string name, byte age, string gender)
            : base(name, age, gender)
        {
        }
        public override void Sound()
        {
            Console.WriteLine("Mew!");
        }
    }
}
