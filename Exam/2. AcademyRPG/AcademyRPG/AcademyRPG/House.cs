using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class House : StaticObject
    {
        protected int Size { get; private set; }

        public ResourceType Type 
        { 
            get 
            { 
                return ResourceType.Lumber; 
            }
        }

        public int Quantity
        {
            get
            {
                return this.Size;
            }
        }

        public House(Point position, int owner) : base(position, owner)
        {
            this.HitPoints = 500;
        }
    }
}