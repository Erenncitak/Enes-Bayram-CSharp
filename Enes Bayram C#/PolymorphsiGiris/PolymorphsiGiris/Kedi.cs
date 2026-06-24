using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PolymorphsiGiris
{
    public class Kedi : Hayvan // Hayvan kedi = new kedi(); 
    {
        public Kedi(string isim) : base(isim)
        {

        }

        public override void konus()
        {
            Console.WriteLine(getIsim() + " miyavlıyor...");
        }

    }
}
