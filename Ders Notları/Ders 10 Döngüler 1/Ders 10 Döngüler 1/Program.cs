using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_10_Döngüler_1
{
    class Program
    {
        static void Main(string[] args)
        {
            /* int i;
            for(i=1;i<=10;i++)
            {
                Console.WriteLine("Merhaba Dünya");
            }
            Console.Read();
            */
           
            
            /* int i;
             for (i = 0; i <= 20; i+=2)
             {
                 Console.WriteLine(i);
             }
             Console.Read();
            */



            int i;
            int toplam;
            toplam = 0;
            for (i=1;i<=5;i++)
            {
                toplam = toplam + i;
            }
            Console.WriteLine("Toplam = " + toplam);
            Console.Read();
        }
    }
}
