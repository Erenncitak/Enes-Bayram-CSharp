using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceSealedKeyword
{
    public class Personel
    {
        public int personel_id{ get; set; }
        public string personel_ismi{ get; set; }
        public string personel_soyismi{ get; set; }
        public int personel_maas{ get; set; }

        public void personelBilgileri()
        {
            Console.WriteLine("Personel id : " + personel_id);
            Console.WriteLine("Personel İsmi: " + personel_ismi);
            Console.WriteLine("Personel Soyismi: " + personel_soyismi);
            Console.WriteLine("Personel Maas: " + personel_maas);
        }
    }
}
