using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_22_Bool_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayı;
            Console.Write("Bir Sayı Giriniz: ");
            sayı = Convert.ToInt32(Console.ReadLine());
            bool durum1 = sayı > 0;
            bool durum2 = sayı > 10;
            Console.WriteLine("Sayı Pozitif midir? {0}", durum1);
            Console.WriteLine("Sayı 10 dan Büyük müdür? {0} ", durum2);
            Console.Read();
        
        }
    }
}
