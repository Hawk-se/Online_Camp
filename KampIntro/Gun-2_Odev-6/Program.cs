using System;

namespace Gun_2_Odev_6
{
    class Program
    {
        static void Main(string[] args)
        {
            Product product1 = new Product();
            product1.productBrand = "Lenovo";
            product1.processorType = "Intel Core i7";
            product1.displaySize = 14.1m;
            product1.operatingSystem = "Windows 10 Pro";
            product1.discCapacity = 512;

            Product product2 = new Product();
            product2.productBrand = "Asus";
            product2.processorType = "Intel Core i5";
            product2.displaySize = 13.0m;
            product2.operatingSystem = "Windows 10 Home";
            product2.discCapacity = 256;

            Product product3 = new Product();
            product3.productBrand = "HP";
            product3.processorType = "AMD Ryzen 7";
            product3.displaySize = 17.3m;
            product3.operatingSystem = "Free DOS";
            product3.discCapacity = 2000;

            Product product4 = new Product();
            product4.productBrand = "Dell";
            product4.processorType = "AMD Ryzen 5";
            product4.displaySize = 16.0m;
            product4.operatingSystem = "Ubuntu";
            product4.discCapacity = 1000;

            Product[] products = new Product[] { product1, product2, product3, product4 };

            Console.WriteLine("************** foreach loop **************");
            foreach (var product in products)   // foreach loop
            {
                Console.WriteLine("Marka: " + product.productBrand);
                Console.WriteLine(" - İşlemci Tipi: " + product.processorType);
                Console.WriteLine(" - Ekran Boyutu: " + product.displaySize + " inç");
                Console.WriteLine(" - İşletim Sistemi: " + product.operatingSystem);
                Console.WriteLine(" - Harddisk Kapasitesi: " + product.discCapacity + " Gb");
            }

            Console.WriteLine(" ");
            Console.WriteLine("************** for loop **************");
            for (int i = 0; i < products.Length; i++)
            {
                Console.WriteLine("Marka: " + products[i].productBrand);
                Console.WriteLine(" - İşlemci Tipi: " + products[i].processorType);
                Console.WriteLine(" - Ekran Boyutu: " + products[i].displaySize + " inç");
                Console.WriteLine(" - İşletim Sistemi: " + products[i].operatingSystem);
                Console.WriteLine(" - Harddisk Kapasitesi: " + products[i].discCapacity + " Gb");
            }

            Console.WriteLine(" ");
            Console.WriteLine("************** while loop **************");

            int k = 0;
            while (k < products.Length)
            {
                Console.WriteLine("Marka: " + products[k].productBrand);
                Console.WriteLine(" - İşlemci Tipi: " + products[k].processorType);
                Console.WriteLine(" - Ekran Boyutu: " + products[k].displaySize + " inç");
                Console.WriteLine(" - İşletim Sistemi: " + products[k].operatingSystem);
                Console.WriteLine(" - Harddisk Kapasitesi: " + products[k].discCapacity + " Gb"); k++;
            }


        }
    }

    class Product
    {
        public string productBrand{ get; set; }
        public string processorType { get; set; }
        public decimal displaySize { get; set; }
        public string operatingSystem { get; set; }
        public int discCapacity { get; set; }
    }
}


