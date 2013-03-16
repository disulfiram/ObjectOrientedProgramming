using System;
using System.Collections.Generic;
using OrganizerCore.Entries;

namespace OrganizerCore
{
    internal class Organizer : IOrganizer
    {
        private IEnumerable<Entry> entries;

        // List of entries
        // Add, Remove
        // GetPrevious, GetCurrent, GetNext
        public IEnumerable<string> GetCurrent()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetNext()
        {
            throw new NotImplementedException();
        }

        public IEnumerable<string> GetPrevious()
        {
            throw new NotImplementedException();
        }

        public void Add(Entry aNewEntry)
        {
            throw new NotImplementedException();
        }

        public void Remove(Entry aEntryToRemove)
        {
            throw new NotImplementedException();
        }
    }
}
