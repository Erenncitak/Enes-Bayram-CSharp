using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticDegiskenKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Calisan c1 = new Calisan();
            c1.calisanID = 1;
            c1.isim= "Eren";
            c1.soyisim= "Çıtak";
            Calisan.maas= 22500;

            Console.WriteLine("Çalışan id : " + c1.calisanID);
            Console.WriteLine("Çalışan İsim: " + c1.isim);
            Console.WriteLine("Çalışan Soyisim: " + c1.soyisim);
            Console.WriteLine("Çalışan Maaş: " + Calisan.maas);

            Console.ReadLine();
        }
    }
}
