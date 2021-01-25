using System;
using System.Collections.Generic;
using System.Text;

namespace OOP2
{
    // Corporate (Tüzel)
    // inheritance: miras
    // Customer class'ında olan herşey Corporate class'ında da vardır
    class CorporateCustomer:Customer
    {
        public string CompanyName { get; set; }
        public string TaxNo { get; set; }
    }
}
