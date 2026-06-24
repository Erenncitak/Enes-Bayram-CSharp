using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PublicvePrivateErisimBelirleyicileri
{
    class Program
    {
        static void Main(string[] args)
        {
            // public -- private--

            Musteri musteri1 = new Musteri();
            musteri1.isim = "Eren";
            musteri1.soyisim = "ÇITAK";
            musteri1.maasDegeri = 20000;
            musteri1.cinsiyet = "Erkek";
            //musteri1.yas = 21;
        }
    }
}
