﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_20_Decimal_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            decimal urun1, urun2, toplam;
            int s1, s2;
            urun1 = 12.65M;
            urun2 = 9.50M;
            Console.Write("1. Ürünün Satış Miktarı: ");
            s1 = Convert.ToInt16(Console.ReadLine());
            Console.Write("2. Ürünün Satış Miktarı: ");
            s2 = Convert.ToInt16(Console.ReadLine());
            toplam = s1 * urun1 + s2 * urun2;
            Console.Write("Gün Sonunda Kasada Bulunan Para: " + toplam);

            Console.Read();
        }
    }
}
