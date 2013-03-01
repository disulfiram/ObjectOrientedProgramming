using System;
using System.Linq;
using System.Collections.Generic;

class Program
{
    static void Main(string[] args)
    {
        List<GSM> arrayOfGSM = new List<GSM>();
        string choice = "new";
        while (choice.ToUpper() == "NEW")
        {
            //GSM init
            Console.WriteLine("Write 'new' in case you wish to add new device.");
            Console.Write("Model: ");
            string model = Console.ReadLine();
            Console.Write("Manufacturer: ");
            string manufacturer = Console.ReadLine();
            Console.Write("Price: ");
            float? price = float.Parse(Console.ReadLine());
            Console.Write("Owner: ");
            string owner = Console.ReadLine();

            //Display init
            Console.Write("Display resolution: ");
            string resolution = Console.ReadLine();
            Console.Write("Display colors: ");
            int? colors = int.Parse(Console.ReadLine());
            Display currentDisplay = new Display(resolution, colors);

            //Battery init
            Console.Write("Battery model: ");
            string batteryModel = Console.ReadLine();
            Console.Write("Battery stand by time: ");
            int? idleHours = int.Parse(Console.ReadLine());
            Console.Write("Battery talk time:");
            int? talkHours = int.Parse(Console.ReadLine());
            Console.Write("Battery type: ");
            BatteryType type = Console.ReadLine();
            Battery currentBattery = new Battery(batteryModel, idleHours, talkHours, type);

            GSM currentGSM = new GSM(model, manufacturer, price, owner, currentDisplay, currentBattery);
            arrayOfGSM.Add(currentGSM);

            Console.WriteLine("Write 'new' in case you wish to add new device.");
            choice = Console.ReadLine();
        }

        for (int GSMwithIndes = 0; GSMwithIndes < arrayOfGSM.Count; GSMwithIndes++)
        {
            Console.WriteLine(arrayOfGSM[GSMwithIndes].ToString());
        }
    }
}