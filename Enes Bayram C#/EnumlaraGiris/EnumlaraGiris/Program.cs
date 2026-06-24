using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlaraGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Enumerations (Numaralandırmalar) anlamına gelir. Eğer ki 1 gelirse şunu yap, 2 ye bunu yap dediğimiz yerlerde ve bunun gibi işlemlerde oldukça faydalı olan bir yapıdır.
            // Büyük projelerde önemi ölçülmeyecek kadar büyüktür.

            // Enum içerisinde değer vermezsek, değerler 0'dan başlar ve birer birer artar

            Gunler gun = Gunler.pazartesi;
            //Console.WriteLine(gun + 1);
            if(gun == Gunler.pazartesi)
            {
                Console.WriteLine("Gün pazartesi");
            }
            else if(gun == Gunler.sali)
            {
                Console.WriteLine("Gün salıdır");
            }
            else if (gun == Gunler.carsamba)
            {
                Console.WriteLine("Gün çarşambadır");
            }
            else if (gun == Gunler.persembe)
            {
                Console.WriteLine("Gün perşembedir");
            }
            else if (gun == Gunler.cuma)
            {
                Console.WriteLine("Gün cumadır");
            }
            else if (gun == Gunler.cumartesi)
            {
                    Console.WriteLine("Gün cumartesi");
            }
            else if (gun == Gunler.pazar)
            {
                    Console.WriteLine("Gün pazardır");
            }

            }
        }
    }
