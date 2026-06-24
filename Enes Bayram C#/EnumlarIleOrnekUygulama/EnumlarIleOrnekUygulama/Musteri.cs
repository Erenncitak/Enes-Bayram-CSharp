using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnumlarIleOrnekUygulama
{
    public class Musteri
    {
        public int id{ get; set; }
        public string isim{ get; set; }
        public string soyisim{ get; set; }
        public string cinsiyet{ get; set; }
        public string emailAdres{ get; set; }

        public Musteri(int id, string isim,string soyisim, string cinsiyet,string emailAdres)
        {
            this.id = id;
            this.isim = isim;
            this.soyisim = soyisim;
            this.cinsiyet   = cinsiyet;
            this.emailAdres = emailAdres;
        }

        public static ArrayList musterliler = new ArrayList();

        public MusteriDurum musteriEkle(Musteri M1)
        {
            musterliler.Add(M1); // Müşterimizi koleksiyona ekledik.

            // return 413444; // değerin eklendiği anlamına gelsin

            return MusteriDurum.kayitBasarili;
        }
        
    
    
    }
}
