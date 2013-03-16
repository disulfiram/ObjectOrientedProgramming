using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassOfStudents myClass = new ClassOfStudents("11a", new List<Teacher>(), "");
            Student Me = new Student("Plamen","Plamenov" ,"Popov", DateTime.Now, "14320", "Civil engineering", "Lazy bastard!");
        }
    }
}
