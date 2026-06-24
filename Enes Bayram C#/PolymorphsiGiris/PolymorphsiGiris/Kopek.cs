using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsiGiris
{
    public class Kopek : Hayvan
    {
        public Kopek (string isim) : base(isim)
        {

        }

        public override void konus()
        {
            Console.WriteLine(getIsim() + " hayvlıyor...");
        }
    }
}
