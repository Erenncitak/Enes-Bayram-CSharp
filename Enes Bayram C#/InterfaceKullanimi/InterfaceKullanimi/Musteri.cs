using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InterfaceKullanimi
{
    public class Musteri : IMusteri, IPersonel // Bir Class sadece bir class tan türetebilirken, bir Class birden çok Interface ten türetilebilir.
    {
        // Interface içerisindeki metotları tanımlarız. Classlarda da içeriğini doldururuz.
        //Interfaceleri miras alan sınıflar, içerisinde tanımlanan tüm metodları Implemente etmek zorundadır.
        public void ekle()
        {
            Console.WriteLine("Müşteri eklendi.");
        }

        public void getir()
        {
            Console.WriteLine("Müşteri getirildi.");
        }

        public void guncelle()
        {
            Console.WriteLine("Müşteri güncellendi.");
        }

        public int personelEkle()
        {
            throw new NotImplementedException();
        }

        public void sil()
        {
            Console.WriteLine("Müşteri silindi.");
        }
    }
}
