using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class ArtisanLoanManager : ICreditManager
    {

        // Esnaf kredisi sonradan eklendi
        public void Calculate()
        {
            Console.WriteLine("Artisan Loan payment plan has been calculated");
        }

        public void DoSomething()
        {
            throw new NotImplementedException();
        }
    }
}
