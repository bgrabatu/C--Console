using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_13_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int[] oktay = { 10, 45, 25, 60, 64, 76 };
             Console.Write(oktay[0]);
             Console.Read();
             */
            /* string[] iller = { "kayseri", "ankara", "kars", "istanbul" };
            Console.Write(iller[2]);
            Console.Read();
            */

            /* string[] sehirler = new string[3];
            int i;
            for (i = 0; i < 3; i++)            tokat ordu trabzon [3] i
            {
                    Console.Write("Şehir :");
                sehirler[i] = Console.ReadLine();
            }
            
            for (i = 0; i < 3; i++) 
            {
                Console.WriteLine(sehirler[i]);
            }
            */
            int[] sayılar = new int[5];
            int i;
            for ( i = 0; i < 5; i++)
            {
                Console.WriteLine((i + 1).ToString() + ".Sayıyı Giriniz: ");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }
            int enbuyuk;
            enbuyuk = sayılar[0];

            for (i = 1; i < 5; i++) 
            {
                if (enbuyuk < sayılar[i])
                {
                    enbuyuk = sayılar[i];
                }
               
            }
            Console.WriteLine(enbuyuk);
            Console.Read();
            }
    }
}
