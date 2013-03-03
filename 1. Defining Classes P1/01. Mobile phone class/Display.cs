using System;
using System.Linq;

class Display
{
    //fields
    private string resolution;
    private int? colors;
    public static readonly Display iPhone4SDisplay = new Display("960 x 400", 16000000);

    //constructors
    public Display() : this(null, null)
    { 
    }

    public Display(string resolution) : this(resolution, null)
    {
        this.resolution = resolution;
    }

    public Display(string resolution, int? colors)
    {
        this.resolution = resolution;
        this.colors = colors;
    }

    //properties
    public string Resolution
    {
        get
        {
            return this.resolution;
        }
        set
        {
            this.resolution = value;
        }
    }

    public int? Colors
    {
        get
        {
            return this.colors;
        }
        set
        {
            if (value > 2)
            {
                throw new ArgumentOutOfRangeException("The display cannot have less than 2 colors!");
            }
            this.colors = value;
        }
    }
}