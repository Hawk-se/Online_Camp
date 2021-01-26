using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{

    // İhtiyaç kredisi
    class FinanceLoanManager : ICreditManager
    {
        
        public void Calculate()
        {
            Console.WriteLine("Finance Loan payment plan has been calculated"); 
        }

        public void DoSomething()
        {
            
        }
    }
}

