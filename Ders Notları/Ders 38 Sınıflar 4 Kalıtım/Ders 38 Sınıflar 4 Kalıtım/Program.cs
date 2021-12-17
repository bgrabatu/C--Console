using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_38_Sınıflar_4_Kalıtım
{
    class Program
    {
        static void Main(string[] args)
        {
            UçakParçaları uck = new UçakParçaları();
            uck.MARKA = "Turkish Airlines";
            uck.KALKIŞ = "İstanbul-Kurtköy";
            uck.VARIŞ = "samsun-çarşamba";
            uck.AD = "Buğra Batuhan";
            uck.SOYAD = "Başar";
            uck.MOTORU = "Dizel";

            Console.WriteLine("Uçak Markası: " + uck.MARKA);
            Console.WriteLine("Uçak Kalkış Noktası: " + uck.KALKIŞ);
            Console.WriteLine("Uçak Varış Noktası: " + uck.VARIŞ);
            Console.WriteLine();
            Console.WriteLine("Yolcu Adı: " + uck.AD);
            Console.WriteLine("Yolcu Soyadı: " + uck.SOYAD);

            Console.Read();
        }
    }

    class Uçak
    {

        private string marka; //protected yapılabilir
        private string kalkış;
        private string varış;

        public string MARKA
        {
            get { return marka; }
            set { marka = value; }
        }
        public string KALKIŞ
        {
            get { return kalkış; }
            set { kalkış = value.ToUpper(); }
        }
        public string VARIŞ
        {
            get { return varış; }
            set { varış = value.ToUpper(); }
        }
    
    }
    
    class Yolcu:Uçak
    {
        private string ad;
        private string soyad;

        public string AD
        {
            get { return ad; }
            set { ad = value; }
        }
        public string SOYAD
        {
            get { return soyad; }
            set { soyad = value; }
        }

    }
    class UçakParçaları:Yolcu
    {
        private string motor;
        public string MOTORU
        {
            get { return motor; }
            set { motor= value; }
        }
    }

}
