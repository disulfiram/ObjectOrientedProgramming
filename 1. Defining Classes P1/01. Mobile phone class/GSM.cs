using System;
using System.Linq;
using System.Text;

public class GSM
{
    //fields
    private string model;
    private string manufacturer;
    private float? price = null;
    private string owner;
    private Display currentDisplay;
    private Battery currentBattery;
    private static GSM iPhone4S;

    //constructors
    public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, float price) : this(model, manufacturer, price, null, null, null)
    {
    }

    public GSM(string model, string manufacturer, string owner) : this(model, manufacturer, null, owner, null, null)
    {
    }

    public GSM(string model, string manufacturer, Display currentDisplay, Battery currentBattery) : this(model, manufacturer, null, null, currentDisplay, currentBattery)
    {
    }

    public GSM(string model, string manufacturer, float? price, string owner, Display currentDisplay, Battery currentBattery)
    {
        this.model = model;
        this.manufacturer = manufacturer;
        this.price = price;
        this.owner = owner;
        this.currentDisplay = currentDisplay;
        this.currentBattery = currentBattery;
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

    public string Manufacturer
    {
        get
        {
            return this.manufacturer;
        }
        set
        {
            this.manufacturer = value;
        }
    }

    public float? Price
    {
        get
        {
            return this.price;
        }
        set
        {
            if (value > 0)
            {
                this.price = value;
            }
        }
    }

    public string Owner
    {
        get
        {
            return this.owner;
        }
        set
        {
            this.owner = value;
        }
    }

    public Display CurrentDisplay
    {
        get
        {
            return this.currentDisplay;
        }
        set
        {
            this.currentDisplay = value;
        }
    }

    public Battery CurrentBattery
    {
        get
        {
            return this.currentBattery;
        }
        set
        {
            this.currentBattery = value;
        }
    }
    

    //methods
    public override string ToString()
    {
        return string.Format("Model - {0}/n Manufacturer - {1}/n Price - {2}/n");
    }
}