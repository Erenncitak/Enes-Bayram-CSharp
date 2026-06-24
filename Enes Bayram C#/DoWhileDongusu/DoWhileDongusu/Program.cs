using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoWhileDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            int toplam = 0;

            do
            {
                toplam += a;
                a++;
            } while (a<=100);

            Console.WriteLine("1'den 100'e kadar olan sayıların TOPLAMI :" + toplam);

        }
    }
}
