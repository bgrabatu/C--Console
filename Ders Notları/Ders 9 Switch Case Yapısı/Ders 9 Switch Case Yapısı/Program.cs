using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_9_Switch_Case_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi;
            Console.Write("1-7 arasında bir sayı giriniz: ");
            sayi = Convert.ToInt16(Console.ReadLine());

            switch(sayi)
            {
                case 1:
                    Console.WriteLine("Gün=Pazartesi");
                    break;
                case 2:Console.WriteLine("Gün=Salı");
                    break;
                case 3:Console.WriteLine("Gün=Çarşamba");
                    break;
                case 4:Console.WriteLine("Gün=Perşembe");
                    break;
                case 5:Console.WriteLine("Gün=Cuma");
                    break;
                case 6:Console.WriteLine("Gün=Cumartesi");
                    break;
                case 7:Console.WriteLine("Gün=Pazar");
                    break;

                default:Console.Write("Hatalı Gün Girişi");
                    break;
            }
            Console.Read();

        }
    }
}
