using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_35_Sınıf_Yapısı
{
    class Program
    {
        static void Main(string[] args)
        {
            Araba arbsnf = new Araba();
            Console.Write("Arabanızın Markasını Giriniz: ");
            arbsnf.marka = Console.ReadLine();
            Console.Write("Arabanızın Rengini Giriniz: ");
            arbsnf.renk = Console.ReadLine();
            Console.Write("Arabanızın Fiyatını Giriniz: ");
            arbsnf.fiyat = Convert.ToInt32(Console.ReadLine());
            Console.Write("Arabanızın Modelini Giriniz: ");
            arbsnf.model = Convert.ToInt16(Console.ReadLine());
            Console.Write("Arabanızın Vites Tipini Giriniz: ");
            arbsnf.vites = Console.ReadLine();
            Console.Write("Aracınızın Plakasını Giriniz: ");
            arbsnf.plaka = Console.ReadLine();
            Console.Write("Aracınızın Teker Tipini Giriniz: ");
            arbsnf.tekertipi = Console.ReadLine();

            Console.WriteLine("Arabanızın Markası: " + arbsnf.marka);
            Console.WriteLine("Arabanızın Rengi: " + arbsnf.renk);
            Console.WriteLine("Arabanızın Fiyatı: " + arbsnf.fiyat);
            Console.WriteLine("Arabanızın Modeli: " + arbsnf.model);
            Console.WriteLine("Arabanızın Vites Tipi: " + arbsnf.vites);
            Console.WriteLine("Arabanızın Plakası: " + arbsnf.plaka);
            Console.WriteLine("Arabanızın Teker Tipi: " + arbsnf.tekertipi);
            
            
            Console.Read();

        }
    }
    class Araba
    {
        public string marka;
        public string renk;
        public int fiyat;
        public int model;
        public string vites;
        public string plaka;
        public string tekertipi;
    }





}
