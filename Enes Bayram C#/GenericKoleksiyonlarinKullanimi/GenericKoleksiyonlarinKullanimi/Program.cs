using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlarinKullanimi
{
    internal class Program
    {
        static void Main(string[] args)
        {
            /*
            List<int> rakamlar = new List<int>();
            rakamlar.Add(0);
            rakamlar.Add(1);
            rakamlar.Add(2);
            rakamlar.Add(3);
            rakamlar.Add(4);
            rakamlar.Add(5);
            rakamlar.Add(6);
            rakamlar.Add(7);
            rakamlar.Add(8);
            rakamlar.Add(9);

            foreach(int rakam in rakamlar)
            {
                Console.WriteLine(rakam);
            }
            */

            List<Musteri> musteriler = new List<Musteri>();
            musteriler.Add(new Musteri(1, "Eren", "ÇITAK", "erenncitak@gmail.com"));
            musteriler.Add(new Musteri(2, "Enes", "BAYRAM", "enesbayram@gmail.com"));
            musteriler.Add(new Musteri(3, "Serhat", "ÇELEBİ", "serhatcelebi@gmail.com"));

            //bool varMi = musteriler.Contains(new Musteri(1, "Eren", "ÇITAK", "erenncitak@gmail.com"));

            //if (varMi)
            //{
            //    Console.WriteLine("Müşteri koleksiyonda var.");
            //}

            Console.WriteLine("Koleksiyon boyutu: " + musteriler.Count);
            musteriler.Clear();

            foreach(Musteri m in musteriler)
            {
                Console.WriteLine(m);
            }


            foreach(Musteri musteri in musteriler)
            {
                Console.WriteLine(musteri);
            }




        }
    }
}
