using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsiGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            //Hayvan hayvan = new Hayvan("Hayvan");
            //hayvan.konus();

            //Hayvan kedi = new Kedi("Minnoş");
            //kedi.konus();

            //Hayvan kopek = new Kopek("Karabaş");
            //kopek.konus();


            //Console.ReadLine();

            HayvanlariKonustur(new Kedi("Minnoş"));
            HayvanlariKonustur(new Kopek("Karabaş"));
            HayvanlariKonustur(new Hayvan("Hayvan"));
            Console.ReadLine();
        }

        public static void HayvanlariKonustur(Hayvan hayvan)
        { 
            hayvan.konus();
        }
    }
}
