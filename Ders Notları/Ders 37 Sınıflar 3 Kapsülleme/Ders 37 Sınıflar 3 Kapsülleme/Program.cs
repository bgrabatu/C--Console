using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_37_Sınıflar_3_Kapsülleme
{
    class Program
    {
        static void Main(string[] args)
        {
            Emlak eml = new Emlak();
            eml.SEMT = "Sultanbeyli";
            eml.RENK = "Kırmızı";
            eml.KATSAYISI = 5;
            eml.ODASAYISI = 3;
            eml.ALAN = 88.5;

            Console.WriteLine("Evin Konumu: " + eml.SEMT);
            Console.WriteLine("Evin Rengi: " + eml.RENK);
            Console.WriteLine("Evin Kat Sayısı: " + eml.KATSAYISI);
            Console.WriteLine("Evin Oda Sayısı: " + eml.ODASAYISI);
            Console.WriteLine("Evin Alanı: " + eml.ALAN);

            Console.Read();
        }
    }


    class Emlak
    {
        private string semt;
        private string renk;
        private int katsayısı;
        private int odasayısı;
        private double alan;

        public string SEMT
        {
            get { return semt;}
            set { semt = value.ToUpper(); }
        }
        public string RENK
        {

            get { return renk; }
            set { renk = value.ToLower(); }
        }
        public int KATSAYISI
        {
            get { return katsayısı; }
            set { katsayısı = Math.Abs(value); }
        }
        public int ODASAYISI
        {
            get { return odasayısı; }
            set { odasayısı = Math.Abs(value); }
        }
        public double ALAN
        {
            get { return alan; }
            set { alan = Math.Abs(value); }
        }
    }

}
