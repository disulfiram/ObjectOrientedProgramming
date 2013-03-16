//Using delegates write a class Timer that can execute certain method at 
//each t seconds.

using System;
using System.Threading;

delegate void MyDelegate();

//second delegate was supposed to fix the problem I had. If you know why
//I could not make the program work I would be thankful problem is on line 54.

//delegate void AnotherDelegate(string input);

class Timer
{
    static int counter;
   

    public static void PrintLineNumbers()
    {
        counter = counter + 1;
        Console.WriteLine(counter);
    }

    //static void GreatSoftwareDeveloper(string inputName)
    //{
    //    Console.WriteLine("Hello {0}!", inputName);
    //}

    static void ForeverRepeat(MyDelegate methodToRepeat/*, AnotherDelegate alternateMethod*/, string devName)
    {
        TimeSpan interval = new TimeSpan(0, 0, 2);      //t
        while (true)
        {
            Thread.Sleep(interval);
            if (counter % 3 == 0)
            {
                //alternateMethod(devName);
                Console.WriteLine("Hello {0}!", devName);
                counter++;
            }
            else
            {
                methodToRepeat();
            }
        }
    }

    static void Main()
    {
        Console.WriteLine("This will last forever.");
        Console.WriteLine("What is your name?");
        string devName = Console.ReadLine();
        Timer.ForeverRepeat(PrintLineNumbers/*, GreatSoftwareDeveloper((dynamic)devName)*/, devName);
    }
}