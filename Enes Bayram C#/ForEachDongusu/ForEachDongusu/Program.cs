using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ForEachDongusu
{
    class Program
    {
        static void Main(string[] args)
        {
            //string[] isimler = { "Enes", "Aysun", "Sevcan", "Elif", "Eren" };

            //foreach (string a in isimler)
            //{
            //    Console.WriteLine(a);
            //}

            double[] os = { 1.2, 1.4, 1.6, 1.8, 2.2 };
        
            foreach (double a in os)
            {
                Console.WriteLine(a);
            }
        
        }
    }
}
