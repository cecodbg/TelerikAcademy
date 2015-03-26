namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    
    class MobilePhoneDeviceMain
    {
        static void Main()
        {
            Console.WriteLine(Gsm.IPhone4S);

            GsmTest.CreateGsms();

            GsmCallHistoryTest.GsmCallHistory();
        }
    }
}
