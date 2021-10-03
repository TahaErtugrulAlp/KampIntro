using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class AppealManager  //Başvuru manager
    {
        //Method injection
        public void BasvuruYap(ICreditManager creditManager,ILoggerService loggerService)
        {
            //Başvuran bilgilerini değerlendirme

            creditManager.Calculate();
            loggerService.Log();

        }


        public void KrediOnBilgilendirmesiYap(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }
        }

    }
}
