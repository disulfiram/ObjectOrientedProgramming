using System;
using System.Linq;

namespace School
{
    class Discipline : ICommentable
    {
        #region Fields
        
        private string name;
        private byte lectures;
        private byte exercises;
        private string comment;
        
        #endregion
        
        #region Properties
            
        public string Name
        {
            get
            {
                return this.name;
            }
            private set
            {
                this.name = value;
            }
        }
            
        public byte Lectures
        {
            get
            {
                return this.lectures;
            }
            private set
            {
                this.lectures = value;
            }
        }
            
        public byte Exercises
        {
            get
            {
                return this.exercises;
            }
            private set
            {
                this.exercises = value;
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
            
        #region Construcotrs
            
        public Discipline(string name, byte lectures, byte exercises, string comment)
        {
            this.Name = name;
            this.Lectures = lectures;
            this.Exercises = exercises;
            this.Comment = comment;
        }
        
        public Discipline(string name, byte lectures, byte exercises) : this(name, lectures, exercises, null)
        {
        }

        #endregion

        #region Methods

        #endregion
    }
}