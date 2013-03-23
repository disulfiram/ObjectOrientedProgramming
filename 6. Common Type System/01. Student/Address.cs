using System;
using Student.Enum;
using System.Text;

namespace Student
{
    class Address
    {
        #region Fields
        
        private Country country;
        private string city;
        private string street;
        private short number;
        private int postalCode;
        
        #endregion
        
        #region Properties
        
        public Country Country
        {
            get
            {
                return this.country;
            }
            private set
            {
                this.country = value;
            }
        }
        
        public string City
        {
            get
            {
                return this.city;
            }
            set
            {
                this.city = value;
            }
        }
        
        public string Street
        {
            get
            {
                return this.street;
            }
            private set
            {
                this.street = value;
            }
        }
        
        public short Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Street number cannot be negative!");
                }
                this.number = value;
            }
        }
        
        public int PostalCode
        {
            get
            {
                return this.postalCode;
            }
            private set
            {
                if (value <= 0)
                {
                    throw new ArgumentException("Postal code cannot be negative number!");
                }
                this.postalCode = value;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public Address(byte country, string city, string street, short number, int postalCode)
        {
            this.Country = (Country)country;
            this.City = city;
            this.Street = street;
            this.Number = number;
            this.PostalCode = postalCode;
        }
        
        #endregion
        
        #region Methods
        
        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.AppendFormat("{0}, {1}", this.city, this.country.ToString());
            toString.AppendLine();
            toString.AppendFormat("{0}", this.postalCode);
            toString.AppendLine();
            toString.AppendFormat("{0}, {1}", this.street, this.number);
        
            return toString.ToString();
        }

        #endregion
    }
}