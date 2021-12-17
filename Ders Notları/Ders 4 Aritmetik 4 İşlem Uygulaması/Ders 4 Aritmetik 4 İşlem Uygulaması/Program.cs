using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_4_Aritmetik_4_İşlem_Uygulaması
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı1, sayı2, toplama, çıkarma, bölme, çarpma;
            Console.WriteLine("**** Aritmetik 4 İşlemler**** ");
            Console.WriteLine();
            Console.WriteLine("Birinci Sayıyı Giriniz: ");
            sayı1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("İkinci Sayıyı Giriniz: ");
            sayı2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine();                                                 
            Console.WriteLine("**** Toplama İşlemi ****");
            Console.WriteLine();
            toplama = sayı1 + sayı2;
            Console.WriteLine("Toplama İşlemi Sonucu: "+toplama);
            Console.WriteLine();
            Console.WriteLine("**** Çıkarma İşlemi ****");
            Console.WriteLine();
            çıkarma = sayı1 - sayı2;
            Console.WriteLine("Çıkarma İşlemi Sonucunuz: " + çıkarma);
            Console.WriteLine();
            Console.WriteLine("**** Çarpma İşlemi ****");
            Console.WriteLine();
            çarpma = sayı1 * sayı2;
            Console.WriteLine("Çarpma İşlemi Sonucunuz: " + çarpma);
            Console.WriteLine();
            Console.WriteLine("**** Bölme İşlemi ****");
            Console.WriteLine();
            bölme = sayı1 / sayı2;
            Console.WriteLine("Bölme İşlemi Sonucunuz: " + bölme);

            Console.Read();

        }
    }
}
