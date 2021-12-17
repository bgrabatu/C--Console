using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_15_Foreach_Döngüsü__Diziler_3_
{
    class Program
    {
        static void Main(string[] args)
        {
            /* string[] harfler = { "a", "b", "c", "d", "e" };
            foreach(string i in harfler)
            {
                Console.WriteLine(i);
            }

            */


            /* int[] sayılar = { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 };
            int toplam = 0;
            foreach (int i in sayılar)
            {
                toplam = toplam + i;

            }
            Console.WriteLine("TOPLAM SONUCUNUZ: " + toplam); 
            */


            /*int[] sayılar = { 1, 2, 3, 4, 5, 6 };
            int sonuc = 1;
            foreach(int i in sayılar)
            {
                sonuc = sonuc * i;
            }
            Console.WriteLine("6 değerinin faktöriyeli: " + sonuc); 
            */


            /* int[] sayılar = { 1, 5, -7, 14, 82, -34, -25, 3, 9, 13 };
             foreach(int i in sayılar)
             {
                 if(i>0 && i%2==1)
                 {
                     Console.WriteLine(i);
                 }
             }
            */




            int[] sayılar = new int[5];
            for(int i=0;i<5;i++)
            {
                Console.Write("Sayıyı Giriniz :");
                sayılar[i] = Convert.ToInt32(Console.ReadLine());
            }
            Array.Sort(sayılar);
            foreach (int i in sayılar)
            {
                Console.WriteLine(i);
            }
            Console.Write("Dizinin En Küçük Değeri: " + sayılar[0]);
            Console.Write("Dizinin En Büyük Değeri: " + sayılar[4]);
            Console.Write("Dizinin Boyutu: " + sayılar.Length);
            Console.Read();
        }

    }
}
