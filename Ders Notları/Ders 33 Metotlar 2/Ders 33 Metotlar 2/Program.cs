using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33_Metotlar_2
{
    class Program
    {
        public static void yazdır(string bilgi)
        {
            for (int i = 0; i < 10; i++)
                Console.WriteLine(bilgi);
        }
        static void Main(string[] args)
        {
            Console.Write("Metni Giriniz:");
            string blg = Console.ReadLine();
            yazdır(blg);
            Console.Read();
        }
    }
}
