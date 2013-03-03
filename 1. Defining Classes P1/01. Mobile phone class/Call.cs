using System;
using System.Linq;

public class Call
{
    //fields
    private DateTime callDate;
    private DateTime callTime;
    private string dialedNumber;
    private readonly DateTime callLength;

    //constructor(a phone will always recored all of the above)
    public Call(DateTime callDate, DateTime callTime, string dialedNumber, DateTime callLength)
    {
        this.callDate = callDate;
        this.callTime = callTime;
        this.dialedNumber = dialedNumber;
        this.callLength = callLength;
    }


    //properties

    public DateTime CallLength
    {
        get
        {
            return this.callLength;
        }
    }

    //methods
    
}