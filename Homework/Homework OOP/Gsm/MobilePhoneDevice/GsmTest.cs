namespace MobilePhoneDevice
{
    using System;
    using System.Collections.Generic;

    public class GsmTest
    {
        public static void CreateGsms()
        {
            List<Gsm> gsms = new List<Gsm>();
            for (int i = 2, j = 0, k = 0; i < 10; i++, j += 100, k += 500)
            {
                gsms.Add(new Gsm("Sony", "Xperia", "Gosho", 500 + j,
                    new Battery(BatteryType.LiIon, 1000 + k),
                    new Display(15000 + k, 4 + (i / 2))));
            }

            foreach (Gsm gsm in gsms)
            {
                Console.WriteLine(gsm);
                Console.WriteLine();
                Console.WriteLine();
            }

            Console.WriteLine(Gsm.IPhone4S);
        }
    }
}
