using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_11_Döngüler_2
{
    class Program
    {
        static void Main(string[] args)
        {
            /*int i;
            for(i=0;i<=100;i++)
            {
                if (i%9==0) mod alma
                {
                    Console.WriteLine(i);
                }
            }
            */
            /* int sayı;
             int i;
             sayı = 120;
             for(i=1;i<=120;i++)
             {
                 if (sayı%i==0)
                 {
                     Console.WriteLine(i);
                 }
             }
            */
            int a, b, c;
            int i;
            a = 1;
            b = 1;
            c = a + b;
            for(i=0;i<=8;i++)
            {
                c = a + b;
                a = b;
                b = c;
                Console.WriteLine(c);
            }
            Console.Read();
        }

    }
}
