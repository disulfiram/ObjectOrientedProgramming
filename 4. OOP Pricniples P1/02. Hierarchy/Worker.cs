using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class Worker : Human
    {
        #region Fields
        
        private int weekSalary;
        private byte workHoursPerDay;
        
        #endregion
        
        #region Properties
        
        public int WeekSalary
        {
            get 
            {
                return this.weekSalary;
            }
            set 
            {
                this.weekSalary = value;
            }
        }
        
        public byte WorkHoursPerDay
        {
            get 
            {
                return this.workHoursPerDay;
            }
            set
            {
                if (value > 12)
                {
                    throw new ArgumentOutOfRangeException("You slaverunner, you!");
                }
                this.workHoursPerDay = value;
            }
        }
        
        public override string FirstName
        {
            get
            {
                return this.firstName;
            }
            set
            {
                this.firstName = value;
            }
        }
        
        public override string LastName
        {
            get
            {
                return this.lastName;
            }
            set
            {
                this.lastName = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Worker(string firstName, string lastName, int weekSalary, byte workHoursPerDay)
        {
            this.FirstName = firstName;
            this.LastName = lastName;
            this.WeekSalary = weekSalary;
            this.WorkHoursPerDay = workHoursPerDay;
        }
        
        #endregion
        
        #region Methods
        
        public float MoneyPerHour()
        {
            float mph;
            mph = (float)this.WeekSalary / 5;
            mph = mph / this.WorkHoursPerDay;
            return mph;
        }
        
        public override string ToString()
        {
            return string.Format("{0} {1} {2} : Money per hour - {3}", this.GetType(), this.firstName, this.lastName, this.MoneyPerHour());
        }
    
        #endregion
    }
}