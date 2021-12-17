using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_6_Karar_Yapıları
{
    class Program
    {
        static void Main(string[] args)
        {
            int sınav1, sınav2, ortalama;
            Console.Write("1.Sınavınızı Giriniz: ");
            sınav1 = Convert.ToInt32(Console.ReadLine());
            Console.Write("2.Sınavınızı Giriniz: ");
            sınav2 = Convert.ToInt32(Console.ReadLine());
            ortalama = (sınav2 + sınav1) / 2;
            Console.WriteLine("Sene Sonu Ortalamanız: " + ortalama);
            if (ortalama>=50)
            {
                Console.WriteLine("Öğrenci Sınıfı Geçmiştir ");
            }
            else
            {
                Console.WriteLine("Öğrenci Sınıfta Kalmıştır ");
            }
            Console.Read();
        
        
        
        }


    }
}
