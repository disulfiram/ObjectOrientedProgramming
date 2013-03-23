using System;

namespace BitArray
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Console.Write("Input ulong: ");
            ulong firstNumber;
            ulong.TryParse(Console.ReadLine(), out firstNumber);
            BitArray64 firstBitArray = new BitArray64(firstNumber);
            Console.Write("Input ulong: ");
            ulong secondNumber;
            ulong.TryParse(Console.ReadLine(), out secondNumber);
            BitArray64 secondBitArray = new BitArray64(secondNumber);


            Console.WriteLine("First number == Second number? {0}", firstBitArray == secondBitArray);
            Console.WriteLine("First number != Second number? {0}", firstBitArray != secondBitArray);
            Console.WriteLine("First number equals Second number? {0}", firstBitArray.Equals(secondBitArray));
            Console.WriteLine("First number hash code: {0}", firstBitArray.GetHashCode());
            Console.WriteLine("Second number hash code: {0}", secondBitArray.GetHashCode());

            Console.WriteLine("First 8 bits of first number");
            for (byte bit = 8; bit >= 1; bit--)     //starts from 8 and goes to 1 because otherwise the cycle goes to 255 before it breaks
            {
                
                Console.Write(firstBitArray[(byte)(bit-(byte)1)]);
            }
            Console.WriteLine();
        }
    }
}
