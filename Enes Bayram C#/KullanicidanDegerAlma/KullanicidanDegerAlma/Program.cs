using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KullanicidanDegerAlma
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen adınızı giriniz");
            string isim = Console.ReadLine();

            Console.WriteLine("Soyisminizi giriniz");
            string soyisim = Console.ReadLine();


            Console.WriteLine("Kullanıcının ismi " + isim);
            Console.WriteLine("Kullanıcının soyismi " + soyisim);

        }

    }
}
