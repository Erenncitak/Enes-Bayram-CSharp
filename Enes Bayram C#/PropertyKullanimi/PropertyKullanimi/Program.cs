using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PropertyKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            //Musteri musteri1 = new Musteri();
            //musteri1.KİLO = 85; // Değer atama yaptığım için set blokları çalışacak
            //Console.WriteLine(musteri1.KİLO);
            //// Eğer değer ataması yapmasaydım get blokları çalışacaktı!

            Musteri m1 = new Musteri();

            m1.kilo1 = 85;
            m1.kilo2 = 85;

            Console.WriteLine("Property olan kilo ==> "+m1.kilo1);
            Console.WriteLine("Değişken olan kilo ==> " +m1.kilo2);

            Console.ReadLine();

        }
    }
}
