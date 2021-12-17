using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_24_Çok_Boyutlu_Diziler
{
    class Program
    {
        static void Main(string[] args)
        {
            /*  int[,] dizi = new int[2, 2];
              dizi[0, 0] = 25;
              dizi[0, 1] = 35;
              dizi[1, 0] = 15;
              dizi[1, 1] = 16;
              for (int i = 0; i < 2; i++) 
              {
                  for (int j = 0; j < 2; j++) 
                  Console.Write("{0} ", dizi[i, j]);
                  Console.WriteLine();

              }
              Console.Read();
            */
            /*
             * int [,] matris1 = { { 1, 3, 4, 6 }, { 5, 8, 9, 5 },{ 5, 6, 7, 8 },{ 15, 45, 67, 98 } };
            int[,] matris2 = { { 10, 14, 15, 16 }, { 9, 45, 3, 6 },{ 15, 16, 25, 67 },{ 14, 43, 23, 12 } };
            int[,] toplam = new int[4, 4];

            for(int i=0;i<4;i++)
            {
                for (int j = 0; j < 4; j++) 
                {
                    toplam[i, j] = matris1[i, j] + matris2[i, j];
                }
            }
            for (int k = 0; k < 4; k++) 
            {
                Console.WriteLine();
                for (int m = 0; m < 4; m++)
                {
                    Console.Write(toplam[k, m]+"  " );
                }
            }
            Console.Read();
            */

            /* int satir, sutun;
            Console.Write("Satır Sayısını Giriniz: ");
            satir = Convert.ToInt16(Console.ReadLine());
            Console.Write("Sütun Sayısını Giriniz: ");
            sutun = Convert.ToInt16(Console.ReadLine());

            int[,] matris = new int[satir, sutun];
            for(int i=0;i<satir;i++)
            {
                for(int j=0;j<sutun;j++)
                {
                    Console.Write("Matrisin {0} X {1} Değerini Giriniz: ", i + 1, j + 1);
                    matris[i, j] = Convert.ToInt16(Console.ReadLine());
                }
            }
            Console.WriteLine();
            for(int k=0;k<satir;k++)
            {
                for(int m=0;m<sutun;m++)
                {
                    Console.Write(matris[k, m] + " ");
                    
                }
                Console.WriteLine();
            }
            Console.WriteLine();
            for(int x=0;x<satir;x++)
            {
                for(int y=0;y<sutun;y++)
                {
                    Console.Write(matris[y, x] * 5+ " " );
                }
                Console.WriteLine();
            }
            Console.Read();
            */

            int a, b, c, d, sonuç;
            Console.Write("A Değeri: ");
            a = Convert.ToInt16(Console.ReadLine());
            Console.Write("B Değeri: ");
            b = Convert.ToInt16(Console.ReadLine());
            Console.Write("C Değeri: ");
            c = Convert.ToInt16(Console.ReadLine());
            Console.Write("D Değeri: ");
            d = Convert.ToInt16(Console.ReadLine());
            Console.WriteLine();

            sonuç = Math.Abs((a * d) - (b * c));
            Console.Write("Determinant Sonucunuz: " + sonuç);

            Console.Read();
        }
    }
}
