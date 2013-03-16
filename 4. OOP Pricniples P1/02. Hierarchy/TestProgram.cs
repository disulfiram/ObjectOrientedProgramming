using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Hierarchy
{
    class TestProgram
    {
        static void PrintGenericList<T>(T[] listToBePrinted)
        {
            for (int listItem = 0; listItem < listToBePrinted.Length; listItem++)
            {
                Console.WriteLine(listToBePrinted[listItem].ToString()); 
            }
        }

        static void Main(string[] args)
        {
            #region InputData
            
            Student[] arrayOfStudents = //
            {
                new Student("Anatoli", "Peev", 6),
                new Student("Spas", "Argirov", 4),
                new Student("Ismail", "Abdul", 5),
                new Student("Glaro", "Zaicev", 6),
                new Student("Ming", "Lo", 2),
                new Student("Solnica", "Shareva", 3),
                new Student("Zlatko", "Georgiev", 3),
                new Student("Giorgi", "Georgiev", 5),
                new Student("Oleg", "Terziev", 5.5f),
                new Student("Haralampi", "Genev", 4.5f),
            };
            Worker[] arrayOfWorkers =
            {
                new Worker("Boqn", "Kalchev", 600, 10),
                new Worker("Angel", "Arhangleov", 300, 12),
                new Worker("Amon", "Tobin", 750, 3),
                new Worker("Simon", "Green", 1000, 2),
                new Worker("Simon", "Pegg", 500, 7),
                new Worker("Spas", "Marinov", 310, 8),
                new Worker("Asmat", "Georgiev", 1000, 9),
                new Worker("Aristotel", "Gurchev", 50, 2),
                new Worker("Toni", "Terziev", 2000, 10),
                new Worker("Liubomir", "Diev", 100, 7),
            };
            
            #endregion
            
            #region Input Print
            
            PrintGenericList<Student>(arrayOfStudents);
            Console.WriteLine();
            PrintGenericList<Worker>(arrayOfWorkers);
            Console.WriteLine("*   *   *");
            
            #endregion
            
            #region Basic sorting
            
            arrayOfStudents = arrayOfStudents.OrderBy(student => student.Grade).ToArray();
            arrayOfWorkers = arrayOfWorkers.OrderBy(worker => worker.MoneyPerHour()).ToArray();
            PrintGenericList<Student>(arrayOfStudents);
            Console.WriteLine();
            PrintGenericList<Worker>(arrayOfWorkers);
            Console.WriteLine("*   *   *");
            
            #endregion
            
            #region Complex sorting
            
            List<Human> allHumans = new List<Human>(20);
            allHumans.AddRange(arrayOfStudents);
            allHumans.AddRange(arrayOfWorkers);
            Human[] allHumansArray = allHumans.ToArray();
            allHumansArray = allHumansArray.OrderBy(human => human.FirstName).ToArray();      //nope!
            foreach (var person in allHumansArray)
            {
                Console.WriteLine(person.ToString());
            }
        
            #endregion
        }
    }
}