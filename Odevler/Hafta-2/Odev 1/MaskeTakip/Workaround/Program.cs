using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Workaround
{
    class Program
    {
        static void Main(string[] args)
        {
            //Intro();
            //SelamVer();
            //SelamVer("Engin");
            //Console.WriteLine(Topla(5, 8));
            //Arrays();
            //IntoList();



            Console.ReadLine();
        }

        private static void IntoList()
        {
            List<string> sehirler = new List<string>()
            {
                "Ankara",
                "İstanbul",
                "İzmir"
            };

            sehirler.Add("Adana");
        }

        private static void Arrays()
        {
            string[] ogrenciler = new string[3];

            ogrenciler[0] = "Engin";
            ogrenciler[1] = "Kerem";
            ogrenciler[2] = "Berkay";

            foreach (var ogr in ogrenciler)
            {
                Console.WriteLine(ogr);
            }
        }

        static void SelamVer(string name = "noname")
        {
            Console.WriteLine("Merhaba" + name);
        }

        static int Topla(int a, int b)
        {
            int result = a + b;

            return result;
        }


        private static void Intro()
        {
            Console.WriteLine("Hello World");

            string mesaj = "Merhaba";
            double tutar = 100000;
            int sayi = 100;

            string ad = "Engin";
            string soyad = "Demiroğ";
            int dogumYili = 1985;
            long tcNo = 12345678901;


            Console.WriteLine(tutar * 1.18);
        }
    }

    public class Vatandas
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }
        public int DogumYili { get; set; }
        public long TcNo { get; set; }

    }
}