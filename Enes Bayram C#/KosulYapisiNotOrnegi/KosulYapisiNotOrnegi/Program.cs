using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KosulYapisiNotOrnegi
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Lütfen 1.notunuzu giriniz");
            int birinici_not = Convert.ToInt32(Console.ReadLine());
            int ikinici_not = Convert.ToInt32(Console.ReadLine());
            int ucunucu_not = Convert.ToInt32(Console.ReadLine());

            int sonuc = (birinici_not + ikinici_not + ucunucu_not)/3;

            if(sonuc > 80 && sonuc< 100)
            {
                Console.WriteLine("Not değeriniz : A+");
            }
            else if(sonuc >60 && sonuc < 80)
            {
                Console.WriteLine("Not değeriniz : A");
            }
            else if (sonuc > 40 && sonuc < 60)
            {
                Console.WriteLine("Not değeriniz : B+");
            }
            else
            {
                Console.WriteLine("Not değeriniz : F");
            }


        }
    }
}
