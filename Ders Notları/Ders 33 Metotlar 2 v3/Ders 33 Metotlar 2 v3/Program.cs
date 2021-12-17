using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33_Metotlar_2_v3
{
    class Program
    {
        public static int kupdeger(int sayı)
        {
            int kup = sayı * sayı * sayı;
            return kup;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Sayıyı Giriniz: ");
            int s;
            s = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine("Sonuç: " + kupdeger(s));
            Console.Read();


        }
    }
}
