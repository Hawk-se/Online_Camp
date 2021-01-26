using System;
using System.Collections.Generic;

namespace OOP3
{
    class Program
    {
        static void Main(string[] args)
        {
            ICreditManager financeLoanManager = new FinanceLoanManager();
            ICreditManager transportLoanManager = new TransportLoanManager();
            ICreditManager mortgageLoanManager = new MortgageLoanManager();
            ICreditManager artisanLoanManager = new ArtisanLoanManager();

            ILoggerService databaseLoggerService = new DataBaseLoggerService();
            ILoggerService fileLoggerService = new FileLoggerService();

            ApplicationManager applicationManager = new ApplicationManager();
            applicationManager.Apply(artisanLoanManager, new List<ILoggerService> { new DataBaseLoggerService(), new SmsLoggerService()});  // new DataBaseLoggerService alternatif olarak böyle de ifade edilebilir

            List<ICreditManager> credits = new List<ICreditManager> { financeLoanManager, transportLoanManager };

            //applicationManager.CreditPreInformation(credits);


        }
    }
}
