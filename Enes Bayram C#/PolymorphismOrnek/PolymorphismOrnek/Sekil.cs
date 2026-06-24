using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphismOrnek
{
    public class Sekil // base class
    {
        public string isim{ get; set; }

        public Sekil(string isim)
        {
            this.isim = isim;
        }

        public string getIsim()
        {
            return this.isim;
        }

        public virtual void sekilHesapla()
        {
            Console.WriteLine("Şekilin alanı hesaplanıyor...");
        }

        public virtual void sekilBilgileriGoster()
        {
            Console.WriteLine(getIsim() + " nin bilgileri !");
        }
    }
}
