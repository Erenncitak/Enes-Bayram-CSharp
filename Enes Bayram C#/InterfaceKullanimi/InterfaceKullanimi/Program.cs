using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {

            Musteri musteri = new Musteri();
            musteri.ekle();
            musteri.sil();
            //musteri.guncelle();
            //musteri.getir();

            Console.ReadLine();



            // IMusteri musteriInterface = new IMusteri(); // Interfacelerden obje oluşturulamaz.!!!
           // IMusteri musteri = new Musteri(); // Interface'i implement'e eden classdan aldığmız örneği interface karşılayabilir.
        }
    }
}
