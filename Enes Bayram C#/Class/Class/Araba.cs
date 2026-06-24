using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    public class Araba
    {
        public int kapiSayisi;
        public string arabaModel;
        public string arabaRenk;

        public Araba(int _kapiSayisi, string _arabaModel, string _arabaRenk)
        {
            kapiSayisi = _kapiSayisi;
            arabaModel = _arabaModel;
            arabaRenk = _arabaRenk;
        }

        public void motorCalistir()
        {
            Console.WriteLine("Motor Çalışıyor..");
        }

        public void kapilariKitle()
        {
            Console.WriteLine("Kapılar kilitleniyor...");
        }

    }
}
