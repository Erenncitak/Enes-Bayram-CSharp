using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericKoleksiyonlarGiris
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //ArrayList koleksiyon = new ArrayList();
            //koleksiyon.Add(1);
            //koleksiyon.Add("Enes");
            //koleksiyon.Add(3.5);

            degerEkle(5);


        }

        static void degerEkle(int deger)
        {
            ArrayList koleksiyon = new ArrayList();
            koleksiyon.Add(deger);
        }
    }
}
