using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGirisOrnek
{
    class Program
    {
        static void Main(string[] args)
        {
            Kedi kedi = new Kedi();

            kedi.isim = "Minnoş";
            kedi.kilo = 3;
            kedi.renk = "Beyaz";
            kedi.cinsiyet = "Dişi";
            kedi.ayakSayısı = 4;

            kedi.sesCikar();
            kedi.hayvanBilgileriGoster();

            Console.ReadLine();
        }
    }
}
