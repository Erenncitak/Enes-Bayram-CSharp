using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GirilenSayiTekmiCiftmiDizilerOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] sayilar = new int[10];
            int ciftSayilarAdet = 0;
            int tekSayilarAdet = 0;
            int ciftSayilarToplam = 0;
            int tekSayilarToplam = 0;

            for (int i = 0; i < 10; i++)
            {
                Console.Write("Lütfen " + (i+1) + ". değeri giriniz:");
                sayilar[i] =Convert.ToInt32(Console.ReadLine());
            }

            for (int i = 0;i < sayilar.Length;i++)
            {
                if(sayilar[i]%2 == 0)
                {
                    ciftSayilarAdet++;
                    ciftSayilarToplam += sayilar[i];
                }
                else
                {
                    tekSayilarAdet++;
                    tekSayilarToplam += sayilar[i];
                }
            }

            if(ciftSayilarToplam > tekSayilarToplam)
            {
                Console.WriteLine("Çift sayıların toplamı tek sayıların toplamından büyüktür.");
                Console.WriteLine("Çift sayıların adeti : " + ciftSayilarAdet);
                Console.WriteLine("Çift sayıların toplamı: " + ciftSayilarToplam);
                Console.WriteLine("Arasındaki fark ise : " + (ciftSayilarToplam - tekSayilarToplam));
            }
            else
            {
                Console.WriteLine("Tek sayıların toplamı çift sayıların toplamından büyüktür.");
                Console.WriteLine("Tek sayıların adeti : " + tekSayilarAdet);
                Console.WriteLine("Tek sayıların toplamı: " + tekSayilarToplam);
                Console.WriteLine("Arasındaki fark ise : " + (tekSayilarToplam - ciftSayilarToplam));
            }
        }
    }
}
