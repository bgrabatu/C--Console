using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_34_Metotlar_3
{
    class Metotlar
    {
        int topla(int a, int b)
        {
            return a + b;
        }
        static void Main(string[] args)
        {
            Metotlar mtr = new Metotlar();
            int z;
            z = mtr.topla(1, 3);
            Console.WriteLine("Toplam: " + z);
            Console.Read();
        }
    }
}
