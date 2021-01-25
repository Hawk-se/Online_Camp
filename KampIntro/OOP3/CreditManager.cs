﻿using System;
using System.Collections.Generic;
using System.Text;

namespace OOP3
{
    // base class interface'a dönüştürüldü. Bunun sebebi her bir kredi hesaplaması için farklı farklı oranlar olmasından kaynaklanmaktadır
    // Genellikle operasyonel class'larda interface kullanılır
    // birbirinin alternatifi olan ama code içerikleri farklı olan durumlar için kullanırız
    // bu örnekte kredi türlerinin hepsinde bir geri ödeme hesaplaması vardır.
    // kredinin türüne göre hesaplama değişiklik gösterir
    // 
    interface ICreditManager // okunurluğu arttırmak için interface'ler I ile başlatılır
    {
        void Calculate();

        void DoSomething();

    }
}
