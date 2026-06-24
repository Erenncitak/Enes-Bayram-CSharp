using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri();

            musteri.personel_id = 1;
            musteri.personel_ismi = "Eren";
            musteri.personel_soyismi="Çıtak";
            musteri.personel_maas = 2000;

            musteri.personelBilgileri();

        }
    }
}
