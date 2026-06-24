using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarIleOrnekUygulama
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Musteri musteri = new Musteri(1,"Eren,","ÇITAK","Erkek","erenncitak@gmail.com");
            /*
            musteri.id = 1;
            musteri.isim = "Eren";
            musteri.soyisim = "ÇITAK";
            musteri.cinsiyet = "Erkek";
            musteri.emailAdres = "erenncitak@gmail.com";
            */

           MusteriDurum durum =  musteri.musteriEkle(musteri);
            //if(gelenKod == 413444)
            //{
            //    Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir.");
            //}

            if(durum == MusteriDurum.kayitBasarili)
            {
                Console.WriteLine("Müşteri başarılı bir şekilde eklenmiştir");
            }
        }
    }
}
