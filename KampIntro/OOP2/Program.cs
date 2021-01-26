using System;

namespace OOP2
{
    class Program
    {
        static void Main(string[] args)
        {
            // Engin Demiroğ
            IndividualCustomer customer1 = new IndividualCustomer();
            customer1.Id = 1;
            customer1.CustomerNo = "12345";
            customer1.Name = "Engin";
            customer1.Surname = "Demiroğ";
            customer1.TcNo = "12345678910";

            //Kodlama.io (corporate client)

            CorporateCustomer customer2 = new CorporateCustomer();
            customer2.Id = 2;
            customer2.CustomerNo = "54321";
            customer2.CompanyName = "Kodlama.io";
            customer2.TaxNo = "1234567890";



            // Gerçek Müşteri - Tüzel Müşteri (farklı müşteri tipleri olduğu için birbirinin yerine asla kullanılmaz)
            // SOLID

            // new bellekteki referens no'dur
            // Customer hem IndividualCustomer hem de CorporateCustomer referansını tutabiliyor !!!

            Customer customer3 = new IndividualCustomer();
            Customer customer4 = new CorporateCustomer();


            CustomerManager customerManager = new CustomerManager();
            customerManager.Add(customer1);   // CustomerManager'ın örneğini oluşturduktan sonra hem customer1 hem de customer2 çağrılabilir
            customerManager.Add(customer2);

        }
    }
}
