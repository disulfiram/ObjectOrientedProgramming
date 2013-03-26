using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Ninja : Character, IGatherer, IFighter
    {
        private int attackPoints = 0;
        private int hitPoints = 1;

        public Ninja(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = 1;
        }

        public int HitPoints
        {
            get
            {
                if (this.hitPoints <= 0)
                {
                    this.HitPoints = 1;
                }
                return this.hitPoints;
            }
            set 
            {
                if (value <= 0)
                {
                    this.hitPoints = 1; 
                }
                this.hitPoints = value;
            }
        }

        public int AttackPoints
        {
            get
            {
                return this.attackPoints;
            }
            private set
            {
                this.attackPoints = value;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            int counter = 0;
            var sortedTargets = from targets in availableTargets
                                orderby targets.HitPoints
                                select targets;
            foreach (var target in sortedTargets)
            {
                if ((target.Owner != this.Owner && target.Owner != 0))
                {
                    return counter;
                }
                counter ++;
            }
           
            return -1;
        }

        public int DefensePoints { get; set; }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                this.attackPoints += 2 * resource.Quantity;
                
                return true;
            }
            if (resource.Type == ResourceType.Lumber)
            {
                this.attackPoints += resource.Quantity;
            }

            return false;
        }
    }
}