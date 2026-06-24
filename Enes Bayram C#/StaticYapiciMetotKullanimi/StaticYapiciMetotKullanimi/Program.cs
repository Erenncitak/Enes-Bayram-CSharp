using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StaticYapiciMetotKullanimi
{
    class Program
    {
        static void Main(string[] args)
        {
            Kullanici k1 = new Kullanici(1,"Eren","ÇITAK");
            Kullanici k2 = new Kullanici(2,"Serhat" ,"Demir");

            k1.bilgileriGoster();
            k1.zamYap(5500);
        }
    }
}
