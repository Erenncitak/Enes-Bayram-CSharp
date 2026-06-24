using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Class
{
    class Program
    {
        static void Main(string[] args)
        {
            //int kapiSayisi = 4;
            //string arabaModel = "Honda";
            //string arabaRengi = "Kırmızı";
            //Araba arac1 = new Araba();
            //arac1.arabaModel = "Civic";
            //arac1.arabaRenk = "Kırmızı";
            //arac1.kapiSayisi = 5;
            //arac1.motorCalistir();
            //arac1.kapilariKitle();
            //Console.WriteLine("Arabanın modeli= "+arac1.arabaModel);
            //Console.WriteLine("Arabanın rengi= " +arac1.arabaRenk);
            //Console.WriteLine("Arabanın kapı sayısı= " +arac1.kapiSayisi);
            Araba arac1 = new Araba(4, "Honda", "Kırmızı");
            Console.WriteLine("Arabanın modeli: " + arac1.arabaModel);
            Console.WriteLine("Arabanın rengi : " + arac1.arabaRenk);
            Console.WriteLine("Arabanın kapı sayısı: " + arac1.kapiSayisi);
        }
    }
}
