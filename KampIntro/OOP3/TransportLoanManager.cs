using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // Taşıt kredisi
    class TransportLoanManager : ICreditManager
    {
        

        public void Calculate()
        {
            Console.WriteLine("Transport Loan payment plan has been calculated");
        }

        public void DoSomething()
        {
            
        }
    }
}
