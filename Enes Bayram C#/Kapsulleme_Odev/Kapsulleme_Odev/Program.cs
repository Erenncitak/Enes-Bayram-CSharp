using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kapsulleme_Odev
{
    class Program
    {
        static void Main(string[] args)
        {
            Personel p1 = new Personel();

            p1.TCKİMLİKNO = "12345678910";

            Console.WriteLine("TC kimlik numaranız : " + p1.TCKİMLİKNO);
        }
    }
}
