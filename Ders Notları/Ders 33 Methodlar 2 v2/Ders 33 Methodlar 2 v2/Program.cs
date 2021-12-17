using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_33_Methodlar_2_v2
{
    class Program
    {
        public static int Topla(int s1, int s2)
        {
            int t = s1 + s2;
            return t;
        }
        static void Main(string[] args)
        {
            Console.WriteLine("Toplam: " + Topla(5, 7));
            Console.Read();
        }
    }
}
