using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<GSM> arrayOfGSM = new List<GSM>();

        GSM GSM1 = new GSM("Galaxy", "Samsung", 500.50f, "Google", new Display("240 x 320", 16000000), new Battery(500, 100, BatteryType.NiMH));
        arrayOfGSM.Add(GSM1);
        GSM GSM2 = new GSM("Xperia", "Sony");
        arrayOfGSM.Add(GSM2);
        GSM GSM3 = GSM.iPhone4S;
        arrayOfGSM.Add(GSM3);
        //GSM GSM4 = new GSM();
        //arrayOfGSM.Add(GSM4);
        
        //Uncomment below if you wish to add manually devices

        //string choice = "new";
        //while (choice.ToUpper() == "NEW")
        //{
        //    //GSM init
        //    Console.WriteLine("Write 'new' in case you wish to add new device.");
        //    Console.Write("Model: ");
        //    string model = Console.ReadLine();
        //    Console.Write("Manufacturer: ");
        //    string manufacturer = Console.ReadLine();
        //    Console.Write("Price: ");
        //    float? price = float.Parse(Console.ReadLine());
        //    Console.Write("Owner: ");
        //    string owner = Console.ReadLine();

        //    //Display init
        //    Console.Write("Display resolution: ");
        //    string resolution = Console.ReadLine();
        //    Console.Write("Display colors: ");
        //    int? colors = int.Parse(Console.ReadLine());
        //    Display currentDisplay = new Display(resolution, colors);

        //    //Battery init
        //    Console.Write("Battery model: ");
        //    string batteryModel = Console.ReadLine();
        //    Console.Write("Battery stand by time: ");
        //    int? idleHours = int.Parse(Console.ReadLine());
        //    Console.Write("Battery talk time:");
        //    int? talkHours = int.Parse(Console.ReadLine());
        //    Console.Write("Battery type: ");
        //    BatteryType type = (BatteryType)Enum.Parse(typeof(BatteryType), Console.ReadLine());        //test!!
        //    Battery currentBattery = new Battery(idleHours, talkHours, type);

        //    GSM currentGSM = new GSM(model, manufacturer, price, owner, currentDisplay, currentBattery);
        //    arrayOfGSM.Add(currentGSM);

        //    Console.WriteLine("Write 'new' in case you wish to add new device.");
        //    choice = Console.ReadLine();
        //}

        for (int GSMwithIndes = 0; GSMwithIndes < arrayOfGSM.Count; GSMwithIndes++)
        {
            Console.WriteLine(arrayOfGSM[GSMwithIndes].ToString());
            Console.WriteLine();
            Console.WriteLine();
        }
    }
}