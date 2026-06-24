using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShortVeriTipi
{
    class Program
    {
        static void Main(string[] args)
        {
            // Short değişkeni -32768 ile 32767 arasında değer depolayabilir.

            short biriniciDegisken = -50;
            short ikiniciDegisken = 25550;
            short ucuncuDegsiken = 32000;

            short maxDeger = short.MaxValue;
            short minDeger = short.MinValue;

            Console.WriteLine(maxDeger);
            Console.WriteLine(minDeger);

            Console.ReadLine();        
        }
    }
}
