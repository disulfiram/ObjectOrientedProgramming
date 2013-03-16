using System;

namespace OrganizerCore.Entries
{
    internal abstract class Entry : IEntry
    {
        // ToDo: Add WasHandled boolean property
        // ToDo: Array of strings with info (each Property)
        private DateTime createdOn;

        private string subject;

        protected Entry(string aSubject, string aComments)
        {
            this.Subject = aSubject;
            this.Comments = aComments;
            this.createdOn = DateTime.Now;
        }

        public string Subject
        {
            get
            {
                return this.Subject;
            }

            protected set
            {
                if (value.Length <= 0)
                {
                    // Custom Exception
                }

                this.subject = value;
            }
        }

        public DateTime CreatedOn
        {
            get
            {
                return this.createdOn;
            }
        }

        public string Comments { get; set; }

        public abstract bool IsObsolete();
    }
}
