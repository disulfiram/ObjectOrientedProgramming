//Implement a set of extension methods for IEnumerable<T> that 
//implement the following group functions: sum, product, min, max, 
//average.

using System;
using System.Collections.Generic;

static class IEnumerableExtensions
{
    public static T Sum<T>(this IEnumerable<T> enumeration) where T : struct
    {
        dynamic sum = 0;
        foreach (var number in enumeration)
        {
            sum += (dynamic)number;
        }
        return sum;
    }

    public static T Product<T>(this IEnumerable<T> enumeration) where T : struct
    {
        dynamic product = 1;
        foreach (var number in enumeration)
        {
            product *= (dynamic)number;
        }
        return product;
    }

    public static T Min<T>(this IEnumerable<T> enumeration) where T : struct
    {
        dynamic min = uint.MaxValue;
        foreach (var number in enumeration)
        {
            if (min > (dynamic)number)
            {
                min = (dynamic)number;
            }
        }
        return min;
    }

    public static T Max<T>(this IEnumerable<T> enumeration) where T : struct
    {
        dynamic max = int.MinValue;
        foreach (var number in enumeration)
        {
            if (max < (dynamic)number)
            {
                max = (dynamic)number;
            }
        }
        return max;
    }

    public static T Avarage<T>(this IEnumerable<T> enumeration) where T : struct
    {
        dynamic sum = 0;
        int counter = 0;
        foreach (var number in enumeration)
        {
            counter++;
            sum += (dynamic)number;
        }
        return sum / counter;
    }
}

class ExtensionsTest
{
    static void Main(string[] args)
    {
        List<int> testList = new List<int>();
        testList.Add(3);
        testList.Add(5);
        testList.Add(-5);
        Console.WriteLine("Sum: {0}",testList.Sum<int>());
        Console.WriteLine("Min: {0}", testList.Min<int>());
        Console.WriteLine("Max: {0}", testList.Max<int>());
        Console.WriteLine("Product: {0}", testList.Product<int>());
        Console.WriteLine("Avarage: {0}", testList.Avarage<int>());
        testList.Sum();
        int[] intArr = { 3, 5, -5,20,-10 };
        Console.WriteLine("Sum: {0}", intArr.Sum<int>());
        Console.WriteLine("Min: {0}", intArr.Min<int>());
        Console.WriteLine("Max: {0}", intArr.Max<int>());
        Console.WriteLine("Product: {0}", intArr.Product<int>());
        Console.WriteLine("Avarage: {0}", intArr.Avarage<int>());
    }
}