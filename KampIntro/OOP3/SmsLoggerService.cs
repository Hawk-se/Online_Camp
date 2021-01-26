using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    class SmsLoggerService : ILoggerService
    {

        // Sonradan eklendi
        public void Log()
        {
            Console.WriteLine("Sms has been sent");
        }
    }
}
