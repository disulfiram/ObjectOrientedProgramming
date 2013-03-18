//Inherit the Engine class. Create a method ShootPlayerRacket. Leave it 
//empty for now

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    class Shoot : Engine
    {
        public Shoot(IRenderer renderer, IUserInterface userInterface)
            : base(renderer, userInterface)
        {
 
        }

        public void ShootPlayerRacket()
        {
 
        }
    }
}