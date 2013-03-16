using System.Collections.Generic;
using OrganizerCore.Entries;

namespace OrganizerCore
{
    internal interface IOrganizer
    {
        IEnumerable<string> GetCurrent();

        IEnumerable<string> GetNext();
        
        IEnumerable<string> GetPrevious();

        void Add(Entry aNewEntry);

        void Remove(Entry aEntryToRemove);
    }
}
