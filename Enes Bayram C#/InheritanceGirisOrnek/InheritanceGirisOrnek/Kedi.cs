using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceGirisOrnek
{
    public class Kedi : Kopek
    {
        public void sesCikar()
        {
            Console.WriteLine("Kedi ses çıkarıyor...");
        }

        public void hayvanBilgileriGoster()
        {
            Console.WriteLine("Hayvan ismi : " + isim);
            Console.WriteLine("Hayvan rengi : " + renk);
            Console.WriteLine("Hayvan kilo: " + kilo);
            Console.WriteLine("Hayvan cinsiyet: " + cinsiyet);
            Console.WriteLine("Hayvan ayak sayısı: " + ayakSayısı);
        }
    }
}
