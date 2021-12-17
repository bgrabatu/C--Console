using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_5_Double_Değişkenler
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("**** ÖĞRENCİ BİLGİLERİ ****");
            Console.WriteLine();
            Console.WriteLine("**** Kimlik Bilgileri ****");
            Console.WriteLine();
            string ad, soyad, okulno;
            Console.Write("Adınızı Giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı Giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Okul Numaranızı Giriniz: ");
            okulno = Console.ReadLine();
            Console.WriteLine();
            Console.WriteLine("**** Not Bilgileri ****");
            Console.WriteLine();
            double sın1, sın2, proje, ortalama;
            Console.Write("Birinci Sınav Notunuzu Giriniz: ");
            sın1 = Convert.ToDouble(Console.ReadLine());
            Console.Write("İkinci Sınav Notunuzu Giriniz: ");
            sın2 = Convert.ToDouble(Console.ReadLine());
            Console.Write("Proje Notunuzu Giriniz: ");
            proje = Convert.ToDouble(Console.ReadLine());
            Console.WriteLine();
            Console.WriteLine("**** Not Ortalama Bilgisi ****");
            Console.WriteLine();
            ortalama = (sın1 + sın2 + proje) / 3;
            Console.Write("Yıl Sonu Ortalamanız: "+ortalama);

            Console.Read();


        }
    }
}
