using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticMetotKullanimi
{
    public class Personel
    {
        public static void isimSoyisimYazdir()
        {
            Console.WriteLine("Eren ÇITAK");
        }

        public static void sayilarinToplami(int s1, int s2)
        {
            int toplam = s1 + s2;
            Console.WriteLine("Sayıların toplamı ==> " + toplam);
        }
    }
}
