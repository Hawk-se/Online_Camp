using System;

namespace Gun_3_Odev_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayimizOut;
            DegistirOut(out sayimizOut);
            Console.WriteLine(sayimizOut);

            int sayimizRef = 0;  // değer verilmediğinde hata verecektir.
            DegistirRef(ref sayimizRef);
            Console.WriteLine(sayimizRef);


            int sayimiz = 3;
            Console.WriteLine("Başlangıç değeri: {0}", sayimiz);
            Kare(sayimiz);
            Console.WriteLine("Kare() sonrası: {0}", sayimiz);
            Kare2(ref sayimiz);
            Console.WriteLine("Kare2() sonrası: {0}", sayimiz);
        }
        static void Kare(int sayi)
        {
            sayi = sayi * sayi;
        }

        static void Kare2(ref int sayi)
        {
            sayi = sayi * sayi;

        }
        static void DegistirRef(ref int sayiRef)
        {
            sayiRef = 1234;
        }

        static void DegistirOut(out int sayiOut)
        {
            sayiOut = 1234;
        }

    }
}