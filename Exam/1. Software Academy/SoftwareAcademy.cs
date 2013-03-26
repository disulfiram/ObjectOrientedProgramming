using System;
using System.Linq;
using System.Text;
using System.CodeDom.Compiler;
using Microsoft.CSharp;
using System.Reflection;
using System.Collections.Generic;

namespace SoftwareAcademy
{
    public interface ITeacher
    {
        string Name { get; set; }

        void AddCourse(ICourse course);

        string ToString();
    }

    public interface ICourse
    {
        string Name { get; set; }

        ITeacher Teacher { get; set; }

        void AddTopic(string topic);

        string ToString();
    }

    public interface ILocalCourse : ICourse
    {
        string Lab { get; set; }
    }

    public interface IOffsiteCourse : ICourse
    {
        string Town { get; set; }
    }

    public interface ICourseFactory
    {
        ITeacher CreateTeacher(string name);

        ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab);

        IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town);
    }

    public class CourseFactory : ICourseFactory
    {
        public ITeacher CreateTeacher(string name)
        {
            ITeacher newTeacher = new Teacher(name);
            return newTeacher;
        }

        public ILocalCourse CreateLocalCourse(string name, ITeacher teacher, string lab)
        {
            ILocalCourse newLocalCourse = new LocalCourse(name, teacher, lab);
            return newLocalCourse;
        }

        public IOffsiteCourse CreateOffsiteCourse(string name, ITeacher teacher, string town)
        {
            IOffsiteCourse newOffsiteCourse = new OffsiteCourse(name, teacher, town);
            return newOffsiteCourse;
        }
    }

    public class SoftwareAcademyCommandExecutor
    {
        static void Main()
        {
            string csharpCode = ReadInputCSharpCode();
            CompileAndRun(csharpCode);
        }

        private static string ReadInputCSharpCode()
        {
            StringBuilder result = new StringBuilder();
            string line;
            while ((line = Console.ReadLine()) != "")
            {
                result.AppendLine(line);
            }
            return result.ToString();
        }

        static void CompileAndRun(string csharpCode)
        {
            // Prepare a C# program for compilation
            string[] csharpClass =
            {
                @"using System;
                  using SoftwareAcademy;

                  public class RuntimeCompiledClass
                  {
                     public static void Main()
                     {"
                +
                csharpCode + @"
                     }
                  }"
            };

            // Compile the C# program
            CompilerParameters compilerParams = new CompilerParameters();
            compilerParams.GenerateInMemory = true;
            compilerParams.TempFiles = new TempFileCollection(".");
            compilerParams.ReferencedAssemblies.Add("System.dll");
            compilerParams.ReferencedAssemblies.Add(Assembly.GetExecutingAssembly().Location);
            CSharpCodeProvider csharpProvider = new CSharpCodeProvider();
            CompilerResults compile = csharpProvider.CompileAssemblyFromSource(
                compilerParams, csharpClass);

            // Check for compilation errors
            if (compile.Errors.HasErrors)
            {
                string errorMsg = "Compilation error: ";
                foreach (CompilerError ce in compile.Errors)
                {
                    errorMsg += "\r\n" + ce.ToString();
                }
                throw new Exception(errorMsg);
            }

            // Invoke the Main() method of the compiled class
            Assembly assembly = compile.CompiledAssembly;
            Module module = assembly.GetModules()[0];
            Type type = module.GetType("RuntimeCompiledClass");
            MethodInfo methInfo = type.GetMethod("Main");
            methInfo.Invoke(null, null);
        }
    }

    public abstract class Courses : ICourse
    {
        private string name;
        private ITeacher teacher;
        private IList<string> topicList = new List<string>();

        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        public ITeacher Teacher
        {
            get
            {
                return this.teacher;
            }
            set
            {
                this.teacher = value;
            }
        }

        public void AddTopic(string topic)
        {
            this.topicList.Add(topic);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.GetType().Name);
            toString.Append(": Name=");
            toString.Append(this.Name);
            if (this.Teacher != null)
            {
                toString.Append("; Teacher=" + this.Teacher.Name);
            }
            if (this.topicList.Count != 0)
            {
                toString.Append("; Topics=[");
                foreach (string topic in this.topicList)
                {
                    toString.Append(topic + ", ");
                }
                toString.Length -= 2;
                toString.Append("]");
            }
            if (this is ILocalCourse)
            {
                toString.Append("; Lab=" + ((ILocalCourse)this).Lab);
            }
            if (this is IOffsiteCourse)
            {
                toString.Append("; Town=" + ((IOffsiteCourse)this).Town);
            }
            
            return toString.ToString();
        }
    }

    public class LocalCourse : Courses, ILocalCourse     //The reason I do not create a class Course which is than inherited by two classes that implement ILocalCourse and IOffsiteCourse is that those two interfaces already inherti the ICourse interface!
    {
        //FIelds
        private string lab;
        
        //Properties
        public string Lab
        {
            get
            {
                return this.lab;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.lab = value;
            }
        }
        
        //Constructors
        public LocalCourse(string name, ITeacher teacher, string lab)
        {
            this.Lab = lab;
            this.Name = name;
            this.Teacher = teacher;
        }
        //Methods
    }

    public class OffsiteCourse : Courses, IOffsiteCourse     //The reason I do not create a class Course which is than inherited by two classes that implement ILocalCourse and IOffsiteCourse is that those two interfaces already inherti the ICourse interface!
    {
        //Fields
        private string town;

        //Properties
        public string Town
        {
            get
            {
                return this.town;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.town = value;
            }
        }

        //Constructors
        public OffsiteCourse(string name, ITeacher teacher, string town)
        {
            this.Name = name;
            this.Teacher = teacher;
            this.Town = town;
        }
    }

    public class Teacher : ITeacher
    {
        //Fields
        private string name;
        private IList<ICourse> courses = new List<ICourse>();

        //Properties
        public string Name
        {
            get
            {
                return this.name;
            }
            set
            {
                if (value == null)
                {
                    throw new ArgumentNullException();
                }
                this.name = value;
            }
        }

        //Construcors
        public Teacher(string name)
        {
            this.Name = name;
        }

        //Methods
        public void AddCourse(ICourse course)
        {
            this.courses.Add(course);
        }

        public override string ToString()
        {
            StringBuilder toString = new StringBuilder();
            toString.Append(this.GetType().Name);
            toString.Append(": Name=");
            toString.Append(this.Name);
            if (courses.Count != 0)
            {
                toString.Append("; Courses=[");
                foreach (ICourse course in courses)
                {
                    toString.Append(course.Name + ", ");
                }
                toString.Length--;
                toString.Length--;
                toString.Append("]");
            }
            return toString.ToString();
        }
    }
}