using System;
using System.Collections;
using System.Collections.Generic;

namespace BitArray
{
    class BitArray64 : IEnumerable<int>
    {
        #region Fields
        
        private ulong number;
        private byte[] bitsArray;
        
        #endregion
        
        #region Properties
        
        public ulong Number
        {
            get
            {
                return this.number;
            }
            private set
            {
                this.number = value;
            }
        }
        
        public byte[] InBits
        {
            get
            {
                return this.bitsArray;
            }
        }
        
        #endregion
        
        #region Constructors
        
        public BitArray64(ulong number)
        {
            this.Number = number;
            this.bitsArray = GetBits(this.number);
        }
        
        #endregion
        
        #region Methods
        
        public IEnumerator<int> GetEnumerator()
        {
            for (byte bit = 0; bit < this.bitsArray.Length; bit++)
            {
                yield return bitsArray[bit];
            }
        }
        
        IEnumerator IEnumerable.GetEnumerator()
        {
            return this.GetEnumerator();
        }
        
        private byte[] GetBits(ulong number)
        {
            byte[] bitArray = new byte[64];
            byte counter = 0;
            while (number != 0)
            {
                bitArray[counter] = (byte)(number % 2);
                number /= 2;
                counter++;
            }
            return bitArray;
        }
        
        public override bool Equals(object array)
        {
            BitArray64 secondArrayOfBits = array as BitArray64;
            for (int bit = 0; bit < bitsArray.Length; bit++)
            {
                if (this.bitsArray[bit] != secondArrayOfBits.bitsArray[bit])
                {
                    return false;
                }
            }
            return true;
        }
        
        public static bool operator ==(BitArray64 first, BitArray64 second)
        {
            return BitArray64.Equals(first, second);
        }
        
        public static bool operator !=(BitArray64 first, BitArray64 second)
        {
            return !BitArray64.Equals(first, second);
        }
        
        public byte this[byte index]
        {
            get
            {
                if (index < 0 || index > 63)
                {
                    throw new IndexOutOfRangeException();
                }
                return (byte)((this.number >> index) & 1);
            }
        }
        
        public override int GetHashCode()
        {
            return this.Number.GetHashCode() ^ this.bitsArray.GetHashCode();
        }
    
        #endregion
    }
}