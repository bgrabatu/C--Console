using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_2_String_Değişkenleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string ad, soyad, şehir;
            
            Console.Write("Adınızı giriniz: ");
            ad = Console.ReadLine();
            Console.Write("Soyadınızı giriniz: ");
            soyad = Console.ReadLine();
            Console.Write("Şehirinizi giriniz: ");
            şehir = Console.ReadLine();

            Console.WriteLine("ad:{0} soyad:{1} şehir:{2}", ad, soyad, şehir);

            Console.Read();

        }
    }
}
