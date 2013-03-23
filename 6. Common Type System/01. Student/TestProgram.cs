//This sollution (01.Student) contains sollutions to tasks 1, 2 and 3

using System;
using System.Collections.Generic;

namespace Student
{
    class TestProgram
    {
        static void Main()
        {
            Address firstAddress = new Address(1, "Sofia", "Solunska", 12,1000);
            Address secondAddress = new Address(2, "London", "Trafalgar sqr.", 1, 19000);
            Student firstStudent = new Student("Martin", "Bonchev", "Angelov", 1, 1, 1, 12345, firstAddress);
            Student secondStudent = new Student("Tony", "Bangladesh", "Terziev", 2, 2, 2, 23458, secondAddress);
            Student thirdStudent = new Student("Martin", "Bonchev", "Angelov", 1, 1, 1, 12345, firstAddress);
            List<Student> listOfStudents = new List<Student>(3); 
            listOfStudents.Add(firstStudent);
            listOfStudents.Add(secondStudent);
            listOfStudents.Add(thirdStudent);

            //test ToString()
            Console.WriteLine("ToString()");
            foreach (Student student in listOfStudents)
            {
                Console.WriteLine();
                Console.WriteLine(student.ToString());
            }
            PrintEnding();

            //test Equals()
            Console.WriteLine("Equals()");
            Console.WriteLine("First student equals Second student? {0}", firstStudent.Equals(secondStudent));
            Console.WriteLine("First student equals Third student? {0}", firstStudent.Equals(thirdStudent));
            PrintEnding();

            //test ==
            Console.WriteLine("==");
            Console.WriteLine("First student == Second student? {0}", firstStudent == secondStudent);
            Console.WriteLine("FIrst student == Third student? {0}", firstStudent == thirdStudent);
            PrintEnding();

            //test !=
            Console.WriteLine("!=");
            Console.WriteLine("First student != Second student? {0}", firstStudent != secondStudent);
            Console.WriteLine("FIrst student != Third student? {0}", firstStudent != thirdStudent);
            PrintEnding();

            //test GetHashCode()
            Console.WriteLine("GetHashCode");
            Console.WriteLine("First student hash code {0}", firstStudent.GetHashCode());
            Console.WriteLine("Second student hash code {0}", secondStudent.GetHashCode());
            Console.WriteLine("Third student hash code {0}", thirdStudent.GetHashCode());
            PrintEnding();

            //test CompareTo()
            //-1 means first item is before second item
            //0 means both items are the same (based on cryteria)
            //1 means second item is before first item
            Console.WriteLine("CompareTo()");
            Console.WriteLine("First student compared to Second student: {0}", firstStudent.CompareTo(secondStudent));
            Console.WriteLine("Second student compared to Third student: {0}", secondStudent.CompareTo(thirdStudent));
            Console.WriteLine("First student compared to Third student: {0}", firstStudent.CompareTo(thirdStudent));
            PrintEnding();

            //test Clone()
            Console.WriteLine("Clone()");
            Student clonedStudent = firstStudent.Clone();
            Console.WriteLine("First student compared to cloned student, before change: {0}", firstStudent.CompareTo(clonedStudent));
            Console.WriteLine("First student == Cloned student? {0}", firstStudent == clonedStudent);
            clonedStudent.ChangeFirstName("Gopeto");
            Console.WriteLine("First student compared to cloned student, after change: {0}", firstStudent.CompareTo(clonedStudent));        //If I am not mistaken task is completed this way :)
            Console.WriteLine("First student == Cloned student? {0}", firstStudent == clonedStudent);
        }
  
        private static void PrintEnding()
        {
            Console.WriteLine("*    *    *");
            Console.WriteLine();
        }
    }
}