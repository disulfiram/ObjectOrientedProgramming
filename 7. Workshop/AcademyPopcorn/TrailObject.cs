//Implement a TrailObject class. It should inherit the GameObject class
//and should have a constructor which takes an additional "lifetime" 
//integer. The trailObject should disappear after a "lifetime" amount of
//turns. You must not edit any existin .cs files. Then test the TrailObject
//by adding an instance of it in the engine through the 
//AcademyPopcornMain.cs file 

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AcademyPopcorn
{
    public class TrailObject : GameObject
    {
        #region Fields
        
        int lifetime;
        
        #endregion
        
        #region
            
        public int LifeTime
        {
            get
            {
                return this.lifetime;
            }
            set
            {
                if (value <= 0)
                {
                    throw new ArgumentOutOfRangeException("Lifetime must be postive integer");
                }
                this.lifetime = value;
            }
        }
        
        #endregion
        
        #region Constructors
            
        public TrailObject(MatrixCoords topLeft, int lifetime) 
            : base(topLeft, new char[,]{ { '.' } })
        {
            this.lifetime = lifetime;
        }
        
        #endregion
            
        public override void Update()
        {
            this.lifetime--;
            if (this.lifetime <= 0)
            {
                this.IsDestroyed = true;
            }
        }
    }
}