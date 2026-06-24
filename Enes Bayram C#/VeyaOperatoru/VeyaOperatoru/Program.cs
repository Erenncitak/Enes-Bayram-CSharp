using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VeyaOperatoru
{
    class Program
    {
        static void Main(string[] args)
        {
            int sayi1 = 3;
            int sayi2 = 3;
            int sayi3 = 6;

            bool kontrolEt = sayi1 != sayi2 || sayi2 > sayi3;

            Console.WriteLine(kontrolEt);
            Console.ReadLine();

        }
    }
}
