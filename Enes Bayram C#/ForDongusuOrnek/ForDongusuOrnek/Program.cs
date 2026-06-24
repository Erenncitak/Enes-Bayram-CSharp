using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForDongusuOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Bir sayı giriniz : ");
            int sayi = Convert.ToInt32(Console.ReadLine());

            int toplam = 0;

            for (int i = 1; i <= sayi; i++)
            {
                toplam += i;
            }

            double ortalama = toplam / sayi;

            if (ortalama > 50)
            {
                Console.WriteLine("Ortalamanız 50 den büyüktür...");
            }
            else
            {
                Console.WriteLine("Ortalamanız 50 den küçüktür...");
            }








        }
    }
}
