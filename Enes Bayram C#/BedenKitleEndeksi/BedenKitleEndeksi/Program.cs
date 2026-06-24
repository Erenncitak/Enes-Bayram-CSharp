using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BedenKitleEndeksi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Kilonuzu giriniz");
            int kilo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Boyunuzu giriniz");
            int boy= Convert.ToInt32(Console.ReadLine());

            double bke = kilo / (boy * boy); 
        
            if(bke < 18)
            {
                Console.WriteLine("Zayıfsınız");
            }
            else if (bke >18 && bke < 25)
            {
                Console.WriteLine("Normalsniz");
            }
            else
            {
                Console.WriteLine("Obezsiniz...");
            }
        
        
        }
    }
}
