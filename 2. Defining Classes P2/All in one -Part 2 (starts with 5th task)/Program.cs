using System;
using System.Linq;


class Program
{
    static void Main(string[] args)
    {
        GenericList<int> testList = new GenericList<int>(6);
        testList.Add(4);
        testList.Remove(2);
        object test = testList[0];
        testList.Clear();
        testList.InsertAt(4, 30);
        
    }
}