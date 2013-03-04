using System;
using System.Linq;

class GSMCallHistoryTest
{
    static void Main()
    {
        Display myDisplay = new Display("240 x 320 px", 256000000);
        Battery myBattery = new Battery(370, 9, BatteryType.LiPo);
        GSM myGSM = new GSM("W995", "SonyEricsson", 700, "Me", myDisplay, myBattery);
        myGSM.CallAdd(new Call(DateTime.Now.Date.ToString(), DateTime.Now.TimeOfDay.ToString(), "0888555666", new TimeSpan(1, 2, 3)));
        myGSM.CallAdd(new Call(DateTime.Now.Date.Subtract(new TimeSpan(1,0,0,0)).ToString(), DateTime.Now.TimeOfDay.ToString(), "0888555666", new TimeSpan(20, 2, 3)));
        myGSM.CallAdd(new Call(DateTime.Now.Date.Subtract(new TimeSpan(2, 3, 20, 30)).ToString(), DateTime.Now.TimeOfDay.ToString(), "0888555666", new TimeSpan(11, 22, 30)));

        Console.WriteLine(myGSM.CallCosts((decimal)0.37));

        long maxLength = 0;
        int indexOfCall = 0;
        for (int callIndex = 0; callIndex < myGSM.CallHistory.Count; callIndex++)
        {
            if (myGSM.CallHistory[callIndex].CallLength.Ticks > maxLength)
            {
                maxLength = myGSM.CallHistory[callIndex].CallLength.Ticks;
                indexOfCall = callIndex;
            }
        }

        myGSM.CallRemove(indexOfCall);

        Console.WriteLine(myGSM.CallCosts((decimal)0.37));
    }
}