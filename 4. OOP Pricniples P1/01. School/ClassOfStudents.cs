using System;
using System.Collections.Generic;
using System.Linq;

namespace School
{
    class ClassOfStudents : ICommentable
    {
        #region Fields
        
        private string className;
        private List<Teacher> teachers;
        private string comment;
        
        #endregion
        
        #region Properties
            
        public string ClassName
        {
            get
            {
                return this.className;
            }
            private set
            {
                this.className = value;
            }
        }
            
        public List<Teacher> Teachers
        {
            get
            {
                return this.teachers;
            }
            private set
            {
                this.teachers = value;
            }
        }
            
        public string Comment
        {
            get
            {
                return this.comment;
            }
            set
            {
                this.comment = value;
            }
        }

        #endregion

        internal Teacher Teacher
        {
            get
            {
                throw new System.NotImplementedException();
            }
            set
            {
            }
        }
        
        #region Constructors
            
        public ClassOfStudents(string className, List<Teacher> teachers, string comment)
        {
            this.ClassName = className;
            this.Teachers = teachers;
            this.Comment = comment;
        }

        public ClassOfStudents(string className, List<Teacher> teachers) : this(className, teachers, null)
        {
        }

        public ClassOfStudents(string className) : this(className, new List<Teacher>(), null)
        {
        }
        
        #endregion
            
        #region Methods

        public void AddTeacher(Teacher newTeacher)
        {
            this.Teachers.Add(newTeacher);
        }
                
        public void RemoveTeacher(Teacher teacherToBeRemoved)
        {
            try
            {
                this.Teachers.Remove(teacherToBeRemoved);
            }
            catch (Exception)
            {
                throw;
            }
        }

        #endregion
    }
}