using System;
using System.Linq;

public enum BatteryType
{
    Unknown,
    LiIon,
    NiMH,
    NiCd,
    LiPo
};

public class Battery
{
    //fields
    private int? idleHours;
    private int? talkHours;
    public BatteryType type = BatteryType.Unknown;
    public static readonly Battery iPhone4SBattery = new Battery(200, 14, BatteryType.LiPo);


    //contructors
    public Battery() : this( null, null, BatteryType.Unknown)
    {
    }

    public Battery(int idleHours, int talkHours) : this(idleHours, talkHours, BatteryType.Unknown)
    {
    }

    public Battery(BatteryType type) : this(null, null, type)
    {
        this.type = type;
    }

    public Battery(int? idleHours, int? talkHours, BatteryType type)
    {
        this.idleHours = idleHours;
        this.talkHours = talkHours;
        this.type = type;
    }


    //properties
    public int? IdleHours
    {
        get
        {
            return this.idleHours;
        }
        set 
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be negative!"); 
            }
            this.idleHours = value; 
        }
    }

    public int? TalkHours
    {
        get
        {
            return this.talkHours;
        }
        set
        {
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Cannot be negative!");
            }
            this.talkHours = value;
        }
    }

    public BatteryType Type
    {
        get
        {
            return this.type;
        }
        set
        {
            this.type = value;
        }
    }

    //methods
    public override string ToString()
    {
        return string.Format("Hours talk - {0}\nHours idle - {1}\nModle - {2}", this.TalkHours == null ? "unknown" : this.TalkHours.ToString(), this.IdleHours == null ? "unknown" : this.IdleHours.ToString(), this.Type.ToString());
    }
}