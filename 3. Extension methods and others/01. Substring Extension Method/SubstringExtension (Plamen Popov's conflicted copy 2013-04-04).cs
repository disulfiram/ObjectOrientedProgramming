//For this homework I made all classess in one project because I believe
//it is easier to check and write that way, for our tasks. Chears!

//Implement an extension method Substring(int index, int length) for the 
//class StringBuilder that returns new StringBuilder and has the same 
//functionality as Substring in the class String.

using System;
using System.Linq;
using System.Text;

static class SubstringExtension
{
    public static StringBuilder MySubstring(this StringBuilder str, int beginning, int length)
    {
        string stringBuilt = str.ToString();
        string[] letterArray = new string[length];
        for (int index = beginning, arrIndex = 0; arrIndex < length; index++, arrIndex++)
        {
            letterArray[arrIndex] = stringBuilt[index].ToString();
        }                                                           //first of all, I am sure this is not optimal
        return new StringBuilder(string.Join("",letterArray));      //second, I think the result is shifted with one index. Don't be hatin!
    }
}

class SubstringExtensionTest
{
    static void Main(string[] args)
    {
        StringBuilder testStringBuilder = new StringBuilder(Console.ReadLine());
        int index = int.Parse(Console.ReadLine());
        int length = int.Parse(Console.ReadLine());
        Console.WriteLine(testStringBuilder.MySubstring(index, length)); 
    }
}