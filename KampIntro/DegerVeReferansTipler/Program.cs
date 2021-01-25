using System;

namespace DegerVeReferansTipler
{
    class Program
    {
        static void Main(string[] args)
        {
            
            int sayi1 = 10;
            int sayi2 = 30;
            sayi1 = sayi2;
            sayi2 = 65;
            // sayi1 ??? 30
            Console.WriteLine(sayi1);

            int[] sayilar1 = new int[] { 10, 20, 30 };
            int[] sayilar2 = new int[] { 100, 200, 300 };
            sayilar1 = sayilar2;
            sayilar2[0] = 999;
            //sayilar1[0] ?  999
            Console.WriteLine(sayilar1[0]);

            // int, decimal, float, double, boolean(0,1) değer tip (değer atanır) Belleğin Stack bölümünde tanımlanır
            // array, class, interface referans tip (adres atanır) Belleğin Heap bölümünde tanımlanır
            // new tanımlandığı anda Heap'te bir alan ayrılır ve adres atanır
            // değer tiplerde değer atanır, referans tiplerde adres atanır

        }
    }
}
