using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirleyicileri
{
    public class Musteri
    {
        public string isim;
        public string soyisim;
        public int maasDegeri;
        public string cinsiyet;
        private int yas;

        public Musteri()
        {
            Console.WriteLine("Müşteri sınıfının yapıcı metodu çalıştı.!");
            IsimSoyisimYazdir("eren","çıtak");

        }

        public void musteriBilgileriGoster()
        {
            Console.WriteLine("İsmi: " + isim);
            Console.WriteLine("Soyismi: " + soyisim);
            Console.WriteLine("Maaş Değeri: " + maasDegeri);
            Console.WriteLine("Cinsiyet: " + cinsiyet);
            Console.WriteLine("Yaş Değeri: " + yas);
        }

        private void IsimSoyisimYazdir(string musteriIsim, string musteriSoyisim)
        {
            Console.WriteLine("İsim ve Soyismi: " + musteriIsim + " " + musteriSoyisim);
        }

    }
}
