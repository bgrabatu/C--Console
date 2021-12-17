using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_3_İnt_Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {

            string ad, soyad, okul;
            int sınav1, sınav2, performans,ortalama;

            Console.WriteLine("****Öğrenci Bilgileri ****");
            Console.WriteLine();

            ad = "Buğra Batuhan";
            soyad = "Başar";
            okul = "Kırşehir Ahi Evran Üniversitesi";

            sınav1 = 90;
            sınav2 = 80;
            performans = 60;

            Console.WriteLine("Öğrenci Adı: "+ad);
            Console.WriteLine("Öğrenci Soyadı: "+soyad);
            Console.WriteLine("Öğrencinin Okulu: "+okul);
            Console.WriteLine();
            Console.WriteLine("****Sınav Bilgileri ****");
            Console.WriteLine();
            Console.WriteLine("Birinci Sınav: " + sınav1);
            Console.WriteLine("İkinci Sınav: " + sınav2);
            Console.WriteLine("Performans Notu: " + performans);
            Console.WriteLine();
            Console.WriteLine("**** Ortalama Not Bilgisi ****");
            ortalama = (sınav1 + sınav2 + performans) / 3;
            Console.WriteLine();
            Console.WriteLine("Ortalama Notunuz: " + ortalama);
           
            

            Console.Read();
        }

    }
}
