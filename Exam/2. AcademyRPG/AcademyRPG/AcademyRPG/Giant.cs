using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace AcademyRPG
{
    public class Giant : Character, IGatherer, IFighter
    {
        private int attackPoints = 150;
        private int defensePoints = 80;
        private bool isBoosted = false;

        public Giant(string name, Point position, int owner) : base(name, position, owner)
        {
            this.HitPoints = 200;
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

        public int DefensePoints
        {
            get
            {
                return this.defensePoints;
            }
            private set
            {
                this.DefensePoints = value;
            }
        }

        public int GetTargetIndex(List<WorldObject> availableTargets)
        {
            for (int i = 0; i < availableTargets.Count; i++)
            {
                if (availableTargets[i].Owner != this.Owner && availableTargets[i].Owner != 0)
                {
                    return i;
                }
            }

            return -1;
        }

        public bool TryGather(IResource resource)
        {
            if (resource.Type == ResourceType.Stone)
            {
                if (this.isBoosted == false)
                {
                    this.attackPoints = 250;
                }
                this.isBoosted = true;
                return true;
            }

            return false;
        }
    }
}