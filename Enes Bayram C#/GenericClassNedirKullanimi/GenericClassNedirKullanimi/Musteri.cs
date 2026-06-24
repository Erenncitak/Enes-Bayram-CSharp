using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericClassNedirKullanimi
{
    public class Musteri <T>
    {
        public T id { get; set; }
        public string isim { get; set; }
        public string soyisim { get; set; }
        public T emailAdres{ get; set; }

    }
}
