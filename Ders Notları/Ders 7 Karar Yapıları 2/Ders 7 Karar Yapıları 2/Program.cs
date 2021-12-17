using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_7_Karar_Yapıları_2
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
            if (ortalama>0 && ortalama<30)
            {
                Console.WriteLine("Vasat");
            }
            else if (ortalama>=30 && ortalama<50)
            {
                Console.WriteLine("Kötü");
            }                                         
            else if (ortalama>=50 && ortalama<70)
            {
                Console.WriteLine("İyi");
            }
            else if (ortalama>=70 && ortalama<85)
            {
                Console.WriteLine("Güzel");
            }
            else if (ortalama>=85 && ortalama<=100)
            {
                Console.WriteLine("Harika");
            }
            
            

            Console.Read();

        }
    }
}
