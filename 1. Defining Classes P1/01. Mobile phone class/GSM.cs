using System;
using System.Collections.Generic;
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
    private List<Call> callHistory;
    public static readonly GSM iPhone4S = new GSM("iPhone4S", "Apple", null, null, Display.iPhone4SDisplay, Battery.iPhone4SBattery);

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
        this.callHistory = new List<Call>();
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
            if (value == null)
            {
                throw new ArgumentNullException("Model is obligatory!");
            }
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
            if (value == null)
            {
                throw new ArgumentNullException("Manufacturer is obligatory");
            }
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

    public List<Call> CallHistory { get; set; }
    
    //methods
    public override string ToString()
    {
        return string.Format("Model - {0}/n Manufacturer - {1}/n Price - {2}/n");
    }

    public void CallAdd(Call newCall)   //method for adding calls
    {
        CallHistory.Add(newCall);
    }

    public void CallRemove(int indexOfCall)
    {
        this.callHistory.RemoveAt(indexOfCall);
    }

    public void ClearHistory()          //method for clearing history
    {
        CallHistory.Clear();
    }

    public decimal CallCosts(decimal pricePerMinute)
    {
        decimal totalCost = 0;
        foreach (Call call in CallHistory)
        {
            int seconds = call.CallLength.Second;
            int minutes = call.CallLength.Minute;
            decimal callPrice = (decimal)((seconds / 60) + minutes) * pricePerMinute;
            totalCost += callPrice;
        }
        return totalCost;
    }
}