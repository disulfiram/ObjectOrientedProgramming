using System;
using System.Linq;

public enum BatteryType
{
    unknown,
    LiIon,
    NiMH,
    NiCd
};

class Battery
{
    //fields
    private string model;
    private int? idleHours;
    private int? talkHours;
    public BatteryType type;

    //contructors
    public Battery() : this(null, null, null, 0)
    {
    }

    public Battery(string model) : this(model, null, null, 0)
    {
    }

    public Battery(int idleHours, int talkHours) : this(null, idleHours, talkHours, 0)
    {
    }

    public Battery(BatteryType type) : this(null, null, null, type)
    {
        this.type = type;
    }

    public Battery(string model, int? idleHours, int? talkHours, BatteryType type)
    {
        this.model = model;
        this.idleHours = idleHours;
        this.talkHours = talkHours;
        this.type = type;
    }

    //properties
    public string Model
    {
        get
        {
            return this.model;
        }
        set
        {
            this.model = value;
        }
    }

    public int? IdleHours
    {
        get
        {
            return this.idleHours;
        }
        set 
        {
            if (value > 0)
            {
                this.idleHours = value; 
            }
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
            if (value > 0)
            {
                this.talkHours = value;
            }
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
            if (value >= 0 && value < 3)
            {
                this.type = value;
            }
        }
    }
}