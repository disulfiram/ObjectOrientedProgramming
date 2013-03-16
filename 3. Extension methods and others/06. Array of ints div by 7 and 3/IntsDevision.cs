//Write a program that prints from given array of integers all numbers 
//that are divisible by 7 and 3. Use the built-in extension methods and 
//lambda expressions. Rewrite the same with LINQ.


using System;
using System.Linq;
using System.Collections.Generic;

class IntDevision
{
    private static void PrintDevisable(List<int> arrayOfInts)
    {
        var queryInts =
            from integers in arrayOfInts
            where integers % 3 == 0 && integers % 7 == 0
            select integers;
        foreach (int integer in queryInts)
        {
            Console.WriteLine(integer);
        }
    }

    static void Main()
    {
        List <int> arrayOfInts = new List<int>(1000);
        for (int i = 0; i < 1000; i++)
        {
            arrayOfInts.Add(i + 1);
        }
        
        //With Linq
        Console.WriteLine("With Linq");
        PrintDevisable(arrayOfInts);

        //With Lambda expresions
        Console.WriteLine("\nWith Lambda");
        var devisableInts = arrayOfInts.FindAll(x => (x % 3 == 0 && x % 7 == 0));
        foreach (int integer in devisableInts)
        {
            Console.WriteLine(integer);
        }
    }
}
