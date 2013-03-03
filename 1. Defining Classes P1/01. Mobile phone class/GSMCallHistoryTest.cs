﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

class GSMCallHistoryTest
{
    Display myDisplay = new Display("240 x 320 px", 256000000);
    Battery myBattery = new Battery(370, 9, BatteryType.LiPo);
    GSM myGSM = new GSM("W995", "SonyEricsson", 700, "Me", myDisplay, myBattery);
    
}