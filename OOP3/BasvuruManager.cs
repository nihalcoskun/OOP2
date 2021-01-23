using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class BasvuruManager
    {

        public void BasvuruYap(IKrediManager krediManager, List<ILoggerService> loggerServices)
        {
            krediManager.Hesapla(); //tekli hesaplama

            foreach (var loggerService in loggerServices)
            {
                loggerService.Log(); //farklı alternatifler seçebilirim
                                     //her  loglayıcıyı çalıştır diyorum
            }


           // KonutKrediManager konutKrediManager = new KonutKrediManager();
            //konutKrediManager.Hesapla();
        }

        public void KrediOnBilgilendirmesiYap(List<IKrediManager> krediler)
        {
            foreach(var kredi in krediler)
            {
                kredi.Hesapla();
            }
        }
    }
}
