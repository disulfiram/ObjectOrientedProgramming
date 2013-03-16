using System;
using System.Collections.Generic;

namespace School
{
    class Teacher : Human, ICommentable
    {
        #region Fields
        
        private List<Discipline> disciplines;
        private string comment;
        
        #endregion
        
        #region Properties
            
        public List<Discipline> Disciplines
        {
            get
            {
                return this.disciplines;
            }
            set
            {
                this.disciplines = value;
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

        internal Discipline Discipline
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
            
        public Teacher(string firstName, string middleName, string lastName, DateTime birthDate, List<Discipline> disciplines, string comment) : base(firstName, middleName, lastName, birthDate)
        {
            this.Disciplines = disciplines;
            this.Comment = comment;
        }

        public Teacher(string firstName, string middleName, string lastName, DateTime birthDate, List<Discipline> disciplines) : this(firstName, middleName, lastName, birthDate, disciplines, null)
        {
        }

        public Teacher(string firstName, string middleName, string lastName, DateTime birthDate) : this(firstName, middleName, lastName, birthDate, null, null)
        { 
        }
        
        #endregion
        
        #region Methods
        
        public void AddDiscipline(Discipline newDiscipline)
        {
            this.Disciplines.Add(newDiscipline);
        }
        
        public void RemoveDiscipline(Discipline disciplineToBeRemoved)
        {
            this.Disciplines.Remove(disciplineToBeRemoved);
        }
    
        public void ClearDisciplines()
        {
            this.Disciplines.Clear();
        }

        #endregion
    }
}