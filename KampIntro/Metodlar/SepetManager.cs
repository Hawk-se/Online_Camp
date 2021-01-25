using System;
using System.Collections.Generic;
using System.Text;

namespace Metodlar
{
    class SepetManager
    {
        // Naming convention
        // syntax
        // Doğru kullanım bu !!! Ürüne parametre eklemek gerektiğinde sade Urun.cs altındaki property kısmına 
        // ekleme yapmak yeterli olacak. Ekle operatörü altındaki koda herhangi bir düzeltme gerekmeyecek !!!
        public void Ekle(Urun urun)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urun.Adi);

        }

        // Bu kullanım doğru değil !!! Bir parametre daha eklendiğinde tüm sayfalardaki Ekle2 operatörü çalışmaz hale gelir.
        public void Ekle2(string urunAdi, string aciklama, double fiyat, int stokAdedi)
        {
            Console.WriteLine("Tebrikler. Sepete eklendi : " + urunAdi);
        }
    }
}
