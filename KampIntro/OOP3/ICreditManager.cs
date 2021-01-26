using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // base class interface'a dönüştürüldü. Bunun sebebi her bir kredi hesaplaması için farklı gereksinimlerin (faiz oranı, dosya
    // masrafı vs.) olmasından kaynaklanmaktadır
    // Genellikle operasyonel class'larda interface kullanılır
    // birbirinin alternatifi olan ama code içerikleri farklı olan durumlar için kullanırız
    // bu örnekte kredi türlerinin hepsinde bir geri ödeme hesaplaması vardır.
    // kredinin türüne göre hesaplama değişiklik gösterir
    // Interface'ler de o interface'i implement eden class'ın referansını tutar !!!
    // Interface'leri birbirinin alternatifi olan ama kod içerikleri farklı olan durumlar için kullanırız !!!
    // Kredi türlerinin hepsinde bir geri ödeme planı vardır ve hepsinde ortaktır ancak kredinin türüne göre hesaplama kodları farklıdır 

    interface ICreditManager // okunurluğu arttırmak için interface'ler I ile başlatılır ve küme parantezleri {} kullanılmaz
    {
        void Calculate();

        void DoSomething();

    }
}
