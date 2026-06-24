using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KapsullemeyeGiris
{
    class Program
    {
        static void Main(string[] args)
        {
            // geter seter metotlar
            // proterty ile

            Ogrenci ogr1 = new Ogrenci();
            //Console.WriteLine(ogr1.isim);
            ogr1.setIsim("Eren");
            string ad = ogr1.getIsim();
            
            if(ad == "Eren")
            {
                Console.WriteLine("Başarılı");
            }
            else
            {
                Console.WriteLine("Başarısız");
            }




                Console.ReadLine();
        }
    }
}
