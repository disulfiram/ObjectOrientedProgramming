using System;
using System.Linq;

public class Call
{
    //fields
    private string callDate;
    private string callTime;
    private string dialedNumber;
    private TimeSpan callLength;

    //constructor(a phone will always recored all of the above)
    public Call(string callDate, string callTime, string dialedNumber, TimeSpan callLength)
    {
        this.callDate = callDate;
        this.callTime = callTime;
        this.dialedNumber = dialedNumber;
        this.callLength = callLength;
    }


    //properties

    public TimeSpan CallLength
    {
        get
        {
            return this.callLength;
        }
    }

    //methods
    
}