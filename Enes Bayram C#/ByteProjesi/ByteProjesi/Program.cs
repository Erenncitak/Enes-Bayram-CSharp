using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ByteProjesi
{
    class Program
    {
        static void Main(string[] args)
        {
            byte birinci = 5;
            byte ikinici = 25;
            byte ucuncu = 244; // 0-255


            byte maxDeger = byte.MaxValue;
            byte minDeger = byte.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);
            Console.ReadLine(); 
        }
    }
}
