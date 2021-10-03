using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            
            ICreditManager needCreditManager = new NeedCreditManager();
            ICreditManager vehicleCreditManager = new VehicleCreditManager();
            ICreditManager homeCreditManager = new HomeCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            AppealManager appealManager = new AppealManager();
            appealManager.BasvuruYap(vehicleCreditManager,fileLoggerService);

            List<ICreditManager> credits = new List<ICreditManager>() {needCreditManager,vehicleCreditManager};

            //appealManager.KrediOnBilgilendirmesiYap(credits);


        }



    }
}
