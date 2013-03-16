using System;

namespace OrganizerCore.Entries
{
    internal class Meeting : Entry
    {
        public Meeting(string aSubject, string aComments, DateTime aMeetingTime)
            : base(aSubject, aComments)
        {
            this.MeetingTime = aMeetingTime;
        }

        public DateTime MeetingTime { get; protected set; }

        public override bool IsObsolete()
        {
            throw new NotImplementedException();
        }
    }
}
