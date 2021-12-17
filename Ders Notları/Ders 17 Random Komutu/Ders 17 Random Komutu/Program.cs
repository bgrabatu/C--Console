using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_17_Random_Komutu
{
    class Program
    {
        static void Main(string[] args)
        {
            /* Random mami = new Random();
             int a;
             a = mami.Next(0,11);
             Console.Write(a);
             Console.Read();
            */

            Random rastgele = new Random();
            string[] şehirler = { "bursa", "izmir", "istanbul", "ankara", 
                "kırşehir", "antalya",
                "karabük", "ordu", "tokat","sinop" };
            int a;
            a = rastgele.Next(0, şehirler.Length);
            Console.WriteLine(a);
            Console.WriteLine(şehirler[a]);
            Console.Read();
        }
    }
}
