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

    public GSM(string model, string manufacturer, Display currentDisplay, Battery currentBattery): this(model, manufacturer, null, null, currentDisplay, currentBattery)
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
    //methods
    public override string ToString()
    { 
        return string.Format("Model - {0}/n Manufacturer - {1}/n Price - {2}/n");
    }
}