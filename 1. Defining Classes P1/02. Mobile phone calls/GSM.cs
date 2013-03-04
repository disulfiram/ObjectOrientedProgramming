using System;
using System.Collections.Generic;
using System.Linq;

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
    public GSM(string model, string manufacturer) : this(model, manufacturer, null, null, new Display(), new Battery())
    {
    }

    public GSM(string model, string manufacturer, float price) : this(model, manufacturer, price, null,new Display(), new Battery())
    {
    }

    public GSM(string model, string manufacturer, string owner) : this(model, manufacturer, null, owner, new Display(), new Battery())
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
                throw new ArgumentNullException("Manufacturer is obligatory!");
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
            if (value < 0)
            {
                throw new ArgumentOutOfRangeException("Price can't be negative number!");
            }
            try
            {
                this.price = value;
            }
            catch (FormatException)
            {
                
                throw new FormatException("Price has to be a number!");
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

    public List<Call> CallHistory
    {
        get
        {
            return this.callHistory;
        }
    }
    

    //methods
    public override string ToString()
    {
        return string.Format("Model - {0}\nManufacturer - {1}\nPrice - {2}\nOwner - {3}\nBattery:\n{4}\nDisplay:\n{5}", this.Model == null ? "unknown" : this.Model, this.Manufacturer == null ? "unknown" : this.Manufacturer, this.Price == null ? "unknown" : this.Price.ToString(), this.Owner == null ? "unknown" : this.Owner, this.CurrentBattery.ToString(), this.CurrentDisplay.ToString());
    }

    public List<Call> CallAdd(Call newCall)   //method for adding calls
    {
        this.callHistory.Add(newCall);
        return callHistory;
    }

    public void CallRemove(int indexOfCall)
    {
        this.callHistory.RemoveAt(indexOfCall);
    }

    public void ClearHistory()          //method for clearing history
    {
        this.callHistory.Clear();
    }

    public decimal CallCosts(decimal pricePerMinute)
    {
        decimal totalCost = 0;
        foreach (Call call in callHistory)
        {
            int seconds = call.CallLength.Seconds;
            int minutes = call.CallLength.Minutes;
            int hours = call.CallLength.Hours;
            decimal callPrice = (decimal)((seconds / 60) + minutes+(hours*60)) * pricePerMinute;
            totalCost += callPrice;
        }
        return totalCost;
    }

    public void PrintCalls()
    {
    }
}