using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_18_Char_Değişkeni
{
    class Program
    {
        static void Main(string[] args)
        {
            char cinsiyet;
            Console.Write("Cinsiyetiniz Kadın ise k veya K basınız: \n" +
                "Cinsiyetiniz Erkek ise e veya E basınız: " );
            
            cinsiyet = Convert.ToChar(Console.ReadLine());
            if (cinsiyet == 'e' || cinsiyet == 'E')
            {
                Console.WriteLine("Cinsiyet Erkektir");
            }
            else if (cinsiyet == 'k' || cinsiyet == 'K') 
            {
                Console.WriteLine("Cinsiyet Kadındır");
            }
            else
            {
                Console.WriteLine("Hatalı Harf Girişi");
            }
            Console.Read();
        }
    }
}
