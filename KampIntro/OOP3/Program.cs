using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager financeCreditManager = new FinanceCreditManager();
            ICreditManager carCreditManager = new CarCreditManager();
            ICreditManager morgageCreditManager = new MorgageCreditManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(morgageCreditManager, new DataBaseLoggerService());  // new DataBaseLoggerService alternatif olarak böyle de ifade edilebilir

            List<ICreditManager> credits = new List<ICreditManager> { financeCreditManager, carCreditManager };

            //applicationManager.CreditPreInformation(credits);


        }
    }
}
