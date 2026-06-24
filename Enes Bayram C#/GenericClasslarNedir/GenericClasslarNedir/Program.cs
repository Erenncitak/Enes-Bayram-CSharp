using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClasslarNedir
{
    class Program
    {
        static void Main(string[] args)
        {
            Repository<Musteri> repositoryMusteri = new Repository<Musteri>();
            List<Musteri> musterilerim  = repositoryMusteri.getir();
            Musteri musteri = new Musteri();
            musteri.id = 1;
            musteri.isim = "Eren";
            musteri.soyisim = "ÇITAK";
            musteri.emailAdres = "asdf@gmail.com";

            repositoryMusteri.ekle(musteri);


            Repository<Urun> repositoryUrun = new Repository<Urun>();
            List<Urun> urunlerim =  repositoryUrun.getir();
            Urun urun = new Urun();
            urun.urunId = 1;
            urun.urunIsmi = "Ram bellek";
            urun.urunFiyat = 300;

            string cikti = repositoryUrun.ekle(urun);
            Console.WriteLine(cikti);
        
        }
    }
}
