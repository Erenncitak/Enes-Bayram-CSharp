using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurDonusumleri
{
    class Program
    {
        static void Main(string[] args)
        {
            string sayi1 = "1";
            string sayi2 = "2";

            //int a = int.Parse(sayi1);
            //int b = int.Parse(sayi2);

            //Console.WriteLine(a + b);


            //int a = Convert.ToInt32(sayi1);
            //int b = Convert.ToInt32(sayi2);

            //Console.WriteLine(a+b);

            //int sayi1 = 5;
            //int sayi2 = 10;
            //string a = sayi1.ToString();
            //string b = sayi2.ToString();

            //Console.WriteLine(a + b);


            double sayi = 5.22;

            int a = Convert.ToInt32(sayi);
            //int b = int.Parse(sayi);

           Console.WriteLine(a);
            Console.WriteLine(sayi.GetType());


            string kullanici_yas = Console.ReadLine();

            int kullanici_yasInt = int.Parse(kullanici_yas);
            int kullanici_yasInt2 = Convert.ToInt32((kullanici_yas));

            Console.WriteLine(kullanici_yasInt);
            Console.WriteLine(kullanici_yasInt2);


            Console.WriteLine("birinici sayiyi giriniz");
            string sayi1 = Console.ReadLine();

            Console.WriteLine("ikinci sayiyi giriniz");
            string sayi2 = Console.ReadLine();

            int sayı1Int = int.Parse(sayi1);
            int sayı2Int = int.Parse(sayi2);

            Console.WriteLine("İki sayinin toplamı : " + sayı1Int+ sayı2Int);

        }
    }
}
