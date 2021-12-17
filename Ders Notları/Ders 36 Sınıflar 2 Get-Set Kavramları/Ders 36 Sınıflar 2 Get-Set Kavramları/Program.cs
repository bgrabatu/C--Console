using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Ders_36_Sınıflar_2_Get_Set_Kavramları
{
    class Program
    {
        static void Main(string[] args)
        {
            Öğrenci ogr = new Öğrenci();
            ogr.ADI="Buğra Batuhan";
            ogr.SOYADI = "Başar";
            ogr.YAŞI = 15;

            Console.WriteLine("Öğrencinin Adı: " + ogr.ADI);
            Console.WriteLine("Öğrencinin Soyadı: " + ogr.SOYADI);
            Console.WriteLine("Öğrencinin Yaşı: " + ogr.YAŞI);

            Console.Read();



        }
    }

    class Öğrenci
    {
        private string ad;
        private string soyad;
        private int yaş;

        public string ADI
        {
            get { return ad;}
            set { ad = value; }
        }
        public string SOYADI
        {
            get { return soyad; }
            set { soyad = value; }
        }
        public int YAŞI
        {
            get { return yaş; }
            set
            {
                if (value<18)
                {
                    yaş = 18;
                }
                else
                {
                    yaş = value;
                }
            }

        }




    }




}
