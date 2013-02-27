using System;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string model = Console.ReadLine();
        string manufacturer = Console.ReadLine();
        GSM myGSM = new GSM(model, manufacturer);
    }
}