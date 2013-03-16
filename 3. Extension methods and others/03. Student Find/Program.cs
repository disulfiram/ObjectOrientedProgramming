using System;
using System.Collections.Generic;
using System.Linq;

class Student
{
    //fields
    private string firstName;
    private string lastName;
    private byte? age;

    //properties
    public string FirstName
    {
        get
        {
            return this.firstName;
        }
        private set
        {
            this.firstName = value;
        }
    }

    public string LastName
    {
        get
        {
            return this.lastName;
        }
        private set
        {
            this.lastName = value;
        }
    }

    public byte? Age
    {
        get 
        {
            return age;
        }
        private set
        {
            this.Age = value;
        }
    }

    //constructors
    public Student(string firstName, string lastName, byte age)
    {
        this.FirstName = firstName;
        this.lastName = lastName;
        this.age = age;
    }

    public Student(string firstName, string lastName) : this(firstName, lastName, 0)
    {
    }

    //methods
    public override string ToString()
    {
        return string.Format("{0} {1}, age: {2}", this.firstName, this.lastName, this.Age == null ? "unknown" : (dynamic)this.Age);
    }
}

class Program
{
    //Write a method that from a given array of students finds all students 
    //whose first name is before its last name alphabetically. Use LINQ query 
    //operators.
    static void FindStudents(List<Student> studentsList)
    {
        var queryStudents =
                           from student in studentsList
                           where student.FirstName.CompareTo(student.LastName) < 0 //change direction for the opposite effect
                           select student;
        foreach (var student in queryStudents)
        {
            Console.WriteLine(student.ToString());
        }
    }

    //Write a LINQ query that finds the first name and last name of all students 
    //with age between 18 and 24.
    static void FindStudentsAge(List<Student> studentList)
    {
        var queryStudents =
                           from student in studentList
                           where student.Age >= 18 && student.Age <= 24
                           select student;
        foreach (var student in queryStudents)
        {
            Console.WriteLine("{0} {1}", student.FirstName, student.LastName);
        }
    }

    static void Main(string[] args)
    {
        //Input data.
        Student firstStudent = new Student("Anastasiya", "Romanova", 17);       //change students to check if the program works, I think it does though
        Student secondStudent = new Student("George", "Carlin", 71);            
        Student thirdStudent = new Student("Arthur", "Pendragon", 24);
        List<Student> studentsList = new List<Student>();
        //I do not know a better way to create lists. Please tell me if there is :)
        studentsList.Add(firstStudent);
        studentsList.Add(secondStudent);
        studentsList.Add(thirdStudent);

        Console.WriteLine("Students with names alphabetically grater than family names\n");   //:D
        FindStudents(studentsList);

        Console.WriteLine("\n**********");
        Console.WriteLine("Students between (and including) the ages of 18 and 24\n");
        FindStudentsAge(studentsList);

        //Using the extension methods OrderBy() and ThenBy() with lambda 
        //expressions sort the students by first name and last name in 
        //descending order. Rewrite the same with LINQ.

        Console.WriteLine("\n**********");
        Console.WriteLine("Sort the students by first name in decending order\n");
        var studentsByFName = studentsList.OrderBy(student => student.FirstName);
        foreach (Student student in studentsByFName)
        {
            Console.WriteLine(student.ToString());
        }

        Console.WriteLine("\nNow with Linq\n");
        OrderStudenstByFName(studentsList);
        Console.WriteLine();

        Console.WriteLine("\n**********");
        Console.WriteLine("Sort the students by last name in decending order\n");
        var studentsByLName = studentsList.OrderBy(student => student.LastName);
        foreach (Student student in studentsByLName)
        {
            Console.WriteLine(student.ToString());
        }
        Console.WriteLine("\nNow with Linq\n");
        OrderStudenstByLName(studentsList);
        Console.WriteLine("\n**********");
    }

    private static void OrderStudenstByLName(List<Student> studentsList)
    {
        var queryStudents =
            from student in studentsList
            orderby student.LastName
            select student;
        foreach (Student student in queryStudents)
        {
            Console.WriteLine(student.ToString());
        }
    }

    private static void OrderStudenstByFName(List<Student> studentList)
    {
        var queryStudents =
                           from student in studentList
                           orderby student.FirstName
                           select student;
        foreach (var student in queryStudents)
        {
            Console.WriteLine(student.ToString());
        }
    }
}