using System;

namespace Metodlar
{
    class Program
    {
        static void Main(string[] args)
        {
            string urunAdi = "Elma";
            double fiyati = 15;
            string aciklama = "Amasya elması";

            Urun urun1 = new Urun();
            urun1.Adi = "Elma";
            urun1.Fiyati = 15;
            urun1.Aciklama = "Amasya elması";

            Urun urun2 = new Urun();
            urun2.Adi = "Karpuz";
            urun2.Fiyati = 80;
            urun2.Aciklama = "Diyarbakır karpuzu";

            Urun urun3 = new Urun();
            urun3.Adi = "Kayısı";
            urun3.Fiyati = 40;
            urun3.Aciklama = "Malatya kayısısı";

            Urun[] urunler = new Urun[] { urun1, urun2, urun3};


            // type safe - tip güvenli
            foreach (Urun urun in urunler)
            {
                Console.WriteLine(urun.Adi);
                Console.WriteLine(urun.Fiyati);
                Console.WriteLine(urun.Aciklama);
                Console.WriteLine("----------------------");
            }

            Console.WriteLine("--------------Metodlar--------------");
            // instance - örnek
            // encapsulation

            SepetManager sepetManager = new SepetManager();
            sepetManager.Ekle(urun1);
            sepetManager.Ekle(urun2);
            sepetManager.Ekle(urun3);


            // bu kullanım diğer tarafta açıklandığı üzere doğru değil. 
            // parametre eklendiğinde Ekle2 operatörünün kodunda düzeltme gerektirir!!!
            sepetManager.Ekle2("Armut", "Yeşil armut", 12, 10);
            sepetManager.Ekle2("Elma", "Yeşil elma", 12, 8);
            sepetManager.Ekle2("Karpuz", "Diyarbakır karpuzu", 12, 9);

        }
    }
}

// Don't repeat yourself - DRY - Clean Code - Best practice