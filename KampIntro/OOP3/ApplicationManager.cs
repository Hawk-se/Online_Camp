using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ApplicationManager
    {
        // Method injection
        public void Apply(ICreditManager creditManager, List<ILoggerService> loggerServices) // çoklu Logger ile çalışmak için List<> eklendi
        {
            // Başvuran bilgilerini değerlendirme
            // 

            creditManager.Calculate();
            foreach (var loggerService in loggerServices)
            {
                loggerService.Log();
            }

        }


        // listedeki her kredinin hesabı
        public void CreditPreInformation(List<ICreditManager> credits)
        {
            foreach (var credit in credits)
            {
                credit.Calculate();
            }

        }
    }

}
