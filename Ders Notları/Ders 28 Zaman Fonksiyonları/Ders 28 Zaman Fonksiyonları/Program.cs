using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_28_Zaman_Fonksiyonları
{
    class Program
    {
        static void Main(string[] args)
        {
            /*    DateTime zaman;
                zaman = DateTime.Now;
                Console.Write("Saat Ve Zaman : {0}", zaman);
                Console.Read();
            */

            DateTime zaman;
            zaman = DateTime.Now;
            int ay = zaman.Month;
            int gün = zaman.Day;
            int yıl = zaman.Year;
            DayOfWeek haftanıngünü = zaman.DayOfWeek;

            Console.WriteLine("GÜN {0}", gün);
            Console.WriteLine("AY {0}", ay);
            Console.WriteLine("YIL {0}", yıl);
            Console.WriteLine("HAFTANIN GÜNÜ {0}", haftanıngünü);
            Console.Read();


        }
    }
}
