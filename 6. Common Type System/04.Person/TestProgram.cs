using System;

namespace Person
{
    class TestProgram
    {
        static void Main(string[] args)
        {
            Person firstPerson = new Person("Joro", 22);
            Person secondPerson = new Person("Nakov");

            Console.WriteLine(firstPerson);
            Console.WriteLine(secondPerson);
        }
    }
}
