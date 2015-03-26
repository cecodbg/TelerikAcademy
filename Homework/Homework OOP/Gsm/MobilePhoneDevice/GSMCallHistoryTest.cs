namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class GsmCallHistoryTest
    {
        private static Gsm testGsm = new Gsm("Sony", "Xperia", "Gosho", 500,
                                     new Battery(BatteryType.LiIon, 1000),
                                     new Display(15000, 4));
        public static void GsmCallHistory()
        {
            List<Call> historyCall = new List<Call>();
            decimal pricePerMinute = 0.37M;

            for (int i = 0, j = 0; i < 10; i++, j+= 35)
            {
                Call call = new Call(DateTime.Now.AddHours(i), "0888565656", 30 + j);
                historyCall.Add(call);
            }

            foreach (Call call in historyCall)
            {
                Console.WriteLine(call);
                Console.WriteLine();
            }

            Console.WriteLine("{0}", testGsm.CalculateTotalPrice(historyCall, pricePerMinute));
            Console.WriteLine();

            historyCall = historyCall.OrderBy(x => x.Duration).ToList();
            historyCall.RemoveAt(historyCall.Count - 1);

            foreach (Call call in historyCall)
            {
                Console.WriteLine(call);
                Console.WriteLine();
            }

            Console.WriteLine("{0}", testGsm.CalculateTotalPrice(historyCall, pricePerMinute));
        }
    }
}
