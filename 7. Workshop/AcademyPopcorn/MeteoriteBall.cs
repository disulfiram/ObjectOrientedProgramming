//Implement a MeteoriteBall. It should inherit the Ball class and should
//have a trail of TrailObject objects. Each trail object should last for 
//3 "turns". Other than that, the Meteorite ball should behave the same
//way as the nromal ball. You must not edit any existing .cs files.

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class MeteoriteBall : Ball
    {
        public MeteoriteBall(MatrixCoords topLeft, MatrixCoords speed) : base(topLeft, speed)
        { 
        }

        protected override void UpdatePosition()
        {
            this.TopLeft += this.Speed;
        }

        public TrailObject MeteoriteTrail()
        {
            TrailObject trail = new TrailObject(this.topLeft, 3);
            return trail;
        }
    }
}